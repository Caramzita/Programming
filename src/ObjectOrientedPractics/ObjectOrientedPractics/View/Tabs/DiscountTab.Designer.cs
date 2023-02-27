namespace ObjectOrientedPractics.View.Tabs
{
    partial class DiscountTab
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
            this.AmountLabel = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.Discount = new System.Windows.Forms.Label();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.UpdatePercent = new System.Windows.Forms.Button();
            this.ApplyPercent = new System.Windows.Forms.Button();
            this.CalculatePercent = new System.Windows.Forms.Button();
            this.InfoPercent = new System.Windows.Forms.Label();
            this.PercentDiscount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AmountPercent = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountLabel.Location = new System.Drawing.Point(368, 140);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(103, 13);
            this.AmountLabel.TabIndex = 0;
            this.AmountLabel.Text = "Products Amount";
            // 
            // Amount
            // 
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Amount.Location = new System.Drawing.Point(371, 153);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(100, 23);
            this.Amount.TabIndex = 1;
            this.Amount.Text = "4 990, 90";
            this.Amount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DiscountLabel.Location = new System.Drawing.Point(364, 190);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(107, 13);
            this.DiscountLabel.TabIndex = 2;
            this.DiscountLabel.Text = " Discount Amount";
            // 
            // Discount
            // 
            this.Discount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Discount.Location = new System.Drawing.Point(367, 203);
            this.Discount.Name = "Discount";
            this.Discount.Size = new System.Drawing.Size(100, 23);
            this.Discount.TabIndex = 3;
            this.Discount.Text = "499";
            this.Discount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.Location = new System.Drawing.Point(43, 140);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(29, 13);
            this.InfoLabel.TabIndex = 4;
            this.InfoLabel.Text = "Info";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(46, 156);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(94, 36);
            this.CalculateButton.TabIndex = 5;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(146, 156);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(94, 36);
            this.ApplyButton.TabIndex = 6;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(246, 156);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(94, 36);
            this.UpdateButton.TabIndex = 7;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // UpdatePercent
            // 
            this.UpdatePercent.Location = new System.Drawing.Point(246, 276);
            this.UpdatePercent.Name = "UpdatePercent";
            this.UpdatePercent.Size = new System.Drawing.Size(94, 36);
            this.UpdatePercent.TabIndex = 15;
            this.UpdatePercent.Text = "Update";
            this.UpdatePercent.UseVisualStyleBackColor = true;
            this.UpdatePercent.Click += new System.EventHandler(this.UpdatePercent_Click);
            // 
            // ApplyPercent
            // 
            this.ApplyPercent.Location = new System.Drawing.Point(146, 276);
            this.ApplyPercent.Name = "ApplyPercent";
            this.ApplyPercent.Size = new System.Drawing.Size(94, 36);
            this.ApplyPercent.TabIndex = 14;
            this.ApplyPercent.Text = "Apply";
            this.ApplyPercent.UseVisualStyleBackColor = true;
            this.ApplyPercent.Click += new System.EventHandler(this.ApplyPercent_Click);
            // 
            // CalculatePercent
            // 
            this.CalculatePercent.Location = new System.Drawing.Point(46, 276);
            this.CalculatePercent.Name = "CalculatePercent";
            this.CalculatePercent.Size = new System.Drawing.Size(94, 36);
            this.CalculatePercent.TabIndex = 13;
            this.CalculatePercent.Text = "Calculate";
            this.CalculatePercent.UseVisualStyleBackColor = true;
            this.CalculatePercent.Click += new System.EventHandler(this.CalculatePercent_Click);
            // 
            // InfoPercent
            // 
            this.InfoPercent.AutoSize = true;
            this.InfoPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoPercent.Location = new System.Drawing.Point(43, 260);
            this.InfoPercent.Name = "InfoPercent";
            this.InfoPercent.Size = new System.Drawing.Size(29, 13);
            this.InfoPercent.TabIndex = 12;
            this.InfoPercent.Text = "Info";
            // 
            // PercentDiscount
            // 
            this.PercentDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PercentDiscount.Location = new System.Drawing.Point(367, 323);
            this.PercentDiscount.Name = "PercentDiscount";
            this.PercentDiscount.Size = new System.Drawing.Size(100, 23);
            this.PercentDiscount.TabIndex = 11;
            this.PercentDiscount.Text = "499";
            this.PercentDiscount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(364, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = " Discount Amount";
            // 
            // AmountPercent
            // 
            this.AmountPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AmountPercent.Location = new System.Drawing.Point(371, 273);
            this.AmountPercent.Name = "AmountPercent";
            this.AmountPercent.Size = new System.Drawing.Size(100, 23);
            this.AmountPercent.TabIndex = 9;
            this.AmountPercent.Text = "4 990, 90";
            this.AmountPercent.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(368, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Products Amount";
            // 
            // DiscoundTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.UpdatePercent);
            this.Controls.Add(this.ApplyPercent);
            this.Controls.Add(this.CalculatePercent);
            this.Controls.Add(this.InfoPercent);
            this.Controls.Add(this.PercentDiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AmountPercent);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.Discount);
            this.Controls.Add(this.DiscountLabel);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.AmountLabel);
            this.Name = "DiscoundTab";
            this.Size = new System.Drawing.Size(626, 439);
            this.Load += new System.EventHandler(this.DiscoundTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.Label Discount;
        private System.Windows.Forms.Label InfoLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button UpdatePercent;
        private System.Windows.Forms.Button ApplyPercent;
        private System.Windows.Forms.Button CalculatePercent;
        private System.Windows.Forms.Label InfoPercent;
        private System.Windows.Forms.Label PercentDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label AmountPercent;
        private System.Windows.Forms.Label label5;
    }
}
