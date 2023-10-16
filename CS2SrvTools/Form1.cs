using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace CS2SrvTools
{
    public partial class Form1 : UIForm
    {
        private static string CS2Path = "";
        private static Process CS2SRVPrv=new Process();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void uiCheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            uiTextBox1.Enabled =! uiTextBox1.Enabled;
        }

        private void uiIntegerUpDown1_ValueChanged(object sender, int value)
        {
            if (value <= 0 || value>65535) { UIMessageBox.Show("Maximum port range 65535 !"); uiIntegerUpDown1.Value = 1; }
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            Process[] m_csgoprocess = Process.GetProcessesByName("cs2");
            if (m_csgoprocess.Length > 0)
            {
                CS2Path = m_csgoprocess[m_csgoprocess.Length - 1].MainModule.FileName;
                uiTextBox2.Text = CS2Path;
            }
            else
                UIMessageBox.Show("游戏呢游戏呢?", "喵喵喵???");
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            OpenFileDialog selectCS2 = new OpenFileDialog();
            selectCS2.FileName = "cs2.exe";
            if (selectCS2.ShowDialog() == DialogResult.OK)
            {
                uiTextBox2.Text = CS2Path;
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (!System.IO.File.Exists(CS2Path)||CS2Path==string.Empty) { UIMessageBox.Show("游戏文件不存在", "喵喵喵???"); }
            if (uiTextBox4.Text==string.Empty) { UIMessageBox.Show("地图不能为空!", "喵喵喵???"); }
            ProcessStartInfo pROCESSInfo = new ProcessStartInfo();
            pROCESSInfo.FileName = CS2Path;
            pROCESSInfo.Arguments = $"-dedicated +hostport {uiIntegerUpDown1.Value} ";
            if (uiCheckBox2.Checked)
                pROCESSInfo.Arguments = $"-dedicated -insecure +hostport {uiIntegerUpDown1.Value} ";//$"-insecure ";
            if (uiCheckBox3.Checked) 
                pROCESSInfo.Arguments += $"+sv_password \"{uiTextBox1.Text}\" ";
            if(uiCheckBox1.Checked)
                pROCESSInfo.Arguments += $"+sv_lan 0 ";
            switch (uiComboBox1.SelectedIndex) {
                case 0:
                    pROCESSInfo.Arguments += $"+game_type 0 +game_mode 1 ";
                    break;
                case 1:
                    pROCESSInfo.Arguments += $"+game_type 0 +game_mode 0 ";
                    break;
                case 2:
                    pROCESSInfo.Arguments += $"+game_type 1 +game_mode 2 ";
                    break;
            }
            pROCESSInfo.Arguments += $"+map {uiTextBox4.Text} ";
            MessageBox.Show(pROCESSInfo.Arguments);
            CS2SRVPrv.StartInfo = pROCESSInfo;
            CS2SRVPrv.Start();
            uiButton2.Enabled = !uiButton2.Enabled;
            uiButton1.Enabled = false;
        }

        private void uiTextBox2_TextChanged(object sender, EventArgs e)
        {
            CS2Path = uiTextBox2.Text;
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            CS2SRVPrv.Kill();
            uiButton1.Enabled = !uiButton1.Enabled;
            uiButton2.Enabled = false;
        }
    }
}
