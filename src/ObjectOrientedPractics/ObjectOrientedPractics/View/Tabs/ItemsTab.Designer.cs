
namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            this.InfoTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.RandomizeButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.FindLabel = new System.Windows.Forms.Label();
            this.FindTextBox = new System.Windows.Forms.TextBox();
            this.OrderByLabel = new System.Windows.Forms.Label();
            this.OrderByComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InfoTextBox.Location = new System.Drawing.Point(331, 332);
            this.InfoTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InfoTextBox.Multiline = true;
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.Size = new System.Drawing.Size(484, 246);
            this.InfoTextBox.TabIndex = 31;
            this.InfoTextBox.TextChanged += new System.EventHandler(this.InfoTextBox_TextChanged);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Location = new System.Drawing.Point(327, 305);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(78, 16);
            this.DescriptionLabel.TabIndex = 30;
            this.DescriptionLabel.Text = "Description:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Location = new System.Drawing.Point(331, 138);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox.Multiline = true;
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(484, 150);
            this.NameTextBox.TabIndex = 29;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            this.NameTextBox.Leave += new System.EventHandler(this.NameTextBox_Leave);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(327, 119);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(47, 16);
            this.NameLabel.TabIndex = 28;
            this.NameLabel.Text = "Name:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(411, 86);
            this.CategoryComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(187, 24);
            this.CategoryComboBox.TabIndex = 27;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // CostTextBox
            // 
            this.CostTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CostTextBox.Location = new System.Drawing.Point(411, 57);
            this.CostTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(187, 22);
            this.CostTextBox.TabIndex = 26;
            this.CostTextBox.TextChanged += new System.EventHandler(this.CostTextBox_TextChanged);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTextBox.Location = new System.Drawing.Point(411, 27);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(187, 22);
            this.IdTextBox.TabIndex = 25;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(327, 90);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(65, 16);
            this.CategoryLabel.TabIndex = 24;
            this.CategoryLabel.Text = "Category:";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Location = new System.Drawing.Point(327, 60);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(37, 16);
            this.CostLabel.TabIndex = 23;
            this.CostLabel.Text = "Cost:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(327, 31);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(23, 16);
            this.IdLabel.TabIndex = 22;
            this.IdLabel.Text = "ID:";
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.AutoSize = true;
            this.SelectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedItemLabel.Location = new System.Drawing.Point(327, 2);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(102, 16);
            this.SelectedItemLabel.TabIndex = 21;
            this.SelectedItemLabel.Text = "Selected Item";
            // 
            // RandomizeButton
            // 
            this.RandomizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RandomizeButton.Location = new System.Drawing.Point(4, 543);
            this.RandomizeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RandomizeButton.Name = "RandomizeButton";
            this.RandomizeButton.Size = new System.Drawing.Size(317, 37);
            this.RandomizeButton.TabIndex = 20;
            this.RandomizeButton.Text = "Randomize";
            this.RandomizeButton.UseVisualStyleBackColor = true;
            this.RandomizeButton.Click += new System.EventHandler(this.RandomizeButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButton.Location = new System.Drawing.Point(167, 496);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(155, 42);
            this.RemoveButton.TabIndex = 19;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Location = new System.Drawing.Point(4, 496);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(155, 42);
            this.AddButton.TabIndex = 18;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.IntegralHeight = false;
            this.ItemsListBox.ItemHeight = 16;
            this.ItemsListBox.Location = new System.Drawing.Point(4, 54);
            this.ItemsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(316, 405);
            this.ItemsListBox.TabIndex = 17;
            this.ItemsListBox.SelectedIndexChanged += new System.EventHandler(this.ItemsListBox_SelectedIndexChanged);
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsLabel.Location = new System.Drawing.Point(3, 2);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(44, 16);
            this.ItemsLabel.TabIndex = 16;
            this.ItemsLabel.Text = "Items";
            // 
            // FindLabel
            // 
            this.FindLabel.AutoSize = true;
            this.FindLabel.Location = new System.Drawing.Point(3, 27);
            this.FindLabel.Name = "FindLabel";
            this.FindLabel.Size = new System.Drawing.Size(36, 16);
            this.FindLabel.TabIndex = 32;
            this.FindLabel.Text = "Find:";
            // 
            // FindTextBox
            // 
            this.FindTextBox.Location = new System.Drawing.Point(48, 25);
            this.FindTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindTextBox.Name = "FindTextBox";
            this.FindTextBox.Size = new System.Drawing.Size(272, 22);
            this.FindTextBox.TabIndex = 33;
            this.FindTextBox.TextChanged += new System.EventHandler(this.FindTextBox_TextChanged);
            // 
            // OrderByLabel
            // 
            this.OrderByLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OrderByLabel.AutoSize = true;
            this.OrderByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderByLabel.Location = new System.Drawing.Point(3, 469);
            this.OrderByLabel.Name = "OrderByLabel";
            this.OrderByLabel.Size = new System.Drawing.Size(62, 16);
            this.OrderByLabel.TabIndex = 34;
            this.OrderByLabel.Text = "Order by:";
            // 
            // OrderByComboBox
            // 
            this.OrderByComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OrderByComboBox.FormattingEnabled = true;
            this.OrderByComboBox.Location = new System.Drawing.Point(71, 465);
            this.OrderByComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderByComboBox.Name = "OrderByComboBox";
            this.OrderByComboBox.Size = new System.Drawing.Size(249, 24);
            this.OrderByComboBox.TabIndex = 35;
            this.OrderByComboBox.SelectedIndexChanged += new System.EventHandler(this.OrderByComboBox_SelectedIndexChanged);
            // 
            // ItemsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OrderByComboBox);
            this.Controls.Add(this.OrderByLabel);
            this.Controls.Add(this.FindTextBox);
            this.Controls.Add(this.FindLabel);
            this.Controls.Add(this.InfoTextBox);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.SelectedItemLabel);
            this.Controls.Add(this.RandomizeButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.ItemsLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ItemsTab";
            this.Size = new System.Drawing.Size(821, 583);
            this.Load += new System.EventHandler(this.ItemsTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InfoTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label SelectedItemLabel;
        private System.Windows.Forms.Button RandomizeButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Label FindLabel;
        private System.Windows.Forms.TextBox FindTextBox;
        private System.Windows.Forms.Label OrderByLabel;
        private System.Windows.Forms.ComboBox OrderByComboBox;
    }
}
