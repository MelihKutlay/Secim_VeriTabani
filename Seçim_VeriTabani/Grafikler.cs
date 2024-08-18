using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seçim_VeriTabani
{
    public partial class Grafikler : Form
    {
        public Grafikler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MELIH\\MELIH;Initial Catalog=SeçimVeriTabani;Integrated Security=True");

        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand sehir = new SqlCommand("select SEHIR from TBL_SEHIR", baglanti);
            SqlDataReader getir = sehir.ExecuteReader();
            while (getir.Read())
            {
                cmbsehır.Items.Add(getir[0]);
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand topla = new SqlCommand("select sum(APARTI),sum(BPARTI),sum(CPARTI),sum(DPARTI),sum(EPARTI) from TBL_SEHIR", baglanti);
            SqlDataReader oku = topla.ExecuteReader();
            while (oku.Read())
            {
                chart1.Series["PARTİLER"].Points.AddXY("A PARTİ", oku[0]);
                chart1.Series["PARTİLER"].Points.AddXY("B PARTİ",oku[1]);
                chart1.Series["PARTİLER"].Points.AddXY("C PARTİ", oku[2]);
                chart1.Series["PARTİLER"].Points.AddXY("D PARTİ", oku[3]);
                chart1.Series["PARTİLER"].Points.AddXY("E PARTİ", oku[4]);
            }
            baglanti.Close();
        }

        private void cmbsehır_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand oran = new SqlCommand("select * from TBL_SEHIR where SEHIR=@p1 ", baglanti);
                oran.Parameters.AddWithValue("@p1", cmbsehır.Text);
                SqlDataReader oku = oran.ExecuteReader();
                while (oku.Read())
                {
                    proga.Value = int.Parse(oku[2].ToString());
                    progb.Value = int.Parse(oku[3].ToString());
                    progc.Value = int.Parse(oku[4].ToString());
                    progd.Value = int.Parse(oku[5].ToString());
                    proge.Value = int.Parse(oku[6].ToString());

                    lbla.Text = oku[2].ToString();
                    lblb.Text = oku[3].ToString();
                    lblc.Text = oku[4].ToString();
                    lbld.Text = oku[5].ToString();
                    lble.Text = oku[6].ToString();
                }
                baglanti.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }
     

        private void btncikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            OyGiris frm = new OyGiris();
            frm.Show();
            this.Close();
        }
    }
}
