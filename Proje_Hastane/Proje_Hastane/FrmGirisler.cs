using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnHastaGirişi_Click(object sender, EventArgs e)
        {
            FrmHastaGiris fr= new FrmHastaGiris();
            fr.Show();
            this.Hide();
        }

        private void btnDoktorGirişi_Click(object sender, EventArgs e)
        {
            FrmDoktorGiriş fr = new FrmDoktorGiriş();
            fr.Show();
            this.Hide();
        }

        private void btnSekreterGirişi_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris fr = new FrmSekreterGiris();
            fr.Show();
            this.Hide();
        }

       
    }
}
