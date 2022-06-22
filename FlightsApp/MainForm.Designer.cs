
namespace FlightsApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.FlightsListBox = new System.Windows.Forms.ListBox();
            this.SelectedFlight = new System.Windows.Forms.GroupBox();
            this.FlightTypeComboBox = new System.Windows.Forms.ComboBox();
            this.FlightTypeLabel = new System.Windows.Forms.Label();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.DepartureTimeLabel = new System.Windows.Forms.Label();
            this.DepartureTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DestinationTextBox = new System.Windows.Forms.TextBox();
            this.DestinationLabel = new System.Windows.Forms.Label();
            this.DepartureTextBox = new System.Windows.Forms.TextBox();
            this.DepartureLabel = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.AddPictureBox = new System.Windows.Forms.PictureBox();
            this.RemovePictureBox = new System.Windows.Forms.PictureBox();
            this.SelectedFlight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemovePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // FlightsListBox
            // 
            this.FlightsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FlightsListBox.FormattingEnabled = true;
            this.FlightsListBox.ItemHeight = 16;
            this.FlightsListBox.Location = new System.Drawing.Point(12, 12);
            this.FlightsListBox.Name = "FlightsListBox";
            this.FlightsListBox.Size = new System.Drawing.Size(428, 420);
            this.FlightsListBox.TabIndex = 0;
            this.FlightsListBox.SelectedIndexChanged += new System.EventHandler(this.FlightsListBox_SelectedIndexChanged);
            // 
            // SelectedFlight
            // 
            this.SelectedFlight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SelectedFlight.Controls.Add(this.FlightTypeComboBox);
            this.SelectedFlight.Controls.Add(this.FlightTypeLabel);
            this.SelectedFlight.Controls.Add(this.DurationTextBox);
            this.SelectedFlight.Controls.Add(this.DurationLabel);
            this.SelectedFlight.Controls.Add(this.DepartureTimeLabel);
            this.SelectedFlight.Controls.Add(this.DepartureTimePicker);
            this.SelectedFlight.Controls.Add(this.DestinationTextBox);
            this.SelectedFlight.Controls.Add(this.DestinationLabel);
            this.SelectedFlight.Controls.Add(this.DepartureTextBox);
            this.SelectedFlight.Controls.Add(this.DepartureLabel);
            this.SelectedFlight.Location = new System.Drawing.Point(446, 12);
            this.SelectedFlight.Name = "SelectedFlight";
            this.SelectedFlight.Size = new System.Drawing.Size(342, 202);
            this.SelectedFlight.TabIndex = 1;
            this.SelectedFlight.TabStop = false;
            this.SelectedFlight.Text = "Selected Flight";
            // 
            // FlightTypeComboBox
            // 
            this.FlightTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FlightTypeComboBox.FormattingEnabled = true;
            this.FlightTypeComboBox.Location = new System.Drawing.Point(126, 162);
            this.FlightTypeComboBox.Name = "FlightTypeComboBox";
            this.FlightTypeComboBox.Size = new System.Drawing.Size(198, 24);
            this.FlightTypeComboBox.TabIndex = 8;
            this.FlightTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.FlightTypeComboBox_SelectedIndexChanged);
            // 
            // FlightTypeLabel
            // 
            this.FlightTypeLabel.AutoSize = true;
            this.FlightTypeLabel.Location = new System.Drawing.Point(35, 162);
            this.FlightTypeLabel.Name = "FlightTypeLabel";
            this.FlightTypeLabel.Size = new System.Drawing.Size(82, 17);
            this.FlightTypeLabel.TabIndex = 7;
            this.FlightTypeLabel.Text = "Flight Type:";
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(126, 130);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(198, 22);
            this.DurationTextBox.TabIndex = 2;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(51, 130);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(66, 17);
            this.DurationLabel.TabIndex = 6;
            this.DurationLabel.Text = "Duration:";
            // 
            // DepartureTimeLabel
            // 
            this.DepartureTimeLabel.AutoSize = true;
            this.DepartureTimeLabel.Location = new System.Drawing.Point(9, 98);
            this.DepartureTimeLabel.Name = "DepartureTimeLabel";
            this.DepartureTimeLabel.Size = new System.Drawing.Size(111, 17);
            this.DepartureTimeLabel.TabIndex = 5;
            this.DepartureTimeLabel.Text = "Departure Time:";
            // 
            // DepartureTimePicker
            // 
            this.DepartureTimePicker.CustomFormat = "yyyy.MM.dd hh:mm:ss";
            this.DepartureTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DepartureTimePicker.Location = new System.Drawing.Point(126, 98);
            this.DepartureTimePicker.Name = "DepartureTimePicker";
            this.DepartureTimePicker.Size = new System.Drawing.Size(198, 22);
            this.DepartureTimePicker.TabIndex = 4;
            this.DepartureTimePicker.ValueChanged += new System.EventHandler(this.DepartureTimePicker_ValueChanged);
            this.DepartureTimePicker.Leave += new System.EventHandler(this.DepartureTimePicker_Leave);
            // 
            // DestinationTextBox
            // 
            this.DestinationTextBox.Location = new System.Drawing.Point(126, 64);
            this.DestinationTextBox.Name = "DestinationTextBox";
            this.DestinationTextBox.Size = new System.Drawing.Size(198, 22);
            this.DestinationTextBox.TabIndex = 3;
            this.DestinationTextBox.TextChanged += new System.EventHandler(this.DestinationTextBox_TextChanged);
            // 
            // DestinationLabel
            // 
            this.DestinationLabel.AutoSize = true;
            this.DestinationLabel.Location = new System.Drawing.Point(37, 64);
            this.DestinationLabel.Name = "DestinationLabel";
            this.DestinationLabel.Size = new System.Drawing.Size(83, 17);
            this.DestinationLabel.TabIndex = 2;
            this.DestinationLabel.Text = "Destination:";
            // 
            // DepartureTextBox
            // 
            this.DepartureTextBox.Location = new System.Drawing.Point(126, 30);
            this.DepartureTextBox.Name = "DepartureTextBox";
            this.DepartureTextBox.Size = new System.Drawing.Size(198, 22);
            this.DepartureTextBox.TabIndex = 1;
            this.DepartureTextBox.TextChanged += new System.EventHandler(this.DepartureTextBox_TextChanged);
            // 
            // DepartureLabel
            // 
            this.DepartureLabel.AutoSize = true;
            this.DepartureLabel.Location = new System.Drawing.Point(41, 30);
            this.DepartureLabel.Name = "DepartureLabel";
            this.DepartureLabel.Size = new System.Drawing.Size(76, 17);
            this.DepartureLabel.TabIndex = 0;
            this.DepartureLabel.Text = "Departure:";
            // 
            // AddPictureBox
            // 
            this.AddPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPictureBox.Image = global::FlightsApp.Properties.Resources.AddButton;
            this.AddPictureBox.Location = new System.Drawing.Point(484, 235);
            this.AddPictureBox.Name = "AddPictureBox";
            this.AddPictureBox.Size = new System.Drawing.Size(24, 24);
            this.AddPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.AddPictureBox.TabIndex = 3;
            this.AddPictureBox.TabStop = false;
            this.AddPictureBox.Click += new System.EventHandler(this.AddPictureBox_Click);
            this.AddPictureBox.MouseLeave += new System.EventHandler(this.AddPictureBox_MouseLeave);
            this.AddPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.AddPictureBox_MouseMove);
            // 
            // RemovePictureBox
            // 
            this.RemovePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemovePictureBox.Image = global::FlightsApp.Properties.Resources.RemoveButton;
            this.RemovePictureBox.Location = new System.Drawing.Point(560, 235);
            this.RemovePictureBox.Name = "RemovePictureBox";
            this.RemovePictureBox.Size = new System.Drawing.Size(24, 24);
            this.RemovePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.RemovePictureBox.TabIndex = 2;
            this.RemovePictureBox.TabStop = false;
            this.RemovePictureBox.Click += new System.EventHandler(this.RemovePictureBox_Click);
            this.RemovePictureBox.MouseLeave += new System.EventHandler(this.RemovePictureBox_MouseLeave);
            this.RemovePictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RemovePictureBox_MouseMove);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddPictureBox);
            this.Controls.Add(this.RemovePictureBox);
            this.Controls.Add(this.SelectedFlight);
            this.Controls.Add(this.FlightsListBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "FlightsApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlightsApp_FormClosing);
            this.Load += new System.EventHandler(this.FlightsApp_Load);
            this.SelectedFlight.ResumeLayout(false);
            this.SelectedFlight.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RemovePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox FlightsListBox;
        private System.Windows.Forms.GroupBox SelectedFlight;
        private System.Windows.Forms.TextBox DepartureTextBox;
        private System.Windows.Forms.Label DepartureLabel;
        private System.Windows.Forms.Label DestinationLabel;
        private System.Windows.Forms.Label DepartureTimeLabel;
        private System.Windows.Forms.DateTimePicker DepartureTimePicker;
        private System.Windows.Forms.TextBox DestinationTextBox;
        private System.Windows.Forms.ComboBox FlightTypeComboBox;
        private System.Windows.Forms.Label FlightTypeLabel;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.PictureBox RemovePictureBox;
        private System.Windows.Forms.PictureBox AddPictureBox;
        private System.Windows.Forms.ToolTip ToolTip;
    }
}

