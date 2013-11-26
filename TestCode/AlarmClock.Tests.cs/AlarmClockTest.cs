using System.Windows.Forms;
using NUnit; 
using NUnit.Framework;
using TestStack.White.Factory;             // InitializeOption // Application  
using TestStack.White.UIItems.WindowItems; // Window // TextBox 
using TestStack.White.UIItems.Finders;     // Access to SearchCriteria 

// Define shortcuts
using Application = TestStack.White.Application; 
using Button = TestStack.White.UIItems.Button;
using Label = TestStack.White.UIItems.Label;
using CheckBox = TestStack.White.UIItems.CheckBox; 
using RadioButton = TestStack.White.UIItems.RadioButton;  
using TextBox = TestStack.White.UIItems.TextBox;
using ComboBox = TestStack.White.UIItems.ListBoxItems.ComboBox;

namespace AlarmClock.Tests 
{

    [TestFixture] 
    public class AlarmClockTest
    {     
        [Test]       // Verify GUI window initializes         
        public void frmMain_CheckUI_Initialize()         
        {             
            Application application = Application.Launch("AlarmClock.exe");             
            Window window1 = application.GetWindow("Alarm", InitializeOption.NoCache);
            
            Assert.IsNotNull(window1);

            window1.Dispose();
            application.Close();             
        }

        [Test]       // Verify Alarm File text box (textBox1) is not blank         
        public void frmMain_AlarmFile_Default()
        {
            Application application = Application.Launch("AlarmClock.exe");
            Window window1 = application.GetWindow("Alarm", InitializeOption.NoCache);

            // Finds the Alarm File comboBox  
            var File = window1.Get<TextBox>(SearchCriteria.ByAutomationId("textBox1"));

            Assert.AreNotEqual(File.Text, "");

            window1.Dispose();
            application.Close();
        }

        [Test]         // Verify lblTime = system time         
        public void frmMain_lblTime_EQ_SystemTime()
        {
            Application application = Application.Launch("AlarmClock.exe");
            Window window = application.GetWindow("Alarm", InitializeOption.NoCache);
            
            System.Threading.Thread.Sleep(1000);   //wait 1 second
            var time = window.Get<Label>(SearchCriteria.ByAutomationId("lblTime"));

            Assert.AreEqual(time.Text, System.DateTime.Now.ToShortTimeString());

            window.Dispose();
            application.Close();
        }
        
        [Test]         // Verify txtBoxNote is "Note"         
        public void frmMain_txtBoxNote_Is_Note()
        {
            Application application = Application.Launch("AlarmClock.exe");
            Window window = application.GetWindow("Alarm", InitializeOption.NoCache);
                       
            // test text box
            var Note = window.Get<TextBox>(SearchCriteria.ByAutomationId("txtBoxNote"));

            Assert.AreEqual(Note.Text, "Note");

            window.Dispose();
            application.Close();
        }
       
        [Test]         // Verify Hour comboBox can be set from 1 to 12 
        public void frmMain_cboHourTest()         
        {
            Application application = Application.Launch("AlarmClock.exe");
            Window window2 = application.GetWindow("Alarm", InitializeOption.NoCache); 

            int intHr = 1;
            do{
                window2.WaitWhileBusy();
                // convert int to string
                string strHr = intHr.ToString();

                //inputs the Hour into the Hour dropdown  
                var Hour = window2.Get<ComboBox>(SearchCriteria.ByAutomationId("cboHours"));  
                Hour.Click();  
                window2.WaitWhileBusy();
                Hour.Select(strHr);
                window2.WaitWhileBusy();
                Assert.AreEqual(Hour.SelectedItemText, strHr);

                intHr++;
            } while (intHr<13);

            window2.Dispose();
            application.Close();    
        }

