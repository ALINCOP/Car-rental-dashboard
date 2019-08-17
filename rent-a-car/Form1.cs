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

namespace rentAcar
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Data.mdf;Integrated Security=True;Connect Timeout=30");
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From useri where username='" + textBoxUserName.Text + "' and password = '" + textBoxPassword.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Home form = new Home();
                form.Show();
                
            }
            else
            {
                MessageBox.Show("Datele de conectare nu sunt corecte");
            }
            con.Close();

        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text == "" || textBoxPassword.Text == "")
            {
                MessageBox.Show("Introdu date!");
            }
            else
            {

                SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From useri where username='" + textBoxUserName.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MessageBox.Show("Exista deja un cont cu acest nume");
            }
            else
            {
                    SqlCommand cmd;
                    cmd = new SqlCommand("insert into useri(username,password) values(@us,@pw)", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@us", textBoxUserName.Text);
                    cmd.Parameters.AddWithValue("@pw", textBoxPassword.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Cont creat!");
            }

            }
        }
    }
}
