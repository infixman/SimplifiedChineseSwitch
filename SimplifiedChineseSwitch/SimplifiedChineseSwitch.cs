using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplifiedChineseSwitch
{
    public partial class SimplifiedChineseSwitch : Form
    {
        private const string _regRoot = "HKEY_CURRENT_USER";
        private const string _regPath = "Software\\Microsoft\\IME\\15.0\\IMETC";
        private const string _regKey = "Enable Simplified Chinese Output";
        private const string _enableSimChineseValue = "0x00000001";
        private const string _disableSimChineseValue = "0x00000000";
        private const string _statusTradi = "現在是正體";
        private const string _statusSim = "現在是簡體";
        private const string _statusNotFound = "找不到新注音內?";

        public SimplifiedChineseSwitch()
        {
            InitializeComponent();
        }

        private void SimplifiedChineseSwitch_Load(object sender, EventArgs e)
        {
            noti_icon.Icon = Properties.Resources.icon;
            noti_icon.Visible = true;

            //1.檢查regedit
            if (CheckRegKeyExists())
            {
                //2.設定狀態
                var nowStatus = SetAndGetNowStatus(GetRegValue());

                //3.隱藏視窗
                this.WindowState = FormWindowState.Minimized;

                //4.顯示提示氣泡
                ShowBalloonTip(nowStatus);
            }
            else
            {
                lbl_status.Text = _statusNotFound;
            }
        }

        private bool CheckRegKeyExists()
        {
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(_regPath, true);
            if (null != reg)
            {
                if (reg.GetValueNames().Contains(_regKey))
                {
                    return true;
                }
            }

            return false;
        }

        private string GetRegValue()
        {
            return Registry.GetValue($"{_regRoot}\\{_regPath}", _regKey, null).ToString(); ;
        }

        private string SetAndGetNowStatus(string nowValue)
        {
            var nowStatus = string.Empty;
            if (nowValue == _disableSimChineseValue)
            {
                nowStatus = _statusTradi;
            }
            else
            {
                if (nowValue == _enableSimChineseValue)
                {
                    nowStatus = _statusSim;
                }
                else
                {
                    nowStatus = _statusNotFound;
                }
            }

            noti_icon.Text = nowStatus;
            lbl_status.Text = nowStatus;

            return nowStatus;
        }
                
        private void Switch()
        {
            var nowValue = GetRegValue();
            var newValue = string.Empty;
            var nowStatus = string.Empty;
            if (nowValue == _disableSimChineseValue)
            {
                newValue = _enableSimChineseValue;
                nowStatus = _statusSim;
            }
            else if (nowValue == _enableSimChineseValue)
            {
                newValue = _disableSimChineseValue;
                nowStatus = _statusTradi;
            }
            else
            {
                lbl_status.Text = _statusNotFound;
                noti_icon.Text = _statusNotFound;
                return;
            }

            lbl_status.Text = nowStatus;
            noti_icon.Text = nowStatus;

            Registry.SetValue($"{_regRoot}\\{_regPath}", _regKey, newValue, RegistryValueKind.String);

            if (this.WindowState == FormWindowState.Minimized)
            {
                ShowBalloonTip(newValue);
            }
        }

        private void ShowBalloonTip(string nowValue)
        {
            var msg = string.Empty;

            if (nowValue == _disableSimChineseValue)
            {
                msg = _statusTradi;
            }
            else if (nowValue == _enableSimChineseValue)
            {
                msg = _statusSim;
            }
            else
            {
                return;
            }

            noti_icon.ShowBalloonTip(50, "Tips", $"{msg}\r\n(左鍵點切換正/簡，右鍵點叫出視窗)", ToolTipIcon.Info);
        }

        private void ShowMe()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.ShowInTaskbar = true;
                this.WindowState = FormWindowState.Normal;
            }
            this.Activate();
            this.Focus();
        }

        private void HideMe()
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.ShowInTaskbar = false;
                ShowBalloonTip(GetRegValue());
            }
        }

        private void btn_Switch_Click(object sender, EventArgs e)
        {
            Switch();
        }

        private void SimplifiedChineseSwitch_FormClosing(object sender, FormClosingEventArgs e)
        {
            noti_icon.Dispose();
        }

        private void SimplifiedChineseSwitch_Resize(object sender, EventArgs e)
        {
            HideMe();
        }
        
        private void noti_icon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Switch();
            }
            else if (e.Button == MouseButtons.Right)
            {
                ShowMe();
            }
        }
    }
}
