
namespace Programming.View.Controls
{
    partial class EnumerationsControl
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
            this.EnumirationsGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumirationsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumirationsGroupBox
            // 
            this.EnumirationsGroupBox.Controls.Add(this.label1);
            this.EnumirationsGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumirationsGroupBox.Controls.Add(this.label4);
            this.EnumirationsGroupBox.Controls.Add(this.label2);
            this.EnumirationsGroupBox.Controls.Add(this.label3);
            this.EnumirationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumirationsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumirationsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumirationsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.EnumirationsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumirationsGroupBox.Name = "EnumirationsGroupBox";
            this.EnumirationsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumirationsGroupBox.Size = new System.Drawing.Size(600, 299);
            this.EnumirationsGroupBox.TabIndex = 14;
            this.EnumirationsGroupBox.TabStop = false;
            this.EnumirationsGroupBox.Text = "Enumerations";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // IntValueTextBox
            // 
            this.IntValueTextBox.Location = new System.Drawing.Point(311, 46);
            this.IntValueTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IntValueTextBox.Name = "IntValueTextBox";
            this.IntValueTextBox.ReadOnly = true;
            this.IntValueTextBox.Size = new System.Drawing.Size(100, 22);
            this.IntValueTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Int value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = " Choose enumeration:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(157, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose value:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 16;
            this.EnumsListBox.Location = new System.Drawing.Point(5, 46);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(141, 212);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 16;
            this.ValuesListBox.Location = new System.Drawing.Point(157, 46);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(141, 212);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnumirationsGroupBox);
            this.Name = "EnumerationsControl";
            this.Size = new System.Drawing.Size(600, 299);
            this.EnumirationsGroupBox.ResumeLayout(false);
            this.EnumirationsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EnumirationsGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.ListBox ValuesListBox;
    }
}
