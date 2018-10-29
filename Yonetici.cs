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
    public partial class Yonetici : Form
    {
        public Yonetici()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MESUT-EXPER\SQLMESUT;Initial Catalog=Kutuphane;Integrated Security=True");

        bool durum;

        public void mukerrer(){
           
        con.Open();

            SqlCommand sql = new SqlCommand("Select * from Kitap where isim=@p20 OR Raf=@p21", con);
            sql.Parameters.AddWithValue("@p20", txtisim.Text);
            sql.Parameters.AddWithValue("@p21", txtraf.Text);

            SqlDataReader datar = sql.ExecuteReader();
            if (datar.Read())
            {
                durum = false;
            }
            else
            {
                durum = true;
 
            }
            con.Close();
        }
        public void temizle()
        {
            txtid.Text = " ";
            txtisim.Text = " ";
            txtyazar.Text = " ";
            txttur.Text = " ";
            txtsayfa.Text = " ";
            txtraf.Text = " ";
            txtbilgi.Text = " ";


        }
        public void listele()
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=MESUT-EXPER\SQLMESUT;Initial Catalog=Kutuphane;Integrated Security=True");
            con.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * from Kitap", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            mukerrer();
            if (durum == true)
            {
                
                con.Open();
                SqlCommand ekle = new SqlCommand("insert into Kitap(isim,Yazar,Tür,Sayfasayı,Raf,Bilgi) values(@p1,@p2,@p3,@p4,@p5,@p6)", con);

                ekle.Parameters.AddWithValue("@p1", txtisim.Text);
                ekle.Parameters.AddWithValue("@p2", txtyazar.Text);
                ekle.Parameters.AddWithValue("@p3", txttur.Text);
                ekle.Parameters.AddWithValue("@p4", int.Parse(txtsayfa.Text));
                ekle.Parameters.AddWithValue("@p5", txtraf.Text);
                ekle.Parameters.AddWithValue("@p6", txtbilgi.Text);

                ekle.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Kitap kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bu kayıt zaten mevcut", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            temizle();

            listele();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MESUT-EXPER\SQLMESUT;Initial Catalog=Kutuphane;Integrated Security=True");
            con.Open();
            DialogResult secim = new DialogResult();
            secim=MessageBox.Show("Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (secim==DialogResult.Yes) { 
            SqlCommand sil = new SqlCommand("Delete From Kitap where kitapid=@p1", con);

            sil.Parameters.AddWithValue("@p1", txtid.Text);


            sil.ExecuteNonQuery();
            con.Close();

                MessageBox.Show("Kitap silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            temizle();

            listele();
        }

        private void btnkitapara_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MESUT-EXPER\SQLMESUT;Initial Catalog=Kutuphane;Integrated Security=True");
            con.Open();

            SqlCommand ara = new SqlCommand("Select * from Kitap where isim like '%"+txtkitapara.Text+"%'", con);
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            yoneticigiris yo = new yoneticigiris();
            yo.Show();
            this.Hide();
        }
    }
}
