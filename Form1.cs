using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_TinhTong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtKQ_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            double so1, so2, ketqua;
            so1 = Convert.ToDouble(txtso1.Text);
            so2 = Convert.ToDouble(txtso2.Text);
            ketqua = so1 + so2;
            txtKQ.Text=ketqua.ToString();
            lblKQ.Text = ketqua.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double so1, so2, ketqua;
            so1 = Convert.ToDouble(txtso1.Text);
            so2 = Convert.ToDouble(txtso2.Text);
            ketqua = so1 * so2;
            txtKQ.Text = ketqua.ToString();
            lblKQ.Text = ketqua.ToString();
        }

        private void btntinhhieu_Click(object sender, EventArgs e)
        {
            double so1, so2, ketqua;
            so1 = Convert.ToDouble(txtso1.Text);
            so2 = Convert.ToDouble(txtso2.Text);
            ketqua = so1 - so2;
            txtKQ.Text = ketqua.ToString();
            lblKQ.Text = ketqua.ToString();
        }

        private void btntinhthuong_Click(object sender, EventArgs e)
        {
            double so1, so2, ketqua;
            so1 = Convert.ToDouble(txtso1.Text);
            so2 = Convert.ToDouble(txtso2.Text);
            if (so2 == 0)
            {
                // báo lỗi
                // txtKQ . text = "không thể chia cho 0";
            }
            else
            {
                ketqua = so1 / so2;
            txtKQ.Text = ketqua.ToString();
            lblKQ.Text = ketqua.ToString();
            }
            
        }
    }
}
