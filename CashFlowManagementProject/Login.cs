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
using System.Configuration;
namespace CashFlowManagementProject
{
    public partial class Login : Form
    {
        public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["connect"].ToString());
        public Login()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn thoát", "",
                  MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Đóng form
                e.Cancel = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_Username.Text == "")
            {
                this.errorProvider1.SetError(textBox_Username, "Username is required");
            }
            if (textBox_Password.Text == "")
            {
                this.errorProvider2.SetError(textBox_Password, "Password is required");
            }
            else
            {
                con.Open();
                int count = 0;
                string sql = ("Select * from Users where Email = '" + textBox_Username.Text + "' and Password = '" + textBox_Password.Text + "'");
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.CommandType = CommandType.Text;
                SqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    Menu menu = new Menu();
                    this.Hide();
                    menu.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Check your username and password");
                }
                con.Close();

            }
        }

        private void linkLabel_Register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.ShowDialog();
        }
    }
}
