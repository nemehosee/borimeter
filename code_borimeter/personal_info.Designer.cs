namespace Borimeter
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.lay_MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_MainControl = new System.Windows.Forms.Panel();
            this.box_Controls = new System.Windows.Forms.GroupBox();
            this.btn_Finish = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.pnl_PersonalInfo = new System.Windows.Forms.Panel();
            this.Studies = new System.Windows.Forms.GroupBox();
            this.cmb_Year = new System.Windows.Forms.ComboBox();
            this.lbl_Year = new System.Windows.Forms.Label();
            this.lbl_Degree = new System.Windows.Forms.Label();
            this.cmb_Degree = new System.Windows.Forms.ComboBox();
            this.lbl_Speciality = new System.Windows.Forms.Label();
            this.txt_Speciality = new System.Windows.Forms.TextBox();
            this.lbl_University = new System.Windows.Forms.Label();
            this.txt_University = new System.Windows.Forms.TextBox();
            this.TestSet = new System.Windows.Forms.GroupBox();
            this.lbl_TestSet = new System.Windows.Forms.Label();
            this.cmb_TestSet = new System.Windows.Forms.ComboBox();
            this.Information = new System.Windows.Forms.GroupBox();
            this.InfoTextBox = new System.Windows.Forms.RichTextBox();
            this.PersonalInfo = new System.Windows.Forms.GroupBox();
            this.cmb_Gender = new System.Windows.Forms.ComboBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.num_Age = new System.Windows.Forms.NumericUpDown();
            this.pnl_PictureCtrl = new System.Windows.Forms.Panel();
            this.box_TestControls = new System.Windows.Forms.GroupBox();
            this.btn_GotIt = new System.Windows.Forms.Button();
            this.btn_Complete = new System.Windows.Forms.Button();
            this.btn_NextPicture = new System.Windows.Forms.Button();
            this.btn_NextTrial = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Category = new System.Windows.Forms.TextBox();
            this.txt_Description = new System.Windows.Forms.TextBox();
            this.lbl_Category = new System.Windows.Forms.Label();
            this.pnl_PictureArea = new System.Windows.Forms.Panel();
            this.box_Image = new System.Windows.Forms.GroupBox();
            this.box_PictureArea = new System.Windows.Forms.PictureBox();
            this.TestTime = new System.Windows.Forms.Timer(this.components);
            this.lay_MainLayout.SuspendLayout();
            this.pnl_MainControl.SuspendLayout();
            this.box_Controls.SuspendLayout();
            this.pnl_PersonalInfo.SuspendLayout();
            this.Studies.SuspendLayout();
            this.TestSet.SuspendLayout();
            this.Information.SuspendLayout();
            this.PersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Age)).BeginInit();
            this.pnl_PictureCtrl.SuspendLayout();
            this.box_TestControls.SuspendLayout();
            this.pnl_PictureArea.SuspendLayout();
            this.box_Image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.box_PictureArea)).BeginInit();
            this.SuspendLayout();
            // 
            // lay_MainLayout
            // 
            this.lay_MainLayout.ColumnCount = 2;
            this.lay_MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.lay_MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lay_MainLayout.Controls.Add(this.pnl_MainControl, 0, 1);
            this.lay_MainLayout.Controls.Add(this.pnl_PersonalInfo, 0, 0);
            this.lay_MainLayout.Controls.Add(this.pnl_PictureCtrl, 1, 1);
            this.lay_MainLayout.Controls.Add(this.pnl_PictureArea, 1, 0);
            this.lay_MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lay_MainLayout.Location = new System.Drawing.Point(0, 0);
            this.lay_MainLayout.Name = "lay_MainLayout";
            this.lay_MainLayout.RowCount = 2;
            this.lay_MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.lay_MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.lay_MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.lay_MainLayout.Size = new System.Drawing.Size(980, 787);
            this.lay_MainLayout.TabIndex = 11;
            this.lay_MainLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.MainTableLayout_Paint);
            // 
            // pnl_MainControl
            // 
            this.pnl_MainControl.Controls.Add(this.box_Controls);
            this.pnl_MainControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_MainControl.Location = new System.Drawing.Point(3, 719);
            this.pnl_MainControl.Name = "pnl_MainControl";
            this.pnl_MainControl.Size = new System.Drawing.Size(234, 65);
            this.pnl_MainControl.TabIndex = 1;
            // 
            // box_Controls
            // 
            this.box_Controls.Controls.Add(this.btn_Finish);
            this.box_Controls.Controls.Add(this.btn_Start);
            this.box_Controls.Controls.Add(this.btn_Submit);
            this.box_Controls.Location = new System.Drawing.Point(4, 5);
            this.box_Controls.Name = "box_Controls";
            this.box_Controls.Size = new System.Drawing.Size(226, 54);
            this.box_Controls.TabIndex = 0;
            this.box_Controls.TabStop = false;
            this.box_Controls.Text = "Controls";
            // 
            // btn_Finish
            // 
            this.btn_Finish.Enabled = false;
            this.btn_Finish.Location = new System.Drawing.Point(153, 19);
            this.btn_Finish.Name = "btn_Finish";
            this.btn_Finish.Size = new System.Drawing.Size(68, 23);
            this.btn_Finish.TabIndex = 13;
            this.btn_Finish.Text = "Finish";
            this.btn_Finish.UseVisualStyleBackColor = true;
            this.btn_Finish.Click += new System.EventHandler(this.FinishButton_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Enabled = false;
            this.btn_Start.Location = new System.Drawing.Point(79, 19);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(68, 23);
            this.btn_Start.TabIndex = 12;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(5, 19);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(68, 23);
            this.btn_Submit.TabIndex = 11;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // pnl_PersonalInfo
            // 
            this.pnl_PersonalInfo.Controls.Add(this.Studies);
            this.pnl_PersonalInfo.Controls.Add(this.TestSet);
            this.pnl_PersonalInfo.Controls.Add(this.Information);
            this.pnl_PersonalInfo.Controls.Add(this.PersonalInfo);
            this.pnl_PersonalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_PersonalInfo.Location = new System.Drawing.Point(3, 3);
            this.pnl_PersonalInfo.Name = "pnl_PersonalInfo";
            this.pnl_PersonalInfo.Size = new System.Drawing.Size(234, 710);
            this.pnl_PersonalInfo.TabIndex = 0;
            // 
            // Studies
            // 
            this.Studies.Controls.Add(this.cmb_Year);
            this.Studies.Controls.Add(this.lbl_Year);
            this.Studies.Controls.Add(this.lbl_Degree);
            this.Studies.Controls.Add(this.cmb_Degree);
            this.Studies.Controls.Add(this.lbl_Speciality);
            this.Studies.Controls.Add(this.txt_Speciality);
            this.Studies.Controls.Add(this.lbl_University);
            this.Studies.Controls.Add(this.txt_University);
            this.Studies.Location = new System.Drawing.Point(3, 149);
            this.Studies.Name = "Studies";
            this.Studies.Size = new System.Drawing.Size(226, 195);
            this.Studies.TabIndex = 2;
            this.Studies.TabStop = false;
            this.Studies.Text = "Studies";
            // 
            // cmb_Year
            // 
            this.cmb_Year.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Year.FormattingEnabled = true;
            this.cmb_Year.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year",
            "5th Year",
            "6th Year"});
            this.cmb_Year.Location = new System.Drawing.Point(85, 138);
            this.cmb_Year.Name = "cmb_Year";
            this.cmb_Year.Size = new System.Drawing.Size(136, 21);
            this.cmb_Year.TabIndex = 7;
            // 
            // lbl_Year
            // 
            this.lbl_Year.AutoSize = true;
            this.lbl_Year.Location = new System.Drawing.Point(6, 141);
            this.lbl_Year.Name = "lbl_Year";
            this.lbl_Year.Size = new System.Drawing.Size(66, 13);
            this.lbl_Year.TabIndex = 21;
            this.lbl_Year.Text = "Year/Grade:";
            // 
            // lbl_Degree
            // 
            this.lbl_Degree.AutoSize = true;
            this.lbl_Degree.Location = new System.Drawing.Point(6, 168);
            this.lbl_Degree.Name = "lbl_Degree";
            this.lbl_Degree.Size = new System.Drawing.Size(49, 13);
            this.lbl_Degree.TabIndex = 20;
            this.lbl_Degree.Text = "Degree*:";
            // 
            // cmb_Degree
            // 
            this.cmb_Degree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Degree.FormattingEnabled = true;
            this.cmb_Degree.Items.AddRange(new object[] {
            "Master (MA)",
            "Bachelor (BA)"});
            this.cmb_Degree.Location = new System.Drawing.Point(85, 165);
            this.cmb_Degree.Name = "cmb_Degree";
            this.cmb_Degree.Size = new System.Drawing.Size(136, 21);
            this.cmb_Degree.TabIndex = 8;
            // 
            // lbl_Speciality
            // 
            this.lbl_Speciality.AutoSize = true;
            this.lbl_Speciality.Location = new System.Drawing.Point(6, 29);
            this.lbl_Speciality.Name = "lbl_Speciality";
            this.lbl_Speciality.Size = new System.Drawing.Size(55, 13);
            this.lbl_Speciality.TabIndex = 17;
            this.lbl_Speciality.Text = "Speciality:";
            // 
            // txt_Speciality
            // 
            this.txt_Speciality.Location = new System.Drawing.Point(85, 26);
            this.txt_Speciality.Multiline = true;
            this.txt_Speciality.Name = "txt_Speciality";
            this.txt_Speciality.Size = new System.Drawing.Size(136, 50);
            this.txt_Speciality.TabIndex = 5;
            // 
            // lbl_University
            // 
            this.lbl_University.AutoSize = true;
            this.lbl_University.Location = new System.Drawing.Point(6, 85);
            this.lbl_University.Name = "lbl_University";
            this.lbl_University.Size = new System.Drawing.Size(63, 13);
            this.lbl_University.TabIndex = 12;
            this.lbl_University.Text = "University* :";
            // 
            // txt_University
            // 
            this.txt_University.Location = new System.Drawing.Point(85, 82);
            this.txt_University.Multiline = true;
            this.txt_University.Name = "txt_University";
            this.txt_University.Size = new System.Drawing.Size(136, 50);
            this.txt_University.TabIndex = 6;
            // 
            // TestSet
            // 
            this.TestSet.Controls.Add(this.lbl_TestSet);
            this.TestSet.Controls.Add(this.cmb_TestSet);
            this.TestSet.Location = new System.Drawing.Point(3, 350);
            this.TestSet.Name = "TestSet";
            this.TestSet.Size = new System.Drawing.Size(226, 49);
            this.TestSet.TabIndex = 3;
            this.TestSet.TabStop = false;
            this.TestSet.Text = "Test set";
            // 
            // lbl_TestSet
            // 
            this.lbl_TestSet.AutoSize = true;
            this.lbl_TestSet.Location = new System.Drawing.Point(6, 23);
            this.lbl_TestSet.Name = "lbl_TestSet";
            this.lbl_TestSet.Size = new System.Drawing.Size(63, 13);
            this.lbl_TestSet.TabIndex = 1;
            this.lbl_TestSet.Text = "Choose set:";
            // 
            // cmb_TestSet
            // 
            this.cmb_TestSet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_TestSet.FormattingEnabled = true;
            this.cmb_TestSet.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cmb_TestSet.Location = new System.Drawing.Point(85, 20);
            this.cmb_TestSet.Name = "cmb_TestSet";
            this.cmb_TestSet.Size = new System.Drawing.Size(136, 21);
            this.cmb_TestSet.TabIndex = 9;
            // 
            // Information
            // 
            this.Information.Controls.Add(this.InfoTextBox);
            this.Information.Location = new System.Drawing.Point(3, 405);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(226, 296);
            this.Information.TabIndex = 0;
            this.Information.TabStop = false;
            this.Information.Text = "Information";
            // 
            // InfoTextBox
            // 
            this.InfoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InfoTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.InfoTextBox.Location = new System.Drawing.Point(4, 20);
            this.InfoTextBox.Name = "InfoTextBox";
            this.InfoTextBox.ReadOnly = true;
            this.InfoTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.InfoTextBox.Size = new System.Drawing.Size(216, 270);
            this.InfoTextBox.TabIndex = 0;
            this.InfoTextBox.Text = "";
            // 
            // PersonalInfo
            // 
            this.PersonalInfo.Controls.Add(this.cmb_Gender);
            this.PersonalInfo.Controls.Add(this.lbl_Name);
            this.PersonalInfo.Controls.Add(this.txt_Name);
            this.PersonalInfo.Controls.Add(this.txt_Surname);
            this.PersonalInfo.Controls.Add(this.lbl_Surname);
            this.PersonalInfo.Controls.Add(this.lbl_Gender);
            this.PersonalInfo.Controls.Add(this.lbl_Age);
            this.PersonalInfo.Controls.Add(this.num_Age);
            this.PersonalInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.PersonalInfo.Location = new System.Drawing.Point(3, 9);
            this.PersonalInfo.Name = "PersonalInfo";
            this.PersonalInfo.Size = new System.Drawing.Size(226, 134);
            this.PersonalInfo.TabIndex = 1;
            this.PersonalInfo.TabStop = false;
            this.PersonalInfo.Text = "Personal information";
            // 
            // cmb_Gender
            // 
            this.cmb_Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Gender.FormattingEnabled = true;
            this.cmb_Gender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cmb_Gender.Location = new System.Drawing.Point(85, 78);
            this.cmb_Gender.Name = "cmb_Gender";
            this.cmb_Gender.Size = new System.Drawing.Size(136, 21);
            this.cmb_Gender.TabIndex = 3;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(6, 24);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(38, 13);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(85, 24);
            this.txt_Name.MaxLength = 20;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(136, 20);
            this.txt_Name.TabIndex = 1;
            // 
            // txt_Surname
            // 
            this.txt_Surname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Surname.Location = new System.Drawing.Point(85, 51);
            this.txt_Surname.MaxLength = 20;
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(136, 20);
            this.txt_Surname.TabIndex = 2;
            // 
            // lbl_Surname
            // 
            this.lbl_Surname.AutoSize = true;
            this.lbl_Surname.Location = new System.Drawing.Point(6, 54);
            this.lbl_Surname.Name = "lbl_Surname";
            this.lbl_Surname.Size = new System.Drawing.Size(52, 13);
            this.lbl_Surname.TabIndex = 3;
            this.lbl_Surname.Text = "Surname:";
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.AutoSize = true;
            this.lbl_Gender.Location = new System.Drawing.Point(6, 79);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(45, 13);
            this.lbl_Gender.TabIndex = 6;
            this.lbl_Gender.Text = "Gender:";
            // 
            // lbl_Age
            // 
            this.lbl_Age.AutoSize = true;
            this.lbl_Age.Location = new System.Drawing.Point(6, 107);
            this.lbl_Age.Name = "lbl_Age";
            this.lbl_Age.Size = new System.Drawing.Size(29, 13);
            this.lbl_Age.TabIndex = 7;
            this.lbl_Age.Text = "Age:";
            // 
            // num_Age
            // 
            this.num_Age.Location = new System.Drawing.Point(85, 105);
            this.num_Age.Name = "num_Age";
            this.num_Age.ReadOnly = true;
            this.num_Age.Size = new System.Drawing.Size(136, 20);
            this.num_Age.TabIndex = 4;
            // 
            // pnl_PictureCtrl
            // 
            this.pnl_PictureCtrl.Controls.Add(this.box_TestControls);
            this.pnl_PictureCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_PictureCtrl.Location = new System.Drawing.Point(243, 719);
            this.pnl_PictureCtrl.Name = "pnl_PictureCtrl";
            this.pnl_PictureCtrl.Size = new System.Drawing.Size(734, 65);
            this.pnl_PictureCtrl.TabIndex = 2;
            // 
            // box_TestControls
            // 
            this.box_TestControls.Controls.Add(this.btn_GotIt);
            this.box_TestControls.Controls.Add(this.btn_Complete);
            this.box_TestControls.Controls.Add(this.btn_NextPicture);
            this.box_TestControls.Controls.Add(this.btn_NextTrial);
            this.box_TestControls.Controls.Add(this.label4);
            this.box_TestControls.Controls.Add(this.txt_Category);
            this.box_TestControls.Controls.Add(this.txt_Description);
            this.box_TestControls.Controls.Add(this.lbl_Category);
            this.box_TestControls.Enabled = false;
            this.box_TestControls.Location = new System.Drawing.Point(3, 5);
            this.box_TestControls.Name = "box_TestControls";
            this.box_TestControls.Size = new System.Drawing.Size(727, 54);
            this.box_TestControls.TabIndex = 19;
            this.box_TestControls.TabStop = false;
            this.box_TestControls.Text = "Test controls";
            // 
            // btn_GotIt
            // 
            this.btn_GotIt.Location = new System.Drawing.Point(95, 19);
            this.btn_GotIt.Name = "btn_GotIt";
            this.btn_GotIt.Size = new System.Drawing.Size(75, 23);
            this.btn_GotIt.TabIndex = 17;
            this.btn_GotIt.Text = "Got it";
            this.btn_GotIt.UseVisualStyleBackColor = true;
            this.btn_GotIt.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // btn_Complete
            // 
            this.btn_Complete.Enabled = false;
            this.btn_Complete.Location = new System.Drawing.Point(558, 19);
            this.btn_Complete.Name = "btn_Complete";
            this.btn_Complete.Size = new System.Drawing.Size(75, 23);
            this.btn_Complete.TabIndex = 18;
            this.btn_Complete.Text = "Submit";
            this.btn_Complete.UseVisualStyleBackColor = true;
            this.btn_Complete.Click += new System.EventHandler(this.SubmitSolutionButton_Click);
            // 
            // btn_NextPicture
            // 
            this.btn_NextPicture.AutoSize = true;
            this.btn_NextPicture.Location = new System.Drawing.Point(14, 19);
            this.btn_NextPicture.Name = "btn_NextPicture";
            this.btn_NextPicture.Size = new System.Drawing.Size(75, 23);
            this.btn_NextPicture.TabIndex = 13;
            this.btn_NextPicture.Text = "Next Picture";
            this.btn_NextPicture.UseVisualStyleBackColor = true;
            this.btn_NextPicture.Click += new System.EventHandler(this.NextPictureButton_Click);
            // 
            // btn_NextTrial
            // 
            this.btn_NextTrial.AutoSize = true;
            this.btn_NextTrial.Enabled = false;
            this.btn_NextTrial.Location = new System.Drawing.Point(639, 19);
            this.btn_NextTrial.Name = "btn_NextTrial";
            this.btn_NextTrial.Size = new System.Drawing.Size(75, 23);
            this.btn_NextTrial.TabIndex = 14;
            this.btn_NextTrial.Text = "Next Trial";
            this.btn_NextTrial.UseVisualStyleBackColor = true;
            this.btn_NextTrial.Click += new System.EventHandler(this.NextTrialButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name:";
            // 
            // txt_Category
            // 
            this.txt_Category.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_Category.Enabled = false;
            this.txt_Category.HideSelection = false;
            this.txt_Category.Location = new System.Drawing.Point(417, 21);
            this.txt_Category.MaxLength = 20;
            this.txt_Category.Name = "txt_Category";
            this.txt_Category.Size = new System.Drawing.Size(135, 20);
            this.txt_Category.TabIndex = 16;
            // 
            // txt_Description
            // 
            this.txt_Description.Enabled = false;
            this.txt_Description.Location = new System.Drawing.Point(220, 21);
            this.txt_Description.MaxLength = 20;
            this.txt_Description.Name = "txt_Description";
            this.txt_Description.Size = new System.Drawing.Size(135, 20);
            this.txt_Description.TabIndex = 15;
            // 
            // lbl_Category
            // 
            this.lbl_Category.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Category.AutoSize = true;
            this.lbl_Category.Location = new System.Drawing.Point(359, 24);
            this.lbl_Category.Name = "lbl_Category";
            this.lbl_Category.Size = new System.Drawing.Size(52, 13);
            this.lbl_Category.TabIndex = 4;
            this.lbl_Category.Text = "Category:";
            // 
            // pnl_PictureArea
            // 
            this.pnl_PictureArea.Controls.Add(this.box_Image);
            this.pnl_PictureArea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_PictureArea.Location = new System.Drawing.Point(243, 3);
            this.pnl_PictureArea.Name = "pnl_PictureArea";
            this.pnl_PictureArea.Size = new System.Drawing.Size(734, 710);
            this.pnl_PictureArea.TabIndex = 3;
            // 
            // box_Image
            // 
            this.box_Image.Controls.Add(this.box_PictureArea);
            this.box_Image.Location = new System.Drawing.Point(6, 9);
            this.box_Image.Name = "box_Image";
            this.box_Image.Size = new System.Drawing.Size(724, 692);
            this.box_Image.TabIndex = 21;
            this.box_Image.TabStop = false;
            this.box_Image.Text = "Image";
            // 
            // box_PictureArea
            // 
            this.box_PictureArea.BackColor = System.Drawing.SystemColors.Control;
            this.box_PictureArea.InitialImage = null;
            this.box_PictureArea.Location = new System.Drawing.Point(12, 19);
            this.box_PictureArea.Name = "box_PictureArea";
            this.box_PictureArea.Size = new System.Drawing.Size(700, 662);
            this.box_PictureArea.TabIndex = 0;
            this.box_PictureArea.TabStop = false;
            this.box_PictureArea.Visible = false;
            // 
            // TestTime
            // 
            this.TestTime.Tick += new System.EventHandler(this.TestTime_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 787);
            this.Controls.Add(this.lay_MainLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Borimeter";
            this.lay_MainLayout.ResumeLayout(false);
            this.pnl_MainControl.ResumeLayout(false);
            this.box_Controls.ResumeLayout(false);
            this.pnl_PersonalInfo.ResumeLayout(false);
            this.Studies.ResumeLayout(false);
            this.Studies.PerformLayout();
            this.TestSet.ResumeLayout(false);
            this.TestSet.PerformLayout();
            this.Information.ResumeLayout(false);
            this.PersonalInfo.ResumeLayout(false);
            this.PersonalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Age)).EndInit();
            this.pnl_PictureCtrl.ResumeLayout(false);
            this.box_TestControls.ResumeLayout(false);
            this.box_TestControls.PerformLayout();
            this.pnl_PictureArea.ResumeLayout(false);
            this.box_Image.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.box_PictureArea)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel lay_MainLayout;
        private System.Windows.Forms.Label lbl_Category;
        private System.Windows.Forms.TextBox txt_Category;
        private System.Windows.Forms.Button btn_NextPicture;
        private System.Windows.Forms.Button btn_NextTrial;
        private System.Windows.Forms.Panel pnl_MainControl;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Panel pnl_PersonalInfo;
        private System.Windows.Forms.Panel pnl_PictureCtrl;
        private System.Windows.Forms.Label lbl_Surname;
        private System.Windows.Forms.TextBox txt_Surname;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.NumericUpDown num_Age;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.GroupBox PersonalInfo;
        private System.Windows.Forms.Button btn_GotIt;
        private System.Windows.Forms.Button btn_Complete;
        private System.Windows.Forms.GroupBox box_Controls;
        private System.Windows.Forms.GroupBox box_TestControls;
        private System.Windows.Forms.Button btn_Finish;
        private System.Windows.Forms.Panel pnl_PictureArea;
        private System.Windows.Forms.GroupBox box_Image;
        private System.Windows.Forms.PictureBox box_PictureArea;
        private System.Windows.Forms.GroupBox Information;
        private System.Windows.Forms.Timer TestTime;
        private System.Windows.Forms.RichTextBox InfoTextBox;
        private System.Windows.Forms.GroupBox TestSet;
        private System.Windows.Forms.GroupBox Studies;
        private System.Windows.Forms.ComboBox cmb_Year;
        private System.Windows.Forms.Label lbl_Year;
        private System.Windows.Forms.Label lbl_Degree;
        private System.Windows.Forms.ComboBox cmb_Degree;
        private System.Windows.Forms.Label lbl_Speciality;
        private System.Windows.Forms.TextBox txt_Speciality;
        private System.Windows.Forms.Label lbl_University;
        private System.Windows.Forms.TextBox txt_University;
        private System.Windows.Forms.ComboBox cmb_Gender;
        private System.Windows.Forms.Label lbl_TestSet;
        private System.Windows.Forms.ComboBox cmb_TestSet;
    }
}

