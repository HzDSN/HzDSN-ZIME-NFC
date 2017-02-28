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
        Byte[] ReadBuf = new Byte[20];
        int Status;
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            /*if (RF_YLE280U.YLE280_GetReaderCode() == -2)
            {
                RF_YLE280U.YLE280_GreenLedOn();
                RF_YLE280U.YLE280_RedLedOff();
            }
            else if(RF_YLE280U.YLE280_GetReaderCode() == 0)
            {
                RF_YLE280U.YLE280_GreenLedOff();
                RF_YLE280U.YLE280_RedLedOn();
            }*/
            Byte[] x = new Byte[20];
            int result = RF_YLE280U.YLE280_GetSerialNo(x);
            if(result == 0 && /*x.ToHexString() != ReadBuf.ToHexString() &&*/ Status != 0)
            {
                ReadBuf = x;
                
                string s = ReadBuf.ToHexString();
                string t = string.Empty;
                for (int i = s.Length - 2; i >= 0; i -= 2)
                {
                    t += s.Substring(i, 2);
                    t += ":";
                }
                t = t.Substring(0, t.Length - 1);
                while (t.StartsWith("00:"))
                {
                    t = t.Substring(3);
                }
                lbInfo.Items.Add("UID:" + t);
            }
            Status = result;
        }

        private void chkBuzzer_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void chkRedLed_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void button_GetUID_Click(object sender, EventArgs e)
        {
            
            int result = RF_YLE280U.YLE280_GetSerialNo(ReadBuf);
            if (result == RF_YLE280U.YLE280_OK)
            {
                //读取序列号成功，其中数据在ReadBuf中，将ReadBuf中的数据转换成十六进制，并显示到界面上
                lbInfo.Items.Add("Get UID Succeed.");
                string s = ReadBuf.ToHexString();
                string t = string.Empty;
                for(int i=s.Length-2;i>=0;i-=2)
                {
                    t += s.Substring(i, 2);
                    t += ":";
                }
                t = t.Substring(0, t.Length - 1);
                while(t.StartsWith("00:"))
                {
                    t = t.Substring(3);
                }
                lbInfo.Items.Add("UID:" + t);
            }
            else
            {
                //数据读取失败，可将结果显示到界面上
                lbInfo.Items.Add("Get UID failed! Error " + result);
            }

        }

        private void lbInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbInfo_ValueMemberChanged(object sender, EventArgs e)
        {
            
        }
    }
}
