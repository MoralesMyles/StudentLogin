namespace Garica0211
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.btnNewStudent = new System.Windows.Forms.Button();
            this.Logout = new System.Windows.Forms.Button();
            this.Logs = new System.Windows.Forms.Button();
            this.btnInactiveStudents = new System.Windows.Forms.Button();
            this.btnActiveStudents = new System.Windows.Forms.Button();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.gbActiveStudents = new System.Windows.Forms.GroupBox();
            this.lblActiveAmount = new System.Windows.Forms.Label();
            this.gbInactiveStudents = new System.Windows.Forms.GroupBox();
            this.lblInactiveAmount = new System.Windows.Forms.Label();
            this.gbGender = new System.Windows.Forms.GroupBox();
            this.lblFemaleAmount = new System.Windows.Forms.Label();
            this.lblMaleAmount = new System.Windows.Forms.Label();
            this.lblFemaleTitle = new System.Windows.Forms.Label();
            this.lblMaleTitle = new System.Windows.Forms.Label();
            this.gbCourse = new System.Windows.Forms.GroupBox();
            this.lblBSCECount = new System.Windows.Forms.Label();
            this.lblBSCE = new System.Windows.Forms.Label();
            this.lblBScSCount = new System.Windows.Forms.Label();
            this.lblBScS = new System.Windows.Forms.Label();
            this.lblBEEDCount = new System.Windows.Forms.Label();
            this.lblBEED = new System.Windows.Forms.Label();
            this.lblBSITCount = new System.Windows.Forms.Label();
            this.lblBSIT = new System.Windows.Forms.Label();
            this.gbHobbies = new System.Windows.Forms.GroupBox();
            this.lblVolleyballAmount = new System.Windows.Forms.Label();
            this.lblBasketballCount = new System.Windows.Forms.Label();
            this.lblVolleyballTitle = new System.Windows.Forms.Label();
            this.lblBasketballTitle = new System.Windows.Forms.Label();
            this.tmrRefresh = new System.Windows.Forms.Timer(this.components);
            this.lblHybridCount = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.gbActiveStudents.SuspendLayout();
            this.gbInactiveStudents.SuspendLayout();
            this.gbGender.SuspendLayout();
            this.gbCourse.SuspendLayout();
            this.gbHobbies.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMenu
            // 
            this.gbMenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gbMenu.Controls.Add(this.picProfile);
            this.gbMenu.Controls.Add(this.btnNewStudent);
            this.gbMenu.Controls.Add(this.Logout);
            this.gbMenu.Controls.Add(this.Logs);
            this.gbMenu.Controls.Add(this.btnInactiveStudents);
            this.gbMenu.Controls.Add(this.btnActiveStudents);
            this.gbMenu.Controls.Add(this.lblDashboardTitle);
            this.gbMenu.Controls.Add(this.lblDate);
            this.gbMenu.Controls.Add(this.lblName);
            this.gbMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbMenu.Location = new System.Drawing.Point(-2, -12);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(210, 436);
            this.gbMenu.TabIndex = 0;
            this.gbMenu.TabStop = false;
            // 
            // picProfile
            // 
            this.picProfile.Image = ((System.Drawing.Image)(resources.GetObject("picProfile.Image")));
            this.picProfile.Location = new System.Drawing.Point(46, 18);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(118, 107);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picProfile.TabIndex = 8;
            this.picProfile.TabStop = false;
            // 
            // btnNewStudent
            // 
            this.btnNewStudent.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewStudent.Location = new System.Drawing.Point(46, 255);
            this.btnNewStudent.Name = "btnNewStudent";
            this.btnNewStudent.Size = new System.Drawing.Size(112, 32);
            this.btnNewStudent.TabIndex = 7;
            this.btnNewStudent.Text = "New Student";
            this.btnNewStudent.UseVisualStyleBackColor = true;
            this.btnNewStudent.Click += new System.EventHandler(this.btnNewStudent_Click);
            // 
            // Logout
            // 
            this.Logout.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logout.Location = new System.Drawing.Point(46, 373);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(112, 32);
            this.Logout.TabIndex = 6;
            this.Logout.Text = "Logout";
            this.Logout.UseVisualStyleBackColor = true;
            this.Logout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // Logs
            // 
            this.Logs.Font = new System.Drawing.Font("Lucida Bright", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logs.Location = new System.Drawing.Point(46, 335);
            this.Logs.Name = "Logs";
            this.Logs.Size = new System.Drawing.Size(112, 32);
            this.Logs.TabIndex = 5;
            this.Logs.Text = "Logs";
            this.Logs.UseVisualStyleBackColor = true;
            this.Logs.Click += new System.EventHandler(this.Logs_Click);
            // 
            // btnInactiveStudents
            // 
            this.btnInactiveStudents.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInactiveStudents.Location = new System.Drawing.Point(46, 297);
            this.btnInactiveStudents.Name = "btnInactiveStudents";
            this.btnInactiveStudents.Size = new System.Drawing.Size(112, 32);
            this.btnInactiveStudents.TabIndex = 4;
            this.btnInactiveStudents.Text = "Inactive Students";
            this.btnInactiveStudents.UseVisualStyleBackColor = true;
            this.btnInactiveStudents.Click += new System.EventHandler(this.btnInactiveStudents_Click);
            // 
            // btnActiveStudents
            // 
            this.btnActiveStudents.Font = new System.Drawing.Font("Lucida Bright", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActiveStudents.Location = new System.Drawing.Point(46, 217);
            this.btnActiveStudents.Name = "btnActiveStudents";
            this.btnActiveStudents.Size = new System.Drawing.Size(112, 32);
            this.btnActiveStudents.TabIndex = 3;
            this.btnActiveStudents.Text = "Active Students";
            this.btnActiveStudents.UseVisualStyleBackColor = true;
            this.btnActiveStudents.Click += new System.EventHandler(this.btnActiveStudents_Click);
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Franklin Gothic Heavy", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardTitle.Location = new System.Drawing.Point(41, 180);
            this.lblDashboardTitle.Name = "lblDashboardTitle";
            this.lblDashboardTitle.Size = new System.Drawing.Size(123, 24);
            this.lblDashboardTitle.TabIndex = 2;
            this.lblDashboardTitle.Text = "DASHBOARD";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(61, 150);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(85, 16);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "00/00/0000";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(71, 130);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "<Name>";
            // 
            // gbActiveStudents
            // 
            this.gbActiveStudents.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbActiveStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbActiveStudents.Controls.Add(this.lblActiveAmount);
            this.gbActiveStudents.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbActiveStudents.Location = new System.Drawing.Point(208, 12);
            this.gbActiveStudents.Name = "gbActiveStudents";
            this.gbActiveStudents.Size = new System.Drawing.Size(184, 160);
            this.gbActiveStudents.TabIndex = 1;
            this.gbActiveStudents.TabStop = false;
            this.gbActiveStudents.Text = "Active Students";
            // 
            // lblActiveAmount
            // 
            this.lblActiveAmount.AutoSize = true;
            this.lblActiveAmount.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblActiveAmount.Location = new System.Drawing.Point(67, 70);
            this.lblActiveAmount.Name = "lblActiveAmount";
            this.lblActiveAmount.Size = new System.Drawing.Size(156, 31);
            this.lblActiveAmount.TabIndex = 0;
            this.lblActiveAmount.Text = "<AMOUNT>";
            // 
            // gbInactiveStudents
            // 
            this.gbInactiveStudents.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbInactiveStudents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbInactiveStudents.Controls.Add(this.lblInactiveAmount);
            this.gbInactiveStudents.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInactiveStudents.Location = new System.Drawing.Point(414, 12);
            this.gbInactiveStudents.Name = "gbInactiveStudents";
            this.gbInactiveStudents.Size = new System.Drawing.Size(184, 160);
            this.gbInactiveStudents.TabIndex = 2;
            this.gbInactiveStudents.TabStop = false;
            this.gbInactiveStudents.Text = "Inactive Students";
            // 
            // lblInactiveAmount
            // 
            this.lblInactiveAmount.AutoSize = true;
            this.lblInactiveAmount.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInactiveAmount.Location = new System.Drawing.Point(67, 70);
            this.lblInactiveAmount.Name = "lblInactiveAmount";
            this.lblInactiveAmount.Size = new System.Drawing.Size(156, 31);
            this.lblInactiveAmount.TabIndex = 1;
            this.lblInactiveAmount.Text = "<AMOUNT>";
            // 
            // gbGender
            // 
            this.gbGender.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbGender.Controls.Add(this.lblFemaleAmount);
            this.gbGender.Controls.Add(this.lblMaleAmount);
            this.gbGender.Controls.Add(this.lblFemaleTitle);
            this.gbGender.Controls.Add(this.lblMaleTitle);
            this.gbGender.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbGender.Location = new System.Drawing.Point(620, 210);
            this.gbGender.Name = "gbGender";
            this.gbGender.Size = new System.Drawing.Size(168, 160);
            this.gbGender.TabIndex = 2;
            this.gbGender.TabStop = false;
            this.gbGender.Text = "Gender";
            // 
            // lblFemaleAmount
            // 
            this.lblFemaleAmount.AutoSize = true;
            this.lblFemaleAmount.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFemaleAmount.Location = new System.Drawing.Point(106, 105);
            this.lblFemaleAmount.Name = "lblFemaleAmount";
            this.lblFemaleAmount.Size = new System.Drawing.Size(49, 16);
            this.lblFemaleAmount.TabIndex = 5;
            this.lblFemaleAmount.Text = "<AMT>";
            // 
            // lblMaleAmount
            // 
            this.lblMaleAmount.AutoSize = true;
            this.lblMaleAmount.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaleAmount.Location = new System.Drawing.Point(106, 39);
            this.lblMaleAmount.Name = "lblMaleAmount";
            this.lblMaleAmount.Size = new System.Drawing.Size(49, 16);
            this.lblMaleAmount.TabIndex = 4;
            this.lblMaleAmount.Text = "<AMT>";
            // 
            // lblFemaleTitle
            // 
            this.lblFemaleTitle.AutoSize = true;
            this.lblFemaleTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFemaleTitle.Location = new System.Drawing.Point(6, 97);
            this.lblFemaleTitle.Name = "lblFemaleTitle";
            this.lblFemaleTitle.Size = new System.Drawing.Size(87, 27);
            this.lblFemaleTitle.TabIndex = 3;
            this.lblFemaleTitle.Text = "Female:";
            // 
            // lblMaleTitle
            // 
            this.lblMaleTitle.AutoSize = true;
            this.lblMaleTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaleTitle.Location = new System.Drawing.Point(6, 33);
            this.lblMaleTitle.Name = "lblMaleTitle";
            this.lblMaleTitle.Size = new System.Drawing.Size(66, 27);
            this.lblMaleTitle.TabIndex = 2;
            this.lblMaleTitle.Text = "Male:";
            // 
            // gbCourse
            // 
            this.gbCourse.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbCourse.Controls.Add(this.lblBSCECount);
            this.gbCourse.Controls.Add(this.lblBSCE);
            this.gbCourse.Controls.Add(this.lblBScSCount);
            this.gbCourse.Controls.Add(this.lblBScS);
            this.gbCourse.Controls.Add(this.lblBEEDCount);
            this.gbCourse.Controls.Add(this.lblBEED);
            this.gbCourse.Controls.Add(this.lblBSITCount);
            this.gbCourse.Controls.Add(this.lblBSIT);
            this.gbCourse.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCourse.Location = new System.Drawing.Point(414, 210);
            this.gbCourse.Name = "gbCourse";
            this.gbCourse.Size = new System.Drawing.Size(184, 160);
            this.gbCourse.TabIndex = 4;
            this.gbCourse.TabStop = false;
            this.gbCourse.Text = "Course";
            // 
            // lblBSCECount
            // 
            this.lblBSCECount.AutoSize = true;
            this.lblBSCECount.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBSCECount.Location = new System.Drawing.Point(116, 136);
            this.lblBSCECount.Name = "lblBSCECount";
            this.lblBSCECount.Size = new System.Drawing.Size(67, 21);
            this.lblBSCECount.TabIndex = 14;
            this.lblBSCECount.Text = "<AMT>";
            // 
            // lblBSCE
            // 
            this.lblBSCE.AutoSize = true;
            this.lblBSCE.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBSCE.Location = new System.Drawing.Point(7, 134);
            this.lblBSCE.Name = "lblBSCE";
            this.lblBSCE.Size = new System.Drawing.Size(67, 27);
            this.lblBSCE.TabIndex = 13;
            this.lblBSCE.Text = "BSCE:";
            // 
            // lblBScSCount
            // 
            this.lblBScSCount.AutoSize = true;
            this.lblBScSCount.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBScSCount.Location = new System.Drawing.Point(116, 99);
            this.lblBScSCount.Name = "lblBScSCount";
            this.lblBScSCount.Size = new System.Drawing.Size(67, 21);
            this.lblBScSCount.TabIndex = 12;
            this.lblBScSCount.Text = "<AMT>";
            // 
            // lblBScS
            // 
            this.lblBScS.AutoSize = true;
            this.lblBScS.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBScS.Location = new System.Drawing.Point(10, 97);
            this.lblBScS.Name = "lblBScS";
            this.lblBScS.Size = new System.Drawing.Size(65, 27);
            this.lblBScS.TabIndex = 11;
            this.lblBScS.Text = "BScS:";
            // 
            // lblBEEDCount
            // 
            this.lblBEEDCount.AutoSize = true;
            this.lblBEEDCount.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBEEDCount.Location = new System.Drawing.Point(116, 62);
            this.lblBEEDCount.Name = "lblBEEDCount";
            this.lblBEEDCount.Size = new System.Drawing.Size(67, 21);
            this.lblBEEDCount.TabIndex = 10;
            this.lblBEEDCount.Text = "<AMT>";
            // 
            // lblBEED
            // 
            this.lblBEED.AutoSize = true;
            this.lblBEED.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBEED.Location = new System.Drawing.Point(6, 60);
            this.lblBEED.Name = "lblBEED";
            this.lblBEED.Size = new System.Drawing.Size(68, 27);
            this.lblBEED.TabIndex = 9;
            this.lblBEED.Text = "BEED:";
            // 
            // lblBSITCount
            // 
            this.lblBSITCount.AutoSize = true;
            this.lblBSITCount.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBSITCount.Location = new System.Drawing.Point(116, 25);
            this.lblBSITCount.Name = "lblBSITCount";
            this.lblBSITCount.Size = new System.Drawing.Size(67, 21);
            this.lblBSITCount.TabIndex = 8;
            this.lblBSITCount.Text = "<AMT>";
            // 
            // lblBSIT
            // 
            this.lblBSIT.AutoSize = true;
            this.lblBSIT.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBSIT.Location = new System.Drawing.Point(11, 23);
            this.lblBSIT.Name = "lblBSIT";
            this.lblBSIT.Size = new System.Drawing.Size(62, 27);
            this.lblBSIT.TabIndex = 7;
            this.lblBSIT.Text = "BSIT:";
            // 
            // gbHobbies
            // 
            this.gbHobbies.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gbHobbies.Controls.Add(this.lblVolleyballAmount);
            this.gbHobbies.Controls.Add(this.lblBasketballCount);
            this.gbHobbies.Controls.Add(this.lblVolleyballTitle);
            this.gbHobbies.Controls.Add(this.lblBasketballTitle);
            this.gbHobbies.Font = new System.Drawing.Font("Lucida Console", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbHobbies.Location = new System.Drawing.Point(208, 210);
            this.gbHobbies.Name = "gbHobbies";
            this.gbHobbies.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbHobbies.Size = new System.Drawing.Size(184, 160);
            this.gbHobbies.TabIndex = 3;
            this.gbHobbies.TabStop = false;
            this.gbHobbies.Text = "Hobbies";
            // 
            // lblVolleyballAmount
            // 
            this.lblVolleyballAmount.AutoSize = true;
            this.lblVolleyballAmount.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolleyballAmount.Location = new System.Drawing.Point(138, 96);
            this.lblVolleyballAmount.Name = "lblVolleyballAmount";
            this.lblVolleyballAmount.Size = new System.Drawing.Size(67, 21);
            this.lblVolleyballAmount.TabIndex = 7;
            this.lblVolleyballAmount.Text = "<AMT>";
            // 
            // lblBasketballCount
            // 
            this.lblBasketballCount.AutoSize = true;
            this.lblBasketballCount.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasketballCount.Location = new System.Drawing.Point(138, 35);
            this.lblBasketballCount.Name = "lblBasketballCount";
            this.lblBasketballCount.Size = new System.Drawing.Size(67, 21);
            this.lblBasketballCount.TabIndex = 6;
            this.lblBasketballCount.Text = "<AMT>";
            // 
            // lblVolleyballTitle
            // 
            this.lblVolleyballTitle.AutoSize = true;
            this.lblVolleyballTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolleyballTitle.Location = new System.Drawing.Point(6, 91);
            this.lblVolleyballTitle.Name = "lblVolleyballTitle";
            this.lblVolleyballTitle.Size = new System.Drawing.Size(115, 27);
            this.lblVolleyballTitle.TabIndex = 2;
            this.lblVolleyballTitle.Text = "Volleyball:";
            // 
            // lblBasketballTitle
            // 
            this.lblBasketballTitle.AutoSize = true;
            this.lblBasketballTitle.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasketballTitle.Location = new System.Drawing.Point(6, 30);
            this.lblBasketballTitle.Name = "lblBasketballTitle";
            this.lblBasketballTitle.Size = new System.Drawing.Size(118, 27);
            this.lblBasketballTitle.TabIndex = 1;
            this.lblBasketballTitle.Text = "Basketball:";
            // 
            // tmrRefresh
            // 
            this.tmrRefresh.Tick += new System.EventHandler(this.tmrRefresh_Tick);
            // 
            // lblHybridCount
            // 
            this.lblHybridCount.AutoSize = true;
            this.lblHybridCount.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHybridCount.Location = new System.Drawing.Point(240, 378);
            this.lblHybridCount.Name = "lblHybridCount";
            this.lblHybridCount.Size = new System.Drawing.Size(104, 21);
            this.lblHybridCount.TabIndex = 5;
            this.lblHybridCount.Text = "<AMOUNT>";
            this.lblHybridCount.Visible = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(720, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(82, 29);
            this.btnExit.TabIndex = 45;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblHybridCount);
            this.Controls.Add(this.gbCourse);
            this.Controls.Add(this.gbHobbies);
            this.Controls.Add(this.gbGender);
            this.Controls.Add(this.gbInactiveStudents);
            this.Controls.Add(this.gbActiveStudents);
            this.Controls.Add(this.gbMenu);
            this.Name = "DashBoard";
            this.Text = "DashBoard";
            this.gbMenu.ResumeLayout(false);
            this.gbMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.gbActiveStudents.ResumeLayout(false);
            this.gbActiveStudents.PerformLayout();
            this.gbInactiveStudents.ResumeLayout(false);
            this.gbInactiveStudents.PerformLayout();
            this.gbGender.ResumeLayout(false);
            this.gbGender.PerformLayout();
            this.gbCourse.ResumeLayout(false);
            this.gbCourse.PerformLayout();
            this.gbHobbies.ResumeLayout(false);
            this.gbHobbies.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Timer tmrRefresh;
        public System.Windows.Forms.Label lblBSCECount;
        public System.Windows.Forms.Label lblBSCE;
        public System.Windows.Forms.Label lblBScSCount;
        public System.Windows.Forms.Label lblBScS;
        public System.Windows.Forms.Label lblBEEDCount;
        public System.Windows.Forms.Label lblBEED;
        public System.Windows.Forms.Label lblBSITCount;
        public System.Windows.Forms.Label lblBSIT;
        public System.Windows.Forms.GroupBox gbMenu;
        public System.Windows.Forms.GroupBox gbActiveStudents;
        public System.Windows.Forms.GroupBox gbInactiveStudents;
        public System.Windows.Forms.GroupBox gbGender;
        public System.Windows.Forms.GroupBox gbCourse;
        public System.Windows.Forms.GroupBox gbHobbies;
        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.Button Logout;
        public System.Windows.Forms.Button Logs;
        public System.Windows.Forms.Button btnInactiveStudents;
        public System.Windows.Forms.Button btnActiveStudents;
        public System.Windows.Forms.Label lblDashboardTitle;
        public System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lblActiveAmount;
        public System.Windows.Forms.Label lblInactiveAmount;
        public System.Windows.Forms.Label lblFemaleAmount;
        public System.Windows.Forms.Label lblMaleAmount;
        public System.Windows.Forms.Label lblFemaleTitle;
        public System.Windows.Forms.Label lblMaleTitle;
        public System.Windows.Forms.Label lblVolleyballTitle;
        public System.Windows.Forms.Label lblBasketballTitle;
        public System.Windows.Forms.Label lblVolleyballAmount;
        public System.Windows.Forms.Label lblBasketballCount;
        public System.Windows.Forms.Label lblHybridCount;
        public System.Windows.Forms.Button btnNewStudent;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picProfile;
    }
}