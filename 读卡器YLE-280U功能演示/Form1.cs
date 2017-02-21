using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 读卡器YLE_280U功能演示
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lbInfo.Items.Clear();

        }

        private void btnYLE280_Open_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Add("YLE280_Open(InComPort = 0); // 参数0为自动查找设备");
            lbInfo.Items.Add("返回值： " + RF_YLE280U.YLE280_Open(Convert.ToInt32(cbComPortNo.Text)).ToString());
        }

        private void btnYLE280_Close_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Add("YLE280_Close()");
            lbInfo.Items.Add("返回值： " + RF_YLE280U.YLE280_Close().ToString());
        }

        private void btnYLE280_Reset_Click(object sender, EventArgs e)
        {
            lbInfo.Items.Add("YLE280_Reset()");
            lbInfo.Items.Add("返回值： " + RF_YLE280U.YLE280_Reset().ToString());
        }

        private void chkRedLed_CheckedChanged(object sender, EventArgs e)  //对应MainUnit.pas的RedLedCheckBoxClick
        {
            int result;

            if (chkRedLed.Checked)
            {
                lbInfo.Items.Add("YLE280_RedLedOn()");
                result = RF_YLE280U.YLE280_RedLedOn();
            }
            else
            {
                lbInfo.Items.Add("YLE280_RedLedOff()");
                result = RF_YLE280U.YLE280_RedLedOff();
            }

            lbInfo.Items.Add("返回值： " + result.ToString());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            int result;

            if (checkBox1.Checked)
            {
                lbInfo.Items.Add("YLE280_GreenLedOn()");
                result = RF_YLE280U.YLE280_GreenLedOn();
            }
            else
            {
                lbInfo.Items.Add("YLE280_GreenLedOff()");
                result = RF_YLE280U.YLE280_GreenLedOff();
            }
            lbInfo.Items.Add("返回值： " + result.ToString());
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            int result;

            if (chkBuzzer.Checked)
            {
                lbInfo.Items.Add("YLE280_BuzzerOn()");
                result = RF_YLE280U.YLE280_BuzzerOn();
            }
            else
            {
                lbInfo.Items.Add("YLE280_BuzzerOff()");
                result = RF_YLE280U.YLE280_BuzzerOff();
            }
            lbInfo.Items.Add("返回值： " + result.ToString());
        }
    }
}
