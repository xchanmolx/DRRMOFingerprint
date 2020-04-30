using System;
using System.Windows.Forms;

namespace DRRMOFingerprintApp.UI
{
    public partial class VerifiedPerson : Form
    {
        public VerifiedPerson()
        {
            InitializeComponent();
        }

        private void VerifiedPerson_Load(object sender, EventArgs e)
        {
            lblName.Text = lblFName.Text + " " + lblLName.Text + " " + lblExName.Text;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
