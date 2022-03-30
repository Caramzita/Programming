
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
            this.components = new System.ComponentModel.Container();
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.SeasonGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonButton = new System.Windows.Forms.Button();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.EnumirationsGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IntValueTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.ParsingLabelOut = new System.Windows.Forms.Label();
            this.ParsingTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ParseButton = new System.Windows.Forms.Button();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.Classes = new System.Windows.Forms.TabPage();
            this.MovieGroupBox = new System.Windows.Forms.GroupBox();
            this.FindFilmButton = new System.Windows.Forms.Button();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.ReleasedDateTextBox = new System.Windows.Forms.TextBox();
            this.ReleasedDateLabel = new System.Windows.Forms.Label();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.MovieListBox = new System.Windows.Forms.ListBox();
            this.Reactangles = new System.Windows.Forms.GroupBox();
            this.FindButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.ColorLabel = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.EnumsTabPage.SuspendLayout();
            this.SeasonGroupBox.SuspendLayout();
            this.EnumirationsGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.Classes.SuspendLayout();
            this.MovieGroupBox.SuspendLayout();
            this.Reactangles.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.SeasonGroupBox);
            this.EnumsTabPage.Controls.Add(this.EnumirationsGroupBox);
            this.EnumsTabPage.Controls.Add(this.WeekdayParsingGroupBox);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 25);
            this.EnumsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsTabPage.Size = new System.Drawing.Size(756, 441);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonGroupBox
            // 
            this.SeasonGroupBox.Controls.Add(this.SeasonButton);
            this.SeasonGroupBox.Controls.Add(this.SeasonComboBox);
            this.SeasonGroupBox.Controls.Add(this.label7);
            this.SeasonGroupBox.Location = new System.Drawing.Point(376, 281);
            this.SeasonGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonGroupBox.Name = "SeasonGroupBox";
            this.SeasonGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonGroupBox.Size = new System.Drawing.Size(372, 153);
            this.SeasonGroupBox.TabIndex = 15;
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
            // EnumirationsGroupBox
            // 
            this.EnumirationsGroupBox.Controls.Add(this.label1);
            this.EnumirationsGroupBox.Controls.Add(this.IntValueTextBox);
            this.EnumirationsGroupBox.Controls.Add(this.label4);
            this.EnumirationsGroupBox.Controls.Add(this.label2);
            this.EnumirationsGroupBox.Controls.Add(this.label3);
            this.EnumirationsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumirationsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumirationsGroupBox.Location = new System.Drawing.Point(8, 4);
            this.EnumirationsGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumirationsGroupBox.Name = "EnumirationsGroupBox";
            this.EnumirationsGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumirationsGroupBox.Size = new System.Drawing.Size(740, 274);
            this.EnumirationsGroupBox.TabIndex = 13;
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
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.ParsingLabelOut);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParsingTextBox);
            this.WeekdayParsingGroupBox.Controls.Add(this.label6);
            this.WeekdayParsingGroupBox.Controls.Add(this.ParseButton);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(8, 281);
            this.WeekdayParsingGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(361, 153);
            this.WeekdayParsingGroupBox.TabIndex = 14;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // ParsingLabelOut
            // 
            this.ParsingLabelOut.AutoSize = true;
            this.ParsingLabelOut.Location = new System.Drawing.Point(5, 80);
            this.ParsingLabelOut.Name = "ParsingLabelOut";
            this.ParsingLabelOut.Size = new System.Drawing.Size(114, 17);
            this.ParsingLabelOut.TabIndex = 12;
            this.ParsingLabelOut.Text = "ParsingLabelOut";
            this.ParsingLabelOut.Visible = false;
            // 
            // ParsingTextBox
            // 
            this.ParsingTextBox.Location = new System.Drawing.Point(9, 55);
            this.ParsingTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParsingTextBox.Name = "ParsingTextBox";
            this.ParsingTextBox.Size = new System.Drawing.Size(212, 22);
            this.ParsingTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Type value for parsing:";
            // 
            // ParseButton
            // 
            this.ParseButton.Location = new System.Drawing.Point(232, 53);
            this.ParseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ParseButton.Name = "ParseButton";
            this.ParseButton.Size = new System.Drawing.Size(81, 27);
            this.ParseButton.TabIndex = 11;
            this.ParseButton.Text = "Parse";
            this.ParseButton.UseVisualStyleBackColor = true;
            this.ParseButton.Click += new System.EventHandler(this.ParseButton_Click);
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.EnumsTabPage);
            this.MainTabControl.Controls.Add(this.Classes);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(764, 470);
            this.MainTabControl.TabIndex = 0;
            // 
            // Classes
            // 
            this.Classes.Controls.Add(this.MovieGroupBox);
            this.Classes.Controls.Add(this.Reactangles);
            this.Classes.Controls.Add(this.label5);
            this.Classes.Location = new System.Drawing.Point(4, 25);
            this.Classes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Classes.Name = "Classes";
            this.Classes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Classes.Size = new System.Drawing.Size(756, 441);
            this.Classes.TabIndex = 1;
            this.Classes.Text = "Classes";
            this.Classes.UseVisualStyleBackColor = true;
            // 
            // MovieGroupBox
            // 
            this.MovieGroupBox.Controls.Add(this.FindFilmButton);
            this.MovieGroupBox.Controls.Add(this.RatingTextBox);
            this.MovieGroupBox.Controls.Add(this.RatingLabel);
            this.MovieGroupBox.Controls.Add(this.GenreTextBox);
            this.MovieGroupBox.Controls.Add(this.GenreLabel);
            this.MovieGroupBox.Controls.Add(this.ReleasedDateTextBox);
            this.MovieGroupBox.Controls.Add(this.ReleasedDateLabel);
            this.MovieGroupBox.Controls.Add(this.DurationTextBox);
            this.MovieGroupBox.Controls.Add(this.DurationLabel);
            this.MovieGroupBox.Controls.Add(this.MovieListBox);
            this.MovieGroupBox.Location = new System.Drawing.Point(364, 4);
            this.MovieGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MovieGroupBox.Name = "MovieGroupBox";
            this.MovieGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MovieGroupBox.Size = new System.Drawing.Size(384, 430);
            this.MovieGroupBox.TabIndex = 2;
            this.MovieGroupBox.TabStop = false;
            this.MovieGroupBox.Text = "Movies";
            // 
            // FindFilmButton
            // 
            this.FindFilmButton.Location = new System.Drawing.Point(177, 241);
            this.FindFilmButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindFilmButton.Name = "FindFilmButton";
            this.FindFilmButton.Size = new System.Drawing.Size(161, 25);
            this.FindFilmButton.TabIndex = 9;
            this.FindFilmButton.Text = "Find";
            this.FindFilmButton.UseVisualStyleBackColor = true;
            this.FindFilmButton.Click += new System.EventHandler(this.FindMovieButton_Click);
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(177, 188);
            this.RatingTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(160, 22);
            this.RatingTextBox.TabIndex = 8;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(174, 169);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(53, 17);
            this.RatingLabel.TabIndex = 7;
            this.RatingLabel.Text = "Rating:";
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(177, 138);
            this.GenreTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(160, 22);
            this.GenreTextBox.TabIndex = 6;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(174, 119);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(52, 17);
            this.GenreLabel.TabIndex = 5;
            this.GenreLabel.Text = "Genre:";
            // 
            // ReleasedDateTextBox
            // 
            this.ReleasedDateTextBox.Location = new System.Drawing.Point(177, 90);
            this.ReleasedDateTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReleasedDateTextBox.Name = "ReleasedDateTextBox";
            this.ReleasedDateTextBox.Size = new System.Drawing.Size(160, 22);
            this.ReleasedDateTextBox.TabIndex = 4;
            this.ReleasedDateTextBox.TextChanged += new System.EventHandler(this.ReleasedDate_TextChanged);
            // 
            // ReleasedDateLabel
            // 
            this.ReleasedDateLabel.AutoSize = true;
            this.ReleasedDateLabel.Location = new System.Drawing.Point(174, 71);
            this.ReleasedDateLabel.Name = "ReleasedDateLabel";
            this.ReleasedDateLabel.Size = new System.Drawing.Size(106, 17);
            this.ReleasedDateLabel.TabIndex = 3;
            this.ReleasedDateLabel.Text = "Released Date:";
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(177, 42);
            this.DurationTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(160, 22);
            this.DurationTextBox.TabIndex = 2;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(174, 21);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(66, 17);
            this.DurationLabel.TabIndex = 1;
            this.DurationLabel.Text = "Duration:";
            // 
            // MovieListBox
            // 
            this.MovieListBox.FormattingEnabled = true;
            this.MovieListBox.ItemHeight = 16;
            this.MovieListBox.Location = new System.Drawing.Point(5, 21);
            this.MovieListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MovieListBox.Name = "MovieListBox";
            this.MovieListBox.Size = new System.Drawing.Size(161, 244);
            this.MovieListBox.TabIndex = 0;
            this.MovieListBox.SelectedIndexChanged += new System.EventHandler(this.MovieListBox_SelectedIndexChanged);
            // 
            // Reactangles
            // 
            this.Reactangles.Controls.Add(this.FindButton);
            this.Reactangles.Controls.Add(this.ColorTextBox);
            this.Reactangles.Controls.Add(this.ColorLabel);
            this.Reactangles.Controls.Add(this.WidthTextBox);
            this.Reactangles.Controls.Add(this.WidthLabel);
            this.Reactangles.Controls.Add(this.LengthTextBox);
            this.Reactangles.Controls.Add(this.LengthLabel);
            this.Reactangles.Controls.Add(this.RectanglesListBox);
            this.Reactangles.Location = new System.Drawing.Point(8, 4);
            this.Reactangles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Reactangles.Name = "Reactangles";
            this.Reactangles.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Reactangles.Size = new System.Drawing.Size(349, 430);
            this.Reactangles.TabIndex = 1;
            this.Reactangles.TabStop = false;
            this.Reactangles.Text = "Rectangles";
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(179, 241);
            this.FindButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(160, 25);
            this.FindButton.TabIndex = 7;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(179, 139);
            this.ColorTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(160, 22);
            this.ColorTextBox.TabIndex = 6;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // ColorLabel
            // 
            this.ColorLabel.AutoSize = true;
            this.ColorLabel.Location = new System.Drawing.Point(175, 119);
            this.ColorLabel.Name = "ColorLabel";
            this.ColorLabel.Size = new System.Drawing.Size(45, 17);
            this.ColorLabel.TabIndex = 5;
            this.ColorLabel.Text = "Color:";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(179, 91);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(160, 22);
            this.WidthTextBox.TabIndex = 4;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(175, 71);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(48, 17);
            this.WidthLabel.TabIndex = 3;
            this.WidthLabel.Text = "Width:";
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(179, 43);
            this.LengthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(160, 22);
            this.LengthTextBox.TabIndex = 2;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Location = new System.Drawing.Point(175, 21);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(56, 17);
            this.LengthLabel.TabIndex = 1;
            this.LengthLabel.Text = "Length:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.ItemHeight = 16;
            this.RectanglesListBox.Location = new System.Drawing.Point(5, 21);
            this.RectanglesListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(161, 244);
            this.RectanglesListBox.TabIndex = 0;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 470);
            this.Controls.Add(this.MainTabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.EnumsTabPage.ResumeLayout(false);
            this.SeasonGroupBox.ResumeLayout(false);
            this.SeasonGroupBox.PerformLayout();
            this.EnumirationsGroupBox.ResumeLayout(false);
            this.EnumirationsGroupBox.PerformLayout();
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.Classes.ResumeLayout(false);
            this.Classes.PerformLayout();
            this.MovieGroupBox.ResumeLayout(false);
            this.MovieGroupBox.PerformLayout();
            this.Reactangles.ResumeLayout(false);
            this.Reactangles.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TextBox IntValueTextBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ParseButton;
        private System.Windows.Forms.TextBox ParsingTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox EnumirationsGroupBox;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.GroupBox SeasonGroupBox;
        private System.Windows.Forms.Button SeasonButton;
        private System.Windows.Forms.ComboBox SeasonComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label ParsingLabelOut;
        private System.Windows.Forms.TabPage Classes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox Reactangles;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.Label ColorLabel;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.ListBox RectanglesListBox;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.GroupBox MovieGroupBox;
        private System.Windows.Forms.ListBox MovieListBox;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.Label ReleasedDateLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.TextBox ReleasedDateTextBox;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Button FindFilmButton;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Label RatingLabel;
    }
}

