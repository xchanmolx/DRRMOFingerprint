using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;
using DRRMOFingerprintApp.Model;

namespace DRRMOFingerprintApp
{
    public partial class Register : Form
    {
        private DPFP.Template Template;

        readonly DataAccess db = new DataAccess();
        List<PersonTest> people = new List<PersonTest>();

        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            people = db.GetPeople();
            Lists();
        }

        private void Clean()
        {
            txtFirstName.Text = "";
        }

        private void Lists()
        {
            try
            {
                var persons = from person in people select new
                {
                    Id = person.Id,
                    FullName = person.FullName
                };

                if (persons != null)
                {
                    dgvLists.DataSource = persons.ToList();
                    dgvLists.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            CaptureFingerprint captureFingerprint = new CaptureFingerprint();
            captureFingerprint.OnTemplate += this.OnTemplate;
            captureFingerprint.ShowDialog();
        }

        private void OnTemplate(DPFP.Template template)
        {
            this.Invoke(new Function(delegate ()
            {
                Template = template;
                btnSave.Enabled = (Template != null);
                if (Template != null)
                {
                    MessageBox.Show("The fingerprint template is ready for fingerprint verification.", "Fingerprint Enrollment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFingerprint.Text = "Fingerprint captured correctly";
                }
                else
                {
                    MessageBox.Show("The fingerprint template is not valid. Repeat fingerprint enrollment", "Fingerprint Enrollment Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] streamFingerprint = Template.Bytes;

                PersonTest person = new PersonTest
                {
                    FullName = txtFirstName.Text,
                    Fingerprint = streamFingerprint
                };

                using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("UsersDB")))
                {
                    string query = $"INSERT INTO Person (FullName, Fingerprint) VALUES (@FullName, @Fingerprint)";
                    connection.Execute(query, new { person.FullName, person.Fingerprint }, commandType: CommandType.Text);
                }

                people.Add(person);

                MessageBox.Show("Record added to DB successfully", "Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clean();
                Lists();
                Template = null;
                btnSave.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
