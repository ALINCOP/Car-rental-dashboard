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
using System.IO;

namespace rentAcar
{
    public partial class adauga_masina : Form
    {
        public adauga_masina()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Data.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand command;
        string imgLoc = "";
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "JPG Files (*.jpg)|*.jpg|PNG files (*.png)|*.png|All files (*.*)|*.*";
                dlg.Title = "Selecteaza poza pentru masina";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    imgLoc = dlg.FileName.ToString();
                    meniuPic.ImageLocation = imgLoc;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] img = null;
                FileStream fs = new FileStream(imgLoc, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fs);
                img = br.ReadBytes((int)fs.Length);
                               
                string sql = "Insert into masini(denumire, pret, comentariu, imagine) values(@numeMasina,@pretMasina,@coment,@img)";
                if (conn.State != ConnectionState.Open)
                    conn.Open();
                command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@numeMasina", textBox_numeMasina.Text);
                command.Parameters.AddWithValue("@pretMasina", textBox_Pret.Text);
                command.Parameters.AddWithValue("@coment", textBox_Comentariu.Text);
                command.Parameters.Add(new SqlParameter("@img", img));
                int x = command.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(x.ToString() + " inregistrare adaugata.");
                Hide();
                
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
