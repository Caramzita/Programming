
namespace ObjectOrientedPractics.View.Controls
{
    partial class AddressControl
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
            this.AddressLabel = new System.Windows.Forms.Label();
            this.IndexLabel = new System.Windows.Forms.Label();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.StreetLabel = new System.Windows.Forms.Label();
            this.BuildingLabel = new System.Windows.Forms.Label();
            this.IndexTextBox = new System.Windows.Forms.TextBox();
            this.CountryTextBox = new System.Windows.Forms.TextBox();
            this.StreetTextBox = new System.Windows.Forms.TextBox();
            this.BuildingTextBox = new System.Windows.Forms.TextBox();
            this.CityLabel = new System.Windows.Forms.Label();
            this.CityTextBox = new System.Windows.Forms.TextBox();
            this.ApartmentLabel = new System.Windows.Forms.Label();
            this.ApartmentTextBox = new System.Windows.Forms.TextBox();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressLabel.Location = new System.Drawing.Point(3, 3);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(102, 13);
            this.AddressLabel.TabIndex = 0;
            this.AddressLabel.Text = "Delivery Address";
            // 
            // IndexLabel
            // 
            this.IndexLabel.AutoSize = true;
            this.IndexLabel.Location = new System.Drawing.Point(3, 32);
            this.IndexLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IndexLabel.Name = "IndexLabel";
            this.IndexLabel.Size = new System.Drawing.Size(59, 13);
            this.IndexLabel.TabIndex = 1;
            this.IndexLabel.Text = "Post index:";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(3, 58);
            this.CountryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(46, 13);
            this.CountryLabel.TabIndex = 2;
            this.CountryLabel.Text = "Country:";
            // 
            // StreetLabel
            // 
            this.StreetLabel.AutoSize = true;
            this.StreetLabel.Location = new System.Drawing.Point(3, 88);
            this.StreetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StreetLabel.Name = "StreetLabel";
            this.StreetLabel.Size = new System.Drawing.Size(38, 13);
            this.StreetLabel.TabIndex = 3;
            this.StreetLabel.Text = "Street:";
            // 
            // BuildingLabel
            // 
            this.BuildingLabel.AutoSize = true;
            this.BuildingLabel.Location = new System.Drawing.Point(3, 119);
            this.BuildingLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.BuildingLabel.Name = "BuildingLabel";
            this.BuildingLabel.Size = new System.Drawing.Size(47, 13);
            this.BuildingLabel.TabIndex = 4;
            this.BuildingLabel.Text = "Building:";
            // 
            // IndexTextBox
            // 
            this.IndexTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IndexTextBox.Location = new System.Drawing.Point(65, 32);
            this.IndexTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IndexTextBox.Name = "IndexTextBox";
            this.IndexTextBox.Size = new System.Drawing.Size(101, 20);
            this.IndexTextBox.TabIndex = 5;
            this.IndexTextBox.TextChanged += new System.EventHandler(this.IndexTextBox_TextChanged);
            // 
            // CountryTextBox
            // 
            this.CountryTextBox.Location = new System.Drawing.Point(65, 58);
            this.CountryTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CountryTextBox.Name = "CountryTextBox";
            this.CountryTextBox.Size = new System.Drawing.Size(143, 20);
            this.CountryTextBox.TabIndex = 6;
            this.CountryTextBox.TextChanged += new System.EventHandler(this.CountryTextBox_TextChanged);
            // 
            // StreetTextBox
            // 
            this.StreetTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StreetTextBox.Location = new System.Drawing.Point(65, 85);
            this.StreetTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StreetTextBox.Name = "StreetTextBox";
            this.StreetTextBox.Size = new System.Drawing.Size(299, 20);
            this.StreetTextBox.TabIndex = 7;
            this.StreetTextBox.TextChanged += new System.EventHandler(this.StreetTextBox_TextChanged);
            // 
            // BuildingTextBox
            // 
            this.BuildingTextBox.Location = new System.Drawing.Point(65, 117);
            this.BuildingTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BuildingTextBox.Name = "BuildingTextBox";
            this.BuildingTextBox.Size = new System.Drawing.Size(101, 20);
            this.BuildingTextBox.TabIndex = 8;
            this.BuildingTextBox.TextChanged += new System.EventHandler(this.BuildingTextBox_TextChanged);
            // 
            // CityLabel
            // 
            this.CityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityLabel.AutoSize = true;
            this.CityLabel.Location = new System.Drawing.Point(212, 58);
            this.CityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CityLabel.Name = "CityLabel";
            this.CityLabel.Size = new System.Drawing.Size(27, 13);
            this.CityLabel.TabIndex = 9;
            this.CityLabel.Text = "City:";
            // 
            // CityTextBox
            // 
            this.CityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CityTextBox.Location = new System.Drawing.Point(242, 56);
            this.CityTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CityTextBox.Name = "CityTextBox";
            this.CityTextBox.Size = new System.Drawing.Size(122, 20);
            this.CityTextBox.TabIndex = 10;
            this.CityTextBox.TextChanged += new System.EventHandler(this.CityTextBox_TextChanged);
            // 
            // ApartmentLabel
            // 
            this.ApartmentLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApartmentLabel.AutoSize = true;
            this.ApartmentLabel.Location = new System.Drawing.Point(180, 119);
            this.ApartmentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ApartmentLabel.Name = "ApartmentLabel";
            this.ApartmentLabel.Size = new System.Drawing.Size(58, 13);
            this.ApartmentLabel.TabIndex = 11;
            this.ApartmentLabel.Text = "Apartment:";
            // 
            // ApartmentTextBox
            // 
            this.ApartmentTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ApartmentTextBox.Location = new System.Drawing.Point(242, 117);
            this.ApartmentTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ApartmentTextBox.Name = "ApartmentTextBox";
            this.ApartmentTextBox.Size = new System.Drawing.Size(122, 20);
            this.ApartmentTextBox.TabIndex = 12;
            this.ApartmentTextBox.TextChanged += new System.EventHandler(this.ApartmentTextBox_TextChanged);
            // 
            // AddressControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ApartmentTextBox);
            this.Controls.Add(this.ApartmentLabel);
            this.Controls.Add(this.CityTextBox);
            this.Controls.Add(this.CityLabel);
            this.Controls.Add(this.BuildingTextBox);
            this.Controls.Add(this.StreetTextBox);
            this.Controls.Add(this.CountryTextBox);
            this.Controls.Add(this.IndexTextBox);
            this.Controls.Add(this.BuildingLabel);
            this.Controls.Add(this.StreetLabel);
            this.Controls.Add(this.CountryLabel);
            this.Controls.Add(this.IndexLabel);
            this.Controls.Add(this.AddressLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddressControl";
            this.Size = new System.Drawing.Size(379, 152);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.Label IndexLabel;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.Label StreetLabel;
        private System.Windows.Forms.Label BuildingLabel;
        private System.Windows.Forms.TextBox IndexTextBox;
        private System.Windows.Forms.TextBox CountryTextBox;
        private System.Windows.Forms.TextBox StreetTextBox;
        private System.Windows.Forms.TextBox BuildingTextBox;
        private System.Windows.Forms.Label CityLabel;
        private System.Windows.Forms.TextBox CityTextBox;
        private System.Windows.Forms.Label ApartmentLabel;
        private System.Windows.Forms.TextBox ApartmentTextBox;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}
