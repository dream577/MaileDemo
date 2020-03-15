using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.IO;

namespace MailDemo
{

    public partial class ReceiveMail : Form
    {

        #region Private Variables

        private TcpClient Server;
        private NetworkStream StrmWtr;
        private StreamReader StrmRdr;
        private String cmdData;
        private byte[] szData;
        private int num;
        private const String CRLF = "\r\n";

        #endregion

        public ReceiveMail()
        {
            InitializeComponent();
        }

        #region Private Functions

        /// <summary>
        /// 获取命令端口返回结果，并记录在lsb_status上
        /// </summary>
        private String getSatus()
        {
            String ret = StrmRdr.ReadLine();
            lsb_status.Items.Add(ret);
            lsb_status.SelectedIndex = lsb_status.Items.Count - 1;
            return ret;
        }


        #endregion

        #region Button:  Connect & Disconnect

        private void btn_connect_Click(object sender, EventArgs e)
        {
            Cursor cr = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            Server = new TcpClient(tb_POPServer.Text, 110);
            lsb_status.Items.Clear();

            try
            {
                StrmWtr = Server.GetStream();
                StrmRdr = new StreamReader(Server.GetStream());
                this.getSatus();

                string ret;

                //输入用户名命令
                cmdData = "USER " + tb_username.Text + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();

                //输入密码命令
                cmdData = "PASS " + tb_password.Text + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                ret = this.getSatus();
                if (ret[0] == '-') throw new InvalidOperationException("用户名密码错误");

                //Get Email's Info
                cmdData = "STAT" + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();

                btn_connect.Enabled = false;
                btn_disconnect.Enabled = true;
                btn_Receive.Enabled = true;

            }
            catch (InvalidOperationException err)
            {
                lsb_status.Items.Add("ERROR: " + err.Message.ToString());
            }
            finally
            {
                Cursor.Current = cr;
            }
        }

        /// <summary>
        /// 连接或断开邮箱服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_disconnect_Click(object sender, EventArgs e)
        {
            Cursor cr = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            //Logout
            cmdData = "QUIT" + CRLF;
            szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
            StrmWtr.Write(szData, 0, szData.Length);
            this.getSatus();

            StrmWtr.Close();
            StrmRdr.Close();

            btn_connect.Enabled = true;
            btn_disconnect.Enabled = false;
            btn_Receive.Enabled = false;

            Cursor.Current = cr;

        }

        #endregion

        #region Button:  Receive Email

        /// <summary>
        /// 接收邮件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Receive_Click(object sender, EventArgs e)
        {
            Cursor cr = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            string szTemp;
            tb_message.Clear();
            try
            {
                cmdData = "RETR " + tb_ID.Text + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                szTemp = this.getSatus();

                if (szTemp[0] != '-')
                {
                    int k = 0;
                    while (szTemp != ".")
                    {
                        if (k >= 15)
                            tb_message.Text += szTemp + "\r\n";
                        szTemp = StrmRdr.ReadLine();
                        if(szTemp.Length>4&&szTemp.Substring(0,4)=="from")
                        {
                            fromUser.Text = szTemp.Substring(6);
                        }
                        if(szTemp.Length>2&&szTemp.Substring(0,2)=="to")
                        {
                            receiver.Text = szTemp.Substring(4);
                        }
                        if (szTemp.Length > 7 && szTemp.Substring(0, 7) == "subject")
                        {
                            subject.Text = szTemp.Substring(9);
                        }
                        k++;
                    }
                }
            }
            catch (InvalidOperationException err)
            {
                lsb_status.Items.Add("ERROR: " + err.Message.ToString());

            }
        }


        #endregion

        /// <summary>
        /// 删除邮件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            cmdData = "DELE " + tb_ID.Text + CRLF;
            szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
            StrmWtr.Write(szData, 0, szData.Length);
            this.getSatus();
        }
    }
}
