﻿using System;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.View
{
    public partial class AddDiscountForm : Form
    {
        /// <summary>
        /// Возвращает выбранную категорию товара.
        /// </summary>
        public Category SelectedCategory
        {
            get
            {
                return (Category)CategoryComboBox.SelectedItem;
            }
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="AddDiscountForm"/>
        /// </summary>
        public AddDiscountForm()
        {
            InitializeComponent();
        }

        private void AddDiscountForm_Load(object sender, EventArgs e)
        {
            foreach(var category in Enum.GetValues(typeof(Category)))
            {
                CategoryComboBox.Items.Add(category);
            }

            CategoryComboBox.SelectedIndex = 0;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
