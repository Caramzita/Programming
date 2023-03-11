
namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.ItemsListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.CustomersComboBox = new System.Windows.Forms.ComboBox();
            this.CartLabel = new System.Windows.Forms.Label();
            this.CartListBox = new System.Windows.Forms.ListBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.CreateOrderButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ClearCartButton = new System.Windows.Forms.Button();
            this.DiscountsCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.DiscountAmountLabel = new System.Windows.Forms.Label();
            this.DiscountAmount = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemsLabel.Location = new System.Drawing.Point(4, 4);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(44, 16);
            this.ItemsLabel.TabIndex = 0;
            this.ItemsLabel.Text = "Items";
            // 
            // ItemsListBox
            // 
            this.ItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.ItemsListBox.FormattingEnabled = true;
            this.ItemsListBox.IntegralHeight = false;
            this.ItemsListBox.ItemHeight = 16;
            this.ItemsListBox.Location = new System.Drawing.Point(8, 25);
            this.ItemsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ItemsListBox.Name = "ItemsListBox";
            this.ItemsListBox.Size = new System.Drawing.Size(313, 597);
            this.ItemsListBox.TabIndex = 1;
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Location = new System.Drawing.Point(8, 628);
            this.AddButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(313, 37);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add To Cart";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CustomerLabel.Location = new System.Drawing.Point(324, 28);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(76, 16);
            this.CustomerLabel.TabIndex = 3;
            this.CustomerLabel.Text = "Customer:";
            // 
            // CustomersComboBox
            // 
            this.CustomersComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomersComboBox.FormattingEnabled = true;
            this.CustomersComboBox.Location = new System.Drawing.Point(406, 25);
            this.CustomersComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CustomersComboBox.Name = "CustomersComboBox";
            this.CustomersComboBox.Size = new System.Drawing.Size(613, 24);
            this.CustomersComboBox.TabIndex = 4;
            this.CustomersComboBox.SelectedIndexChanged += new System.EventHandler(this.CustomersComboBox_SelectedIndexChanged);
            // 
            // CartLabel
            // 
            this.CartLabel.AutoSize = true;
            this.CartLabel.Location = new System.Drawing.Point(324, 90);
            this.CartLabel.Name = "CartLabel";
            this.CartLabel.Size = new System.Drawing.Size(34, 16);
            this.CartLabel.TabIndex = 5;
            this.CartLabel.Text = "Cart:";
            // 
            // CartListBox
            // 
            this.CartListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CartListBox.FormattingEnabled = true;
            this.CartListBox.ItemHeight = 16;
            this.CartListBox.Location = new System.Drawing.Point(327, 108);
            this.CartListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CartListBox.Name = "CartListBox";
            this.CartListBox.Size = new System.Drawing.Size(692, 228);
            this.CartListBox.TabIndex = 6;
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(951, 338);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(70, 18);
            this.AmountLabel.TabIndex = 7;
            this.AmountLabel.Text = "Amount:";
            // 
            // Amount
            // 
            this.Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount.Location = new System.Drawing.Point(791, 357);
            this.Amount.Name = "Amount";
            this.Amount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Amount.Size = new System.Drawing.Size(241, 30);
            this.Amount.TabIndex = 8;
            this.Amount.Text = "4 990,90";
            this.Amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CreateOrderButton
            // 
            this.CreateOrderButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateOrderButton.Location = new System.Drawing.Point(327, 391);
            this.CreateOrderButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreateOrderButton.Name = "CreateOrderButton";
            this.CreateOrderButton.Size = new System.Drawing.Size(127, 32);
            this.CreateOrderButton.TabIndex = 9;
            this.CreateOrderButton.Text = "Create Order";
            this.CreateOrderButton.UseVisualStyleBackColor = true;
            this.CreateOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveItemButton.Location = new System.Drawing.Point(795, 391);
            this.RemoveItemButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(127, 32);
            this.RemoveItemButton.TabIndex = 10;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ClearCartButton
            // 
            this.ClearCartButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearCartButton.Location = new System.Drawing.Point(928, 391);
            this.ClearCartButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ClearCartButton.Name = "ClearCartButton";
            this.ClearCartButton.Size = new System.Drawing.Size(100, 32);
            this.ClearCartButton.TabIndex = 11;
            this.ClearCartButton.Text = "Clear Cart";
            this.ClearCartButton.UseVisualStyleBackColor = true;
            this.ClearCartButton.Click += new System.EventHandler(this.ClearCartButton_Click);
            // 
            // DiscountsCheckedListBox
            // 
            this.DiscountsCheckedListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountsCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DiscountsCheckedListBox.CheckOnClick = true;
            this.DiscountsCheckedListBox.FormattingEnabled = true;
            this.DiscountsCheckedListBox.Location = new System.Drawing.Point(327, 459);
            this.DiscountsCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DiscountsCheckedListBox.Name = "DiscountsCheckedListBox";
            this.DiscountsCheckedListBox.Size = new System.Drawing.Size(457, 187);
            this.DiscountsCheckedListBox.TabIndex = 12;
            this.DiscountsCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.DiscountsCheckedListBox_ItemCheck);
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountLabel.Location = new System.Drawing.Point(324, 441);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(79, 16);
            this.DiscountLabel.TabIndex = 13;
            this.DiscountLabel.Text = "Discounts:";
            // 
            // DiscountAmountLabel
            // 
            this.DiscountAmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountAmountLabel.AutoSize = true;
            this.DiscountAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountAmountLabel.Location = new System.Drawing.Point(887, 469);
            this.DiscountAmountLabel.Name = "DiscountAmountLabel";
            this.DiscountAmountLabel.Size = new System.Drawing.Size(126, 16);
            this.DiscountAmountLabel.TabIndex = 14;
            this.DiscountAmountLabel.Text = "Discount Amount:";
            // 
            // DiscountAmount
            // 
            this.DiscountAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DiscountAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountAmount.Location = new System.Drawing.Point(808, 485);
            this.DiscountAmount.Name = "DiscountAmount";
            this.DiscountAmount.Size = new System.Drawing.Size(224, 39);
            this.DiscountAmount.TabIndex = 15;
            this.DiscountAmount.Text = "499";
            this.DiscountAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalLabel
            // 
            this.TotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalLabel.Location = new System.Drawing.Point(961, 542);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(60, 16);
            this.TotalLabel.TabIndex = 16;
            this.TotalLabel.Text = "TOTAL:";
            // 
            // Total
            // 
            this.Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Total.Location = new System.Drawing.Point(803, 558);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(229, 31);
            this.Total.TabIndex = 17;
            this.Total.Text = "4500,90";
            this.Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CartsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Total);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.DiscountAmount);
            this.Controls.Add(this.DiscountAmountLabel);
            this.Controls.Add(this.DiscountLabel);
            this.Controls.Add(this.DiscountsCheckedListBox);
            this.Controls.Add(this.ClearCartButton);
            this.Controls.Add(this.RemoveItemButton);
            this.Controls.Add(this.CreateOrderButton);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.CartListBox);
            this.Controls.Add(this.CartLabel);
            this.Controls.Add(this.CustomersComboBox);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ItemsListBox);
            this.Controls.Add(this.ItemsLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CartsTab";
            this.Size = new System.Drawing.Size(1045, 670);
            this.Load += new System.EventHandler(this.CartsTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.ListBox ItemsListBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.ComboBox CustomersComboBox;
        private System.Windows.Forms.Label CartLabel;
        private System.Windows.Forms.ListBox CartListBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Button CreateOrderButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button ClearCartButton;
        private System.Windows.Forms.CheckedListBox DiscountsCheckedListBox;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Label DiscountAmountLabel;
        private System.Windows.Forms.Label DiscountAmount;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label Total;
    }
}
