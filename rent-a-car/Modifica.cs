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
    public partial class Modifica : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Data.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataReader reader;
        public Modifica()
        {
            InitializeComponent();
        }

        private void buttonModifica_Click(object sender, EventArgs e)
        {
            if (textBoxDenumire.Visible == false)
                textBoxDenumire.Visible = true;
            if (textBoxPret.Visible == false)
                textBoxPret.Visible = true;
            if (textBoxDescriere.Visible == false)
                textBoxDescriere.Visible = true;
            if (buttonSalveaza.Visible == false)
                buttonSalveaza.Visible = true;
            

        }

        private void buttonSalveaza_Click(object sender, EventArgs e)
        {
            textBoxDenumire.Visible = false;
            textBoxPret.Visible = false;
            textBoxDescriere.Visible = false;
            buttonSalveaza.Visible = false;
            SqlCommand command;
            

            if (textBoxDenumire.Text != "" && textBoxPret.Text != "")
            {
                string sql = "update masini set denumire=@denum, pret=@pr, comentariu=@comm where Id=@idd";
                if (cn.State != ConnectionState.Open)
                    cn.Open();
                command = new SqlCommand(sql, cn);
                command.Parameters.AddWithValue("@idd", idd);
                command.Parameters.AddWithValue("@denum", textBoxDenumire.Text);
                command.Parameters.AddWithValue("@pr", textBoxPret.Text);
                command.Parameters.AddWithValue("@comm", textBoxDescriere.Text);
                int x = command.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show(x.ToString() + " inregistrare salvata.");
                
                
            }
            else
            {
                MessageBox.Show("Select from the list");
            }

            listView1.Items.Clear();
            if (cn.State != ConnectionState.Open)
                cn.Open();
            cmd.CommandText = "select id,denumire,pret, comentariu from masini";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[2].ToString());
                lv.SubItems.Add(dr[3].ToString());
                listView1.Items.Add(lv);
            }
            cn.Close();
        }
        int idd;
        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            idd = Int32.Parse(listView1.SelectedItems[0].Text);
            string denumire, pret, comentariu;
            denumire = listView1.SelectedItems[0].SubItems[1].Text;
            pret = listView1.SelectedItems[0].SubItems[2].Text;
            comentariu = listView1.SelectedItems[0].SubItems[3].Text;
            SqlCommand command;
            if (cn.State != ConnectionState.Open)
                cn.Open();
            string sql = "select imagine from masini where id='" + idd + "'";
            command = new SqlCommand(sql, cn);
            reader = command.ExecuteReader();
            reader.Read();
            if (reader.HasRows)
            {
                byte[] img = (byte[])(reader[0]);
                MemoryStream ms = new MemoryStream(img);
                meniuPic.Image = Image.FromStream(ms);
                reader.Close();
            }
            else MessageBox.Show("eroare");
            textBoxDenumire.Text = denumire;
            textBoxPret.Text = pret;
            textBoxDescriere.Text = comentariu;
        }

        private void Modifica_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            if (cn.State != ConnectionState.Open)
                cn.Open();
            cmd.CommandText = "select id,denumire,pret, comentariu from masini";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[2].ToString());
                lv.SubItems.Add(dr[3].ToString());
                listView1.Items.Add(lv);
            }
            cn.Close();

            listView1.Items.Clear();
            if (cn.State != ConnectionState.Open)
                cn.Open();
            cmd.CommandText = "select id,denumire,pret, comentariu from masini";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[2].ToString());
                lv.SubItems.Add(dr[3].ToString());
                listView1.Items.Add(lv);
            }
            cn.Close();

            listView1.Items.Clear();
            if (cn.State != ConnectionState.Open)
                cn.Open();
            cmd.CommandText = "select id,denumire,pret, comentariu from masini";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[2].ToString());
                lv.SubItems.Add(dr[3].ToString());
                listView1.Items.Add(lv);
            }
            cn.Close();
        }

       

        private void buttonSterge_Click(object sender, EventArgs e)
        {
            SqlCommand command;
            string sql = "delete from masini where Id=@id";
            if (cn.State != ConnectionState.Open)
                cn.Open();
            command = new SqlCommand(sql, cn);
            command.Parameters.AddWithValue("@id", idd);
            command.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("Successfully deleted");

            listView1.Items.Clear();
            if (cn.State != ConnectionState.Open)
                cn.Open();
            cmd.CommandText = "select id,denumire,pret, comentariu from masini";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[2].ToString());
                lv.SubItems.Add(dr[3].ToString());
                listView1.Items.Add(lv);
            }
            cn.Close();

        }
    }
}
