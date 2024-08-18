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
    public partial class SehirEkle : Form
    {
        public SehirEkle()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=MELIH\\MELIH;Initial Catalog=SeçimVeriTabani;Integrated Security=True");

        private void btnekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand yenisehir = new SqlCommand("insert into TBL_SEHIR (SEHIR) VALUES (@P1)", baglanti);
            yenisehir.Parameters.AddWithValue("@P1", txtyenisehir.Text);
            yenisehir.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("YENİ ŞEHİR BAŞARILI BİR ŞEKİLDE EKLENMİŞTİR", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtyenisehir.Clear();

        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            OyGiris frm = new OyGiris();
            frm.Show();
            this.Close();
        }
    }
}
