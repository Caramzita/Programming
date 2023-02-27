
namespace Programming.View.Controls
{
    partial class SeasonHandleControl
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
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SeasonGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.SeasonButton);
            this.SeasonGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonGroupBox.Controls.Add(this.label7);
            this.SeasonGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SeasonGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonGroupBox.Size = new System.Drawing.Size(381, 192);
            this.SeasonGroupBox.TabIndex = 16;
            this.SeasonGroupBox.TabStop = false;
            this.SeasonGroupBox.Text = "Season Handle";
            // 
            // SeasonButton
            // 
            this.SeasonButton.Location = new System.Drawing.Point(195, 55);
            this.SeasonButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(81, 28);
            this.SeasonButton.TabIndex = 2;
            this.SeasonButton.Text = "Go!";
            this.SeasonButton.UseVisualStyleBackColor = true;
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(9, 55);
            this.SeasonComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(175, 24);
            this.SeasonComboBox.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Choose season:";
            // 
            // SeasonHandleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SeasonGroupBox);
            this.Name = "SeasonHandleControl";
            this.Size = new System.Drawing.Size(381, 192);
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.Button SeasonButton;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.Label label7;
    }
}
