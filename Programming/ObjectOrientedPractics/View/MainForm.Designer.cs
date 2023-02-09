namespace ObjectOrientedPractics
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.TabControl = new System.Windows.Forms.TabControl();
            this.ItemsPage = new System.Windows.Forms.TabPage();
            this.ItemsTab = new ObjectOrientedPractics.View.Tabs.ItemsTab();
            this.CustomersPage = new System.Windows.Forms.TabPage();
            this.CustomersTab = new ObjectOrientedPractics.View.Tabs.CustomersTab();
            this.CartsTabPage = new System.Windows.Forms.TabPage();
            this.CartsTab = new ObjectOrientedPractics.View.Tabs.CartsTab();
            this.OrdersTabPage = new System.Windows.Forms.TabPage();
            this.OrdersTab = new ObjectOrientedPractics.View.Tabs.OrdersTab();
            this.PriorityTabPage = new System.Windows.Forms.TabPage();
            this.priorityOrdersTab1 = new ObjectOrientedPractics.View.Tabs.PriorityOrdersTab();
            this.DiscountTabPage = new System.Windows.Forms.TabPage();
            this.discoundTab1 = new ObjectOrientedPractics.View.Tabs.DiscoundTab();
            this.TabControl.SuspendLayout();
            this.ItemsPage.SuspendLayout();
            this.CustomersPage.SuspendLayout();
            this.CartsTabPage.SuspendLayout();
            this.OrdersTabPage.SuspendLayout();
            this.PriorityTabPage.SuspendLayout();
            this.DiscountTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ItemsPage);
            this.TabControl.Controls.Add(this.CustomersPage);
            this.TabControl.Controls.Add(this.CartsTabPage);
            this.TabControl.Controls.Add(this.OrdersTabPage);
            this.TabControl.Controls.Add(this.PriorityTabPage);
            this.TabControl.Controls.Add(this.DiscountTabPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(720, 541);
            this.TabControl.TabIndex = 0;
            this.TabControl.SelectedIndexChanged += new System.EventHandler(this.TabControl_SelectedIndexChanged);
            // 
            // ItemsPage
            // 
            this.ItemsPage.Controls.Add(this.ItemsTab);
            this.ItemsPage.Location = new System.Drawing.Point(4, 22);
            this.ItemsPage.Margin = new System.Windows.Forms.Padding(2);
            this.ItemsPage.Name = "ItemsPage";
            this.ItemsPage.Padding = new System.Windows.Forms.Padding(2);
            this.ItemsPage.Size = new System.Drawing.Size(712, 515);
            this.ItemsPage.TabIndex = 2;
            this.ItemsPage.Text = "Items";
            this.ItemsPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            this.ItemsTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ItemsTab.Items = null;
            this.ItemsTab.Location = new System.Drawing.Point(2, 2);
            this.ItemsTab.Margin = new System.Windows.Forms.Padding(2);
            this.ItemsTab.Name = "ItemsTab";
            this.ItemsTab.Size = new System.Drawing.Size(706, 519);
            this.ItemsTab.TabIndex = 0;
            // 
            // CustomersPage
            // 
            this.CustomersPage.Controls.Add(this.CustomersTab);
            this.CustomersPage.Location = new System.Drawing.Point(4, 22);
            this.CustomersPage.Margin = new System.Windows.Forms.Padding(2);
            this.CustomersPage.Name = "CustomersPage";
            this.CustomersPage.Padding = new System.Windows.Forms.Padding(2);
            this.CustomersPage.Size = new System.Drawing.Size(712, 515);
            this.CustomersPage.TabIndex = 1;
            this.CustomersPage.Text = "Customers";
            this.CustomersPage.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            this.CustomersTab.Customers = null;
            this.CustomersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomersTab.Location = new System.Drawing.Point(2, 2);
            this.CustomersTab.Margin = new System.Windows.Forms.Padding(2);
            this.CustomersTab.Name = "CustomersTab";
            this.CustomersTab.Size = new System.Drawing.Size(708, 511);
            this.CustomersTab.TabIndex = 0;
            // 
            // CartsTabPage
            // 
            this.CartsTabPage.Controls.Add(this.CartsTab);
            this.CartsTabPage.Location = new System.Drawing.Point(4, 22);
            this.CartsTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.CartsTabPage.Name = "CartsTabPage";
            this.CartsTabPage.Size = new System.Drawing.Size(712, 515);
            this.CartsTabPage.TabIndex = 3;
            this.CartsTabPage.Text = "Carts";
            this.CartsTabPage.UseVisualStyleBackColor = true;
            // 
            // CartsTab
            // 
            this.CartsTab.Customers = null;
            this.CartsTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CartsTab.Items = null;
            this.CartsTab.Location = new System.Drawing.Point(0, 0);
            this.CartsTab.Margin = new System.Windows.Forms.Padding(2);
            this.CartsTab.Name = "CartsTab";
            this.CartsTab.Size = new System.Drawing.Size(712, 515);
            this.CartsTab.TabIndex = 0;
            // 
            // OrdersTabPage
            // 
            this.OrdersTabPage.Controls.Add(this.OrdersTab);
            this.OrdersTabPage.Location = new System.Drawing.Point(4, 22);
            this.OrdersTabPage.Margin = new System.Windows.Forms.Padding(2);
            this.OrdersTabPage.Name = "OrdersTabPage";
            this.OrdersTabPage.Size = new System.Drawing.Size(712, 515);
            this.OrdersTabPage.TabIndex = 4;
            this.OrdersTabPage.Text = "Orders";
            this.OrdersTabPage.UseVisualStyleBackColor = true;
            // 
            // OrdersTab
            // 
            this.OrdersTab.Customers = null;
            this.OrdersTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OrdersTab.Location = new System.Drawing.Point(0, 0);
            this.OrdersTab.Margin = new System.Windows.Forms.Padding(2);
            this.OrdersTab.Name = "OrdersTab";
            this.OrdersTab.CheckPriority = null;
            this.OrdersTab.Size = new System.Drawing.Size(712, 515);
            this.OrdersTab.TabIndex = 0;
            // 
            // PriorityTabPage
            // 
            this.PriorityTabPage.Controls.Add(this.priorityOrdersTab1);
            this.PriorityTabPage.Location = new System.Drawing.Point(4, 22);
            this.PriorityTabPage.Name = "PriorityTabPage";
            this.PriorityTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.PriorityTabPage.Size = new System.Drawing.Size(712, 515);
            this.PriorityTabPage.TabIndex = 5;
            this.PriorityTabPage.Text = "Priority Order";
            this.PriorityTabPage.UseVisualStyleBackColor = true;
            // 
            // priorityOrdersTab1
            // 
            this.priorityOrdersTab1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priorityOrdersTab1.Location = new System.Drawing.Point(3, 3);
            this.priorityOrdersTab1.Name = "priorityOrdersTab1";
            this.priorityOrdersTab1.Size = new System.Drawing.Size(701, 504);
            this.priorityOrdersTab1.TabIndex = 0;
            // 
            // DiscountTabPage
            // 
            this.DiscountTabPage.Controls.Add(this.discoundTab1);
            this.DiscountTabPage.Location = new System.Drawing.Point(4, 22);
            this.DiscountTabPage.Name = "DiscountTabPage";
            this.DiscountTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.DiscountTabPage.Size = new System.Drawing.Size(712, 515);
            this.DiscountTabPage.TabIndex = 6;
            this.DiscountTabPage.Text = "Discount";
            this.DiscountTabPage.UseVisualStyleBackColor = true;
            // 
            // discoundTab1
            // 
            this.discoundTab1.Location = new System.Drawing.Point(53, 39);
            this.discoundTab1.Name = "discoundTab1";
            this.discoundTab1.Size = new System.Drawing.Size(626, 439);
            this.discoundTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(720, 541);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.TabControl.ResumeLayout(false);
            this.ItemsPage.ResumeLayout(false);
            this.CustomersPage.ResumeLayout(false);
            this.CartsTabPage.ResumeLayout(false);
            this.OrdersTabPage.ResumeLayout(false);
            this.PriorityTabPage.ResumeLayout(false);
            this.DiscountTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage ItemsPage;
        private System.Windows.Forms.TabPage CustomersPage;
        private System.Windows.Forms.TabPage CartsTabPage;
        private System.Windows.Forms.TabPage OrdersTabPage;
        private View.Tabs.OrdersTab OrdersTab;
        private View.Tabs.ItemsTab ItemsTab;
        private View.Tabs.CustomersTab CustomersTab;
        private View.Tabs.CartsTab CartsTab;
        private System.Windows.Forms.TabPage PriorityTabPage;
        private View.Tabs.PriorityOrdersTab priorityOrdersTab1;
        private System.Windows.Forms.TabPage DiscountTabPage;
        private View.Tabs.DiscoundTab discoundTab1;
    }
}

