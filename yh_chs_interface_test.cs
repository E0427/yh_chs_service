using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CHS.ChengDu;

namespace yh_chs_service
{
    public partial class yh_chs_interface_test : Form
    {
        public yh_chs_interface_test()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string _output = "";
            string _input = "{	\"mdtrtarea_admvs\":\"510106\"," +
                "	\"fixmedins_code\":\"H51010600411\"," +
                "	\"fixmedins_name\":\"成都西区安琪儿妇产医院有限公司\"," +
                "	\"psn_no\":\"51000051010000000011159050\"," +
                "	\"setl_id\":\"510100CD000010346667\"," +
                "	\"mdtrt_id\":\"510100CD000015298722\"," +
                "	\"med_type\":\"52\"	}";
            CHSChengDu.CHS_Pint(_input,ref _output);
            MessageBox.Show(_output,"提示");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int code = -1;
            string msg = "";
            CHSChengDu.CHS_Init(ref code, ref msg);
            MessageBox.Show("code:" +code.ToString() + "\nmsg:" + msg, "提示");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int code = -1;
            string msg = "";
            CHSChengDu.CHS_Init(ref code, ref msg);

            string _infno = "1101";
            string _input = "{ 	\"tran_no\":\"1101\"," +
                "	\"tran_time\":\"20211221191849\"," +
                "	\"data\":{ 		" +
                "       \"fixmedins_code\":\"H51010600411\"," +
                "		\"psn_no\":\"\", " +
                "		\"mdtrtarea_admvs\":\"519900\"," +
                " 		\"local_type\":\"3\", 		" +
                "       \"out_type\":\"2\" 		" +
                "       } " +
                "	}";
            string _output = "";
            CHSChengDu.CHS_Call(_infno, _input,ref _output);
            MessageBox.Show(_output,"提示");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CHSChengDu.CHS_Destroy();
            MessageBox.Show("接口已释放");
        }
    }
}
