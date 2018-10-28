using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Borimeter
{
    public partial class wnd_MainWindow : Form
    {
        // Personal and Test information
        c_Student Student = new c_Student();
        c_Test    Test    = new c_Test();
        c_Time    Time    = new c_Time();

        // Current number of step/picture and trial/set
        int IdxImg = 0;
        int IdxSet = 0;

        // Sample time when start trial
        int StartTime = 0;

        // Path to user file
        string FilePath = "";

        // Enable countdown
        Boolean EnableTimeOut = false;
        int TimeOutCounter = 10;

        public wnd_MainWindow()
        {
            InitializeComponent();
        }

        private void lyo_MainTableLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        // Disable input fields after Submit button was clicked
        private void DisableInput()
        {
            // Enable test controls
            btn_Start.Enabled = true;
            // Disable Submit button
            btn_Submit.Enabled = false;
            // Disable Personal Information group box
            box_PersonalInfo.Enabled = false;
            // If Progress bar is disabled
            if (chk_Progress.Checked == false)
            {
                // Hide progress group box
                box_Progress.Enabled = false;
            }
            else
            {
                chk_Progress.Enabled = false;
            }
        }

        // Create user file and write personal information into it
        private void CreateUserFile()
        {
            // Unique User ID
            string UserId;
            // Concatenate User info and date
            string UserData = Student.Name.ToString() + Student.Surname.ToString() + DateTime.Now.ToString();
            // Unique file name
            string FileName;
            
            // Generate unique user ID
            UserId = Math.Abs(UserData.GetHashCode()).ToString();
            // Concatenate User Name and Unique ID to generate file name
            FileName = Student.Name.ToString() + "_" + Student.Surname.ToString() + "_" + UserId;
            // Calculate user file path
            FilePath = @"Results\" + FileName + ".res";
            // If user file already exists
            using (StreamWriter WriteToFile = File.CreateText(FilePath))
            {
                WriteToFile.WriteLine(DateTime.Now.ToString());
                WriteToFile.WriteLine(UserId);
                WriteToFile.WriteLine(Student.Name.ToString());
                WriteToFile.WriteLine(Student.Surname.ToString());
                WriteToFile.WriteLine(Student.Gender.ToString());
                WriteToFile.WriteLine(Student.Age.ToString());
                WriteToFile.WriteLine(Student.Uni.ToString());
                WriteToFile.WriteLine(Student.Spec.ToString());
                WriteToFile.WriteLine(Student.Deg.ToString());
                WriteToFile.WriteLine(Student.Year.ToString());
            }
        }

        // Display a specific picture from a set
        private void DisplayImage(int Set, int Pic)
        {
            // Calculate path to current picture
            string s_Picture = @".\Pictures\" + IdxSet.ToString() + @"\" + IdxImg.ToString() + ".jpg";

            // Set image display mode based on image size
            using (Image Picture = Image.FromFile(s_Picture))
            {
                // If the image is smaller than the display area
                if (Picture.Width <= 700 && Picture.Height <= 662)
                {
                    // Set image size mode to center
                    box_PictureArea.SizeMode = PictureBoxSizeMode.CenterImage;
                }
                else
                {
                    // Set image size mode to stretch
                    box_PictureArea.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            // Load picture into picture area
            box_PictureArea.Load(s_Picture);
            // Make picture area visible
            box_PictureArea.Visible = true;
            // Enable time-out
            EnableTimeOut = true;
        }

        // Submit button action
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            bool b_InputOk  = true;
            string s_Gender = "";

            // Get gender from radio buttons
            if (rb_Male.Checked)
            {
                s_Gender = "M";
            }
            else if (rb_Female.Checked)
            {
                s_Gender = "F";
            }
            else
            {
                s_Gender = "T";
            }
            // Check if all input fields were completed
            b_InputOk = Student.GetInfo(txt_Name.Text, txt_Surname.Text, s_Gender, (int)num_Age.Value, txt_University.Text, txt_Specialization.Text, cmb_Degree.Text, (int)num_Year.Value);
            // If input fields were completed
            if (b_InputOk)
            {
                // Grey-out User information fields
                DisableInput();
                // Create user file
                CreateUserFile();
            }
            // If input fields were not completed
            else
            {
                // TODO: Show warning in the Information area.
            }
        }

        // Start button action
        private void btn_Start_Click(object sender, EventArgs e)
        {
            // Start timer and sample start time
            TestTime.Start();
            StartTime = Time.GetTrialTime();
            // Enable test controls
            box_TestControls.Enabled = true;
            // Disable Start button
            btn_Start.Enabled = false;
            // Initialize indexes to first picture from first set
            IdxImg = 1;
            IdxSet = 1;
            // Display current picture
            DisplayImage(IdxSet, IdxImg);
        }

        private void txt_Category_TextChanged(object sender, EventArgs e)
        {

        }

        // Next Picture button action
        private void btn_NextPicture_Click(object sender, EventArgs e)
        {
            if (IdxImg < Const.PicsPerSet)
            {
                // Switch to the next picture in current set
                IdxImg++;
                // Display current picture
                DisplayImage(IdxSet, IdxImg);
            }
            // If the last picture from current set is reached
            if (IdxImg == Const.PicsPerSet)
            {
                // Disable Next Picture and Got It buttons
                btn_NextPicture.Enabled = false;
                btn_GotIt.Enabled = false;
                // Enable Submit button
                btn_Complete.Enabled = true;
                // Enable Category and Name input fields
                txt_Category.Enabled = true;
                txt_Description.Enabled = true;
            }
        }

        // Next Trial button action
        private void btn_NextTrial_Click(object sender, EventArgs e)
        {
            // If the last set is reached
            if (IdxSet == Const.NrOfSets)
            {
                // Disable Test Control box
                box_TestControls.Enabled = false;
                // Enable Finish button
                btn_Finish.Enabled = true;

            }
            // There are more sets to show
            else if (IdxSet < Const.NrOfSets)
            {
                // Enable timer and sample time
                TestTime.Start();
                StartTime = Time.GetTrialTime();
                // Enable Next Picture and Got It buttons
                btn_NextPicture.Enabled = true;
                btn_GotIt.Enabled = true;
                // Disable Next Trial button
                btn_NextTrial.Enabled = false;
                // Disable Category and Name input fields
                txt_Description.Enabled = false;
                txt_Category.Enabled = false;
                // Switch to 1st picture in the next set
                IdxSet++;
                IdxImg = 1;
                // Display current picture
                DisplayImage(IdxSet, IdxImg);
            }
        }

        private void chk_Progress_CheckedChanged(object sender, EventArgs e)
        {

        }

        // Stop button action
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            // Stop timer and measure elapsed time
            TestTime.Stop();
            Test.TrialTime[IdxSet-1] = Time.GetTrialTime() - StartTime;
            Test.TrialStep[IdxSet-1] = IdxImg;
            // Reset trial time
            Time.Trial = 0;
            // Enable Category and Name input fields
            txt_Category.Enabled = true;
            txt_Description.Enabled = true;
            // Enable Submit button
            btn_Complete.Enabled = true;
            // Disable Next Picture and Got It buttons
            btn_GotIt.Enabled = false;
            btn_NextPicture.Enabled = false;
        }

        // Submit Solution button action
        private void btn_SubmitSolution_Click(object sender, EventArgs e)
        {
            // If solution fields were filled in
            if (txt_Category.Text != "" && txt_Description.Text != "")
            {
                // Save trial Name and Category
                Test.TrialType[IdxSet-1] = txt_Category.Text;
                Test.TrialName[IdxSet-1] = txt_Description.Text;
                // Write trial results to file
                WriteTrialResultToFile();
                // Clear input fields
                txt_Category.Clear();
                txt_Description.Clear();
                // Disable Category and Name input fields
                txt_Category.Enabled = false;
                txt_Description.Enabled = false;
                // Disable Submit button
                btn_Complete.Enabled = false;
                // Enable Next Trial button
                btn_NextTrial.Enabled = true;
            }
            else
            {
                // TODO: Show warning in Information area
            }
        }

        // Write current trial results
        private void WriteTrialResultToFile()
        {
            int Idx = IdxSet - 1;
            int Sec = Test.TrialTime[Idx] / 10;
            int MSec = Test.TrialTime[Idx] % 10;

            // Write solution to user file
            using (StreamWriter WriteToFile = File.AppendText(FilePath))
            {
                WriteToFile.WriteLine(
                    IdxSet.ToString() + ": " +
                    Test.TrialStep[Idx].ToString() + ", " +
                    Sec.ToString() + "." + MSec.ToString() + "s, " +
                    Test.TrialType[Idx] + ", " +
                    Test.TrialName[Idx]
                );
            }
        }

        // Finish button action
        private void btn_Finish_Click(object sender, EventArgs e)
        {
            // Exit application
            Application.Exit();
        }

        // 100ms time event
        private void TestTime_Tick(object sender, EventArgs e)
        {
            // Increment time unit (sec)
            Time.IncTime();

            // If picture display timeout is enabled
            if (EnableTimeOut)
            {
                // If timeout has reached
                if (TimeOutCounter == 0)
                {
                    // Disable time-out
                    EnableTimeOut = false;
                    // Reset time-out counter
                    TimeOutCounter = 10;
                    // Hide picture area
                    box_PictureArea.Visible = false;
                }
                else TimeOutCounter--;
            }
        }
    }

    // Time class
    public class c_Time
    {
        public int Mil = 0;
        public int Sec = 0;
        public int Min = 0;
        public int Ora = 0;
        public int Total = 0;
        public int Trial = 0;

        // Increment Total time (sec) and Hour:Min:Sec
        public void IncTime()
        {
            // Increment trial time
            Trial++;
            // Increment hour, minutes, seconds and milliseconds individually
            if (Mil < 10)
            {
                Mil++;
            }
            else
            {
                Mil = 0;
                // Increment total time (sec)
                Total++;
                if (Sec < 60)
                {
                    Sec++;
                }
                else
                {
                    Sec = 0;
                    if (Min < 60)
                    {
                        Min++;
                    }
                    else
                    {
                        Min = 0;
                        Ora++;
                    }
                }
            }
        }

        // Get Time in Hour:Mint:Sec format
        public string GetTimeHMS()
        {
            string TimeString;
            
            // Hours were not counted
            if (Ora == 0)
            {
                // Minutes were not counted
                if (Min == 0)
                {
                    TimeString = Sec.ToString();
                }
                // Minutes counted
                else
                {
                    TimeString = Min.ToString() + ":" + Sec.ToString();
                }
            }
            // Hours counted
            else
            {
                TimeString = Ora.ToString() + ":" + Min.ToString() + ":" + Sec.ToString();
            }

            // Return Time in string format
            return TimeString;
        }

        // Get trial time in milliseconds
        public  int GetTrialTime()
        {
            // Return trial time
            return Trial;
        }

        // Get total test time in seconds
        public int GetTotalTime()
        {
            // Return total amount of time
            return Total;
        }
    }
    
    // Class to define constant values
    public class Const
    {
        // Maximum number of pictures per set
        public const int PicsPerSet = 5;
        // Maximum number of sets
        // TODO: Correct value to 20 on final version
        public const int NrOfSets = 3;
    }

    // Test trial information
    public class c_Test
    {
        // Measure time and step count for each trial
        public int[] TrialTime = new int[Const.NrOfSets];
        public int[] TrialStep = new int[Const.NrOfSets];
        // Store name and Category for each trial
        public string[] TrialName = new string[Const.NrOfSets];
        public string[] TrialType = new string[Const.NrOfSets];
        // Total amount of time needed to complete the whole test
        public int TotalTime = 0;
    }

    public class c_Student
    {
        public int      Id      = 0;
        public string   Name    = "";
        public string   Surname = "";
        public string   Gender  = "";
        public int      Age     = 0;
        public string   Uni     = "";
        public string   Spec    = "";
        public string   Deg     = "";
        public int  Year    = 0;

        public bool GetInfo(string in_Name, string in_Surname, string in_Gender, int in_Age, string in_Uni, string in_Spec, string in_Deg, int in_Year)
        {
            bool b_InputOk = true;

            // Personal Information is incomplete
            if (in_Name     == "" ||
                in_Surname  == "" ||
                in_Age      == 0  ||
                in_Uni      == "" ||
                in_Spec     ==""  ||
                in_Deg      == "" ||
                in_Year     == 0)
            {
                b_InputOk = false;
            }
            // Personal Information is complete
            else
            {
                Name    = in_Name;
                Surname = in_Surname;
                Gender  = in_Gender;
                Age     = in_Age;
                Uni     = in_Uni;
                Spec    = in_Spec;
                Deg     = in_Deg ;
                Year    = in_Year;
            }

            return b_InputOk;
        }
    }
}