        [Test]         // Verify Minutes comboBox can be set from 0 to 59
        public void frmMain_cboMinutesTest()   
        {
            Application application = Application.Launch("AlarmClock.exe");
            Window window3 = application.GetWindow("Alarm", InitializeOption.NoCache); 

            int intMin = 0;
            do{
                window3.WaitWhileBusy();
                // convert int to string
                string strMin = intMin.ToString();
                // corection for single digit
                if (strMin == "0") strMin = "00";
                if (strMin == "1") strMin = "01";
                if (strMin == "2") strMin = "02";
                if (strMin == "3") strMin = "03";
                if (strMin == "4") strMin = "04";
                if (strMin == "5") strMin = "05";
                if (strMin == "6") strMin = "06";
                if (strMin == "7") strMin = "07";
                if (strMin == "8") strMin = "08";
                if (strMin == "9") strMin = "09";
                //inputs the Minutes into the Minutes dropdown  
                var Minutes = window3.Get<ComboBox>(SearchCriteria.ByAutomationId("cboMinutes"));
                window3.WaitWhileBusy(); 
                Minutes.Click();  
                window3.WaitWhileBusy();  
                Minutes.Select(strMin);
                window3.WaitWhileBusy();
                Assert.AreEqual(Minutes.SelectedItemText, strMin);
            
                intMin++;
            } while (intMin < 60);
            
            window3.Dispose();
            application.Close();   
              
        }

        [Test]         // Verify AMPM combo box set to AM or PM 
        public void frmMain_cboAmPmTest()
        {
            Application application = Application.Launch("AlarmClock.exe");
            Window window4 = application.GetWindow("Alarm", InitializeOption.NoCache);
            
            window4.WaitWhileBusy();
            // Finds the AmPm comboBox  
            var AmPm = window4.Get<ComboBox>(SearchCriteria.ByAutomationId("cboAmPm"));
            // select AM
            AmPm.Click();
            window4.WaitWhileBusy();
            AmPm.Select("AM");
            window4.WaitWhileBusy();

            Assert.AreEqual(AmPm.SelectedItemText, "AM");
            
            // select PM
            AmPm.Click();
            window4.WaitWhileBusy();
            AmPm.Select("PM");
            window4.WaitWhileBusy();
            Assert.AreEqual(AmPm.SelectedItemText, "PM");

            window4.Dispose();
            application.Close();
        }

        [Test]         // Verify Activate button  
        public void frmMain_ActivateButtonTest()
        {
            // set an alarm to 7:00PM and slect an MP3 File
            Application application = Application.Launch("AlarmClock.exe");
            Window window = application.GetWindow("Alarm", InitializeOption.NoCache);

            window.WaitWhileBusy();
            // Set the Hour   
            var Hour = window.Get<ComboBox>(SearchCriteria.ByAutomationId("cboHours"));
            Hour.Click();
            window.WaitWhileBusy();
            Hour.Select("7");

            // Set the Minutes
            var Minutes = window.Get<ComboBox>(SearchCriteria.ByAutomationId("cboMinutes"));
            window.WaitWhileBusy();
            Minutes.Click();
            window.WaitWhileBusy();
            Minutes.Select("00");

            // Finds the AmPm comboBox  
            var AmPm = window.Get<ComboBox>(SearchCriteria.ByAutomationId("cboAmPm"));
            // select AM
            AmPm.Click();
            window.WaitWhileBusy();
            AmPm.Select("PM");

            // Finds the Alarm File comboBox  
            var File = window.Get<TextBox>(SearchCriteria.ByAutomationId("textBox1"));
            File.Text = @"G:\Mercer Masters\Fall 2013\SSE 659\Project3\MP3s\alarm01.mp3";

            // Finds the Activate Button  
            var Activate = window.Get<Button>(SearchCriteria.ByAutomationId("btnSetAlarm"));
            Activate.Click();

            // verify the Select button is not Disabled
            Assert.False(Activate.Enabled);

            window.Dispose();
            application.Close();
        }
        [Test]         // Verify Activate/Disable button  
        public void frmMain_ActivateDisableButtonTest()
        {
            // set an alarm to 7:00PM and slect an MP3 File
            Application application = Application.Launch("AlarmClock.exe");
            Window window = application.GetWindow("Alarm", InitializeOption.NoCache);

            window.WaitWhileBusy();
            // Set the Hour   
            var Hour = window.Get<ComboBox>(SearchCriteria.ByAutomationId("cboHours"));
            Hour.Click();
            window.WaitWhileBusy();
            Hour.Select("7");

            // Set the Minutes
            var Minutes = window.Get<ComboBox>(SearchCriteria.ByAutomationId("cboMinutes"));
            window.WaitWhileBusy();
            Minutes.Click();
            window.WaitWhileBusy();
            Minutes.Select("00");

            // Finds the AmPm comboBox  
            var AmPm = window.Get<ComboBox>(SearchCriteria.ByAutomationId("cboAmPm"));
            // select AM
            AmPm.Click();
            window.WaitWhileBusy();
            AmPm.Select("PM");

            // Finds the Alarm File comboBox  
            var File = window.Get<TextBox>(SearchCriteria.ByAutomationId("textBox1"));
            File.Text = @"G:\Mercer Masters\Fall 2013\SSE 659\Project3\MP3s\alarm01.mp3";

            // Finds the Activate Button  
            var Activate = window.Get<Button>(SearchCriteria.ByAutomationId("btnSetAlarm"));
            Activate.Click();

            // verify the Select button is not Disabled
            Assert.True(Activate.Enabled);
            
            // check text field
            Assert.AreEqual(Activate.Text,"Disable");

            // verify the label change back to "Activate" when disable is clicked
            Activate.Click();
            Assert.AreEqual(Activate.Text, "Activate");

            window.Dispose();
            application.Close();
        }

