using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai13_tinhcanchi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            string[] canarr = { "canh", "tân", "nhâm", "quý", "giáp", "ất", "bính", "đinh", "mậu", "kỷ" };
            string[] chiarr = { "thân", "dậu", "tuất", "hợi", "tý", "sửu", "dần", "mẹo", "thìn", "tỵ", "ngọ", " mùi", };
            string giatritrave = canarr[Convert.ToInt32(txtnam.Text) % 10] + " " + chiarr[Convert.ToInt32(txtnam.Text) % 12];
            txtkq.Text = giatritrave;
            for (int nam = 2000; nam <= 2050; nam++)
            {
                lsbnam.Items.Add(nam + " - " + canarr[nam % 10] + " " + chiarr[nam % 12]);
            }
        }
        private void lsbkq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
