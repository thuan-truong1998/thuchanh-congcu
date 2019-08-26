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
    public partial class BMINu : Form
    {
        public BMINu()
        {
            InitializeComponent();
        }

        private void BtnTinhBMI_Click(object sender, EventArgs e)
        {
            float chieucao, cannang, ketqua, chiso;
            string result;

            chieucao = (float.Parse(txtChieuCao.Text)) / 100;//doi cm sang m

            cannang = float.Parse(txtCanNang.Text);

            chiso = (cannang / (chieucao * 2));
            if (chiso < 18.5)
            {
                result = "Thieu Can";
            }
            else if (chiso < 22.9)
            {
                result = "Binh Thuong";
            }
            else if (chiso <= 23)
            {
                result = "Thua Can Nen Van Dong";
            }
            else if (chiso <29.9 )
            {
                result = "Tien Beo Phi";
            }
            else if( chiso < 34.9)
            {
                result = "Beo Phi Muc Do I";
            }
            else if(chiso < 39.9)
            {
                result = "Beo Phi Muc Do II";
            }
            else
            {
                result = "Beo Phi Muc Do III";
            }

            lblKetQua.Text = result;

        }
    }
}
