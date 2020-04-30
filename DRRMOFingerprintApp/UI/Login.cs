using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DRRMOFingerprintApp.UI
{
    public partial class Login : Form
    {
        private const string dbString = "DRRMOFingerprintDB";

        public Login()
        {
            InitializeComponent();
        }

        public async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Helper.CnnVal(dbString)))
                {
                    string query = "SELECT * FROM dbo.Account WHERE Username = '" + txtUsername.Text.Trim() + "' AND Password = '" + txtPassword.Text.Trim() + "'";
                    SqlDataAdapter sda = new SqlDataAdapter(query, connection);
                    DataTable dtbl = new DataTable();
                    await Task.Run(() => sda.Fill(dtbl));

                    if (dtbl.Rows.Count == 1)
                    {
                        this.Hide();
                        var main = new Main();

                        var db = new DataAccess();
                        var accounts = db.GetAccounts();

                        string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));

                        foreach (var account in accounts)
                        {
                            if (account.Username == txtUsername.Text.Trim() && account.Password == txtPassword.Text.Trim())
                            {
                                main.pctrBoxProfile.Image = Image.FromFile(paths + account.StringImage);
                                main.lblName.Text = account.FirstName + " " + account.LastName;
                            }
                        }

                        main.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please check your username and password", "Login Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsername.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error, login account", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
