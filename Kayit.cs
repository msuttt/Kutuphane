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
    public partial class Kayit : Form
    {
        public Kayit()
        {
            InitializeComponent();
        }

        private void Kayit_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MESUT-EXPER\SQLMESUT;Initial Catalog=Kutuphane;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("insert into Kayıt(KullanıcıAdı,Şifre,Profil) values(@p1,@p2,@p3)", con);
            cmd.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            cmd.Parameters.AddWithValue("@p2", txtSifre.Text);
            cmd.Parameters.AddWithValue("@p3", "Kullanıcı");

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Kaydınız başarıyla gerçekleşti", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            login fr = new login();
            fr.Show();
            this.Hide();
        
        }
    }
}
