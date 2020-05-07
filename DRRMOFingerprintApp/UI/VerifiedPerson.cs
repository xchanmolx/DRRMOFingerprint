using System;
using System.ComponentModel;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using DRRMOFingerprintApp.Model;

namespace DRRMOFingerprintApp.UI
{
    public partial class VerifiedPerson : Form
    {
        DataAccess db = new DataAccess();

        public VerifiedPerson()
        {
            InitializeComponent();

            GetLocalDate();

            // Get button from Main form
            Button button = Application.OpenForms["Main"].Controls["btnOn"] as Button;
            if (button.Enabled == true)
            {
                System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
                timer.Tick += new EventHandler(btnClose_Click);
                timer.Interval = 2000; // 2 seconds
                timer.Start();
            }
        }

        private void VerifiedPerson_Load(object sender, EventArgs e)
        {
            GetFNameLNameExName();
        }

        public void GetLocalDate()
        {
            // As of Date
            DateTime localDate = DateTime.Now;
            lblLocalDateNow.Text = Convert.ToString(localDate);
        }

        public void GetFNameLNameExName()
        {
            lblName.Text = lblFName.Text + " " + lblLName.Text + " " + lblExName.Text;
        }

        private async void VerifiedPerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                // Save attendane to table
                var attendance = new Attendance();
                attendance.FirstName = lblFName.Text;
                attendance.LastName = lblLName.Text;
                attendance.OfficeName = lblOfficeName.Text;
                attendance.Gender = lblGender.Text;
                attendance.Designation = lblDesignation.Text;
                attendance.LocalDate = lblLocalDateNow.Text;

                await db.InsertAttendance(attendance);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, insert attendance", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
