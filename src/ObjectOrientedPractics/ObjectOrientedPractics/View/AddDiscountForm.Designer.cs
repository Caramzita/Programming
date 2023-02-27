namespace ObjectOrientedPractics.View
{
    partial class AddDiscountForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PercentDiscountLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OkButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PercentDiscountLabel
            // 
            this.PercentDiscountLabel.AutoSize = true;
            this.PercentDiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PercentDiscountLabel.Location = new System.Drawing.Point(12, 18);
            this.PercentDiscountLabel.Name = "PercentDiscountLabel";
            this.PercentDiscountLabel.Size = new System.Drawing.Size(109, 13);
            this.PercentDiscountLabel.TabIndex = 0;
            this.PercentDiscountLabel.Text = "Percent Discount:";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(12, 42);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(52, 13);
            this.CategoryLabel.TabIndex = 1;
            this.CategoryLabel.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(70, 39);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(198, 21);
            this.CategoryComboBox.TabIndex = 2;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(181, 73);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(87, 30);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(88, 73);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(87, 30);
            this.OkButton.TabIndex = 4;
            this.OkButton.Text = "OK";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // AddDiscountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 120);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.PercentDiscountLabel);
            this.Name = "AddDiscountForm";
            this.ShowIcon = false;
            this.Text = "Add Discount";
            this.Load += new System.EventHandler(this.AddDiscountForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PercentDiscountLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OkButton;
    }
}