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
    public partial class SendMail : Form
    {
        #region Private Variables

        private TcpClient Server;                    
        private NetworkStream StrmWtr;               
        private StreamReader StrmRdr;
        private String cmdData;
        private byte[] szData;
        private const String CRLF = "\r\n";

        #endregion

        public SendMail()
        {
            InitializeComponent();
        }

        #region Private Functions

        private String getSatus()
        {
            String ret = StrmRdr.ReadLine();
            lsb_status.Items.Add(ret);
            lsb_status.SelectedIndex = lsb_status.Items.Count - 1;
            return ret;
        }

        #endregion

        #region  Button:  Connect & Disconnect

        /// <summary>
        /// 连接或断开服务器
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_conn_Click(object sender, EventArgs e)
        {
            if (btn_conn.Text == "连接")
            {
                //Socket conn = SocketConnect.ConnectToServer(tb_server.Text, 25);
                Cursor cr = Cursor.Current;
                Cursor.Current = Cursors.WaitCursor;
                Server = new TcpClient(tb_server.Text, 25);
                
                lsb_status.Items.Clear();
                try
                {
                    StrmWtr = Server.GetStream();
                    StrmRdr = new StreamReader(Server.GetStream());
                    this.getSatus();

                    //Login
                    cmdData = "HELO " + tb_server.Text + CRLF;
                    szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                    StrmWtr.Write(szData, 0, szData.Length);
                    this.getSatus();

                    cmdData = "AUTH LOGIN" + CRLF;
                    szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                    StrmWtr.Write(szData, 0, szData.Length);
                    this.getSatus();

                    cmdData = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(tb_username.Text)) + CRLF;
                    szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                    StrmWtr.Write(szData, 0, szData.Length);
                    this.getSatus();

                    cmdData = Convert.ToBase64String(System.Text.Encoding.ASCII.GetBytes(tb_password.Text)) + CRLF;
                    szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                    StrmWtr.Write(szData, 0, szData.Length);
                    this.getSatus();

                    btn_conn.Text = "断开";
                    btn_send.Enabled = true;

                }
                catch (InvalidOperationException err)
                {
                    lsb_status.Items.Add("ERROR: " + err.ToString());
                }
                finally
                {
                    Cursor.Current = cr;
                }
            }
            else
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


                btn_conn.Text = "连接";
                btn_send.Enabled = false;

                Cursor.Current = cr;
            }
        }


        #endregion

        #region  Button:  Send Mail

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_send_Click(object sender, EventArgs e)
        {
            try
            {
                //Send Email
                cmdData = "MAIL FROM: <" + tb_from.Text + ">" + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();

                cmdData = "RCPT TO: <" + tb_to.Text + ">" + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();

                cmdData = "DATA" + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();

                cmdData = "from: " + tb_from.Text + CRLF
                            + "to: " + tb_to.Text + CRLF
                            + "subject: " + tb_subject.Text + CRLF + CRLF
                            + tb_content.Text + CRLF + "." + CRLF;
                szData = System.Text.Encoding.UTF8.GetBytes(cmdData.ToCharArray());
                StrmWtr.Write(szData, 0, szData.Length);
                this.getSatus();

            }
            catch (InvalidOperationException err)
            {
                lsb_status.Items.Add("ERROR: " + err.ToString());
            }
        }

        #endregion
    }
}