        [Test]         // Verify Snooze checkbox
        public void frmMain_EnableSnoozeCheckbox()
        {
            Application application = Application.Launch("AlarmClock.exe");
            Window window = application.GetWindow("Alarm", InitializeOption.NoCache);

            window.WaitWhileBusy();
            // find the Snooze checkbox
            var checkBox = window.Get<CheckBox>("chkSnooze");
            // Checked
            checkBox.Checked = true;
            Assert.True(checkBox.Checked);
            // UnChecked
            checkBox.Checked = false;
            Assert.False(checkBox.Checked);

            window.Dispose();
            application.Close();
        }
        [Test]         // Verify Loop Alarm checkbox
        public void frmMain_LoopAlarmCheckbox()
        {
            Application application = Application.Launch("AlarmClock.exe");
            Window window = application.GetWindow("Alarm", InitializeOption.NoCache);

            window.WaitWhileBusy();
            // find the Loop checkbox
            var checkBox = window.Get<CheckBox>("chkLoop");
            // Checked
            checkBox.Checked = true;
            Assert.True(checkBox.Checked);
            // UnChecked
            checkBox.Checked = false;
            Assert.False(checkBox.Checked);

            window.Dispose();
            application.Close();

        }
        [Test]         // Verify ActivateOnStartup checkbox
        public void frmMain_ActivateOnStartupCheckbox()
        {
            Application application = Application.Launch("AlarmClock.exe");
            Window window = application.GetWindow("Alarm", InitializeOption.NoCache);

            window.WaitWhileBusy();
            // find the Activate on Startup checkbox
            var checkBox = window.Get<CheckBox>("chkActivateStart");
            // Checked
            checkBox.Checked = true;
            Assert.True(checkBox.Checked);
            // UnChecked
            checkBox.Checked = false;
            Assert.False(checkBox.Checked);

            window.Dispose();
            application.Close();
        }
        [Test]         // Verify MinimizeToTray checkbox
        public void frmMain_MinimizeToTrayCheckbox()
        {
            Application application = Application.Launch("AlarmClock.exe");
            Window window = application.GetWindow("Alarm", InitializeOption.NoCache);

            window.WaitWhileBusy();
            // find the Minimize To Tray checkbox
            var checkBox = window.Get<CheckBox>("chkMin2Tray");
            // Checked
            checkBox.Checked = true;
            Assert.True(checkBox.Checked);
            // UnChecked
            checkBox.Checked = false;
            Assert.False(checkBox.Checked);

            window.Dispose();
            application.Close();
        }
        [Test]         // Verify FG button
        public void frmMain_FGbutton()
        {
            Application application = Application.Launch("AlarmClock.exe");
            Window window = application.GetWindow("Alarm", InitializeOption.NoCache);

            window.WaitWhileBusy();
            // find the Minimize To Tray checkbox
            var btnFG = window.Get<Button>("btnForeground");
            
            Assert.AreEqual(btnFG.Text,"FG");

            window.Dispose();
            application.Close();
        }
        [Test]         // Verify BG button
        public void frmMain_BGbutton()
        {
            Application application = Application.Launch("AlarmClock.exe");
            Window window = application.GetWindow("Alarm", InitializeOption.NoCache);

            window.WaitWhileBusy();
            // find the Minimize To Tray checkbox
            var btnFG = window.Get<Button>("btnBackground");

            Assert.AreEqual(btnFG.Text, "BG");

            window.Dispose();
            application.Close();
        }

    }
}
