using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Хранит данные о всех предметах.
    /// </summary>
    public partial class ItemsTab : UserControl
    {
        private readonly string[] sortingArray = new string[]
        {
            "Name",
            "Cost (Ascending)",
            "Cost (Descending)"
        };

        /// <summary>
        /// Хранит данные выбранного предмета.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Хранит список отображаемых предметов.
        /// </summary>
        private ObservableCollection<Item> _displayedItems = new ObservableCollection<Item>();

        /// <summary>
        /// Хранит событие на изменение предмета. Зажигается при изменении данных предмета.
        /// </summary>
        public event EventHandler<EventArgs> ItemsChanged;

        /// <summary>
        /// Возвращает и задает список предметов класса <see cref="Item"/>.
        /// </summary>
        public ObservableCollection<Item> Items { get; set; }

        /// <summary>
        /// Создает экземпляр класса <see cref="ItemsTab"/>.
        /// </summary>
        public ItemsTab()
        {
            InitializeComponent();
            CheckListCount();
        }

        /// <summary>
        /// Очищает все поля.
        /// </summary>
        private void ClearData()
        {
            IdTextBox.Clear();
            NameTextBox.Clear();
            InfoTextBox.Clear();
            CostTextBox.Clear();
            CostTextBox.BackColor = AppColors.CorrectColor;
            CategoryComboBox.Text = "";
        }

        /// <summary>
        /// Обновляет данные в <see cref="ItemsListBox"/>.
        /// </summary>
        private void UpdateListBox(ObservableCollection<Item> items)
        {
            ItemsListBox.Items.Clear();

            for (int i = 0; i < items.Count; i++)
            {
                ItemsListBox.Items.Add(items[i].Name);
            }
        }

        /// <summary>
        /// Добавляет предмет в список всех предметов.
        /// </summary>
        private void AddItem()
        {
            if (Items.Count == _displayedItems.Count)
            {
                Items.Add(_currentItem);
                _displayedItems = Items;
                UpdateListBox(Items);
                ItemsListBox.SelectedIndex = Items.IndexOf(_currentItem);
                return;
            }
            else
            {
                var search = FindTextBox.Text;

                if (_currentItem.Name.Contains(search, StringComparison.CurrentCultureIgnoreCase))
                {
                    Items.Add(_currentItem);
                    _displayedItems.Add(_currentItem);
                    UpdateListBox(_displayedItems);
                    ItemsListBox.SelectedIndex = _displayedItems.IndexOf(_currentItem);
                }
                else
                {
                    Items.Add(_currentItem);
                }
            }
        }

        /// <summary>
        /// Проверяет <see cref="ItemsListBox"/>, если он пуст или элемент списка не выбран,
        /// то в поля нельзя вводить значения.
        /// </summary>
        private void CheckListCount()
        {
            bool flag = false;

            if (ItemsListBox.Items.Count == 0 || ItemsListBox.SelectedIndex == -1)
            {
                flag = true;
                CategoryComboBox.Text = "";
                CategoryComboBox.Enabled = false;
            }
            else
            {
                CategoryComboBox.Enabled = true;
            }

            CostTextBox.ReadOnly = flag;
            NameTextBox.ReadOnly = flag;
            InfoTextBox.ReadOnly = flag;
        }

        private void ItemsTab_Load(object sender, EventArgs e)
        {
            if (Items == null)
            {
                return;
            }

            for (int i = 0; i < Items.Count; i++)
            {
                ItemsListBox.Items.Add(Items[i].Name);
            }

            _displayedItems = Items;

            foreach (var category in Enum.GetValues(typeof(Category)))
            {
                CategoryComboBox.Items.Add(category);
            }

            foreach(var method in sortingArray)
            {
                OrderByComboBox.Items.Add(method);
            }

            OrderByComboBox.SelectedIndex = 0;
            CategoryComboBox.SelectedIndex = -1;

            if(ItemsListBox.Items.Count == 0)
            {
                return;
            }

            ItemsListBox.SelectedIndex = 0;

            OrderByComboBox_SelectedIndexChanged(sender, e);
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var index = ItemsListBox.SelectedIndex;
                _currentItem = Items[Items.IndexOf(_displayedItems[index])];
                IdTextBox.Text = _currentItem.Id.ToString();
                NameTextBox.Text = _currentItem.Name;
                InfoTextBox.Text = _currentItem.Info;
                CostTextBox.Text = _currentItem.Cost.ToString();
                CategoryComboBox.SelectedItem = (Category)_currentItem.Category;
                CheckListCount();
            }
            catch(ArgumentOutOfRangeException)
            {
                if (Items.Count == 0)
                {
                    ClearData();
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item();
            AddItem();       
            CheckListCount();
            ItemsChanged?.Invoke(this, EventArgs.Empty);

        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int lastIndex = ItemsListBox.SelectedIndex;

                if (lastIndex >= 0 && _displayedItems.Count != 0)
                {
                    var selectedItem = _displayedItems[lastIndex];
                    _displayedItems.RemoveAt(lastIndex);
                    Items.Remove(selectedItem);
                    ItemsListBox.Items.RemoveAt(lastIndex);

                    if (ItemsListBox.SelectedIndex == 0 && _displayedItems.Count >= 1)
                    {
                        ItemsListBox.SelectedIndex = lastIndex + 1;
                    }
                    else
                    {
                        ItemsListBox.SelectedIndex = lastIndex - 1;
                    }
                }

                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
            catch(ArgumentOutOfRangeException)
            {
                ClearData();
            }

            CheckListCount();
        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            _currentItem = ItemFactory.Randomize();         
            AddItem();
            CheckListCount();
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Name = NameTextBox.Text;
                ToolTip.SetToolTip(NameTextBox, "");
                NameTextBox.BackColor = AppColors.CorrectColor;
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception exception)
            {
                NameTextBox.BackColor = AppColors.ErrorColor;
                ToolTip.SetToolTip(NameTextBox, exception.Message);
                return;
            }
        }

        private void NameTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                int index = ItemsListBox.SelectedIndex;
                string changedName = NameTextBox.Text;
                ItemsListBox.Items.RemoveAt(index);
                ItemsListBox.Items.Insert(index, $"{changedName}");
                NameTextBox.Text = changedName;
                ItemsListBox.SelectedIndex = index;
            }
            catch
            {
                ClearData();
            }
        }

        private void InfoTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Info = InfoTextBox.Text;
                ToolTip.SetToolTip(InfoTextBox, "");
                InfoTextBox.BackColor = AppColors.CorrectColor;
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception exception)
            {
                InfoTextBox.BackColor = AppColors.ErrorColor;
                ToolTip.SetToolTip(InfoTextBox, exception.Message);
                return;
            }
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Cost = Double.Parse(CostTextBox.Text);
                ToolTip.SetToolTip(CostTextBox, "");
                CostTextBox.BackColor = AppColors.CorrectColor;
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception exception)
            {
                CostTextBox.BackColor = AppColors.ErrorColor;
                ToolTip.SetToolTip(CostTextBox, exception.Message);
                return;
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Category = (Category)CategoryComboBox.SelectedItem;
                ItemsChanged?.Invoke(this, EventArgs.Empty);
            }
            catch (Exception exception)
            {
                ToolTip.SetToolTip(CostTextBox, exception.Message);
                return;
            }
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            ItemsListBox.Items.Clear();

            string search = FindTextBox.Text;

            _displayedItems = DataTools.Search(Items, item => item.Name.Contains(search,
                StringComparison.CurrentCultureIgnoreCase));

            foreach (Item item in _displayedItems)
            {
                ItemsListBox.Items.Add($"{item.Name}");
            }

            if (search == "")
            {
                Items = DataTools.OrderBy(Items, DataTools.CompareByName);
                _displayedItems = Items;
                UpdateListBox(Items);
            }
            else
            {
                ItemsListBox.SelectedIndex = -1;
            }

            if (_displayedItems.IndexOf(_currentItem) > -1)
            {
                ItemsListBox.SelectedIndex = _displayedItems.IndexOf(_currentItem);
            }
            else if (_displayedItems.Count == 0 || _displayedItems.Contains(_currentItem) == false)
            {
                _currentItem = new Item();
                ClearData();
            }
        }

        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (OrderByComboBox.SelectedItem.ToString())
            {
                case "Name":
                    _displayedItems = DataTools.OrderBy(_displayedItems, DataTools.CompareByName);
                    break;
                case "Cost (Ascending)":
                    _displayedItems = DataTools.OrderBy(_displayedItems, DataTools.CompareByCostAscending);
                    break;
                case "Cost (Descending)":
                    _displayedItems = DataTools.OrderBy(_displayedItems, DataTools.CompareByCostDescending);
                    break;
            }

            UpdateListBox(_displayedItems);
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
