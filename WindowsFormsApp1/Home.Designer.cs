namespace ParkingManagementSystem
{
    partial class Home
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

        //change the code  jbs

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2Button();
            this.btnParkingInfo = new Guna.UI2.WinForms.Guna2Button();
            this.btnParkingSpaces = new Guna.UI2.WinForms.Guna2Button();
            this.btnHome = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblEmpty = new System.Windows.Forms.Label();
            this.lblEmptyNumber = new System.Windows.Forms.Label();
            this.lblFilled = new System.Windows.Forms.Label();
            this.lblFilledNumber = new System.Windows.Forms.Label();
            this.btnBike = new System.Windows.Forms.Button();
            this.btnCar = new System.Windows.Forms.Button();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlSideBar.Controls.Add(this.pictureBox1);
            this.pnlSideBar.Controls.Add(this.btnLogOut);
            this.pnlSideBar.Controls.Add(this.btnParkingInfo);
            this.pnlSideBar.Controls.Add(this.btnParkingSpaces);
            this.pnlSideBar.Controls.Add(this.btnHome);
            this.pnlSideBar.Controls.Add(this.pictureBox5);
            this.pnlSideBar.Controls.Add(this.lblUserName);
            this.pnlSideBar.Controls.Add(this.label2);
            this.pnlSideBar.Controls.Add(this.label1);
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSideBar.Location = new System.Drawing.Point(0, 0);
            this.pnlSideBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Size = new System.Drawing.Size(353, 962);
            this.pnlSideBar.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(104, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(133, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.Transparent;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.Red;
            this.btnLogOut.Image = global::ParkingManagementSystem.Properties.Resources.ic__outline_logout;
            this.btnLogOut.Location = new System.Drawing.Point(19, 769);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.ShadowDecoration.BorderRadius = 10;
            this.btnLogOut.Size = new System.Drawing.Size(317, 55);
            this.btnLogOut.TabIndex = 16;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnParkingInfo
            // 
            this.btnParkingInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParkingInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnParkingInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnParkingInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnParkingInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnParkingInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnParkingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParkingInfo.ForeColor = System.Drawing.Color.White;
            this.btnParkingInfo.Image = global::ParkingManagementSystem.Properties.Resources.line_md__document_report;
            this.btnParkingInfo.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnParkingInfo.Location = new System.Drawing.Point(19, 453);
            this.btnParkingInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnParkingInfo.Name = "btnParkingInfo";
            this.btnParkingInfo.ShadowDecoration.BorderRadius = 10;
            this.btnParkingInfo.Size = new System.Drawing.Size(317, 55);
            this.btnParkingInfo.TabIndex = 15;
            this.btnParkingInfo.Text = "Parking Info";
            this.btnParkingInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnParkingInfo.Click += new System.EventHandler(this.btnParkingInfo_Click);
            // 
            // btnParkingSpaces
            // 
            this.btnParkingSpaces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnParkingSpaces.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnParkingSpaces.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnParkingSpaces.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnParkingSpaces.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnParkingSpaces.FillColor = System.Drawing.Color.Transparent;
            this.btnParkingSpaces.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParkingSpaces.ForeColor = System.Drawing.Color.White;
            this.btnParkingSpaces.Image = global::ParkingManagementSystem.Properties.Resources.maki__parking_garage;
            this.btnParkingSpaces.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnParkingSpaces.Location = new System.Drawing.Point(19, 370);
            this.btnParkingSpaces.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnParkingSpaces.Name = "btnParkingSpaces";
            this.btnParkingSpaces.ShadowDecoration.BorderRadius = 10;
            this.btnParkingSpaces.Size = new System.Drawing.Size(317, 55);
            this.btnParkingSpaces.TabIndex = 13;
            this.btnParkingSpaces.Text = "Parking Spaces";
            this.btnParkingSpaces.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnParkingSpaces.Click += new System.EventHandler(this.btnParkingSpaces_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackgroundImage = global::ParkingManagementSystem.Properties.Resources.Rectangle_110;
            this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHome.FillColor = System.Drawing.Color.Transparent;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Location = new System.Drawing.Point(19, 288);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHome.Name = "btnHome";
            this.btnHome.ShadowDecoration.BorderRadius = 10;
            this.btnHome.Size = new System.Drawing.Size(317, 55);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ParkingManagementSystem.Properties.Resources.ic__round_account_circle;
            this.pictureBox5.Location = new System.Drawing.Point(71, 692);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(55, 52);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserName.Location = new System.Drawing.Point(135, 706);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(112, 24);
            this.lblUserName.TabIndex = 12;
            this.lblUserName.Text = "Avano Finch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(99, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "MANAGEMENT SYSTEM";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(63, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "PARKING";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 2000;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.pnlHeader.Controls.Add(this.btnLogin);
            this.pnlHeader.Controls.Add(this.lblEmpty);
            this.pnlHeader.Controls.Add(this.lblEmptyNumber);
            this.pnlHeader.Controls.Add(this.lblFilled);
            this.pnlHeader.Controls.Add(this.lblFilledNumber);
            this.pnlHeader.Controls.Add(this.btnBike);
            this.pnlHeader.Controls.Add(this.btnCar);
            this.pnlHeader.Controls.Add(this.nightControlBox1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(353, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1394, 80);
            this.pnlHeader.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogin.BackColor = System.Drawing.Color.White;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.Black;
            this.btnLogin.Location = new System.Drawing.Point(998, 15);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(177, 39);
            this.btnLogin.TabIndex = 25;
            this.btnLogin.Text = "Log In";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblEmpty
            // 
            this.lblEmpty.AutoSize = true;
            this.lblEmpty.BackColor = System.Drawing.Color.Transparent;
            this.lblEmpty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpty.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmpty.Location = new System.Drawing.Point(620, 26);
            this.lblEmpty.Name = "lblEmpty";
            this.lblEmpty.Size = new System.Drawing.Size(56, 20);
            this.lblEmpty.TabIndex = 21;
            this.lblEmpty.Text = "Empty";
            // 
            // lblEmptyNumber
            // 
            this.lblEmptyNumber.AutoSize = true;
            this.lblEmptyNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblEmptyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEmptyNumber.Location = new System.Drawing.Point(688, 28);
            this.lblEmptyNumber.Name = "lblEmptyNumber";
            this.lblEmptyNumber.Size = new System.Drawing.Size(27, 20);
            this.lblEmptyNumber.TabIndex = 20;
            this.lblEmptyNumber.Text = "36";
            // 
            // lblFilled
            // 
            this.lblFilled.AutoSize = true;
            this.lblFilled.BackColor = System.Drawing.Color.Transparent;
            this.lblFilled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilled.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFilled.Location = new System.Drawing.Point(412, 26);
            this.lblFilled.Name = "lblFilled";
            this.lblFilled.Size = new System.Drawing.Size(49, 20);
            this.lblFilled.TabIndex = 19;
            this.lblFilled.Text = "Filled";
            // 
            // lblFilledNumber
            // 
            this.lblFilledNumber.AutoSize = true;
            this.lblFilledNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblFilledNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilledNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblFilledNumber.Location = new System.Drawing.Point(469, 26);
            this.lblFilledNumber.Name = "lblFilledNumber";
            this.lblFilledNumber.Size = new System.Drawing.Size(27, 20);
            this.lblFilledNumber.TabIndex = 18;
            this.lblFilledNumber.Text = "12";
            this.lblFilledNumber.Click += new System.EventHandler(this.lblFilledNumber_Click);
            // 
            // btnBike
            // 
            this.btnBike.BackColor = System.Drawing.Color.Black;
            this.btnBike.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBike.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBike.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(9)))), ((int)(((byte)(77)))));
            this.btnBike.FlatAppearance.BorderSize = 0;
            this.btnBike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBike.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBike.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBike.Location = new System.Drawing.Point(201, 21);
            this.btnBike.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBike.Name = "btnBike";
            this.btnBike.Size = new System.Drawing.Size(107, 33);
            this.btnBike.TabIndex = 17;
            this.btnBike.Text = "Bike";
            this.btnBike.UseVisualStyleBackColor = false;
            this.btnBike.Click += new System.EventHandler(this.btnBike_Click);
            // 
            // btnCar
            // 
            this.btnCar.AutoEllipsis = true;
            this.btnCar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(10)))), ((int)(((byte)(227)))));
            this.btnCar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCar.BackgroundImage")));
            this.btnCar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCar.FlatAppearance.BorderSize = 0;
            this.btnCar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCar.Location = new System.Drawing.Point(80, 21);
            this.btnCar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCar.Name = "btnCar";
            this.btnCar.Size = new System.Drawing.Size(101, 33);
            this.btnCar.TabIndex = 16;
            this.btnCar.Text = "Car";
            this.btnCar.UseVisualStyleBackColor = false;
            this.btnCar.Click += new System.EventHandler(this.btnCar_Click);
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(1209, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.ForeColor = System.Drawing.Color.Black;
            this.pnlMain.Location = new System.Drawing.Point(353, 80);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1394, 882);
            this.pnlMain.TabIndex = 3;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1747, 962);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.pnlSideBar.ResumeLayout(false);
            this.pnlSideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblUserName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlHeader;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblEmpty;
        private System.Windows.Forms.Label lblEmptyNumber;
        private System.Windows.Forms.Label lblFilled;
        private System.Windows.Forms.Label lblFilledNumber;
        private System.Windows.Forms.Button btnBike;
        private System.Windows.Forms.Button btnCar;
        private Guna.UI2.WinForms.Guna2Button btnHome;
        private Guna.UI2.WinForms.Guna2Button btnParkingSpaces;
        private Guna.UI2.WinForms.Guna2Button btnParkingInfo;
        private Guna.UI2.WinForms.Guna2Button btnLogOut;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}