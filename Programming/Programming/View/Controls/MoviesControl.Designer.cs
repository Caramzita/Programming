
namespace Programming.View.Controls
{
    partial class MoviesControl
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
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.MovieGroupBox.SuspendLayout();
            this.SuspendLayout();
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
            this.MovieGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovieGroupBox.Location = new System.Drawing.Point(0, 0);
            this.MovieGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MovieGroupBox.Name = "MovieGroupBox";
            this.MovieGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MovieGroupBox.Size = new System.Drawing.Size(391, 467);
            this.MovieGroupBox.TabIndex = 3;
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
            this.FindFilmButton.Click += new System.EventHandler(this.FindFilmButton_Click);
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
            this.ReleasedDateTextBox.TextChanged += new System.EventHandler(this.ReleasedDateTextBox_TextChanged);
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
            // MoveisControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MovieGroupBox);
            this.Name = "MoveisControl";
            this.Size = new System.Drawing.Size(391, 467);
            this.MovieGroupBox.ResumeLayout(false);
            this.MovieGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MovieGroupBox;
        private System.Windows.Forms.Button FindFilmButton;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.TextBox ReleasedDateTextBox;
        private System.Windows.Forms.Label ReleasedDateLabel;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.ListBox MovieListBox;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}
