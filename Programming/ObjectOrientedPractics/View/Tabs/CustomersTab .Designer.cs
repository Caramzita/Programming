﻿
namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.RandomizeButton = new System.Windows.Forms.Button();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.FullnameLabel = new System.Windows.Forms.Label();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.FullnameTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLabel.Location = new System.Drawing.Point(3, 3);
            this.CustomersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomersLabel.TabIndex = 0;
            this.CustomersLabel.Text = "Customers";
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.Location = new System.Drawing.Point(5, 20);
            this.CustomersListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(235, 329);
            this.CustomersListBox.TabIndex = 1;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Location = new System.Drawing.Point(5, 354);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(116, 37);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButton.Location = new System.Drawing.Point(125, 353);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(114, 37);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // RandomizeButton
            // 
            this.RandomizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RandomizeButton.Location = new System.Drawing.Point(5, 396);
            this.RandomizeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RandomizeButton.Name = "RandomizeButton";
            this.RandomizeButton.Size = new System.Drawing.Size(234, 26);
            this.RandomizeButton.TabIndex = 4;
            this.RandomizeButton.Text = "Randomize";
            this.RandomizeButton.UseVisualStyleBackColor = true;
            this.RandomizeButton.Click += new System.EventHandler(this.RandomizeButton_Click);
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.AutoSize = true;
            this.SelectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedItemLabel.Location = new System.Drawing.Point(244, 3);
            this.SelectedItemLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(85, 13);
            this.SelectedItemLabel.TabIndex = 5;
            this.SelectedItemLabel.Text = "Selected Item";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(244, 20);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(24, 13);
            this.IdLabel.TabIndex = 6;
            this.IdLabel.Text = "ID: ";
            // 
            // FullnameLabel
            // 
            this.FullnameLabel.AutoSize = true;
            this.FullnameLabel.Location = new System.Drawing.Point(244, 47);
            this.FullnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FullnameLabel.Name = "FullnameLabel";
            this.FullnameLabel.Size = new System.Drawing.Size(57, 13);
            this.FullnameLabel.TabIndex = 7;
            this.FullnameLabel.Text = "Full Name:";
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(244, 76);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(48, 13);
            this.AddressLabel.TabIndex = 8;
            this.AddressLabel.Text = "Address:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(308, 20);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(220, 20);
            this.IdTextBox.TabIndex = 9;
            // 
            // FullnameTextBox
            // 
            this.FullnameTextBox.Location = new System.Drawing.Point(308, 47);
            this.FullnameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FullnameTextBox.Name = "FullnameTextBox";
            this.FullnameTextBox.Size = new System.Drawing.Size(220, 20);
            this.FullnameTextBox.TabIndex = 10;
            this.FullnameTextBox.TextChanged += new System.EventHandler(this.FullnameTextBox_TextChanged);
            this.FullnameTextBox.Leave += new System.EventHandler(this.FullnameTextBox_Leave);
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressTextBox.Location = new System.Drawing.Point(308, 76);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddressTextBox.Multiline = true;
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(284, 123);
            this.AddressTextBox.TabIndex = 11;
            this.AddressTextBox.TextChanged += new System.EventHandler(this.AddressTextBox_TextChanged);
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddressTextBox);
            this.Controls.Add(this.FullnameTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.AddressLabel);
            this.Controls.Add(this.FullnameLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.SelectedItemLabel);
            this.Controls.Add(this.RandomizeButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.CustomersListBox);
            this.Controls.Add(this.CustomersLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CustomersTab";
            this.Size = new System.Drawing.Size(596, 426);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button RandomizeButton;
        private System.Windows.Forms.Label SelectedItemLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label FullnameLabel;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox FullnameTextBox;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}
