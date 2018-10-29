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
    public partial class yoneticigiris : Form
    {
        public yoneticigiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MESUT-EXPER\SQLMESUT;Initial Catalog=Kutuphane;Integrated Security=True");
            con.Open();

            SqlCommand cmd = new SqlCommand("Select * from Kayıt where KullanıcıAdı=@p1 and Şifre=@p2", con);
            cmd.Parameters.AddWithValue("@p1", lblyoneticigiris.Text);
            cmd.Parameters.AddWithValue("@p2", lblyoneticisifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    if (dr["Profil"].ToString() == "Kullanıcı")
                    {

                        MessageBox.Show("Normal Kullanıcı olarak giriş yapamazsınız", "Uyarı", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    }
                    else if (dr["Profil"].ToString() == "Yönetici")
                    {
                        Yonetici fr = new Yonetici();
                        fr.lblyoname.Text = lblyoneticigiris.Text;
                        fr.Show();
                        this.Hide();
                    }
                }
            }
            else
            {
                MessageBox.Show("Yönetici Adı veya Şifresini yanlış girdiniz", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void yoneticigiris_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }
    }
}
