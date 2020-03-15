namespace MailDemo
{
    partial class ReceiveMail
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.btn_saveSettings = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_POPServer = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.subject = new System.Windows.Forms.TextBox();
            this.receiver = new System.Windows.Forms.TextBox();
            this.fromUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Receive = new System.Windows.Forms.Button();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.mailID = new System.Windows.Forms.Label();
            this.tb_message = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lsb_status = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_disconnect);
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Controls.Add(this.btn_saveSettings);
            this.groupBox1.Controls.Add(this.tb_password);
            this.groupBox1.Controls.Add(this.tb_username);
            this.groupBox1.Controls.Add(this.tb_POPServer);
            this.groupBox1.Controls.Add(this.password);
            this.groupBox1.Controls.Add(this.username);
            this.groupBox1.Controls.Add(this.address);
            this.groupBox1.Location = new System.Drawing.Point(62, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置";
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.Location = new System.Drawing.Point(407, 88);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(104, 30);
            this.btn_disconnect.TabIndex = 8;
            this.btn_disconnect.Text = "断开连接";
            this.btn_disconnect.UseVisualStyleBackColor = true;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(407, 53);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(104, 29);
            this.btn_connect.TabIndex = 7;
            this.btn_connect.Text = "连接";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // btn_saveSettings
            // 
            this.btn_saveSettings.Location = new System.Drawing.Point(407, 17);
            this.btn_saveSettings.Name = "btn_saveSettings";
            this.btn_saveSettings.Size = new System.Drawing.Size(104, 30);
            this.btn_saveSettings.TabIndex = 6;
            this.btn_saveSettings.Text = "保存配置";
            this.btn_saveSettings.UseVisualStyleBackColor = true;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(160, 96);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(211, 25);
            this.tb_password.TabIndex = 5;
            this.tb_password.Text = "123456789cxz";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(160, 59);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(211, 25);
            this.tb_username.TabIndex = 4;
            this.tb_username.Text = "lkhtestmail@163.com";
            // 
            // tb_POPServer
            // 
            this.tb_POPServer.Location = new System.Drawing.Point(160, 22);
            this.tb_POPServer.Name = "tb_POPServer";
            this.tb_POPServer.Size = new System.Drawing.Size(211, 25);
            this.tb_POPServer.TabIndex = 3;
            this.tb_POPServer.Text = "pop.163.com";
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.Location = new System.Drawing.Point(40, 99);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(116, 15);
            this.password.TabIndex = 2;
            this.password.Text = "授    权    码";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(41, 62);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(116, 15);
            this.username.TabIndex = 1;
            this.username.Text = "用    户    名";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(43, 25);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(114, 15);
            this.address.TabIndex = 0;
            this.address.Text = "POP3服务器地址";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.subject);
            this.groupBox2.Controls.Add(this.receiver);
            this.groupBox2.Controls.Add(this.fromUser);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btn_Receive);
            this.groupBox2.Controls.Add(this.tb_ID);
            this.groupBox2.Controls.Add(this.mailID);
            this.groupBox2.Controls.Add(this.tb_message);
            this.groupBox2.Location = new System.Drawing.Point(62, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 294);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "信息";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(385, 256);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(98, 31);
            this.btn_delete.TabIndex = 10;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // subject
            // 
            this.subject.Location = new System.Drawing.Point(82, 75);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(429, 25);
            this.subject.TabIndex = 9;
            // 
            // receiver
            // 
            this.receiver.Location = new System.Drawing.Point(82, 47);
            this.receiver.Name = "receiver";
            this.receiver.Size = new System.Drawing.Size(429, 25);
            this.receiver.TabIndex = 8;
            // 
            // fromUser
            // 
            this.fromUser.Location = new System.Drawing.Point(82, 18);
            this.fromUser.Name = "fromUser";
            this.fromUser.Size = new System.Drawing.Size(429, 25);
            this.fromUser.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "主  题：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "收件人：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "发件人：";
            // 
            // btn_Receive
            // 
            this.btn_Receive.Location = new System.Drawing.Point(234, 256);
            this.btn_Receive.Name = "btn_Receive";
            this.btn_Receive.Size = new System.Drawing.Size(106, 31);
            this.btn_Receive.TabIndex = 3;
            this.btn_Receive.Text = "接收邮件";
            this.btn_Receive.UseVisualStyleBackColor = true;
            this.btn_Receive.Click += new System.EventHandler(this.btn_Receive_Click);
            // 
            // tb_ID
            // 
            this.tb_ID.Location = new System.Drawing.Point(115, 262);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(74, 25);
            this.tb_ID.TabIndex = 2;
            // 
            // mailID
            // 
            this.mailID.AutoSize = true;
            this.mailID.Location = new System.Drawing.Point(27, 265);
            this.mailID.Name = "mailID";
            this.mailID.Size = new System.Drawing.Size(82, 15);
            this.mailID.TabIndex = 1;
            this.mailID.Text = "邮件编号：";
            // 
            // tb_message
            // 
            this.tb_message.Location = new System.Drawing.Point(6, 104);
            this.tb_message.Multiline = true;
            this.tb_message.Name = "tb_message";
            this.tb_message.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_message.Size = new System.Drawing.Size(554, 150);
            this.tb_message.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 462);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "状态";
            // 
            // lsb_status
            // 
            this.lsb_status.FormattingEnabled = true;
            this.lsb_status.ItemHeight = 15;
            this.lsb_status.Location = new System.Drawing.Point(71, 481);
            this.lsb_status.Name = "lsb_status";
            this.lsb_status.ScrollAlwaysVisible = true;
            this.lsb_status.Size = new System.Drawing.Size(551, 94);
            this.lsb_status.TabIndex = 4;
            // 
            // ReceiveMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(706, 587);
            this.Controls.Add(this.lsb_status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ReceiveMail";
            this.Text = "ReceiveMail";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Button btn_saveSettings;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_POPServer;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Receive;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label mailID;
        private System.Windows.Forms.TextBox tb_message;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsb_status;
        private System.Windows.Forms.TextBox subject;
        private System.Windows.Forms.TextBox receiver;
        private System.Windows.Forms.TextBox fromUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_delete;
    }
}