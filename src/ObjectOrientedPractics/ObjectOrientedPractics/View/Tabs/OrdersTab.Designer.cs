
namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            this.OrdersLabel = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.IsPriority = new System.Windows.Forms.DataGridViewImageColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Created = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedOrderLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CreatedTextBox = new System.Windows.Forms.TextBox();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.PriorityPanel = new System.Windows.Forms.Panel();
            this.DeliveryDatePicker = new System.Windows.Forms.DateTimePicker();
            this.DeliveryDateLabel = new System.Windows.Forms.Label();
            this.DeliveryTimeComboBox = new System.Windows.Forms.ComboBox();
            this.DeliveryTimeLabel = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.PriorityPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OrdersLabel
            // 
            this.OrdersLabel.AutoSize = true;
            this.OrdersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrdersLabel.Location = new System.Drawing.Point(4, 4);
            this.OrdersLabel.Name = "OrdersLabel";
            this.OrdersLabel.Size = new System.Drawing.Size(54, 16);
            this.OrdersLabel.TabIndex = 0;
            this.OrdersLabel.Text = "Orders";
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToResizeColumns = false;
            this.DataGridView.AllowUserToResizeRows = false;
            this.DataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridView.ColumnHeadersHeight = 25;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IsPriority,
            this.ID,
            this.Created,
            this.OrderStatusColumn,
            this.FullName,
            this.Address,
            this.AmountColumn,
            this.TotalColumn});
            this.DataGridView.Location = new System.Drawing.Point(7, 25);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersVisible = false;
            this.DataGridView.RowHeadersWidth = 51;
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(513, 645);
            this.DataGridView.TabIndex = 1;
            this.DataGridView.SelectionChanged += new System.EventHandler(this.DataGridView_SelectionChanged);
            // 
            // IsPriority
            // 
            this.IsPriority.HeaderText = "";
            this.IsPriority.MinimumWidth = 6;
            this.IsPriority.Name = "IsPriority";
            this.IsPriority.Width = 30;
            // 
            // ID
            // 
            this.ID.HeaderText = "Id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Width = 25;
            // 
            // Created
            // 
            this.Created.HeaderText = "Created";
            this.Created.MinimumWidth = 6;
            this.Created.Name = "Created";
            this.Created.ReadOnly = true;
            this.Created.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Created.Width = 75;
            // 
            // OrderStatusColumn
            // 
            this.OrderStatusColumn.HeaderText = "Order Status";
            this.OrderStatusColumn.MinimumWidth = 6;
            this.OrderStatusColumn.Name = "OrderStatusColumn";
            this.OrderStatusColumn.ReadOnly = true;
            this.OrderStatusColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OrderStatusColumn.Width = 75;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Customer Full Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.FullName.Width = 175;
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 125;
            // 
            // AmountColumn
            // 
            this.AmountColumn.HeaderText = "Amount";
            this.AmountColumn.MinimumWidth = 6;
            this.AmountColumn.Name = "AmountColumn";
            this.AmountColumn.ReadOnly = true;
            this.AmountColumn.Width = 125;
            // 
            // TotalColumn
            // 
            this.TotalColumn.HeaderText = "Total";
            this.TotalColumn.MinimumWidth = 6;
            this.TotalColumn.Name = "TotalColumn";
            this.TotalColumn.Width = 125;
            // 
            // SelectedOrderLabel
            // 
            this.SelectedOrderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedOrderLabel.AutoSize = true;
            this.SelectedOrderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SelectedOrderLabel.Location = new System.Drawing.Point(523, 4);
            this.SelectedOrderLabel.Name = "SelectedOrderLabel";
            this.SelectedOrderLabel.Size = new System.Drawing.Size(112, 16);
            this.SelectedOrderLabel.TabIndex = 2;
            this.SelectedOrderLabel.Text = "Selected Order";
            // 
            // IDLabel
            // 
            this.IDLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(525, 32);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(23, 16);
            this.IDLabel.TabIndex = 3;
            this.IDLabel.Text = "ID:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(525, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Created:";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(525, 91);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(47, 16);
            this.StatusLabel.TabIndex = 5;
            this.StatusLabel.Text = "Status:";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.IdTextBox.Location = new System.Drawing.Point(608, 28);
            this.IdTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(200, 22);
            this.IdTextBox.TabIndex = 6;
            // 
            // CreatedTextBox
            // 
            this.CreatedTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CreatedTextBox.Location = new System.Drawing.Point(608, 58);
            this.CreatedTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CreatedTextBox.Name = "CreatedTextBox";
            this.CreatedTextBox.ReadOnly = true;
            this.CreatedTextBox.Size = new System.Drawing.Size(200, 22);
            this.CreatedTextBox.TabIndex = 7;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(608, 87);
            this.StatusComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(200, 24);
            this.StatusComboBox.TabIndex = 8;
            this.StatusComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusComboBox_SelectedIndexChanged);
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderItemsLabel.AutoSize = true;
            this.OrderItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OrderItemsLabel.Location = new System.Drawing.Point(525, 300);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(87, 16);
            this.OrderItemsLabel.TabIndex = 10;
            this.OrderItemsLabel.Text = "Order Items";
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.ItemHeight = 16;
            this.OrderItemsListBox.Location = new System.Drawing.Point(528, 319);
            this.OrderItemsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(576, 212);
            this.OrderItemsListBox.TabIndex = 11;
            // 
            // AmountLabel
            // 
            this.AmountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(1035, 534);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(62, 16);
            this.AmountLabel.TabIndex = 12;
            this.AmountLabel.Text = "Amount:";
            // 
            // Amount
            // 
            this.Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount.Location = new System.Drawing.Point(871, 550);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(235, 31);
            this.Amount.TabIndex = 13;
            this.Amount.Text = "4 990,90";
            this.Amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriorityLabel.Location = new System.Drawing.Point(4, 4);
            this.PriorityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(121, 17);
            this.PriorityLabel.TabIndex = 14;
            this.PriorityLabel.Text = "Priority Options";
            // 
            // PriorityPanel
            // 
            this.PriorityPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PriorityPanel.Controls.Add(this.DeliveryDatePicker);
            this.PriorityPanel.Controls.Add(this.DeliveryDateLabel);
            this.PriorityPanel.Controls.Add(this.DeliveryTimeComboBox);
            this.PriorityPanel.Controls.Add(this.DeliveryTimeLabel);
            this.PriorityPanel.Controls.Add(this.PriorityLabel);
            this.PriorityPanel.Location = new System.Drawing.Point(816, 4);
            this.PriorityPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PriorityPanel.Name = "PriorityPanel";
            this.PriorityPanel.Size = new System.Drawing.Size(289, 110);
            this.PriorityPanel.TabIndex = 15;
            // 
            // DeliveryDatePicker
            // 
            this.DeliveryDatePicker.Location = new System.Drawing.Point(115, 54);
            this.DeliveryDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeliveryDatePicker.MinDate = new System.DateTime(2022, 9, 27, 0, 0, 0, 0);
            this.DeliveryDatePicker.Name = "DeliveryDatePicker";
            this.DeliveryDatePicker.Size = new System.Drawing.Size(160, 22);
            this.DeliveryDatePicker.TabIndex = 18;
            this.DeliveryDatePicker.ValueChanged += new System.EventHandler(this.DeliveryDatePicker_ValueChanged);
            // 
            // DeliveryDateLabel
            // 
            this.DeliveryDateLabel.AutoSize = true;
            this.DeliveryDateLabel.Location = new System.Drawing.Point(8, 58);
            this.DeliveryDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeliveryDateLabel.Name = "DeliveryDateLabel";
            this.DeliveryDateLabel.Size = new System.Drawing.Size(92, 16);
            this.DeliveryDateLabel.TabIndex = 17;
            this.DeliveryDateLabel.Text = "Delivery Date:";
            // 
            // DeliveryTimeComboBox
            // 
            this.DeliveryTimeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DeliveryTimeComboBox.FormattingEnabled = true;
            this.DeliveryTimeComboBox.Location = new System.Drawing.Point(115, 21);
            this.DeliveryTimeComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            this.DeliveryTimeComboBox.Size = new System.Drawing.Size(160, 24);
            this.DeliveryTimeComboBox.TabIndex = 16;
            this.DeliveryTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.DeliveryTimeComboBox_SelectedIndexChanged);
            // 
            // DeliveryTimeLabel
            // 
            this.DeliveryTimeLabel.AutoSize = true;
            this.DeliveryTimeLabel.Location = new System.Drawing.Point(8, 28);
            this.DeliveryTimeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            this.DeliveryTimeLabel.Size = new System.Drawing.Size(94, 16);
            this.DeliveryTimeLabel.TabIndex = 15;
            this.DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // Total
            // 
            this.Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Total.Location = new System.Drawing.Point(867, 618);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(239, 31);
            this.Total.TabIndex = 17;
            this.Total.Text = "4 990,90";
            this.Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TotalLabel
            // 
            this.TotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalLabel.Location = new System.Drawing.Point(1037, 602);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(60, 16);
            this.TotalLabel.TabIndex = 16;
            this.TotalLabel.Text = "TOTAL:";
            // 
            // AddressControl
            // 
            this.AddressControl.Address = null;
            this.AddressControl.Location = new System.Drawing.Point(528, 140);
            this.AddressControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddressControl.Name = "AddressControl";
            this.AddressControl.Size = new System.Drawing.Size(576, 158);
            this.AddressControl.TabIndex = 18;
            // 
            // OrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddressControl);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.PriorityPanel);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.AmountLabel);
            this.Controls.Add(this.OrderItemsListBox);
            this.Controls.Add(this.OrderItemsLabel);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.CreatedTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.SelectedOrderLabel);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.OrdersLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrdersTab";
            this.Size = new System.Drawing.Size(1109, 686);
            this.Load += new System.EventHandler(this.OrdersTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.PriorityPanel.ResumeLayout(false);
            this.PriorityPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OrdersLabel;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label SelectedOrderLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox CreatedTextBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label OrderItemsLabel;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.Panel PriorityPanel;
        private System.Windows.Forms.Label DeliveryTimeLabel;
        private System.Windows.Forms.ComboBox DeliveryTimeComboBox;
        private System.Windows.Forms.DateTimePicker DeliveryDatePicker;
        private System.Windows.Forms.Label DeliveryDateLabel;
        private System.Windows.Forms.DataGridViewImageColumn IsPriority;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Created;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatusColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalColumn;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Label TotalLabel;
        private Controls.AddressControl AddressControl;
    }
}
