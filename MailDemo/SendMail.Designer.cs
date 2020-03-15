namespace MailDemo
{
    partial class SendMail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_server = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.fromSender = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Label();
            this.tb_server = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_from = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.btn_saveSettings = new System.Windows.Forms.Button();
            this.btn_conn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.receiver = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.Label();
            this.content = new System.Windows.Forms.Label();
            this.tb_to = new System.Windows.Forms.TextBox();
            this.tb_subject = new System.Windows.Forms.TextBox();
            this.tb_content = new System.Windows.Forms.TextBox();
            this.lsb_status = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_send = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_server
            // 
            this.txt_server.AutoSize = true;
            this.txt_server.Location = new System.Drawing.Point(22, 33);
            this.txt_server.Name = "txt_server";
            this.txt_server.Size = new System.Drawing.Size(82, 15);
            this.txt_server.TabIndex = 0;
            this.txt_server.Text = "邮件服务器";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(311, 30);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(52, 15);
            this.username.TabIndex = 1;
            this.username.Text = "用户名";
            // 
            // fromSender
            // 
            this.fromSender.AutoSize = true;
            this.fromSender.Location = new System.Drawing.Point(22, 71);
            this.fromSender.Name = "fromSender";
            this.fromSender.Size = new System.Drawing.Size(82, 15);
            this.fromSender.TabIndex = 2;
            this.fromSender.Text = "发件人邮箱";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(311, 71);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(52, 15);
            this.password.TabIndex = 3;
            this.password.Text = "授权码";
            // 
            // tb_server
            // 
            this.tb_server.Location = new System.Drawing.Point(110, 30);
            this.tb_server.Name = "tb_server";
            this.tb_server.Size = new System.Drawing.Size(167, 25);
            this.tb_server.TabIndex = 4;
            this.tb_server.Text = "smtp.163.com";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(382, 29);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(171, 25);
            this.tb_username.TabIndex = 5;
            this.tb_username.Text = "lkhtestmail@163.com";
            // 
            // tb_from
            // 
            this.tb_from.Location = new System.Drawing.Point(110, 68);
            this.tb_from.Name = "tb_from";
            this.tb_from.Size = new System.Drawing.Size(167, 25);
            this.tb_from.TabIndex = 6;
            this.tb_from.Text = "lkhtestmail@163.com";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(382, 68);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(171, 25);
            this.tb_password.TabIndex = 7;
            this.tb_password.Text = "123456789cxz";
            // 
            // btn_saveSettings
            // 
            this.btn_saveSettings.Location = new System.Drawing.Point(596, 24);
            this.btn_saveSettings.Name = "btn_saveSettings";
            this.btn_saveSettings.Size = new System.Drawing.Size(101, 32);
            this.btn_saveSettings.TabIndex = 8;
            this.btn_saveSettings.Text = "保存设置";
            this.btn_saveSettings.UseVisualStyleBackColor = true;
            // 
            // btn_conn
            // 
            this.btn_conn.Location = new System.Drawing.Point(596, 62);
            this.btn_conn.Name = "btn_conn";
            this.btn_conn.Size = new System.Drawing.Size(101, 32);
            this.btn_conn.TabIndex = 9;
            this.btn_conn.Text = "连接";
            this.btn_conn.UseVisualStyleBackColor = true;
            this.btn_conn.Click += new System.EventHandler(this.btn_conn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_server);
            this.groupBox1.Controls.Add(this.btn_conn);
            this.groupBox1.Controls.Add(this.fromSender);
            this.groupBox1.Controls.Add(this.btn_saveSettings);
            this.groupBox1.Controls.Add(this.tb_server);
            this.groupBox1.Controls.Add(this.tb_password);
            this.groupBox1.Controls.Add(this.tb_from);
            this.groupBox1.Controls.Add(this.tb_username);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Location = new System.Drawing.Point(63, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(703, 117);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // receiver
            // 
            this.receiver.AutoSize = true;
            this.receiver.Location = new System.Drawing.Point(8, 21);
            this.receiver.Name = "receiver";
            this.receiver.Size = new System.Drawing.Size(82, 15);
            this.receiver.TabIndex = 11;
            this.receiver.Text = "收件人信箱";
            // 
            // subject
            // 
            this.subject.AutoSize = true;
            this.subject.Location = new System.Drawing.Point(8, 55);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(85, 15);
            this.subject.TabIndex = 12;
            this.subject.Text = "标      题";
            // 
            // content
            // 
            this.content.AutoSize = true;
            this.content.Location = new System.Drawing.Point(8, 88);
            this.content.Name = "content";
            this.content.Size = new System.Drawing.Size(85, 15);
            this.content.TabIndex = 13;
            this.content.Text = "内      容";
            // 
            // tb_to
            // 
            this.tb_to.Location = new System.Drawing.Point(102, 21);
            this.tb_to.Name = "tb_to";
            this.tb_to.Size = new System.Drawing.Size(174, 25);
            this.tb_to.TabIndex = 14;
            this.tb_to.Text = "lkhtestmail@163.com";
            //
            // tb_subject
            // 
            this.tb_subject.Location = new System.Drawing.Point(102, 55);
            this.tb_subject.Name = "tb_subject";
            this.tb_subject.Size = new System.Drawing.Size(174, 25);
            this.tb_subject.TabIndex = 15;
            this.tb_subject.Text = "myFirstMail";
            // 
            // tb_content
            // 
            this.tb_content.Location = new System.Drawing.Point(102, 87);
            this.tb_content.Multiline = true;
            this.tb_content.Name = "tb_content";
            this.tb_content.Size = new System.Drawing.Size(500, 200);
            this.tb_content.TabIndex = 16;
            this.tb_content.Text = "第一封邮件";
            // 
            // lsb_status
            // 
            this.lsb_status.FormattingEnabled = true;
            this.lsb_status.ItemHeight = 15;
            this.lsb_status.Location = new System.Drawing.Point(166, 470);
            this.lsb_status.Name = "lsb_status";
            this.lsb_status.Size = new System.Drawing.Size(500, 94);
            this.lsb_status.TabIndex = 17;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_send);
            this.groupBox2.Controls.Add(this.receiver);
            this.groupBox2.Controls.Add(this.subject);
            this.groupBox2.Controls.Add(this.tb_content);
            this.groupBox2.Controls.Add(this.content);
            this.groupBox2.Controls.Add(this.tb_subject);
            this.groupBox2.Controls.Add(this.tb_to);
            this.groupBox2.Location = new System.Drawing.Point(64, 158);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(703, 306);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "写邮件";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(609, 254);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(87, 32);
            this.btn_send.TabIndex = 17;
            this.btn_send.Text = "发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "状态";
            // 
            // SendMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 581);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lsb_status);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SendMail";
            this.Text = "SendMail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt_server;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label fromSender;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox tb_server;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_from;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_saveSettings;
        private System.Windows.Forms.Button btn_conn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label receiver;
        private System.Windows.Forms.Label subject;
        private System.Windows.Forms.Label content;
        private System.Windows.Forms.TextBox tb_to;
        private System.Windows.Forms.TextBox tb_subject;
        private System.Windows.Forms.TextBox tb_content;
        private System.Windows.Forms.ListBox lsb_status;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Label label1;
    }
}