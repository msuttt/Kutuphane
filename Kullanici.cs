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

namespace Kutuphane
{
    public partial class Kullanici : Form
    {
        public Kullanici()
        {
            InitializeComponent();
        }

        
        public void listele()
        {
            SqlConnection con = new SqlConnection(@"Data Source=MESUT-EXPER\SQLMESUT;Initial Catalog=Kutuphane;Integrated Security=True");
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * from Kitap", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView3.DataSource = dt;

            con.Close();
        }

        public void AlınanKitaplar() {
            SqlConnection liste = new SqlConnection(@"Data Source=MESUT-EXPER\SQLMESUT;Initial Catalog=Kutuphane;Integrated Security=True");
            liste.Open();

            SqlDataAdapter adap = new SqlDataAdapter("Select Kitapismi from KitapKayıt where Alan='" + lblname.Text + "'", liste);
            DataTable table = new DataTable();
            adap.Fill(table);
            KitapListe.DataSource = table;

            liste.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            AlınanKitaplar();
            listele();
        }

        public void lblname_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MESUT-EXPER\SQLMESUT;Initial Catalog=Kutuphane;Integrated Security=True");
            con.Open();

            SqlCommand ara = new SqlCommand("Select * from Kitap where isim like '%" + textBox1.Text + "%'", con);
            SqlDataReader dr = ara.ExecuteReader();
            while (dr.Read())
            {
                ListViewItem ekle = new ListViewItem();


                ekle.Text = dr["kitapid"].ToString();

                ekle.SubItems.Add(dr["isim"].ToString());
                ekle.SubItems.Add(dr["Yazar"].ToString());
                ekle.SubItems.Add(dr["Tür"].ToString());
                ekle.SubItems.Add(dr["Sayfasayı"].ToString());
                ekle.SubItems.Add(dr["Raf"].ToString());
                ekle.SubItems.Add(dr["Bilgi"].ToString());

                listView1.Items.Add(ekle);

            }

            con.Close();
        }


        private void dataGridView3_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            
        }

        private void dataGridView3_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           

        }

        private void dataGridView3_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            SqlConnection connect = new SqlConnection(@"Data Source=MESUT-EXPER\SQLMESUT;Initial Catalog=Kutuphane;Integrated Security=True");
            connect.Open();

            SqlCommand komut = new SqlCommand("Select * from Kitap where Bilgi=@p5", connect);
            komut.Parameters.AddWithValue("@p5", dataGridView3.CurrentRow.Cells[6].Value.ToString());

            SqlDataReader rd = komut.ExecuteReader();



            if (rd.Read())
            {
                if (rd["Bilgi"].ToString() == "Kütüphanede")
                {
                    SqlConnection con = new SqlConnection(@"Data Source=MESUT-EXPER\SQLMESUT;Initial Catalog=Kutuphane;Integrated Security=True");
                    con.Open();


                    SqlCommand kaydet = new SqlCommand("insert into KitapKayıt(Kitapismi,Alan) values(@p1,@p2)", con);
                    kaydet.Parameters.AddWithValue("@p1", dataGridView3.CurrentRow.Cells[1].Value.ToString());
                    kaydet.Parameters.AddWithValue("@p2", lblname.Text);


                    kaydet.ExecuteNonQuery();

                    con.Close();

                    SqlConnection zon = new SqlConnection(@"Data Source=MESUT-EXPER\SQLMESUT;Initial Catalog=Kutuphane;Integrated Security=True");
                    zon.Open();

                    SqlCommand cmd = new SqlCommand("Update Kitap Set Bilgi=@p3 where isim=@p4", zon);

                    cmd.Parameters.AddWithValue("@p3", "Alındı");
                    cmd.Parameters.AddWithValue("@p4", dataGridView3.CurrentRow.Cells[1].Value.ToString());



                    cmd.ExecuteNonQuery();
                    zon.Close();

                    MessageBox.Show("Bu kitabı aldınız", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rd["Bilgi"].ToString() == "Alındı")
                {
                    MessageBox.Show("Kitap daha önceden alınmış", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
            }
          

            connect.Close();

            listele();


        }

        private void KitapListe_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            SqlConnection def = new SqlConnection(@"Data Source=MESUT-EXPER\SQLMESUT;Initial Catalog=Kutuphane;Integrated Security=True");
            def.Open();

            DialogResult sec = new DialogResult();
            sec = MessageBox.Show("Emim misiniz", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sec == DialogResult.Yes)
            {

                SqlCommand commando = new SqlCommand("Update Kitap Set Bilgi=@p13 where isim=@p12", def);

                commando.Parameters.AddWithValue("@p12", KitapListe.CurrentRow.Cells[0].Value.ToString());
                commando.Parameters.AddWithValue("@p13", "Kütüphanede");


                commando.ExecuteNonQuery();

                def.Close();



                SqlConnection abc = new SqlConnection(@"Data Source=MESUT-EXPER\SQLMESUT;Initial Catalog=Kutuphane;Integrated Security=True");
                abc.Open();


                SqlCommand cıkar = new SqlCommand("Delete From KitapKayıt where Kitapismi=@p11", abc);
                cıkar.Parameters.AddWithValue("@p11", KitapListe.CurrentRow.Cells[0].Value.ToString());



                cıkar.ExecuteNonQuery();

                abc.Close();



                MessageBox.Show("Kitabı teslim ettiniz", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);



                listele();

            }

        }

        private void btnyenile_Click(object sender, EventArgs e)
        {
            AlınanKitaplar();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login lo = new login();
            lo.Show();
            this.Hide();
        }
    }
}
