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
            this.TabControl.SuspendLayout();
            this.ItemsPage.SuspendLayout();
            this.CustomersPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.ItemsPage);
            this.TabControl.Controls.Add(this.CustomersPage);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Margin = new System.Windows.Forms.Padding(2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(627, 453);
            this.TabControl.TabIndex = 0;
            // 
            // ItemsPage
            // 
            this.ItemsPage.Controls.Add(this.ItemsTab);
            this.ItemsPage.Location = new System.Drawing.Point(4, 22);
            this.ItemsPage.Margin = new System.Windows.Forms.Padding(2);
            this.ItemsPage.Name = "ItemsPage";
            this.ItemsPage.Padding = new System.Windows.Forms.Padding(2);
            this.ItemsPage.Size = new System.Drawing.Size(619, 427);
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
            this.ItemsTab.Size = new System.Drawing.Size(616, 427);
            this.ItemsTab.TabIndex = 0;
            // 
            // CustomersPage
            // 
            this.CustomersPage.Controls.Add(this.CustomersTab);
            this.CustomersPage.Location = new System.Drawing.Point(4, 22);
            this.CustomersPage.Margin = new System.Windows.Forms.Padding(2);
            this.CustomersPage.Name = "CustomersPage";
            this.CustomersPage.Padding = new System.Windows.Forms.Padding(2);
            this.CustomersPage.Size = new System.Drawing.Size(619, 427);
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
            this.CustomersTab.Size = new System.Drawing.Size(615, 423);
            this.CustomersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(627, 453);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.TabControl.ResumeLayout(false);
            this.ItemsPage.ResumeLayout(false);
            this.CustomersPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage ItemsPage;
        private View.Tabs.ItemsTab ItemsTab;
        private System.Windows.Forms.TabPage CustomersPage;
        private View.Tabs.CustomersTab CustomersTab;
    }
}

