namespace CUESYSv._01
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tbUserName = new System.Windows.Forms.TextBox();
            this.tbUserPass = new System.Windows.Forms.TextBox();
            this.lbUserName = new System.Windows.Forms.Label();
            this.lbUserPass = new System.Windows.Forms.Label();
            this.lbCueSys = new System.Windows.Forms.Label();
            this.btLogin = new System.Windows.Forms.Button();
            this.panClock = new System.Windows.Forms.Panel();
            this.lbClockSeconds = new System.Windows.Forms.Label();
            this.lbClockDate = new System.Windows.Forms.Label();
            this.lbClockTime = new System.Windows.Forms.Label();
            this.timeClock = new System.Windows.Forms.Timer(this.components);
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewDevLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewFlightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchFlightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFloor = new System.Windows.Forms.ComboBox();
            this.cbBuilding = new System.Windows.Forms.ComboBox();
            this.lbCustContact = new System.Windows.Forms.Label();
            this.tbCustContact = new System.Windows.Forms.TextBox();
            this.tbCustEmail = new System.Windows.Forms.TextBox();
            this.lbCustEmail = new System.Windows.Forms.Label();
            this.tbCustTel = new System.Windows.Forms.TextBox();
            this.lbCustTel = new System.Windows.Forms.Label();
            this.tbCustTownCity = new System.Windows.Forms.TextBox();
            this.lbCustTownCity = new System.Windows.Forms.Label();
            this.tbCustAdd2 = new System.Windows.Forms.TextBox();
            this.lbCustAdd2 = new System.Windows.Forms.Label();
            this.tbCustAdd1 = new System.Windows.Forms.TextBox();
            this.lbCustAdd1 = new System.Windows.Forms.Label();
            this.tbCustPostcode = new System.Windows.Forms.TextBox();
            this.lbCustPostcode = new System.Windows.Forms.Label();
            this.lbCustTitle = new System.Windows.Forms.Label();
            this.btCustSave = new System.Windows.Forms.Button();
            this.btCustUpdate = new System.Windows.Forms.Button();
            this.btCustDelete = new System.Windows.Forms.Button();
            this.btBook = new System.Windows.Forms.Button();
            this.tbTime = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mcDate = new System.Windows.Forms.MonthCalendar();
            this.cbPaid = new System.Windows.Forms.CheckBox();
            this.tbCustomer = new System.Windows.Forms.TextBox();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.lbBookingInfo = new System.Windows.Forms.Label();
            this.dgRoomBookingsSummary = new System.Windows.Forms.DataGridView();
            this.lbBookFlight = new System.Windows.Forms.Label();
            this.lbFlightCustContact = new System.Windows.Forms.Label();
            this.tbFlightCustContact = new System.Windows.Forms.TextBox();
            this.tbFlightAirline = new System.Windows.Forms.TextBox();
            this.lbFlightAirline = new System.Windows.Forms.Label();
            this.tbFlightDestination = new System.Windows.Forms.TextBox();
            this.lbFlightDestination = new System.Windows.Forms.Label();
            this.tbFlightOrigin = new System.Windows.Forms.TextBox();
            this.lbFlightOrigin = new System.Windows.Forms.Label();
            this.tbFlightAdult = new System.Windows.Forms.TextBox();
            this.lbFlightAdult = new System.Windows.Forms.Label();
            this.lbFlightBookDate = new System.Windows.Forms.Label();
            this.tbFlightSeat = new System.Windows.Forms.TextBox();
            this.lbFlightSeat = new System.Windows.Forms.Label();
            this.tbFlightNumber = new System.Windows.Forms.TextBox();
            this.lbFlightNumber = new System.Windows.Forms.Label();
            this.tbFlightChildren = new System.Windows.Forms.TextBox();
            this.lbFlightChildren = new System.Windows.Forms.Label();
            this.lbFlightBookingPaid = new System.Windows.Forms.Label();
            this.tbFlightInfant = new System.Windows.Forms.TextBox();
            this.lbFlightInfant = new System.Windows.Forms.Label();
            this.btnFlightSave = new System.Windows.Forms.Button();
            this.cbFlightPaid = new System.Windows.Forms.CheckBox();
            this.dtFlightBook = new System.Windows.Forms.MonthCalendar();
            this.tbSearchFlight = new System.Windows.Forms.TextBox();
            this.btSearchFlight = new System.Windows.Forms.Button();
            this.myDarkBg = new System.Windows.Forms.PictureBox();
            this.lbEditFlight = new System.Windows.Forms.Label();
            this.btnEditFlightSave = new System.Windows.Forms.Button();
            this.panClock.SuspendLayout();
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoomBookingsSummary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDarkBg)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(202, 141);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(100, 20);
            this.tbUserName.TabIndex = 0;
            this.tbUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUserName_KeyDown);
            // 
            // tbUserPass
            // 
            this.tbUserPass.Location = new System.Drawing.Point(202, 176);
            this.tbUserPass.Name = "tbUserPass";
            this.tbUserPass.Size = new System.Drawing.Size(100, 20);
            this.tbUserPass.TabIndex = 1;
            this.tbUserPass.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUserPass_KeyDown);
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.Location = new System.Drawing.Point(133, 147);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(55, 13);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "Username";
            // 
            // lbUserPass
            // 
            this.lbUserPass.AutoSize = true;
            this.lbUserPass.Location = new System.Drawing.Point(136, 182);
            this.lbUserPass.Name = "lbUserPass";
            this.lbUserPass.Size = new System.Drawing.Size(53, 13);
            this.lbUserPass.TabIndex = 3;
            this.lbUserPass.Text = "Password";
            // 
            // lbCueSys
            // 
            this.lbCueSys.AutoSize = true;
            this.lbCueSys.Font = new System.Drawing.Font("Consolas", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCueSys.Location = new System.Drawing.Point(230, 12);
            this.lbCueSys.Name = "lbCueSys";
            this.lbCueSys.Size = new System.Drawing.Size(347, 75);
            this.lbCueSys.TabIndex = 4;
            this.lbCueSys.Text = "AZMAN SYS";
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(202, 269);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 5;
            this.btLogin.Text = "LOGIN";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // panClock
            // 
            this.panClock.BackColor = System.Drawing.SystemColors.Control;
            this.panClock.Controls.Add(this.lbClockSeconds);
            this.panClock.Controls.Add(this.lbClockDate);
            this.panClock.Controls.Add(this.lbClockTime);
            this.panClock.Location = new System.Drawing.Point(646, 9);
            this.panClock.Name = "panClock";
            this.panClock.Size = new System.Drawing.Size(142, 55);
            this.panClock.TabIndex = 6;
            // 
            // lbClockSeconds
            // 
            this.lbClockSeconds.AutoSize = true;
            this.lbClockSeconds.BackColor = System.Drawing.Color.Transparent;
            this.lbClockSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClockSeconds.Location = new System.Drawing.Point(122, 23);
            this.lbClockSeconds.Name = "lbClockSeconds";
            this.lbClockSeconds.Size = new System.Drawing.Size(0, 9);
            this.lbClockSeconds.TabIndex = 0;
            // 
            // lbClockDate
            // 
            this.lbClockDate.AutoSize = true;
            this.lbClockDate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbClockDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClockDate.Location = new System.Drawing.Point(142, 0);
            this.lbClockDate.Name = "lbClockDate";
            this.lbClockDate.Size = new System.Drawing.Size(0, 16);
            this.lbClockDate.TabIndex = 2;
            // 
            // lbClockTime
            // 
            this.lbClockTime.AutoSize = true;
            this.lbClockTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClockTime.Location = new System.Drawing.Point(65, 23);
            this.lbClockTime.Name = "lbClockTime";
            this.lbClockTime.Size = new System.Drawing.Size(0, 29);
            this.lbClockTime.TabIndex = 1;
            // 
            // timeClock
            // 
            this.timeClock.Enabled = true;
            this.timeClock.Interval = 1000;
            this.timeClock.Tick += new System.EventHandler(this.timeClock_Tick);
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.Color.Transparent;
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.customerToolStripMenuItem,
            this.flightsToolStripMenuItem});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(800, 24);
            this.mainMenu.TabIndex = 8;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewDevLogsToolStripMenuItem,
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewDevLogsToolStripMenuItem
            // 
            this.viewDevLogsToolStripMenuItem.Name = "viewDevLogsToolStripMenuItem";
            this.viewDevLogsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.viewDevLogsToolStripMenuItem.Text = "View DevLogs";
            this.viewDevLogsToolStripMenuItem.Click += new System.EventHandler(this.viewDevLogsToolStripMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createCustomerToolStripMenuItem,
            this.viewCustomersToolStripMenuItem});
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.customerToolStripMenuItem.Text = "Customers";
            // 
            // createCustomerToolStripMenuItem
            // 
            this.createCustomerToolStripMenuItem.Name = "createCustomerToolStripMenuItem";
            this.createCustomerToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.createCustomerToolStripMenuItem.Text = "Create Customer";
            this.createCustomerToolStripMenuItem.Click += new System.EventHandler(this.createCustomerToolStripMenuItem_Click);
            // 
            // viewCustomersToolStripMenuItem
            // 
            this.viewCustomersToolStripMenuItem.Name = "viewCustomersToolStripMenuItem";
            this.viewCustomersToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.viewCustomersToolStripMenuItem.Text = "View Customers";
            this.viewCustomersToolStripMenuItem.Click += new System.EventHandler(this.viewCustomersToolStripMenuItem_Click);
            // 
            // flightsToolStripMenuItem
            // 
            this.flightsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.viewFlightsToolStripMenuItem,
            this.searchFlightToolStripMenuItem});
            this.flightsToolStripMenuItem.Name = "flightsToolStripMenuItem";
            this.flightsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.flightsToolStripMenuItem.Text = "Flights";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.bookToolStripMenuItem.Text = "Book Flight";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // viewFlightsToolStripMenuItem
            // 
            this.viewFlightsToolStripMenuItem.Name = "viewFlightsToolStripMenuItem";
            this.viewFlightsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.viewFlightsToolStripMenuItem.Text = "View Flights";
            this.viewFlightsToolStripMenuItem.Click += new System.EventHandler(this.viewFlightsToolStripMenuItem_Click);
            // 
            // searchFlightToolStripMenuItem
            // 
            this.searchFlightToolStripMenuItem.Name = "searchFlightToolStripMenuItem";
            this.searchFlightToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.searchFlightToolStripMenuItem.Text = "Search Flight";
            this.searchFlightToolStripMenuItem.Click += new System.EventHandler(this.searchFlightToolStripMenuItem_Click);
            // 
            // cbFloor
            // 
            this.cbFloor.FormattingEnabled = true;
            this.cbFloor.Items.AddRange(new object[] {
            "Ground",
            "First",
            "Second",
            "Third",
            "Fourth"});
            this.cbFloor.Location = new System.Drawing.Point(370, 90);
            this.cbFloor.Name = "cbFloor";
            this.cbFloor.Size = new System.Drawing.Size(121, 21);
            this.cbFloor.TabIndex = 11;
            // 
            // cbBuilding
            // 
            this.cbBuilding.FormattingEnabled = true;
            this.cbBuilding.Items.AddRange(new object[] {
            "Armstrong Siddeley",
            "Jaguar",
            "William Lyons"});
            this.cbBuilding.Location = new System.Drawing.Point(243, 90);
            this.cbBuilding.Name = "cbBuilding";
            this.cbBuilding.Size = new System.Drawing.Size(121, 21);
            this.cbBuilding.TabIndex = 12;
            // 
            // lbCustContact
            // 
            this.lbCustContact.AutoSize = true;
            this.lbCustContact.Location = new System.Drawing.Point(361, 154);
            this.lbCustContact.Name = "lbCustContact";
            this.lbCustContact.Size = new System.Drawing.Size(91, 13);
            this.lbCustContact.TabIndex = 13;
            this.lbCustContact.Text = "Customer Contact";
            // 
            // tbCustContact
            // 
            this.tbCustContact.Location = new System.Drawing.Point(458, 151);
            this.tbCustContact.Name = "tbCustContact";
            this.tbCustContact.Size = new System.Drawing.Size(100, 20);
            this.tbCustContact.TabIndex = 14;
            // 
            // tbCustEmail
            // 
            this.tbCustEmail.Location = new System.Drawing.Point(458, 176);
            this.tbCustEmail.Name = "tbCustEmail";
            this.tbCustEmail.Size = new System.Drawing.Size(100, 20);
            this.tbCustEmail.TabIndex = 16;
            // 
            // lbCustEmail
            // 
            this.lbCustEmail.AutoSize = true;
            this.lbCustEmail.Location = new System.Drawing.Point(361, 179);
            this.lbCustEmail.Name = "lbCustEmail";
            this.lbCustEmail.Size = new System.Drawing.Size(72, 13);
            this.lbCustEmail.TabIndex = 15;
            this.lbCustEmail.Text = "Contact Email";
            // 
            // tbCustTel
            // 
            this.tbCustTel.Location = new System.Drawing.Point(458, 202);
            this.tbCustTel.Name = "tbCustTel";
            this.tbCustTel.Size = new System.Drawing.Size(100, 20);
            this.tbCustTel.TabIndex = 18;
            // 
            // lbCustTel
            // 
            this.lbCustTel.AutoSize = true;
            this.lbCustTel.Location = new System.Drawing.Point(361, 205);
            this.lbCustTel.Name = "lbCustTel";
            this.lbCustTel.Size = new System.Drawing.Size(98, 13);
            this.lbCustTel.TabIndex = 17;
            this.lbCustTel.Text = "Contact Telephone";
            // 
            // tbCustTownCity
            // 
            this.tbCustTownCity.Location = new System.Drawing.Point(458, 279);
            this.tbCustTownCity.Name = "tbCustTownCity";
            this.tbCustTownCity.Size = new System.Drawing.Size(100, 20);
            this.tbCustTownCity.TabIndex = 24;
            // 
            // lbCustTownCity
            // 
            this.lbCustTownCity.AutoSize = true;
            this.lbCustTownCity.Location = new System.Drawing.Point(361, 282);
            this.lbCustTownCity.Name = "lbCustTownCity";
            this.lbCustTownCity.Size = new System.Drawing.Size(62, 13);
            this.lbCustTownCity.TabIndex = 23;
            this.lbCustTownCity.Text = "Town / City";
            // 
            // tbCustAdd2
            // 
            this.tbCustAdd2.Location = new System.Drawing.Point(458, 253);
            this.tbCustAdd2.Name = "tbCustAdd2";
            this.tbCustAdd2.Size = new System.Drawing.Size(100, 20);
            this.tbCustAdd2.TabIndex = 22;
            // 
            // lbCustAdd2
            // 
            this.lbCustAdd2.AutoSize = true;
            this.lbCustAdd2.Location = new System.Drawing.Point(361, 256);
            this.lbCustAdd2.Name = "lbCustAdd2";
            this.lbCustAdd2.Size = new System.Drawing.Size(77, 13);
            this.lbCustAdd2.TabIndex = 21;
            this.lbCustAdd2.Text = "Address Line 2";
            // 
            // tbCustAdd1
            // 
            this.tbCustAdd1.Location = new System.Drawing.Point(458, 228);
            this.tbCustAdd1.Name = "tbCustAdd1";
            this.tbCustAdd1.Size = new System.Drawing.Size(100, 20);
            this.tbCustAdd1.TabIndex = 20;
            // 
            // lbCustAdd1
            // 
            this.lbCustAdd1.AutoSize = true;
            this.lbCustAdd1.Location = new System.Drawing.Point(361, 231);
            this.lbCustAdd1.Name = "lbCustAdd1";
            this.lbCustAdd1.Size = new System.Drawing.Size(77, 13);
            this.lbCustAdd1.TabIndex = 19;
            this.lbCustAdd1.Text = "Address Line 1";
            // 
            // tbCustPostcode
            // 
            this.tbCustPostcode.Location = new System.Drawing.Point(458, 305);
            this.tbCustPostcode.Name = "tbCustPostcode";
            this.tbCustPostcode.Size = new System.Drawing.Size(100, 20);
            this.tbCustPostcode.TabIndex = 26;
            // 
            // lbCustPostcode
            // 
            this.lbCustPostcode.AutoSize = true;
            this.lbCustPostcode.Location = new System.Drawing.Point(361, 308);
            this.lbCustPostcode.Name = "lbCustPostcode";
            this.lbCustPostcode.Size = new System.Drawing.Size(52, 13);
            this.lbCustPostcode.TabIndex = 25;
            this.lbCustPostcode.Text = "Postcode";
            // 
            // lbCustTitle
            // 
            this.lbCustTitle.AutoSize = true;
            this.lbCustTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCustTitle.Location = new System.Drawing.Point(408, 125);
            this.lbCustTitle.Name = "lbCustTitle";
            this.lbCustTitle.Size = new System.Drawing.Size(0, 20);
            this.lbCustTitle.TabIndex = 27;
            // 
            // btCustSave
            // 
            this.btCustSave.Location = new System.Drawing.Point(458, 332);
            this.btCustSave.Name = "btCustSave";
            this.btCustSave.Size = new System.Drawing.Size(100, 23);
            this.btCustSave.TabIndex = 28;
            this.btCustSave.Text = "Save";
            this.btCustSave.UseVisualStyleBackColor = true;
            this.btCustSave.Click += new System.EventHandler(this.btCustSave_Click);
            // 
            // btCustUpdate
            // 
            this.btCustUpdate.Location = new System.Drawing.Point(457, 333);
            this.btCustUpdate.Name = "btCustUpdate";
            this.btCustUpdate.Size = new System.Drawing.Size(100, 23);
            this.btCustUpdate.TabIndex = 29;
            this.btCustUpdate.Text = "Update";
            this.btCustUpdate.UseVisualStyleBackColor = true;
            // 
            // btCustDelete
            // 
            this.btCustDelete.Location = new System.Drawing.Point(457, 362);
            this.btCustDelete.Name = "btCustDelete";
            this.btCustDelete.Size = new System.Drawing.Size(100, 23);
            this.btCustDelete.TabIndex = 30;
            this.btCustDelete.Text = "Delete";
            this.btCustDelete.UseVisualStyleBackColor = true;
            // 
            // btBook
            // 
            this.btBook.Location = new System.Drawing.Point(517, 413);
            this.btBook.Name = "btBook";
            this.btBook.Size = new System.Drawing.Size(75, 23);
            this.btBook.TabIndex = 43;
            this.btBook.Text = "BOOK";
            this.btBook.UseVisualStyleBackColor = true;
            this.btBook.Click += new System.EventHandler(this.btBook_Click);
            // 
            // tbTime
            // 
            this.tbTime.Location = new System.Drawing.Point(365, 342);
            this.tbTime.Mask = "00:00";
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(40, 20);
            this.tbTime.TabIndex = 42;
            this.tbTime.ValidatingType = typeof(System.DateTime);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 370);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 25);
            this.label5.TabIndex = 41;
            this.label5.Text = "Cost       £";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 39;
            this.label3.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 38;
            this.label2.Text = "Paid (Y/N)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 37;
            this.label1.Text = "Customer";
            // 
            // mcDate
            // 
            this.mcDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mcDate.Location = new System.Drawing.Point(365, 170);
            this.mcDate.Name = "mcDate";
            this.mcDate.TabIndex = 36;
            // 
            // cbPaid
            // 
            this.cbPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPaid.Location = new System.Drawing.Point(372, 413);
            this.cbPaid.Name = "cbPaid";
            this.cbPaid.Size = new System.Drawing.Size(25, 25);
            this.cbPaid.TabIndex = 35;
            this.cbPaid.UseVisualStyleBackColor = true;
            // 
            // tbCustomer
            // 
            this.tbCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCustomer.Location = new System.Drawing.Point(365, 130);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Size = new System.Drawing.Size(227, 29);
            this.tbCustomer.TabIndex = 34;
            // 
            // tbCost
            // 
            this.tbCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCost.Location = new System.Drawing.Point(365, 368);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(227, 29);
            this.tbCost.TabIndex = 33;
            // 
            // lbBookingInfo
            // 
            this.lbBookingInfo.AutoSize = true;
            this.lbBookingInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookingInfo.Location = new System.Drawing.Point(368, 96);
            this.lbBookingInfo.Name = "lbBookingInfo";
            this.lbBookingInfo.Size = new System.Drawing.Size(133, 25);
            this.lbBookingInfo.TabIndex = 32;
            this.lbBookingInfo.Text = "xxxxxxxxxxx";
            // 
            // dgRoomBookingsSummary
            // 
            this.dgRoomBookingsSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgRoomBookingsSummary.Location = new System.Drawing.Point(12, 95);
            this.dgRoomBookingsSummary.Name = "dgRoomBookingsSummary";
            this.dgRoomBookingsSummary.Size = new System.Drawing.Size(776, 351);
            this.dgRoomBookingsSummary.TabIndex = 7;
            this.dgRoomBookingsSummary.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgRoomBookingsSummary_CellContentClick);
            this.dgRoomBookingsSummary.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgRoomBookingsSummary_CellMouseDoubleClick);
            // 
            // lbBookFlight
            // 
            this.lbBookFlight.AutoSize = true;
            this.lbBookFlight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbBookFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBookFlight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbBookFlight.Location = new System.Drawing.Point(310, 116);
            this.lbBookFlight.Name = "lbBookFlight";
            this.lbBookFlight.Size = new System.Drawing.Size(208, 29);
            this.lbBookFlight.TabIndex = 45;
            this.lbBookFlight.Text = "BOOK A FLIGHT";
            // 
            // lbFlightCustContact
            // 
            this.lbFlightCustContact.AutoSize = true;
            this.lbFlightCustContact.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFlightCustContact.Location = new System.Drawing.Point(179, 165);
            this.lbFlightCustContact.Name = "lbFlightCustContact";
            this.lbFlightCustContact.Size = new System.Drawing.Size(91, 13);
            this.lbFlightCustContact.TabIndex = 46;
            this.lbFlightCustContact.Text = "Customer Contact";
            // 
            // tbFlightCustContact
            // 
            this.tbFlightCustContact.Location = new System.Drawing.Point(280, 162);
            this.tbFlightCustContact.Name = "tbFlightCustContact";
            this.tbFlightCustContact.Size = new System.Drawing.Size(100, 20);
            this.tbFlightCustContact.TabIndex = 47;
            // 
            // tbFlightAirline
            // 
            this.tbFlightAirline.Location = new System.Drawing.Point(505, 162);
            this.tbFlightAirline.Name = "tbFlightAirline";
            this.tbFlightAirline.Size = new System.Drawing.Size(100, 20);
            this.tbFlightAirline.TabIndex = 49;
            // 
            // lbFlightAirline
            // 
            this.lbFlightAirline.AutoSize = true;
            this.lbFlightAirline.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFlightAirline.Location = new System.Drawing.Point(453, 165);
            this.lbFlightAirline.Name = "lbFlightAirline";
            this.lbFlightAirline.Size = new System.Drawing.Size(35, 13);
            this.lbFlightAirline.TabIndex = 48;
            this.lbFlightAirline.Text = "Airline";
            // 
            // tbFlightDestination
            // 
            this.tbFlightDestination.Location = new System.Drawing.Point(505, 192);
            this.tbFlightDestination.Name = "tbFlightDestination";
            this.tbFlightDestination.Size = new System.Drawing.Size(100, 20);
            this.tbFlightDestination.TabIndex = 53;
            // 
            // lbFlightDestination
            // 
            this.lbFlightDestination.AutoSize = true;
            this.lbFlightDestination.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFlightDestination.Location = new System.Drawing.Point(404, 195);
            this.lbFlightDestination.Name = "lbFlightDestination";
            this.lbFlightDestination.Size = new System.Drawing.Size(88, 13);
            this.lbFlightDestination.TabIndex = 52;
            this.lbFlightDestination.Text = "Flight Destination";
            // 
            // tbFlightOrigin
            // 
            this.tbFlightOrigin.Location = new System.Drawing.Point(280, 192);
            this.tbFlightOrigin.Name = "tbFlightOrigin";
            this.tbFlightOrigin.Size = new System.Drawing.Size(100, 20);
            this.tbFlightOrigin.TabIndex = 51;
            // 
            // lbFlightOrigin
            // 
            this.lbFlightOrigin.AutoSize = true;
            this.lbFlightOrigin.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFlightOrigin.Location = new System.Drawing.Point(179, 195);
            this.lbFlightOrigin.Name = "lbFlightOrigin";
            this.lbFlightOrigin.Size = new System.Drawing.Size(62, 13);
            this.lbFlightOrigin.TabIndex = 50;
            this.lbFlightOrigin.Text = "Flight Origin";
            // 
            // tbFlightAdult
            // 
            this.tbFlightAdult.Location = new System.Drawing.Point(280, 254);
            this.tbFlightAdult.Name = "tbFlightAdult";
            this.tbFlightAdult.Size = new System.Drawing.Size(100, 20);
            this.tbFlightAdult.TabIndex = 61;
            // 
            // lbFlightAdult
            // 
            this.lbFlightAdult.AutoSize = true;
            this.lbFlightAdult.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFlightAdult.Location = new System.Drawing.Point(184, 257);
            this.lbFlightAdult.Name = "lbFlightAdult";
            this.lbFlightAdult.Size = new System.Drawing.Size(58, 13);
            this.lbFlightAdult.TabIndex = 60;
            this.lbFlightAdult.Text = "Adult Price";
            // 
            // lbFlightBookDate
            // 
            this.lbFlightBookDate.AutoSize = true;
            this.lbFlightBookDate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFlightBookDate.Location = new System.Drawing.Point(182, 319);
            this.lbFlightBookDate.Name = "lbFlightBookDate";
            this.lbFlightBookDate.Size = new System.Drawing.Size(84, 13);
            this.lbFlightBookDate.TabIndex = 58;
            this.lbFlightBookDate.Text = "Book Date Time";
            // 
            // tbFlightSeat
            // 
            this.tbFlightSeat.Location = new System.Drawing.Point(505, 224);
            this.tbFlightSeat.Name = "tbFlightSeat";
            this.tbFlightSeat.Size = new System.Drawing.Size(100, 20);
            this.tbFlightSeat.TabIndex = 57;
            // 
            // lbFlightSeat
            // 
            this.lbFlightSeat.AutoSize = true;
            this.lbFlightSeat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFlightSeat.Location = new System.Drawing.Point(424, 227);
            this.lbFlightSeat.Name = "lbFlightSeat";
            this.lbFlightSeat.Size = new System.Drawing.Size(69, 13);
            this.lbFlightSeat.TabIndex = 56;
            this.lbFlightSeat.Text = "Seat Number";
            // 
            // tbFlightNumber
            // 
            this.tbFlightNumber.Location = new System.Drawing.Point(281, 223);
            this.tbFlightNumber.Name = "tbFlightNumber";
            this.tbFlightNumber.Size = new System.Drawing.Size(100, 20);
            this.tbFlightNumber.TabIndex = 55;
            // 
            // lbFlightNumber
            // 
            this.lbFlightNumber.AutoSize = true;
            this.lbFlightNumber.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFlightNumber.Location = new System.Drawing.Point(180, 226);
            this.lbFlightNumber.Name = "lbFlightNumber";
            this.lbFlightNumber.Size = new System.Drawing.Size(72, 13);
            this.lbFlightNumber.TabIndex = 54;
            this.lbFlightNumber.Text = "Flight Number";
            // 
            // tbFlightChildren
            // 
            this.tbFlightChildren.Location = new System.Drawing.Point(505, 254);
            this.tbFlightChildren.Name = "tbFlightChildren";
            this.tbFlightChildren.Size = new System.Drawing.Size(100, 20);
            this.tbFlightChildren.TabIndex = 64;
            // 
            // lbFlightChildren
            // 
            this.lbFlightChildren.AutoSize = true;
            this.lbFlightChildren.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFlightChildren.Location = new System.Drawing.Point(422, 257);
            this.lbFlightChildren.Name = "lbFlightChildren";
            this.lbFlightChildren.Size = new System.Drawing.Size(72, 13);
            this.lbFlightChildren.TabIndex = 63;
            this.lbFlightChildren.Text = "Children Price";
            // 
            // lbFlightBookingPaid
            // 
            this.lbFlightBookingPaid.AutoSize = true;
            this.lbFlightBookingPaid.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFlightBookingPaid.Location = new System.Drawing.Point(422, 289);
            this.lbFlightBookingPaid.Name = "lbFlightBookingPaid";
            this.lbFlightBookingPaid.Size = new System.Drawing.Size(70, 13);
            this.lbFlightBookingPaid.TabIndex = 67;
            this.lbFlightBookingPaid.Text = "Booking Paid";
            // 
            // tbFlightInfant
            // 
            this.tbFlightInfant.Location = new System.Drawing.Point(280, 286);
            this.tbFlightInfant.Name = "tbFlightInfant";
            this.tbFlightInfant.Size = new System.Drawing.Size(100, 20);
            this.tbFlightInfant.TabIndex = 66;
            // 
            // lbFlightInfant
            // 
            this.lbFlightInfant.AutoSize = true;
            this.lbFlightInfant.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbFlightInfant.Location = new System.Drawing.Point(184, 289);
            this.lbFlightInfant.Name = "lbFlightInfant";
            this.lbFlightInfant.Size = new System.Drawing.Size(61, 13);
            this.lbFlightInfant.TabIndex = 65;
            this.lbFlightInfant.Text = "Infant Price";
            // 
            // btnFlightSave
            // 
            this.btnFlightSave.Location = new System.Drawing.Point(391, 493);
            this.btnFlightSave.Name = "btnFlightSave";
            this.btnFlightSave.Size = new System.Drawing.Size(75, 23);
            this.btnFlightSave.TabIndex = 69;
            this.btnFlightSave.Text = "Save";
            this.btnFlightSave.UseVisualStyleBackColor = true;
            this.btnFlightSave.Click += new System.EventHandler(this.btnFlightSave_Click);
            // 
            // cbFlightPaid
            // 
            this.cbFlightPaid.AutoSize = true;
            this.cbFlightPaid.Location = new System.Drawing.Point(506, 288);
            this.cbFlightPaid.Name = "cbFlightPaid";
            this.cbFlightPaid.Size = new System.Drawing.Size(15, 14);
            this.cbFlightPaid.TabIndex = 70;
            this.cbFlightPaid.UseVisualStyleBackColor = true;
            // 
            // dtFlightBook
            // 
            this.dtFlightBook.Location = new System.Drawing.Point(280, 317);
            this.dtFlightBook.Name = "dtFlightBook";
            this.dtFlightBook.TabIndex = 71;
            // 
            // tbSearchFlight
            // 
            this.tbSearchFlight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbSearchFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchFlight.Location = new System.Drawing.Point(244, 173);
            this.tbSearchFlight.Multiline = true;
            this.tbSearchFlight.Name = "tbSearchFlight";
            this.tbSearchFlight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbSearchFlight.Size = new System.Drawing.Size(325, 44);
            this.tbSearchFlight.TabIndex = 73;
            this.tbSearchFlight.Text = "Search for a flight";
            this.tbSearchFlight.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btSearchFlight
            // 
            this.btSearchFlight.Location = new System.Drawing.Point(365, 249);
            this.btSearchFlight.Name = "btSearchFlight";
            this.btSearchFlight.Size = new System.Drawing.Size(75, 23);
            this.btSearchFlight.TabIndex = 74;
            this.btSearchFlight.Text = "search";
            this.btSearchFlight.UseVisualStyleBackColor = true;
            this.btSearchFlight.Click += new System.EventHandler(this.btSearchFlight_Click);
            // 
            // myDarkBg
            // 
            this.myDarkBg.BackColor = System.Drawing.SystemColors.ControlDark;
            this.myDarkBg.Image = global::CUESYSv._01.Properties.Resources.airplane;
            this.myDarkBg.Location = new System.Drawing.Point(12, 88);
            this.myDarkBg.Name = "myDarkBg";
            this.myDarkBg.Size = new System.Drawing.Size(779, 433);
            this.myDarkBg.TabIndex = 44;
            this.myDarkBg.TabStop = false;
            // 
            // lbEditFlight
            // 
            this.lbEditFlight.AutoSize = true;
            this.lbEditFlight.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbEditFlight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEditFlight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbEditFlight.Location = new System.Drawing.Point(319, 119);
            this.lbEditFlight.Name = "lbEditFlight";
            this.lbEditFlight.Size = new System.Drawing.Size(170, 29);
            this.lbEditFlight.TabIndex = 75;
            this.lbEditFlight.Text = "EDIT FLIGHT";
            // 
            // btnEditFlightSave
            // 
            this.btnEditFlightSave.Location = new System.Drawing.Point(391, 488);
            this.btnEditFlightSave.Name = "btnEditFlightSave";
            this.btnEditFlightSave.Size = new System.Drawing.Size(75, 23);
            this.btnEditFlightSave.TabIndex = 76;
            this.btnEditFlightSave.Text = "Save Edit";
            this.btnEditFlightSave.UseVisualStyleBackColor = true;
            this.btnEditFlightSave.Click += new System.EventHandler(this.btnEditFlightSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 520);
            this.Controls.Add(this.btnEditFlightSave);
            this.Controls.Add(this.lbEditFlight);
            this.Controls.Add(this.btSearchFlight);
            this.Controls.Add(this.cbFlightPaid);
            this.Controls.Add(this.btnFlightSave);
            this.Controls.Add(this.lbFlightBookingPaid);
            this.Controls.Add(this.tbFlightInfant);
            this.Controls.Add(this.tbFlightChildren);
            this.Controls.Add(this.lbFlightChildren);
            this.Controls.Add(this.tbFlightAdult);
            this.Controls.Add(this.tbFlightSeat);
            this.Controls.Add(this.lbFlightSeat);
            this.Controls.Add(this.tbFlightNumber);
            this.Controls.Add(this.tbFlightDestination);
            this.Controls.Add(this.lbFlightDestination);
            this.Controls.Add(this.tbFlightOrigin);
            this.Controls.Add(this.tbFlightAirline);
            this.Controls.Add(this.lbFlightAirline);
            this.Controls.Add(this.tbFlightCustContact);
            this.Controls.Add(this.btBook);
            this.Controls.Add(this.tbTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPaid);
            this.Controls.Add(this.tbCustomer);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.lbBookingInfo);
            this.Controls.Add(this.btCustDelete);
            this.Controls.Add(this.btCustUpdate);
            this.Controls.Add(this.btCustSave);
            this.Controls.Add(this.lbCustTitle);
            this.Controls.Add(this.tbCustPostcode);
            this.Controls.Add(this.lbCustPostcode);
            this.Controls.Add(this.tbCustTownCity);
            this.Controls.Add(this.lbCustTownCity);
            this.Controls.Add(this.tbCustAdd2);
            this.Controls.Add(this.lbCustAdd2);
            this.Controls.Add(this.tbCustAdd1);
            this.Controls.Add(this.lbCustAdd1);
            this.Controls.Add(this.tbCustTel);
            this.Controls.Add(this.lbCustTel);
            this.Controls.Add(this.tbCustEmail);
            this.Controls.Add(this.lbCustEmail);
            this.Controls.Add(this.tbCustContact);
            this.Controls.Add(this.lbCustContact);
            this.Controls.Add(this.cbBuilding);
            this.Controls.Add(this.cbFloor);
            this.Controls.Add(this.panClock);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.lbCueSys);
            this.Controls.Add(this.lbUserPass);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.tbUserPass);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.mainMenu);
            this.Controls.Add(this.dtFlightBook);
            this.Controls.Add(this.lbFlightInfant);
            this.Controls.Add(this.lbFlightAdult);
            this.Controls.Add(this.lbFlightBookDate);
            this.Controls.Add(this.lbFlightNumber);
            this.Controls.Add(this.lbFlightOrigin);
            this.Controls.Add(this.lbFlightCustContact);
            this.Controls.Add(this.tbSearchFlight);
            this.Controls.Add(this.lbBookFlight);
            this.Controls.Add(this.mcDate);
            this.Controls.Add(this.dgRoomBookingsSummary);
            this.Controls.Add(this.myDarkBg);
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panClock.ResumeLayout(false);
            this.panClock.PerformLayout();
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgRoomBookingsSummary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDarkBg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUserName;
        private System.Windows.Forms.TextBox tbUserPass;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label lbUserPass;
        private System.Windows.Forms.Label lbCueSys;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Panel panClock;
        private System.Windows.Forms.Label lbClockSeconds;
        private System.Windows.Forms.Label lbClockDate;
        private System.Windows.Forms.Label lbClockTime;
        private System.Windows.Forms.Timer timeClock;
        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewDevLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ComboBox cbFloor;
        private System.Windows.Forms.ComboBox cbBuilding;
        private System.Windows.Forms.ToolStripMenuItem createCustomerToolStripMenuItem;
        private System.Windows.Forms.Label lbCustContact;
        private System.Windows.Forms.TextBox tbCustContact;
        private System.Windows.Forms.TextBox tbCustEmail;
        private System.Windows.Forms.Label lbCustEmail;
        private System.Windows.Forms.TextBox tbCustTel;
        private System.Windows.Forms.Label lbCustTel;
        private System.Windows.Forms.TextBox tbCustTownCity;
        private System.Windows.Forms.Label lbCustTownCity;
        private System.Windows.Forms.TextBox tbCustAdd2;
        private System.Windows.Forms.Label lbCustAdd2;
        private System.Windows.Forms.TextBox tbCustAdd1;
        private System.Windows.Forms.Label lbCustAdd1;
        private System.Windows.Forms.TextBox tbCustPostcode;
        private System.Windows.Forms.Label lbCustPostcode;
        private System.Windows.Forms.Label lbCustTitle;
        private System.Windows.Forms.Button btCustSave;
        private System.Windows.Forms.Button btCustUpdate;
        private System.Windows.Forms.Button btCustDelete;
        private System.Windows.Forms.ToolStripMenuItem viewCustomersToolStripMenuItem;
        private System.Windows.Forms.Button btBook;
        private System.Windows.Forms.MaskedTextBox tbTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar mcDate;
        private System.Windows.Forms.CheckBox cbPaid;
        private System.Windows.Forms.TextBox tbCustomer;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.Label lbBookingInfo;
        private System.Windows.Forms.ToolStripMenuItem flightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewFlightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchFlightToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgRoomBookingsSummary;
        private System.Windows.Forms.PictureBox myDarkBg;
        private System.Windows.Forms.Label lbBookFlight;
        private System.Windows.Forms.Label lbFlightCustContact;
        private System.Windows.Forms.TextBox tbFlightCustContact;
        private System.Windows.Forms.TextBox tbFlightAirline;
        private System.Windows.Forms.Label lbFlightAirline;
        private System.Windows.Forms.TextBox tbFlightDestination;
        private System.Windows.Forms.Label lbFlightDestination;
        private System.Windows.Forms.TextBox tbFlightOrigin;
        private System.Windows.Forms.Label lbFlightOrigin;
        private System.Windows.Forms.TextBox tbFlightAdult;
        private System.Windows.Forms.Label lbFlightAdult;
        private System.Windows.Forms.Label lbFlightBookDate;
        private System.Windows.Forms.TextBox tbFlightSeat;
        private System.Windows.Forms.Label lbFlightSeat;
        private System.Windows.Forms.TextBox tbFlightNumber;
        private System.Windows.Forms.Label lbFlightNumber;
        private System.Windows.Forms.TextBox tbFlightChildren;
        private System.Windows.Forms.Label lbFlightChildren;
        private System.Windows.Forms.Label lbFlightBookingPaid;
        private System.Windows.Forms.TextBox tbFlightInfant;
        private System.Windows.Forms.Label lbFlightInfant;
        private System.Windows.Forms.Button btnFlightSave;
        private System.Windows.Forms.CheckBox cbFlightPaid;
        private System.Windows.Forms.MonthCalendar dtFlightBook;
        private System.Windows.Forms.TextBox tbSearchFlight;
        private System.Windows.Forms.Button btSearchFlight;
        private System.Windows.Forms.Label lbEditFlight;
        private System.Windows.Forms.Button btnEditFlightSave;
    }
}

