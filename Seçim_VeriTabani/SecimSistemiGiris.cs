using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seçim_VeriTabani
{
    public partial class SecimSistemiGiris : Form
    {
        public SecimSistemiGiris()
        {
            InitializeComponent();
        }

        private void picturegiris_Click(object sender, EventArgs e)
        {
            OyGiris frm = new OyGiris();
            frm.Show();
            this.Hide();
        }
    }
}
