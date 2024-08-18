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

namespace Seçim_VeriTabani
{
    public partial class OyGiris : Form
    {
        public OyGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MELIH\\MELIH;Initial Catalog=SeçimVeriTabani;Integrated Security=True");

        private void btntemizle_Click(object sender, EventArgs e)
        {
           
            txtaparti.Clear();
            txtbparti.Clear();
            txtcparti.Clear();
            txtdparti.Clear();
            txteparti.Clear();
            txtaparti.Focus();
        }

        private void btngrafik_Click(object sender, EventArgs e)
        {
            Grafikler grafikler = new Grafikler();
            grafikler.Show();
        }

        private void lnksehir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SehirEkle ekle = new SehirEkle();
            ekle.Show();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sehırler = new SqlCommand("select SEHIR from TBL_SEHIR ORDER BY SEHIR ASC", baglanti);
            SqlDataReader oku = sehırler.ExecuteReader();
            while (oku.Read())
            {
                cmbsehir.Items.Add(oku[0].ToString());
            }
            baglanti.Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand guncelle = new SqlCommand("update TBL_SEHIR set APARTI=@P1,BPARTI=@P2,CPARTI=@P3,DPARTI=@P4,EPARTI=@P5 WHERE SEHIR=@P6", baglanti);
            guncelle.Parameters.AddWithValue("@P1",txtaparti.Text);
            guncelle.Parameters.AddWithValue("@P2",txtbparti.Text);
            guncelle.Parameters.AddWithValue("@P3", txtcparti.Text);
            guncelle.Parameters.AddWithValue("@P4", txtdparti.Text);
            guncelle.Parameters.AddWithValue("@P5", txteparti.Text);
            guncelle.Parameters.AddWithValue("@P6", cmbsehir.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("YENİ OY GİRİŞİ BAŞARILI BİR ŞEKİLDE GERÇEKLEŞMİŞTİR","BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
