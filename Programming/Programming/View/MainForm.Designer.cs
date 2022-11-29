
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
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.Classes = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.RectanglesTabPage = new System.Windows.Forms.TabPage();
            this.SeasonHandleControl = new Programming.View.Controls.SeasonHandleControl();
            this.WeekdayParsingControl = new Programming.View.Controls.WeekdayParsingControl();
            this.EnumerationsControl = new Programming.View.Controls.EnumerationsControl();
            this.MoveisControl = new Programming.View.Controls.MoviesControl();
            this.RectanglesControl = new Programming.View.Controls.RectanglesControl();
            this.RectanglesCollisionControl = new Programming.View.Controls.RectanglesCollisionControl();
            this.rectanglesCollisionControl1 = new Programming.View.Controls.RectanglesCollisionControl();
            this.EnumsTabPage.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.Classes.SuspendLayout();
            this.RectanglesTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.SeasonHandleControl);
            this.EnumsTabPage.Controls.Add(this.WeekdayParsingControl);
            this.EnumsTabPage.Controls.Add(this.EnumerationsControl);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 25);
            this.EnumsTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumsTabPage.Size = new System.Drawing.Size(773, 503);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.EnumsTabPage);
            this.MainTabControl.Controls.Add(this.Classes);
            this.MainTabControl.Controls.Add(this.RectanglesTabPage);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(781, 532);
            this.MainTabControl.TabIndex = 0;
            // 
            // Classes
            // 
            this.Classes.Controls.Add(this.MoveisControl);
            this.Classes.Controls.Add(this.RectanglesControl);
            this.Classes.Controls.Add(this.label5);
            this.Classes.Location = new System.Drawing.Point(4, 25);
            this.Classes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Classes.Name = "Classes";
            this.Classes.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Classes.Size = new System.Drawing.Size(773, 503);
            this.Classes.TabIndex = 1;
            this.Classes.Text = "Classes";
            this.Classes.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 0;
            // 
            // RectanglesTabPage
            // 
            this.RectanglesTabPage.Controls.Add(this.RectanglesCollisionControl);
            this.RectanglesTabPage.Location = new System.Drawing.Point(4, 25);
            this.RectanglesTabPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesTabPage.Name = "RectanglesTabPage";
            this.RectanglesTabPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesTabPage.Size = new System.Drawing.Size(773, 503);
            this.RectanglesTabPage.TabIndex = 2;
            this.RectanglesTabPage.Text = "Rectangles";
            this.RectanglesTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleControl
            // 
            this.SeasonHandleControl.Location = new System.Drawing.Point(376, 281);
            this.SeasonHandleControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SeasonHandleControl.Name = "SeasonHandleControl";
            this.SeasonHandleControl.Size = new System.Drawing.Size(372, 185);
            this.SeasonHandleControl.TabIndex = 18;
            // 
            // WeekdayParsingControl
            // 
            this.WeekdayParsingControl.Location = new System.Drawing.Point(8, 281);
            this.WeekdayParsingControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WeekdayParsingControl.Name = "WeekdayParsingControl";
            this.WeekdayParsingControl.Size = new System.Drawing.Size(363, 185);
            this.WeekdayParsingControl.TabIndex = 17;
            // 
            // EnumerationsControl
            // 
            this.EnumerationsControl.Location = new System.Drawing.Point(8, 5);
            this.EnumerationsControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EnumerationsControl.Name = "EnumerationsControl";
            this.EnumerationsControl.Size = new System.Drawing.Size(740, 273);
            this.EnumerationsControl.TabIndex = 16;
            // 
            // MoveisControl
            // 
            this.MoveisControl.Location = new System.Drawing.Point(359, 4);
            this.MoveisControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoveisControl.Name = "MoveisControl";
            this.MoveisControl.Size = new System.Drawing.Size(389, 462);
            this.MoveisControl.TabIndex = 4;
            // 
            // RectanglesControl
            // 
            this.RectanglesControl.Location = new System.Drawing.Point(5, 4);
            this.RectanglesControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesControl.Name = "RectanglesControl";
            this.RectanglesControl.Size = new System.Drawing.Size(352, 462);
            this.RectanglesControl.TabIndex = 3;
            // 
            // RectanglesCollisionControl
            // 
            this.RectanglesCollisionControl.AutoSize = true;
            this.RectanglesCollisionControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesCollisionControl.Location = new System.Drawing.Point(3, 2);
            this.RectanglesCollisionControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesCollisionControl.Name = "RectanglesCollisionControl";
            this.RectanglesCollisionControl.Size = new System.Drawing.Size(767, 499);
            this.RectanglesCollisionControl.TabIndex = 0;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.AutoSize = true;
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(3, 2);
            this.rectanglesCollisionControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(767, 499);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 532);
            this.Controls.Add(this.MainTabControl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Programming Demo";
            this.EnumsTabPage.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.Classes.ResumeLayout(false);
            this.Classes.PerformLayout();
            this.RectanglesTabPage.ResumeLayout(false);
            this.RectanglesTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage Classes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage RectanglesTabPage;
        private Controls.EnumerationsControl EnumerationsControl;
        private Controls.WeekdayParsingControl WeekdayParsingControl;
        private Controls.RectanglesControl RectanglesControl;
        private Controls.MoviesControl MoveisControl;
        private Controls.SeasonHandleControl SeasonHandleControl;
        private Controls.RectanglesCollisionControl RectanglesCollisionControl;
        private Controls.RectanglesCollisionControl rectanglesCollisionControl1;
    }
}

