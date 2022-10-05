﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class ItemsTab : UserControl
    {
        /// <summary>
        /// Хранит список всех предметов.
        /// </summary>
        public List<Item> _items = ProjectSerializer.LoadItemsFromFile();

        /// <summary>
        /// Хранит данные выбранного предмета.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Создает экземпляр <see cref="ItemsTab"/>. 
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
        }

        /// <summary>
        /// Добавляет предмет в список всех предметов.
        /// </summary>
        private void AddItem()
        {
            _items.Add(_currentItem);
            ItemsListBox.SelectedIndex = _items.Count - 1;
        }

        /// <summary>
        /// Проверяет список предметов, если он пуст, то в поля нельзя вводить значения.
        /// </summary>
        private void CheckListCount()
        {
            if (_items.Count == 0)
            {
                CostTextBox.ReadOnly = true;
                NameTextBox.ReadOnly = true;
                InfoTextBox.ReadOnly = true;
            }
            else
            {
                CostTextBox.ReadOnly = false;
                NameTextBox.ReadOnly = false;
                InfoTextBox.ReadOnly = false;
            }
        }

        private void ItemsTab_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < _items.Count; i++)
            {
                if(_items[i].Name == "")
                {
                    ItemsListBox.Items.Add($"Item {_items[i].Id}");
                    continue;
                }
                ItemsListBox.Items.Add(_items[i].Name);
            }
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem = _items[ItemsListBox.SelectedIndex];
                IdTextBox.Text = _currentItem.Id.ToString();
                NameTextBox.Text = _currentItem.Name;
                InfoTextBox.Text = _currentItem.Info;
                CostTextBox.Text = _currentItem.Cost.ToString();
            }
            catch
            {
                if(_items.Count == 0)
                {
                    ClearInfo();
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            _currentItem = new Item("", "", 0);
            ItemsListBox.Items.Add($"Item {_currentItem.Id}");
            AddItem();
            CheckListCount();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int lastIndex = ItemsListBox.SelectedIndex;
            if(lastIndex >= 0 && _items.Count != 0)
            {
                _items.RemoveAt(lastIndex);
                if(ItemsListBox.SelectedIndex == 0 && _items.Count >= 1)
                {
                    ItemsListBox.SelectedIndex = lastIndex + 1;
                }
                else
                {
                    ItemsListBox.SelectedIndex = lastIndex - 1;
                }
                ItemsListBox.Items.RemoveAt(lastIndex);
            }
            CheckListCount();
        }

        private void RandomizeButton_Click(object sender, EventArgs e)
        {
            _currentItem = ItemFactory.Randomize();
            ItemsListBox.Items.Add($"{_currentItem.Name}");
            AddItem();
            CheckListCount();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _currentItem.Name = NameTextBox.Text;
                ToolTip.SetToolTip(NameTextBox, "");
                NameTextBox.BackColor = AppColors.CorrectColor;
            }
            catch(Exception exception)
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
            }
            catch (Exception exception)
            {
                CostTextBox.BackColor = AppColors.ErrorColor;
                ToolTip.SetToolTip(CostTextBox, exception.Message);
                return;
            }
        }    
    }
}
