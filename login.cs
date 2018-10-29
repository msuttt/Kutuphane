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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
       
        private void linkyonetici_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            yoneticigiris fr = new yoneticigiris();
            fr.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayit kyt = new Kayit();
            kyt.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         SqlConnection con = new SqlConnection(@"Data Source=MESUT-EXPER\SQLMESUT;Initial Catalog=Kutuphane;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Kayıt where KullanıcıAdı=@p1 and Şifre=@p2", con);
            cmd.Parameters.AddWithValue("@p1", txtkullanici.Text);
            cmd.Parameters.AddWithValue("@p2", txtsifre.Text);

         SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (dr["Profil"].ToString() == "Yönetici")
                    {

                        MessageBox.Show("Yönetici olarak giremezsiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                    else if (dr["Profil"].ToString() == "Kullanıcı")
                    {

                        
                        Kullanici fr = new Kullanici();
                        fr.lblname.Text = txtkullanici.Text;
                        fr.Show();
                        this.Hide();
                    }
                }

            }
            else
            {

                MessageBox.Show("Kullanıcı Adı veya şifre yanlış girildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            con.Close();
            
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
