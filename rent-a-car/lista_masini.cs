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
    public partial class lista_masini : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Data.mdf;Integrated Security=True;Connect Timeout=30");
        SqlCommand cmd= new SqlCommand();
        SqlDataReader dr;
        public lista_masini()
        {
            InitializeComponent();
        }

        private void lista_meniuri_Load(object sender, EventArgs e)
        {
            textBox_TEST.Text = "";
        }
        
        SqlDataReader reader;
        private void listView1_ItemActivate(object sender, EventArgs e)
        {
           //textBox_TEST.Text = listView1.SelectedItems[0].Text;
            int idd = Int32.Parse(listView1.SelectedItems[0].Text);
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
            else MessageBox.Show("erorr");
        }

        private void buttonLista_Click(object sender, EventArgs e)
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
        }

        private void buttonCauta_Click(object sender, EventArgs e)
        {
            string deCautat;
            deCautat = textBox_TEST.Text;
            listView1.Items.Clear();
            if (cn.State != ConnectionState.Open)
                cn.Open();
            cmd.CommandText = "select id,denumire,pret, comentariu from masini  WHERE denumire LIKE '%" + deCautat + "%' ";
            cmd.Connection = cn;
            dr = cmd.ExecuteReader();
            int count = 0;
            while (dr.Read())
            {
                count++;
                ListViewItem lv = new ListViewItem(dr[0].ToString());
                lv.SubItems.Add(dr[1].ToString());
                lv.SubItems.Add(dr[2].ToString());
                lv.SubItems.Add(dr[3].ToString());
                listView1.Items.Add(lv);
            }
            if (count == 0)
                MessageBox.Show("Nothing found");
            cn.Close();

        }
    }
}
