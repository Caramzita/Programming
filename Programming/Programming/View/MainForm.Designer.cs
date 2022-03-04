
namespace Programming.View
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
            this.Enums = new System.Windows.Forms.TabPage();
            this.ParsingTextOutput = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.Enumirations = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Int_value = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.WeekdayParsing = new System.Windows.Forms.GroupBox();
            this.ParsingTextOut = new System.Windows.Forms.Label();
            this.ParsingTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Parse = new System.Windows.Forms.Button();
            this.Enumiration = new System.Windows.Forms.TabControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.Enums.SuspendLayout();
            this.Enumirations.SuspendLayout();
            this.WeekdayParsing.SuspendLayout();
            this.Enumiration.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Enums
            // 
            this.Enums.Controls.Add(this.groupBox1);
            this.Enums.Controls.Add(this.ParsingTextOutput);
            this.Enums.Controls.Add(this.label5);
            this.Enums.Controls.Add(this.splitter1);
            this.Enums.Controls.Add(this.Enumirations);
            this.Enums.Controls.Add(this.WeekdayParsing);
            this.Enums.Location = new System.Drawing.Point(4, 25);
            this.Enums.Name = "Enums";
            this.Enums.Padding = new System.Windows.Forms.Padding(3);
            this.Enums.Size = new System.Drawing.Size(763, 449);
            this.Enums.TabIndex = 0;
            this.Enums.Text = "Enums";
            this.Enums.UseVisualStyleBackColor = true;
            this.Enums.Click += new System.EventHandler(this.Enums_Click);
            // 
            // ParsingTextOutput
            // 
            this.ParsingTextOutput.AutoSize = true;
            this.ParsingTextOutput.Location = new System.Drawing.Point(25, 362);
            this.ParsingTextOutput.Name = "ParsingTextOutput";
            this.ParsingTextOutput.Size = new System.Drawing.Size(0, 17);
            this.ParsingTextOutput.TabIndex = 12;
            this.ParsingTextOutput.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 8;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(3, 3);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 443);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // Enumirations
            // 
            this.Enumirations.Controls.Add(this.label1);
            this.Enumirations.Controls.Add(this.Int_value);
            this.Enumirations.Controls.Add(this.label4);
            this.Enumirations.Controls.Add(this.label2);
            this.Enumirations.Controls.Add(this.label3);
            this.Enumirations.Controls.Add(this.EnumsListBox);
            this.Enumirations.Controls.Add(this.ValuesListBox);
            this.Enumirations.Location = new System.Drawing.Point(12, 0);
            this.Enumirations.Name = "Enumirations";
            this.Enumirations.Size = new System.Drawing.Size(743, 278);
            this.Enumirations.TabIndex = 13;
            this.Enumirations.TabStop = false;
            this.Enumirations.Text = "Enumiration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 3;
            // 
            // Int_value
            // 
            this.Int_value.Location = new System.Drawing.Point(338, 45);
            this.Int_value.Name = "Int_value";
            this.Int_value.ReadOnly = true;
            this.Int_value.Size = new System.Drawing.Size(100, 22);
            this.Int_value.TabIndex = 2;
            this.Int_value.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Int value:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = " Choose enumiration:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose value:";
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 16;
            this.EnumsListBox.Location = new System.Drawing.Point(9, 45);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(141, 212);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 16;
            this.ValuesListBox.Location = new System.Drawing.Point(174, 45);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(141, 212);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // WeekdayParsing
            // 
            this.WeekdayParsing.Controls.Add(this.ParsingTextOut);
            this.WeekdayParsing.Controls.Add(this.ParsingTextbox);
            this.WeekdayParsing.Controls.Add(this.label6);
            this.WeekdayParsing.Controls.Add(this.Parse);
            this.WeekdayParsing.Location = new System.Drawing.Point(12, 281);
            this.WeekdayParsing.Name = "WeekdayParsing";
            this.WeekdayParsing.Size = new System.Drawing.Size(358, 155);
            this.WeekdayParsing.TabIndex = 14;
            this.WeekdayParsing.TabStop = false;
            this.WeekdayParsing.Text = "Weekday Parsing:";
            this.WeekdayParsing.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // ParsingTextOut
            // 
            this.ParsingTextOut.AutoSize = true;
            this.ParsingTextOut.Location = new System.Drawing.Point(13, 81);
            this.ParsingTextOut.Name = "ParsingTextOut";
            this.ParsingTextOut.Size = new System.Drawing.Size(66, 17);
            this.ParsingTextOut.TabIndex = 12;
            this.ParsingTextOut.Text = "LabelOut";
            this.ParsingTextOut.VisibleChanged += new System.EventHandler(this.ParsingTextOut_Click);
            this.ParsingTextOut.Click += new System.EventHandler(this.ParsingTextOut_Click);
            // 
            // ParsingTextbox
            // 
            this.ParsingTextbox.Location = new System.Drawing.Point(16, 55);
            this.ParsingTextbox.Name = "ParsingTextbox";
            this.ParsingTextbox.Size = new System.Drawing.Size(212, 22);
            this.ParsingTextbox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Type value for parsing:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Parse
            // 
            this.Parse.Location = new System.Drawing.Point(234, 54);
            this.Parse.Name = "Parse";
            this.Parse.Size = new System.Drawing.Size(81, 27);
            this.Parse.TabIndex = 11;
            this.Parse.Text = "Parse";
            this.Parse.UseVisualStyleBackColor = true;
            this.Parse.Click += new System.EventHandler(this.button1_Click);
            // 
            // Enumiration
            // 
            this.Enumiration.Controls.Add(this.Enums);
            this.Enumiration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enumiration.Location = new System.Drawing.Point(0, 0);
            this.Enumiration.Name = "Enumiration";
            this.Enumiration.SelectedIndex = 0;
            this.Enumiration.Size = new System.Drawing.Size(771, 478);
            this.Enumiration.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SeasonButton);
            this.groupBox1.Controls.Add(this.SeasonComboBox);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(376, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(379, 155);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Season Handle";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Choose season:";
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(23, 52);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(174, 24);
            this.SeasonComboBox.TabIndex = 1;
            this.SeasonComboBox.SelectedIndexChanged += new System.EventHandler(this.SeasonComboBox_SelectedIndexChanged);
            // 
            // SeasonButton
            // 
            this.SeasonButton.Location = new System.Drawing.Point(203, 51);
            this.SeasonButton.Name = "SeasonButton";
            this.SeasonButton.Size = new System.Drawing.Size(81, 28);
            this.SeasonButton.TabIndex = 2;
            this.SeasonButton.Text = "Go!";
            this.SeasonButton.UseVisualStyleBackColor = true;
            this.SeasonButton.Click += new System.EventHandler(this.SeasonButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 478);
            this.Controls.Add(this.Enumiration);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Enums.ResumeLayout(false);
            this.Enums.PerformLayout();
            this.Enumirations.ResumeLayout(false);
            this.Enumirations.PerformLayout();
            this.WeekdayParsing.ResumeLayout(false);
            this.WeekdayParsing.PerformLayout();
            this.Enumiration.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Enums;
        private System.Windows.Forms.TabControl Enumiration;
        private System.Windows.Forms.TextBox Int_value;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label ParsingTextOutput;
        private System.Windows.Forms.Button Parse;
        private System.Windows.Forms.TextBox ParsingTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Enumirations;
        private System.Windows.Forms.GroupBox WeekdayParsing;
        private System.Windows.Forms.Label ParsingTextOut;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SeasonButton;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.Label label7;
    }
}

