using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Borimeter
{
    public partial class MainWindow : Form
    {
        // Personal and Test information
        TestSubjectClass TestSubject = new TestSubjectClass();
        TestDataClass    TestData    = new TestDataClass();
        TimeClass        Time        = new TimeClass();

        // Current number of step/picture and trial/set
        int IdxImg = 0;
        int IdxSet = 0;

        // Number of pictures per set
        int Const_NrPicPerSet = 20;

        // Path to user file
        string FilePath = "";
        string[] TestSetPathList;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainTableLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        // Create user file and write personal information into it
        private void PrepareOutputFile()
        {
            // Unique file name
            string FileName;
            
            // Concatenate User Name and Unique ID to generate file name
            FileName = TestData.TestSet + TestSubject.Id + "_" + TestSubject.Name + "_" + TestSubject.Surname  ;
            // Calculate user file path
            FilePath = @"Results\" + FileName + ".res";
            // If user file already exists
            using (StreamWriter WriteToFile = File.CreateText(FilePath))
            {
                WriteToFile.WriteLine("Date/Time:   {0}", TestData.DateTime);
                WriteToFile.WriteLine("Test ID:     {0}{1}", TestData.TestSet, TestSubject.Id);
                WriteToFile.WriteLine("");
                WriteToFile.WriteLine("--------- Personal information ---------");
                WriteToFile.WriteLine("Name:        {0}", TestSubject.Name);
                WriteToFile.WriteLine("Surname:     {0}", TestSubject.Surname);
                WriteToFile.WriteLine("Gender:      {0}", TestSubject.Gender);
                WriteToFile.WriteLine("Age:         {0}", TestSubject.Age);
                WriteToFile.WriteLine("");
                WriteToFile.WriteLine("---------------- Studies ---------------");
                WriteToFile.WriteLine("Speciality:  {0}", TestSubject.Spec);
                WriteToFile.WriteLine("Institution: {0}", TestSubject.Uni);
                WriteToFile.WriteLine("Year:        {0}", TestSubject.Year);
                WriteToFile.WriteLine("Degree:      {0}", TestSubject.Deg);
                WriteToFile.WriteLine("");
                WriteToFile.WriteLine("-------------- Test Results ------------");
            }
        }

        // Display a specific picture from a set
        private void DisplayImage(int Set, int Pic)
        {
            // Calculate path to current picture
            string ImgFilePath = TestSetPathList[Set] +"\\" + Pic.ToString() + ".png";
            // Set image display mode based on image size
            using (Image Picture = Image.FromFile(ImgFilePath))
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
                    box_PictureArea.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            // Load picture into picture area
            box_PictureArea.Load(ImgFilePath);
            // Make picture area visible
            box_PictureArea.Visible = true;
        }

        // Verifies that all input fields were filled in
        private bool CheckInputFields()
        {
            bool PersonalInfoComplete = true;
            bool StudiesInfoComplete = true;
            bool TestSetChoosen = true;

            // Check personal information are filled in
            if (txt_Name.Text == "" || txt_Surname.Text == "" || cmb_Gender.Text == "" || num_Age.Value == 0)
            {
                PersonalInfoComplete = false;
                // Display notification
                InfoTextBox.AppendText(Environment.NewLine + "Please fill in all Personal information fields.");
                InfoTextBox.AppendText(Environment.NewLine);
            }
            // Check if information about studies are filled in
            if (txt_Speciality.Text == "" || cmb_Year.Text == "")
            {
                StudiesInfoComplete = false;
                // Display notification
                InfoTextBox.AppendText(Environment.NewLine + "Please fill in information about your studies:");
                InfoTextBox.AppendText(Environment.NewLine + " - University and Degree are optional");
                InfoTextBox.AppendText(Environment.NewLine);
            }
            // Check if test set was chosen
            if (cmb_TestSet.Text == "")
            {
                TestSetChoosen = false;
                // Display notification
                InfoTextBox.AppendText(Environment.NewLine + "Please chose a test set indicated by the instructor.");
                InfoTextBox.AppendText(Environment.NewLine);
            }

            return PersonalInfoComplete && StudiesInfoComplete && TestSetChoosen;
        }

        // Submit button action
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            string UserIdData;

            // Clear notification area content
            InfoTextBox.Clear();

            // If all information is complete
            if (CheckInputFields())
            {
                // Populate information about the test subject
                TestSubject.Name    = txt_Name.Text;
                TestSubject.Surname = txt_Surname.Text;
                TestSubject.Gender  = cmb_Gender.Text;
                TestSubject.Age     = num_Age.Value.ToString();
                TestSubject.Spec    = txt_Speciality.Text;
                TestSubject.Uni     = txt_University.Text;
                TestSubject.Year    = cmb_Year.Text;
                TestSubject.Deg     = cmb_Degree.Text;
                // Calculate unique user ID
                UserIdData          = TestSubject.Name + TestSubject.Surname + DateTime.Now.ToString();
                TestSubject.Id      = Math.Abs(UserIdData.GetHashCode()).ToString();
                // Populate test data
                TestData.TestSet    = cmb_TestSet.Text;
                TestData.DateTime   = DateTime.Now.ToString();
                // Get all directories of the test sets
                TestSetPathList = Directory.GetDirectories(@"Pictures\" + TestData.TestSet + "\\");
                // Enable test controls
                btn_Start.Enabled = true;
                // Disable Submit button
                btn_Submit.Enabled = false;
                // Disable Personal Information, Studies and Test Set group box
                PersonalInfo.Enabled = false;
                Studies.Enabled = false;
                TestSet.Enabled = false;
                // Create user file
                PrepareOutputFile();
                // Clear notification area
                InfoTextBox.Clear();
                // Display notification
                InfoTextBox.AppendText(Environment.NewLine + "Please press the Start button to enter the Demo trial.");
                InfoTextBox.AppendText(Environment.NewLine);
            } 
        }

        // Start button action
        private void StartButton_Click(object sender, EventArgs e)
        {
            // Clear notification area content
            InfoTextBox.Clear();
            // Enable test controls
            box_TestControls.Enabled = true;
            // Disable Start button
            btn_Start.Enabled = false;
            // Initialize indexes to first picture from first set
            IdxImg = 20;
            IdxSet = 0;
            // Display current picture
            DisplayImage(IdxSet, IdxImg);
        }

        // Next Picture button action
        private void NextPictureButton_Click(object sender, EventArgs e)
        {
            int Idx = Const_NrPicPerSet - IdxImg;

            // There is an upcoming picture
            if (--IdxImg > 0)
            {
                // Get image display time
                TestData.ImgDispTime[Idx] = Time.GetImgDispTime_100ms();
                // Display current picture
                DisplayImage(IdxSet, IdxImg);
            }
            // Last picture from current set is reached
            else
            {
                // Disable Next Picture button
                btn_NextPicture.Enabled = false;
                // Adjust image index back to 1
                IdxImg = 1;
            }
        }

        // Next Trial button action
        private void NextTrialButton_Click(object sender, EventArgs e)
        {
            // Clear notification area content
            InfoTextBox.Clear();
            // There is an upcoming set
            if (++IdxSet < TestSetPathList.Length)
            {
                // Reset image index
                IdxImg = Const_NrPicPerSet;
                // Reset Image Display Time array
                Array.Clear(TestData.ImgDispTime, 0, Const_NrPicPerSet);
                // Enable Next Picture and Got It buttons
                btn_NextPicture.Enabled = true;
                btn_GotIt.Enabled = true;
                // Disable Next Trial button
                btn_NextTrial.Enabled = false;
                // Disable Category and Name input fields
                txt_Description.Enabled = false;
                txt_Category.Enabled = false;
                // Display current picture
                DisplayImage(IdxSet, IdxImg);
                // Enable timer
                TestTime.Start();
            }
            // Last set was reached
            else
            {
                // Disable Test Control box
                box_TestControls.Enabled = false;
                // Enable Finish button
                btn_Finish.Enabled = true;
            }
        }

        // Stop button action
        private void StopButton_Click(object sender, EventArgs e)
        {
            int Idx = Const_NrPicPerSet - IdxImg;

            // Stop timer
            TestTime.Stop();
            // Get image display time
            TestData.ImgDispTime[Idx] = Time.GetImgDispTime_100ms();
            // Make picture area visible
            box_PictureArea.Visible = false;
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
        private void SubmitSolutionButton_Click(object sender, EventArgs e)
        {

            // If solution fields were filled in
            if (txt_Category.Text != "" && txt_Description.Text != "")
            {
                // Don't do for DEMO set
                if (IdxSet != 0)
                {
                    // Get trial time in 100ms
                    TestData.TrialTime = Time.GetTrialTime_100ms();
                    // Save image index
                    TestData.TrialStep = IdxImg;
                    // Save trial Name and Category
                    TestData.TrialType = txt_Category.Text;
                    TestData.TrialName = txt_Description.Text;
                    // Write trial results to file
                    WriteTrialResultToFile();
                }
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
                // Clear notification area
                InfoTextBox.Clear();
            }
            else
            {
                // Clear notification area
                InfoTextBox.Clear();
                // Display notification
                InfoTextBox.AppendText(Environment.NewLine + "Please fill in both Name and Category fields before you press Submit!");
            }
        }

        // Finish button action
        private void FinishButton_Click(object sender, EventArgs e)
        {
            // Exit application
            Application.Exit();
        }

        // Write current trial results
        private void WriteTrialResultToFile()
        {
            int Sec = TestData.TrialTime / 10;
            int MSec = TestData.TrialTime % 10;

            // Write solution to user file
            using (StreamWriter WriteToFile = File.AppendText(FilePath))
            {
                // Write trial results
                WriteToFile.Write("{0}: {1}, {2}.{3}s, {4}, {5} | ",
                    IdxSet.ToString(),
                    TestData.TrialStep.ToString(),
                    Sec.ToString(),
                    MSec.ToString(),
                    TestData.TrialType,
                    TestData.TrialName
                    );
                // Write individual image display times
                foreach (int Value in TestData.ImgDispTime)
                {
                    Sec = Value / 10;
                    MSec = Value % 10;
                    WriteToFile.Write("{0}.{1}s  ", Sec, MSec);

                }
                WriteToFile.WriteLine("");
            }
        }

        // 100ms time event
        private void TestTime_Tick(object sender, EventArgs e)
        {
            // Increment time unit (sec)
            Time.IncTime();
        }
    }

    // Time class
    public class TimeClass
    {
        private int Mil = 0;
        private int Sec = 0;
        private int Min = 0;
        private int Ora = 0;
        private int Total = 0;
        private int Trial = 0;
        private int Image = 0;

        // Increment Total time (sec) and Hour:Min:Sec
        public void IncTime()
        {
            // Increment trial time
            Trial++;
            // Increment image display time
            Image++;
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
        public string GetTime_hms()
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

        public int GetImgDispTime_100ms()
        {
            int ImageDisplayTime = Image;

            // Reset image display time
            Image = 0;
            // Return image display time
            return ImageDisplayTime;
        }

        // Get trial time in 100 milliseconds
        public int GetTrialTime_100ms()
        {
            int TrialTime = Trial;

            // Reset trial time
            Trial = 0;
            // Reset image display time
            Image = 0;
            // Return trial time
            return TrialTime;
        }

        // Get total test time in seconds
        public int GetTotalTime_Sec()
        {
            // Return total amount of time
            return Total;
        }
    }
    
    // Test trial information
    public class TestDataClass
    {
        // Test Set: A,B or C
        public string TestSet = "";
        // Test Date
        public string DateTime = "";
        // Measure time and step count for each trial
        public int TrialTime;
        public int TrialStep;
        public int[] ImgDispTime = new int[20];
        // Store name and Category for each trial
        public string TrialName;
        public string TrialType;
        // Total amount of time needed to complete the whole test
        public int TotalTime = 0;
    }

    public class TestSubjectClass
    {
        public string Id      = "";
        public string Name    = "";
        public string Surname = "";
        public string Gender  = "";
        public string Age     = "";
        public string Uni     = "";
        public string Spec    = "";
        public string Deg     = "";
        public string Year    = "";
    }
}
