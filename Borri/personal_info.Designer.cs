namespace Borimeter
{
    partial class wnd_MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wnd_MainWindow));
            this.lay_MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_MainControl = new System.Windows.Forms.Panel();
            this.box_Controls = new System.Windows.Forms.GroupBox();
            this.btn_Finish = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.pnl_PersonalInfo = new System.Windows.Forms.Panel();
            this.Information = new System.Windows.Forms.GroupBox();
            this.box_Progress = new System.Windows.Forms.GroupBox();
            this.chk_Progress = new System.Windows.Forms.CheckBox();
            this.prg_ProgressBar = new System.Windows.Forms.ProgressBar();
            this.box_PersonalInfo = new System.Windows.Forms.GroupBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Surname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Surname = new System.Windows.Forms.Label();
            this.num_Year = new System.Windows.Forms.NumericUpDown();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.txt_Specialization = new System.Windows.Forms.TextBox();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.cmb_Degree = new System.Windows.Forms.ComboBox();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Age = new System.Windows.Forms.Label();
            this.num_Age = new System.Windows.Forms.NumericUpDown();
            this.lbl_University = new System.Windows.Forms.Label();
            this.txt_University = new System.Windows.Forms.TextBox();
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
            this.box_Progress.SuspendLayout();
            this.box_PersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Year)).BeginInit();
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
            this.lay_MainLayout.Size = new System.Drawing.Size(980, 770);
            this.lay_MainLayout.TabIndex = 11;
            this.lay_MainLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.lyo_MainTableLayout_Paint);
            // 
            // pnl_MainControl
            // 
            this.pnl_MainControl.Controls.Add(this.box_Controls);
            this.pnl_MainControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_MainControl.Location = new System.Drawing.Point(3, 702);
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
            this.box_Controls.TabIndex = 13;
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
            this.btn_Finish.Click += new System.EventHandler(this.btn_Finish_Click);
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
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.Location = new System.Drawing.Point(5, 19);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(68, 23);
            this.btn_Submit.TabIndex = 11;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = true;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // pnl_PersonalInfo
            // 
            this.pnl_PersonalInfo.Controls.Add(this.Information);
            this.pnl_PersonalInfo.Controls.Add(this.box_Progress);
            this.pnl_PersonalInfo.Controls.Add(this.box_PersonalInfo);
            this.pnl_PersonalInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_PersonalInfo.Location = new System.Drawing.Point(3, 3);
            this.pnl_PersonalInfo.Name = "pnl_PersonalInfo";
            this.pnl_PersonalInfo.Size = new System.Drawing.Size(234, 693);
            this.pnl_PersonalInfo.TabIndex = 0;
            // 
            // Information
            // 
            this.Information.Location = new System.Drawing.Point(4, 431);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(225, 308);
            this.Information.TabIndex = 20;
            this.Information.TabStop = false;
            this.Information.Text = "Information";
            // 
            // box_Progress
            // 
            this.box_Progress.Controls.Add(this.chk_Progress);
            this.box_Progress.Controls.Add(this.prg_ProgressBar);
            this.box_Progress.Location = new System.Drawing.Point(3, 349);
            this.box_Progress.Name = "box_Progress";
            this.box_Progress.Size = new System.Drawing.Size(226, 75);
            this.box_Progress.TabIndex = 19;
            this.box_Progress.TabStop = false;
            this.box_Progress.Text = "Progress";
            // 
            // chk_Progress
            // 
            this.chk_Progress.AutoSize = true;
            this.chk_Progress.Location = new System.Drawing.Point(5, 19);
            this.chk_Progress.Name = "chk_Progress";
            this.chk_Progress.Size = new System.Drawing.Size(177, 17);
            this.chk_Progress.TabIndex = 10;
            this.chk_Progress.Text = "Show progress through the trials";
            this.chk_Progress.UseVisualStyleBackColor = true;
            this.chk_Progress.CheckedChanged += new System.EventHandler(this.chk_Progress_CheckedChanged);
            // 
            // prg_ProgressBar
            // 
            this.prg_ProgressBar.Location = new System.Drawing.Point(6, 42);
            this.prg_ProgressBar.Name = "prg_ProgressBar";
            this.prg_ProgressBar.Size = new System.Drawing.Size(214, 23);
            this.prg_ProgressBar.TabIndex = 2;
            // 
            // box_PersonalInfo
            // 
            this.box_PersonalInfo.Controls.Add(this.lbl_Name);
            this.box_PersonalInfo.Controls.Add(this.label3);
            this.box_PersonalInfo.Controls.Add(this.txt_Name);
            this.box_PersonalInfo.Controls.Add(this.label2);
            this.box_PersonalInfo.Controls.Add(this.txt_Surname);
            this.box_PersonalInfo.Controls.Add(this.label1);
            this.box_PersonalInfo.Controls.Add(this.lbl_Surname);
            this.box_PersonalInfo.Controls.Add(this.num_Year);
            this.box_PersonalInfo.Controls.Add(this.rb_Male);
            this.box_PersonalInfo.Controls.Add(this.txt_Specialization);
            this.box_PersonalInfo.Controls.Add(this.rb_Female);
            this.box_PersonalInfo.Controls.Add(this.cmb_Degree);
            this.box_PersonalInfo.Controls.Add(this.lbl_Gender);
            this.box_PersonalInfo.Controls.Add(this.lbl_Age);
            this.box_PersonalInfo.Controls.Add(this.num_Age);
            this.box_PersonalInfo.Controls.Add(this.lbl_University);
            this.box_PersonalInfo.Controls.Add(this.txt_University);
            this.box_PersonalInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.box_PersonalInfo.Location = new System.Drawing.Point(3, 9);
            this.box_PersonalInfo.Name = "box_PersonalInfo";
            this.box_PersonalInfo.Size = new System.Drawing.Size(226, 334);
            this.box_PersonalInfo.TabIndex = 18;
            this.box_PersonalInfo.TabStop = false;
            this.box_PersonalInfo.Text = "Personal information";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(6, 27);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(38, 13);
            this.lbl_Name.TabIndex = 0;
            this.lbl_Name.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 274);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Year/Grade:";
            // 
            // txt_Name
            // 
            this.txt_Name.Location = new System.Drawing.Point(85, 24);
            this.txt_Name.MaxLength = 20;
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(136, 20);
            this.txt_Name.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Degree:";
            // 
            // txt_Surname
            // 
            this.txt_Surname.Location = new System.Drawing.Point(85, 51);
            this.txt_Surname.MaxLength = 20;
            this.txt_Surname.Name = "txt_Surname";
            this.txt_Surname.Size = new System.Drawing.Size(136, 20);
            this.txt_Surname.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Specialization:";
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
            // num_Year
            // 
            this.num_Year.Location = new System.Drawing.Point(85, 272);
            this.num_Year.Name = "num_Year";
            this.num_Year.Size = new System.Drawing.Size(136, 20);
            this.num_Year.TabIndex = 9;
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Location = new System.Drawing.Point(85, 77);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(48, 17);
            this.rb_Male.TabIndex = 3;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // txt_Specialization
            // 
            this.txt_Specialization.Location = new System.Drawing.Point(85, 189);
            this.txt_Specialization.Multiline = true;
            this.txt_Specialization.Name = "txt_Specialization";
            this.txt_Specialization.Size = new System.Drawing.Size(136, 50);
            this.txt_Specialization.TabIndex = 7;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Location = new System.Drawing.Point(159, 77);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(59, 17);
            this.rb_Female.TabIndex = 4;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // cmb_Degree
            // 
            this.cmb_Degree.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Degree.FormattingEnabled = true;
            this.cmb_Degree.Items.AddRange(new object[] {
            "Master (MA)",
            "Bachelor (BA)"});
            this.cmb_Degree.Location = new System.Drawing.Point(85, 245);
            this.cmb_Degree.Name = "cmb_Degree";
            this.cmb_Degree.Size = new System.Drawing.Size(136, 21);
            this.cmb_Degree.TabIndex = 8;
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
            this.num_Age.Size = new System.Drawing.Size(136, 20);
            this.num_Age.TabIndex = 5;
            // 
            // lbl_University
            // 
            this.lbl_University.AutoSize = true;
            this.lbl_University.Location = new System.Drawing.Point(6, 132);
            this.lbl_University.Name = "lbl_University";
            this.lbl_University.Size = new System.Drawing.Size(56, 13);
            this.lbl_University.TabIndex = 10;
            this.lbl_University.Text = "University:";
            // 
            // txt_University
            // 
            this.txt_University.Location = new System.Drawing.Point(85, 132);
            this.txt_University.Multiline = true;
            this.txt_University.Name = "txt_University";
            this.txt_University.Size = new System.Drawing.Size(136, 50);
            this.txt_University.TabIndex = 6;
            // 
            // pnl_PictureCtrl
            // 
            this.pnl_PictureCtrl.Controls.Add(this.box_TestControls);
            this.pnl_PictureCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_PictureCtrl.Location = new System.Drawing.Point(243, 702);
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
            this.btn_GotIt.Text = "Got It";
            this.btn_GotIt.UseVisualStyleBackColor = true;
            this.btn_GotIt.Click += new System.EventHandler(this.btn_GotIt_Click);
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
            this.btn_Complete.Click += new System.EventHandler(this.btn_Complete_Click);
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
            this.btn_NextPicture.Click += new System.EventHandler(this.btn_NextPicture_Click);
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
            this.btn_NextTrial.Click += new System.EventHandler(this.btn_NextTrial_Click);
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
            this.txt_Category.TextChanged += new System.EventHandler(this.txt_Category_TextChanged);
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
            this.pnl_PictureArea.Size = new System.Drawing.Size(734, 693);
            this.pnl_PictureArea.TabIndex = 3;
            // 
            // box_Image
            // 
            this.box_Image.Controls.Add(this.box_PictureArea);
            this.box_Image.Location = new System.Drawing.Point(5, 9);
            this.box_Image.Name = "box_Image";
            this.box_Image.Size = new System.Drawing.Size(724, 730);
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
            this.box_PictureArea.Size = new System.Drawing.Size(700, 700);
            this.box_PictureArea.TabIndex = 0;
            this.box_PictureArea.TabStop = false;
            this.box_PictureArea.Visible = false;
            // 
            // TestTime
            // 
            this.TestTime.Tick += new System.EventHandler(this.TestTime_Tick);
            // 
            // wnd_MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 770);
            this.Controls.Add(this.lay_MainLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "wnd_MainWindow";
            this.Text = "Borimeter";
            this.lay_MainLayout.ResumeLayout(false);
            this.pnl_MainControl.ResumeLayout(false);
            this.box_Controls.ResumeLayout(false);
            this.pnl_PersonalInfo.ResumeLayout(false);
            this.box_Progress.ResumeLayout(false);
            this.box_Progress.PerformLayout();
            this.box_PersonalInfo.ResumeLayout(false);
            this.box_PersonalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Year)).EndInit();
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
        private System.Windows.Forms.ProgressBar prg_ProgressBar;
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
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.NumericUpDown num_Age;
        private System.Windows.Forms.Label lbl_Age;
        private System.Windows.Forms.TextBox txt_University;
        private System.Windows.Forms.Label lbl_University;
        private System.Windows.Forms.ComboBox cmb_Degree;
        private System.Windows.Forms.CheckBox chk_Progress;
        private System.Windows.Forms.TextBox txt_Specialization;
        private System.Windows.Forms.NumericUpDown num_Year;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Description;
        private System.Windows.Forms.GroupBox box_PersonalInfo;
        private System.Windows.Forms.GroupBox box_Progress;
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

    }
}

