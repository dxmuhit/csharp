namespace UI
{
    partial class UserHomePage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchCurrentBooking = new System.Windows.Forms.TextBox();
            this.CurrentBookingRefreshButton = new System.Windows.Forms.Button();
            this.currentBookingsGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.updateCheckOutTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateCheckInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.updateBookingUpdateButton = new System.Windows.Forms.Button();
            this.updateSuitesBox = new System.Windows.Forms.TextBox();
            this.updateRoomBox = new System.Windows.Forms.TextBox();
            this.updateBookingIdBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkOutDateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.checkInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.suitesBox = new System.Windows.Forms.TextBox();
            this.roombox = new System.Windows.Forms.TextBox();
            this.hotelComboBox = new System.Windows.Forms.ComboBox();
            this.locationComboBox = new System.Windows.Forms.ComboBox();
            this.countryComboBox = new System.Windows.Forms.ComboBox();
            this.newBookingOkButton = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.calcelBookingCancelButton = new System.Windows.Forms.Button();
            this.cancelBookingIdBox = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentBookingsGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(636, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchCurrentBooking);
            this.groupBox1.Controls.Add(this.CurrentBookingRefreshButton);
            this.groupBox1.Controls.Add(this.currentBookingsGridView);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(343, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 226);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current Bookings";
            // 
            // searchCurrentBooking
            // 
            this.searchCurrentBooking.Location = new System.Drawing.Point(144, 31);
            this.searchCurrentBooking.Name = "searchCurrentBooking";
            this.searchCurrentBooking.Size = new System.Drawing.Size(134, 26);
            this.searchCurrentBooking.TabIndex = 2;
            this.searchCurrentBooking.Text = "Search";
            this.searchCurrentBooking.TextChanged += new System.EventHandler(this.currentBookingSearchTextChanged);
            // 
            // CurrentBookingRefreshButton
            // 
            this.CurrentBookingRefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CurrentBookingRefreshButton.Location = new System.Drawing.Point(6, 25);
            this.CurrentBookingRefreshButton.Name = "CurrentBookingRefreshButton";
            this.CurrentBookingRefreshButton.Size = new System.Drawing.Size(132, 32);
            this.CurrentBookingRefreshButton.TabIndex = 1;
            this.CurrentBookingRefreshButton.Text = "Refresh";
            this.CurrentBookingRefreshButton.UseVisualStyleBackColor = true;
            this.CurrentBookingRefreshButton.Click += new System.EventHandler(this.CurrentBookingRefreshButton_Click);
            // 
            // currentBookingsGridView
            // 
            this.currentBookingsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currentBookingsGridView.Location = new System.Drawing.Point(5, 63);
            this.currentBookingsGridView.Name = "currentBookingsGridView";
            this.currentBookingsGridView.Size = new System.Drawing.Size(273, 157);
            this.currentBookingsGridView.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updateCheckOutTimePicker);
            this.groupBox2.Controls.Add(this.updateCheckInDateTimePicker);
            this.groupBox2.Controls.Add(this.updateBookingUpdateButton);
            this.groupBox2.Controls.Add(this.updateSuitesBox);
            this.groupBox2.Controls.Add(this.updateRoomBox);
            this.groupBox2.Controls.Add(this.updateBookingIdBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(343, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 259);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update Bookings";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // updateCheckOutTimePicker
            // 
            this.updateCheckOutTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.updateCheckOutTimePicker.Location = new System.Drawing.Point(100, 181);
            this.updateCheckOutTimePicker.Name = "updateCheckOutTimePicker";
            this.updateCheckOutTimePicker.Size = new System.Drawing.Size(166, 26);
            this.updateCheckOutTimePicker.TabIndex = 20;
            // 
            // updateCheckInDateTimePicker
            // 
            this.updateCheckInDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.updateCheckInDateTimePicker.Location = new System.Drawing.Point(100, 146);
            this.updateCheckInDateTimePicker.Name = "updateCheckInDateTimePicker";
            this.updateCheckInDateTimePicker.Size = new System.Drawing.Size(166, 26);
            this.updateCheckInDateTimePicker.TabIndex = 19;
            // 
            // updateBookingUpdateButton
            // 
            this.updateBookingUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBookingUpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBookingUpdateButton.Location = new System.Drawing.Point(134, 218);
            this.updateBookingUpdateButton.Name = "updateBookingUpdateButton";
            this.updateBookingUpdateButton.Size = new System.Drawing.Size(90, 27);
            this.updateBookingUpdateButton.TabIndex = 10;
            this.updateBookingUpdateButton.Text = "Update";
            this.updateBookingUpdateButton.UseVisualStyleBackColor = true;
            this.updateBookingUpdateButton.Click += new System.EventHandler(this.updateBookingUpdateButton_Click);
            // 
            // updateSuitesBox
            // 
            this.updateSuitesBox.Location = new System.Drawing.Point(100, 110);
            this.updateSuitesBox.Name = "updateSuitesBox";
            this.updateSuitesBox.Size = new System.Drawing.Size(166, 26);
            this.updateSuitesBox.TabIndex = 7;
            // 
            // updateRoomBox
            // 
            this.updateRoomBox.Location = new System.Drawing.Point(100, 74);
            this.updateRoomBox.Name = "updateRoomBox";
            this.updateRoomBox.Size = new System.Drawing.Size(166, 26);
            this.updateRoomBox.TabIndex = 6;
            // 
            // updateBookingIdBox
            // 
            this.updateBookingIdBox.Location = new System.Drawing.Point(100, 37);
            this.updateBookingIdBox.Name = "updateBookingIdBox";
            this.updateBookingIdBox.Size = new System.Drawing.Size(166, 26);
            this.updateBookingIdBox.TabIndex = 5;
            this.updateBookingIdBox.TextChanged += new System.EventHandler(this.bookIdTextBoxTextXhanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Check Out";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Check In";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Suites";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rooms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking ID";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkOutDateTimePicker2);
            this.groupBox3.Controls.Add(this.checkInDateTimePicker);
            this.groupBox3.Controls.Add(this.suitesBox);
            this.groupBox3.Controls.Add(this.roombox);
            this.groupBox3.Controls.Add(this.hotelComboBox);
            this.groupBox3.Controls.Add(this.locationComboBox);
            this.groupBox3.Controls.Add(this.countryComboBox);
            this.groupBox3.Controls.Add(this.newBookingOkButton);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox3.Location = new System.Drawing.Point(12, 34);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 354);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "New Booking";
            // 
            // checkOutDateTimePicker2
            // 
            this.checkOutDateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.checkOutDateTimePicker2.Location = new System.Drawing.Point(114, 261);
            this.checkOutDateTimePicker2.Name = "checkOutDateTimePicker2";
            this.checkOutDateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.checkOutDateTimePicker2.TabIndex = 18;
            // 
            // checkInDateTimePicker
            // 
            this.checkInDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.checkInDateTimePicker.Location = new System.Drawing.Point(114, 227);
            this.checkInDateTimePicker.Name = "checkInDateTimePicker";
            this.checkInDateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.checkInDateTimePicker.TabIndex = 17;
            this.checkInDateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // suitesBox
            // 
            this.suitesBox.Location = new System.Drawing.Point(114, 192);
            this.suitesBox.Name = "suitesBox";
            this.suitesBox.Size = new System.Drawing.Size(198, 26);
            this.suitesBox.TabIndex = 16;
            // 
            // roombox
            // 
            this.roombox.Location = new System.Drawing.Point(114, 157);
            this.roombox.Name = "roombox";
            this.roombox.Size = new System.Drawing.Size(198, 26);
            this.roombox.TabIndex = 15;
            // 
            // hotelComboBox
            // 
            this.hotelComboBox.FormattingEnabled = true;
            this.hotelComboBox.Location = new System.Drawing.Point(114, 122);
            this.hotelComboBox.Name = "hotelComboBox";
            this.hotelComboBox.Size = new System.Drawing.Size(198, 28);
            this.hotelComboBox.TabIndex = 14;
            this.hotelComboBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.hotelComboBoxMouseClicked);
            // 
            // locationComboBox
            // 
            this.locationComboBox.FormattingEnabled = true;
            this.locationComboBox.Location = new System.Drawing.Point(114, 88);
            this.locationComboBox.Name = "locationComboBox";
            this.locationComboBox.Size = new System.Drawing.Size(198, 28);
            this.locationComboBox.TabIndex = 13;
            this.locationComboBox.SelectedIndexChanged += new System.EventHandler(this.locationComboBoxIndexChanged);
            this.locationComboBox.SelectedValueChanged += new System.EventHandler(this.locationComBoxValueChanged);
            // 
            // countryComboBox
            // 
            this.countryComboBox.FormattingEnabled = true;
            this.countryComboBox.Location = new System.Drawing.Point(114, 53);
            this.countryComboBox.Name = "countryComboBox";
            this.countryComboBox.Size = new System.Drawing.Size(198, 28);
            this.countryComboBox.TabIndex = 12;
            this.countryComboBox.SelectedIndexChanged += new System.EventHandler(this.countryComboBoxIndexChanged);
            this.countryComboBox.SelectedValueChanged += new System.EventHandler(this.countryComboBoxValueChanged);
            // 
            // newBookingOkButton
            // 
            this.newBookingOkButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newBookingOkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newBookingOkButton.Location = new System.Drawing.Point(166, 301);
            this.newBookingOkButton.Name = "newBookingOkButton";
            this.newBookingOkButton.Size = new System.Drawing.Size(93, 27);
            this.newBookingOkButton.TabIndex = 11;
            this.newBookingOkButton.Text = "OK";
            this.newBookingOkButton.UseVisualStyleBackColor = true;
            this.newBookingOkButton.Click += new System.EventHandler(this.newBookingOkButton_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 266);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 20);
            this.label12.TabIndex = 6;
            this.label12.Text = "Check Out";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 231);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Check In";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 196);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 4;
            this.label10.Text = "Suites";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Rooms";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Hotel/Resort";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Location";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Country";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.calcelBookingCancelButton);
            this.groupBox4.Controls.Add(this.cancelBookingIdBox);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox4.Location = new System.Drawing.Point(12, 394);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 130);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cancel Bookings";
            // 
            // calcelBookingCancelButton
            // 
            this.calcelBookingCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calcelBookingCancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcelBookingCancelButton.Location = new System.Drawing.Point(166, 80);
            this.calcelBookingCancelButton.Name = "calcelBookingCancelButton";
            this.calcelBookingCancelButton.Size = new System.Drawing.Size(93, 27);
            this.calcelBookingCancelButton.TabIndex = 10;
            this.calcelBookingCancelButton.Text = "OK";
            this.calcelBookingCancelButton.UseVisualStyleBackColor = true;
            this.calcelBookingCancelButton.Click += new System.EventHandler(this.calcelBookingCancelButton_Click);
            // 
            // cancelBookingIdBox
            // 
            this.cancelBookingIdBox.Location = new System.Drawing.Point(114, 42);
            this.cancelBookingIdBox.Name = "cancelBookingIdBox";
            this.cancelBookingIdBox.Size = new System.Drawing.Size(198, 26);
            this.cancelBookingIdBox.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(15, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(88, 20);
            this.label17.TabIndex = 0;
            this.label17.Text = "Booking ID";
            // 
            // UserHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(636, 538);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserHomePage";
            this.Text = "Book Resort/Hotel";
            this.Load += new System.EventHandler(this.UserHomePage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentBookingsGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchCurrentBooking;
        private System.Windows.Forms.Button CurrentBookingRefreshButton;
        private System.Windows.Forms.DataGridView currentBookingsGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox updateSuitesBox;
        private System.Windows.Forms.TextBox updateRoomBox;
        private System.Windows.Forms.TextBox updateBookingIdBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button updateBookingUpdateButton;
        private System.Windows.Forms.DateTimePicker checkInDateTimePicker;
        private System.Windows.Forms.TextBox suitesBox;
        private System.Windows.Forms.TextBox roombox;
        private System.Windows.Forms.ComboBox hotelComboBox;
        private System.Windows.Forms.ComboBox locationComboBox;
        private System.Windows.Forms.ComboBox countryComboBox;
        private System.Windows.Forms.Button newBookingOkButton;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button calcelBookingCancelButton;
        private System.Windows.Forms.TextBox cancelBookingIdBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker checkOutDateTimePicker2;
        private System.Windows.Forms.DateTimePicker updateCheckOutTimePicker;
        private System.Windows.Forms.DateTimePicker updateCheckInDateTimePicker;
    }
}