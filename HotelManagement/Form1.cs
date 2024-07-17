using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HotelManagement
{
    public partial class Form1 : Form
    {
        funtion fn = new funtion();
        string query;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            query = "select username,pass from employee where username = '" + txtUsername.Text + "'and pass = '" + txtPassword.Text + "'";
            DataSet ds = fn.GetData(query);
            if (ds.Tables[0].Rows.Count != 0)
            {
                labelError.Visible = false;
                Dashboard dash = new Dashboard();
                this.Hide();
                dash.Show();
            } else {
                labelError.Visible = true;
                txtPassword.Clear();
            }
        }
    }
}
