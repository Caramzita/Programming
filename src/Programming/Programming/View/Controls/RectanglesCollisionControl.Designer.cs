
namespace Programming.View.Controls
{
    partial class RectanglesCollisionControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RectanglesCollisionControl));
            this.HeightPanelLabel = new System.Windows.Forms.Label();
            this.WidthPanelLabel = new System.Windows.Forms.Label();
            this.YPanelLabel = new System.Windows.Forms.Label();
            this.XPabelLabel = new System.Windows.Forms.Label();
            this.IdPanelLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.HeightPanelTextBox = new System.Windows.Forms.TextBox();
            this.YPanelTextBox = new System.Windows.Forms.TextBox();
            this.XPanelTextBox = new System.Windows.Forms.TextBox();
            this.IdPanelTextBox = new System.Windows.Forms.TextBox();
            this.WidthPanelTextBox = new System.Windows.Forms.TextBox();
            this.RectanglesPanelListBox = new System.Windows.Forms.ListBox();
            this.RectanglesPanel = new System.Windows.Forms.Panel();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.RectangleRemovePictureBox = new System.Windows.Forms.PictureBox();
            this.RectanlgeAddPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RectangleRemovePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectanlgeAddPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HeightPanelLabel
            // 
            this.HeightPanelLabel.AutoSize = true;
            this.HeightPanelLabel.Location = new System.Drawing.Point(51, 422);
            this.HeightPanelLabel.Name = "HeightPanelLabel";
            this.HeightPanelLabel.Size = new System.Drawing.Size(49, 17);
            this.HeightPanelLabel.TabIndex = 29;
            this.HeightPanelLabel.Text = "Height";
            // 
            // WidthPanelLabel
            // 
            this.WidthPanelLabel.AutoSize = true;
            this.WidthPanelLabel.Location = new System.Drawing.Point(55, 394);
            this.WidthPanelLabel.Name = "WidthPanelLabel";
            this.WidthPanelLabel.Size = new System.Drawing.Size(44, 17);
            this.WidthPanelLabel.TabIndex = 28;
            this.WidthPanelLabel.Text = "Width";
            // 
            // YPanelLabel
            // 
            this.YPanelLabel.AutoSize = true;
            this.YPanelLabel.Location = new System.Drawing.Point(77, 366);
            this.YPanelLabel.Name = "YPanelLabel";
            this.YPanelLabel.Size = new System.Drawing.Size(21, 17);
            this.YPanelLabel.TabIndex = 27;
            this.YPanelLabel.Text = "Y:";
            // 
            // XPabelLabel
            // 
            this.XPabelLabel.AutoSize = true;
            this.XPabelLabel.Location = new System.Drawing.Point(77, 338);
            this.XPabelLabel.Name = "XPabelLabel";
            this.XPabelLabel.Size = new System.Drawing.Size(21, 17);
            this.XPabelLabel.TabIndex = 26;
            this.XPabelLabel.Text = "X:";
            // 
            // IdPanelLabel
            // 
            this.IdPanelLabel.AutoSize = true;
            this.IdPanelLabel.Location = new System.Drawing.Point(76, 310);
            this.IdPanelLabel.Name = "IdPanelLabel";
            this.IdPanelLabel.Size = new System.Drawing.Size(23, 17);
            this.IdPanelLabel.TabIndex = 25;
            this.IdPanelLabel.Text = "Id:";
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(7, 273);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(135, 17);
            this.SelectedRectangleLabel.TabIndex = 24;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // HeightPanelTextBox
            // 
            this.HeightPanelTextBox.Location = new System.Drawing.Point(119, 417);
            this.HeightPanelTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeightPanelTextBox.Name = "HeightPanelTextBox";
            this.HeightPanelTextBox.Size = new System.Drawing.Size(124, 22);
            this.HeightPanelTextBox.TabIndex = 23;
            this.HeightPanelTextBox.TextChanged += new System.EventHandler(this.HeightPanelTextBox_TextChanged);
            // 
            // YPanelTextBox
            // 
            this.YPanelTextBox.Location = new System.Drawing.Point(119, 361);
            this.YPanelTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.YPanelTextBox.Name = "YPanelTextBox";
            this.YPanelTextBox.Size = new System.Drawing.Size(124, 22);
            this.YPanelTextBox.TabIndex = 22;
            this.YPanelTextBox.TextChanged += new System.EventHandler(this.YPanelTextBox_TextChanged);
            // 
            // XPanelTextBox
            // 
            this.XPanelTextBox.Location = new System.Drawing.Point(119, 334);
            this.XPanelTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.XPanelTextBox.Name = "XPanelTextBox";
            this.XPanelTextBox.Size = new System.Drawing.Size(124, 22);
            this.XPanelTextBox.TabIndex = 21;
            this.XPanelTextBox.TextChanged += new System.EventHandler(this.XPanelTextBox_TextChanged);
            // 
            // IdPanelTextBox
            // 
            this.IdPanelTextBox.Location = new System.Drawing.Point(119, 305);
            this.IdPanelTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IdPanelTextBox.Name = "IdPanelTextBox";
            this.IdPanelTextBox.ReadOnly = true;
            this.IdPanelTextBox.Size = new System.Drawing.Size(124, 22);
            this.IdPanelTextBox.TabIndex = 20;
            // 
            // WidthPanelTextBox
            // 
            this.WidthPanelTextBox.Location = new System.Drawing.Point(119, 389);
            this.WidthPanelTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WidthPanelTextBox.Name = "WidthPanelTextBox";
            this.WidthPanelTextBox.Size = new System.Drawing.Size(124, 22);
            this.WidthPanelTextBox.TabIndex = 19;
            this.WidthPanelTextBox.TextChanged += new System.EventHandler(this.WidthPanelTextBox_TextChanged);
            // 
            // RectanglesPanelListBox
            // 
            this.RectanglesPanelListBox.FormattingEnabled = true;
            this.RectanglesPanelListBox.ItemHeight = 16;
            this.RectanglesPanelListBox.Location = new System.Drawing.Point(5, 18);
            this.RectanglesPanelListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesPanelListBox.Name = "RectanglesPanelListBox";
            this.RectanglesPanelListBox.Size = new System.Drawing.Size(303, 212);
            this.RectanglesPanelListBox.TabIndex = 18;
            this.RectanglesPanelListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesPanelListBox_SelectedIndexChanged);
            // 
            // RectanglesPanel
            // 
            this.RectanglesPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RectanglesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectanglesPanel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.RectanglesPanel.Location = new System.Drawing.Point(313, 2);
            this.RectanglesPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanglesPanel.Name = "RectanglesPanel";
            this.RectanglesPanel.Size = new System.Drawing.Size(377, 465);
            this.RectanglesPanel.TabIndex = 15;
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.AutoSize = true;
            this.RectanglesLabel.Location = new System.Drawing.Point(3, -1);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(83, 17);
            this.RectanglesLabel.TabIndex = 30;
            this.RectanglesLabel.Text = "Rectangles:";
            // 
            // RectangleRemovePictureBox
            // 
            this.RectangleRemovePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RectangleRemovePictureBox.Image")));
            this.RectangleRemovePictureBox.Location = new System.Drawing.Point(267, 247);
            this.RectangleRemovePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectangleRemovePictureBox.Name = "RectangleRemovePictureBox";
            this.RectangleRemovePictureBox.Size = new System.Drawing.Size(24, 24);
            this.RectangleRemovePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RectangleRemovePictureBox.TabIndex = 17;
            this.RectangleRemovePictureBox.TabStop = false;
            this.RectangleRemovePictureBox.Click += new System.EventHandler(this.RectangleRemovePictureBox_Click);
            this.RectangleRemovePictureBox.MouseLeave += new System.EventHandler(this.RectangleRemovePictureBox_MouseLeave);
            this.RectangleRemovePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RectangleRemovePictureBox_MouseMove);
            // 
            // RectanlgeAddPictureBox
            // 
            this.RectanlgeAddPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.RectanlgeAddPictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("RectanlgeAddPictureBox.ErrorImage")));
            this.RectanlgeAddPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RectanlgeAddPictureBox.Image")));
            this.RectanlgeAddPictureBox.Location = new System.Drawing.Point(219, 247);
            this.RectanlgeAddPictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RectanlgeAddPictureBox.Name = "RectanlgeAddPictureBox";
            this.RectanlgeAddPictureBox.Size = new System.Drawing.Size(24, 24);
            this.RectanlgeAddPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RectanlgeAddPictureBox.TabIndex = 16;
            this.RectanlgeAddPictureBox.TabStop = false;
            this.RectanlgeAddPictureBox.Click += new System.EventHandler(this.RectanlgeAddPictureBox_Click);
            this.RectanlgeAddPictureBox.MouseLeave += new System.EventHandler(this.RectanlgeAddPictureBox_MouseLeave);
            this.RectanlgeAddPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RectanlgeAddPictureBox_MouseMove);
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.RectanglesLabel);
            this.Controls.Add(this.HeightPanelLabel);
            this.Controls.Add(this.WidthPanelLabel);
            this.Controls.Add(this.YPanelLabel);
            this.Controls.Add(this.XPabelLabel);
            this.Controls.Add(this.IdPanelLabel);
            this.Controls.Add(this.SelectedRectangleLabel);
            this.Controls.Add(this.HeightPanelTextBox);
            this.Controls.Add(this.YPanelTextBox);
            this.Controls.Add(this.XPanelTextBox);
            this.Controls.Add(this.IdPanelTextBox);
            this.Controls.Add(this.WidthPanelTextBox);
            this.Controls.Add(this.RectanglesPanelListBox);
            this.Controls.Add(this.RectangleRemovePictureBox);
            this.Controls.Add(this.RectanlgeAddPictureBox);
            this.Controls.Add(this.RectanglesPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(697, 469);
            ((System.ComponentModel.ISupportInitialize)(this.RectangleRemovePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RectanlgeAddPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeightPanelLabel;
        private System.Windows.Forms.Label WidthPanelLabel;
        private System.Windows.Forms.Label YPanelLabel;
        private System.Windows.Forms.Label XPabelLabel;
        private System.Windows.Forms.Label IdPanelLabel;
        private System.Windows.Forms.Label SelectedRectangleLabel;
        private System.Windows.Forms.TextBox HeightPanelTextBox;
        private System.Windows.Forms.TextBox YPanelTextBox;
        private System.Windows.Forms.TextBox XPanelTextBox;
        private System.Windows.Forms.TextBox IdPanelTextBox;
        private System.Windows.Forms.TextBox WidthPanelTextBox;
        private System.Windows.Forms.ListBox RectanglesPanelListBox;
        private System.Windows.Forms.PictureBox RectangleRemovePictureBox;
        private System.Windows.Forms.PictureBox RectanlgeAddPictureBox;
        private System.Windows.Forms.Panel RectanglesPanel;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.Label RectanglesLabel;
    }
}
