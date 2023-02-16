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

        public event EventHandler<EventArgs> ItemsChanged;

        /// <summary>
        /// Хранит список всех предметов.
        /// </summary>
        private ObservableCollection<Item> _items;

        /// <summary>
        /// Хранит данные выбранного предмета.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Хранит список отображаемых предметов.
        /// </summary>
        private ObservableCollection<Item> _displayedItems = new ObservableCollection<Item>();

        /// <summary>
        /// Возвращает и задает список предметов класса <see cref="Item"/>.
        /// </summary>
        public ObservableCollection<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

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
        private void ClearInfo()
        {
            IdTextBox.Clear();
            NameTextBox.Clear();
            InfoTextBox.Clear();
            CostTextBox.Clear();
            CostTextBox.BackColor = AppColors.CorrectColor;
            CategoryComboBox.Text = "";
        }

        /// <summary>
        /// Добавляет предмет в список всех предметов.
        /// </summary>
        private void AddItem()
        {
            if (_items.Count == _displayedItems.Count)
            {
                _items.Add(_currentItem);
                _displayedItems = _items;
                ItemsListBox.SelectedIndex = _items.Count - 1;
                return;
            }

            _items.Add(_currentItem);
            _displayedItems.Add(_currentItem);
            ItemsListBox.SelectedIndex = _displayedItems.Count - 1;
        }

        /// <summary>
        /// Проверяет <see cref="ItemsListBox"/>, если он пуст или элемент списка не выбран, то в поля нельзя вводить значения.
        /// </summary>
        private void CheckListCount()
        {
            if (ItemsListBox.Items.Count == 0 || ItemsListBox.SelectedIndex == -1)
            {
                CostTextBox.ReadOnly = true;
                NameTextBox.ReadOnly = true;
                InfoTextBox.ReadOnly = true;
                CategoryComboBox.Text = "";
                CategoryComboBox.Enabled = false;
            }
            else
            {
                CostTextBox.ReadOnly = false;
                NameTextBox.ReadOnly = false;
                InfoTextBox.ReadOnly = false;
                CategoryComboBox.Enabled = true;
            }
        }

        private void ItemsTab_Load(object sender, EventArgs e)
        {
            if (_items == null)
            {
                return;
            }

            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Name == "")
                {
                    ItemsListBox.Items.Add($"Item {_items[i].Id}");
                    continue;
                }

                ItemsListBox.Items.Add(_items[i].Name);
            }

            _displayedItems = _items;

            foreach (var category in Enum.GetValues(typeof(Category)))
            {
                CategoryComboBox.Items.Add(category);
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
                _currentItem = _items[_items.IndexOf(_displayedItems[index])];
                IdTextBox.Text = _currentItem.Id.ToString();
                NameTextBox.Text = _currentItem.Name;
                InfoTextBox.Text = _currentItem.Info;
                CostTextBox.Text = _currentItem.Cost.ToString();
                CategoryComboBox.SelectedItem = (Category)_currentItem.Category;
                CheckListCount();
            }
            catch
            {
                if (_items.Count == 0)
                {
                    ClearInfo();
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item();
            ItemsListBox.Items.Add($"Предмет {_currentItem.Id}");
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
                    _items.Remove(selectedItem);
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
            catch
            {
                ClearInfo();
            }

            CheckListCount();
        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            _currentItem = ItemFactory.Randomize();
            ItemsListBox.Items.Add($"{_currentItem.Name}");
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
                ClearInfo();
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

            _displayedItems = DataTools.SortBy(_items, item => item.Name.Contains(search,
                StringComparison.CurrentCultureIgnoreCase));

            foreach (Item item in _displayedItems)
            {
                ItemsListBox.Items.Add($"{item.Name}");
            }

            if (search == "")
            {
                _displayedItems = _items;
            }

            if (_displayedItems.IndexOf(_currentItem) > -1)
            {
                ItemsListBox.SelectedIndex = _displayedItems.IndexOf(_currentItem);
            }
            else if (_displayedItems.Count == 0 || _displayedItems.Contains(_currentItem) == false)
            {
                _currentItem = new Item();
                ClearInfo();
            }
        }

        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = ItemsListBox.SelectedIndex;

            if(index == -1)
            {
                return;
            }

            var selectedItem = _displayedItems[index];

            ItemsListBox.Items.Clear();  

            switch (OrderByComboBox.SelectedIndex)
            {
                case 0:
                    _displayedItems = DataTools.OrderBy(_items, DataTools.CompareByName);
                    break;
                case 1:
                    _displayedItems = DataTools.OrderBy(_items, DataTools.CompareByCostAscending);
                    break;
                case 2:
                    _displayedItems = DataTools.OrderBy(_items, DataTools.CompareByCostDescending);
                    break;
            }

            foreach (Item item in _displayedItems)
            {
                ItemsListBox.Items.Add($"{item.Name}");
            }

            ItemsListBox.SelectedIndex = _displayedItems.IndexOf(selectedItem);
            ItemsChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
