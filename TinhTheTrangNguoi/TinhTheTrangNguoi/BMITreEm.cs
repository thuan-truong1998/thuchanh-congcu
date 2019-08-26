using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TinhTheTrangNguoi
{
    public partial class BMITreEm : Form
    {
        public BMITreEm()
        {
            InitializeComponent();
        }

        private void BtnTinhBMI_Click(object sender, EventArgs e)
        {
            float chieucao, cannang,ketqua,chiso;
            string result;

            chieucao = (float.Parse(txtChieuCao.Text))/100;//doi cm sang m
            
            cannang = float.Parse(txtCanNang.Text);

            chiso = (cannang / (chieucao * 2));
            if(chiso < 14.2)
            {
                result = "Thieu Can";
            }else if(chiso < 18.1)
            {
                result = "suc khoe dinh duong tot";
            }else if(chiso < 19.1)
            {
                result = "nguy co beo phi";
            }
            else
            {
                result = "beo phi";
            }

            lblKetQua.Text = result;


        }
    }
}
