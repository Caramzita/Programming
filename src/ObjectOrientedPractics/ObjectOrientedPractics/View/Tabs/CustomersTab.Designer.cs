
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
            this.FullNameTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.FullnameLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SelectedItemLabel = new System.Windows.Forms.Label();
            this.RandomizeButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.CustomersListBox = new System.Windows.Forms.ListBox();
            this.CustomersLabel = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PriorityCheckBox = new System.Windows.Forms.CheckBox();
            this.DiscountsLabel = new System.Windows.Forms.Label();
            this.DiscountsListBox = new System.Windows.Forms.ListBox();
            this.RemoveDiscountButton = new System.Windows.Forms.Button();
            this.AddDiscountButton = new System.Windows.Forms.Button();
            this.AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.SuspendLayout();
            // 
            // FullNameTextBox
            // 
            this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FullNameTextBox.Location = new System.Drawing.Point(308, 46);
            this.FullNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FullNameTextBox.Name = "FullNameTextBox";
            this.FullNameTextBox.Size = new System.Drawing.Size(141, 20);
            this.FullNameTextBox.TabIndex = 21;
            this.FullNameTextBox.TextChanged += new System.EventHandler(this.FullNameTextBox_TextChanged);
            this.FullNameTextBox.Leave += new System.EventHandler(this.FullNameTextBox_Leave);
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTextBox.Location = new System.Drawing.Point(308, 22);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(141, 20);
            this.IdTextBox.TabIndex = 20;
            // 
            // FullnameLabel
            // 
            this.FullnameLabel.AutoSize = true;
            this.FullnameLabel.Location = new System.Drawing.Point(245, 49);
            this.FullnameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.FullnameLabel.Name = "FullnameLabel";
            this.FullnameLabel.Size = new System.Drawing.Size(57, 13);
            this.FullnameLabel.TabIndex = 19;
            this.FullnameLabel.Text = "Full Name:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(245, 25);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(24, 13);
            this.IdLabel.TabIndex = 18;
            this.IdLabel.Text = "ID: ";
            // 
            // SelectedItemLabel
            // 
            this.SelectedItemLabel.AutoSize = true;
            this.SelectedItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedItemLabel.Location = new System.Drawing.Point(245, 2);
            this.SelectedItemLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectedItemLabel.Name = "SelectedItemLabel";
            this.SelectedItemLabel.Size = new System.Drawing.Size(85, 13);
            this.SelectedItemLabel.TabIndex = 17;
            this.SelectedItemLabel.Text = "Selected Item";
            // 
            // RandomizeButton
            // 
            this.RandomizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RandomizeButton.Location = new System.Drawing.Point(3, 441);
            this.RandomizeButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RandomizeButton.Name = "RandomizeButton";
            this.RandomizeButton.Size = new System.Drawing.Size(238, 30);
            this.RandomizeButton.TabIndex = 16;
            this.RandomizeButton.Text = "Randomize";
            this.RandomizeButton.UseVisualStyleBackColor = true;
            this.RandomizeButton.Click += new System.EventHandler(this.RandomizeButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButton.Location = new System.Drawing.Point(125, 403);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(116, 34);
            this.RemoveButton.TabIndex = 15;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Location = new System.Drawing.Point(3, 403);
            this.AddButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(116, 34);
            this.AddButton.TabIndex = 14;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CustomersListBox
            // 
            this.CustomersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CustomersListBox.FormattingEnabled = true;
            this.CustomersListBox.IntegralHeight = false;
            this.CustomersListBox.Location = new System.Drawing.Point(3, 18);
            this.CustomersListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomersListBox.Name = "CustomersListBox";
            this.CustomersListBox.Size = new System.Drawing.Size(238, 380);
            this.CustomersListBox.TabIndex = 13;
            this.CustomersListBox.SelectedIndexChanged += new System.EventHandler(this.CustomersListBox_SelectedIndexChanged);
            // 
            // CustomersLabel
            // 
            this.CustomersLabel.AutoSize = true;
            this.CustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomersLabel.Location = new System.Drawing.Point(2, 2);
            this.CustomersLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CustomersLabel.Name = "CustomersLabel";
            this.CustomersLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomersLabel.TabIndex = 12;
            this.CustomersLabel.Text = "Customers";
            // 
            // PriorityCheckBox
            // 
            this.PriorityCheckBox.AutoSize = true;
            this.PriorityCheckBox.Location = new System.Drawing.Point(308, 71);
            this.PriorityCheckBox.Name = "PriorityCheckBox";
            this.PriorityCheckBox.Size = new System.Drawing.Size(67, 17);
            this.PriorityCheckBox.TabIndex = 23;
            this.PriorityCheckBox.Text = "is Priority";
            this.PriorityCheckBox.UseVisualStyleBackColor = true;
            this.PriorityCheckBox.CheckedChanged += new System.EventHandler(this.PriorityCheckBox_CheckedChanged);
            // 
            // DiscountsLabel
            // 
            this.DiscountsLabel.AutoSize = true;
            this.DiscountsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountsLabel.Location = new System.Drawing.Point(245, 251);
            this.DiscountsLabel.Name = "DiscountsLabel";
            this.DiscountsLabel.Size = new System.Drawing.Size(63, 13);
            this.DiscountsLabel.TabIndex = 24;
            this.DiscountsLabel.Text = "Discounts";
            // 
            // DiscountsListBox
            // 
            this.DiscountsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountsListBox.FormattingEnabled = true;
            this.DiscountsListBox.IntegralHeight = false;
            this.DiscountsListBox.Location = new System.Drawing.Point(248, 267);
            this.DiscountsListBox.Name = "DiscountsListBox";
            this.DiscountsListBox.Size = new System.Drawing.Size(365, 166);
            this.DiscountsListBox.TabIndex = 25;
            // 
            // RemoveDiscountButton
            // 
            this.RemoveDiscountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveDiscountButton.Location = new System.Drawing.Point(532, 439);
            this.RemoveDiscountButton.Name = "RemoveDiscountButton";
            this.RemoveDiscountButton.Size = new System.Drawing.Size(81, 32);
            this.RemoveDiscountButton.TabIndex = 26;
            this.RemoveDiscountButton.Text = "Remove";
            this.RemoveDiscountButton.UseVisualStyleBackColor = true;
            this.RemoveDiscountButton.Click += new System.EventHandler(this.RemoveDiscountButton_Click);
            // 
            // AddDiscountButton
            // 
            this.AddDiscountButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDiscountButton.Location = new System.Drawing.Point(445, 439);
            this.AddDiscountButton.Name = "AddDiscountButton";
            this.AddDiscountButton.Size = new System.Drawing.Size(81, 32);
            this.AddDiscountButton.TabIndex = 27;
            this.AddDiscountButton.Text = "Add";
            this.AddDiscountButton.UseVisualStyleBackColor = true;
            this.AddDiscountButton.Click += new System.EventHandler(this.AddDiscountButton_Click);
            // 
            // AddressControl
            // 
            this.AddressControl.Address = null;
            this.AddressControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddressControl.Location = new System.Drawing.Point(245, 93);
            this.AddressControl.Margin = new System.Windows.Forms.Padding(2);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(368, 156);
            this.AddressControl.TabIndex = 22;
            // 
            // CustomersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddDiscountButton);
            this.Controls.Add(this.RemoveDiscountButton);
            this.Controls.Add(this.DiscountsListBox);
            this.Controls.Add(this.DiscountsLabel);
            this.Controls.Add(this.PriorityCheckBox);
            this.Controls.Add(this.AddressControl);
            this.Controls.Add(this.FullNameTextBox);
            this.Controls.Add(this.IdTextBox);
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
            this.Size = new System.Drawing.Size(616, 474);
            this.Load += new System.EventHandler(this.CustomersTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FullNameTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label FullnameLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label SelectedItemLabel;
        private System.Windows.Forms.Button RandomizeButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ListBox CustomersListBox;
        private System.Windows.Forms.Label CustomersLabel;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.CheckBox PriorityCheckBox;
        private System.Windows.Forms.Label DiscountsLabel;
        private System.Windows.Forms.ListBox DiscountsListBox;
        private System.Windows.Forms.Button RemoveDiscountButton;
        private System.Windows.Forms.Button AddDiscountButton;
        private Controls.AddressControl AddressControl;
    }
}
