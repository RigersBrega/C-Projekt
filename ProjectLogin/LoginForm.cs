using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Threading;
using System.Runtime.Remoting.Contexts;

namespace ProjectLogin
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        SqlConnection con = DbConnection.getConnection();
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                if (isUserAuthenticated(con))
                {
                    openMainPage();
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password!");
                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private Boolean isUserAuthenticated(SqlConnection con)
        {
            DataTable dt = new DataTable();
            String command = "Select count(*) from [user] where username = @username and password = @password";
            using (SqlCommand sqlCommand = new SqlCommand(command, con))
            {
                sqlCommand.Parameters.AddWithValue("@username", UnameTb.Text);
                sqlCommand.Parameters.AddWithValue("@password", PasswordTB.Text);
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand))
                    dataAdapter.Fill(dt);
            }
            if (dt.Rows[0][0].ToString() == "1")
                return true;
            else
                return false;
        }

        private void openMainPage()
        {
            this.Hide();
            Thread thrd = new Thread(() => {
                Application.Run(new MainPage());
            });
            thrd.Start();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void UnameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
