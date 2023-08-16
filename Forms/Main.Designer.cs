namespace KeyAuth
{
    public partial class Main : global::System.Windows.Forms.Form
    {
        protected override void Dispose(bool disposing)
        {
            bool flag = disposing && this.components != null;
            if (flag)
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.siticoneDragControl1 = new Siticone.UI.WinForms.SiticoneDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.key = new Siticone.UI.WinForms.SiticoneLabel();
            this.expiry = new Siticone.UI.WinForms.SiticoneLabel();
            this.subscription = new Siticone.UI.WinForms.SiticoneLabel();
            this.chatmsg = new Siticone.UI.WinForms.SiticoneRoundedTextBox();
            this.ip = new Siticone.UI.WinForms.SiticoneLabel();
            this.hwid = new Siticone.UI.WinForms.SiticoneLabel();
            this.createDate = new Siticone.UI.WinForms.SiticoneLabel();
            this.lastLogin = new Siticone.UI.WinForms.SiticoneLabel();
            this.subscriptionDaysLabel = new Siticone.UI.WinForms.SiticoneLabel();
            this.siticoneShadowForm = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.siticoneShadowForm1 = new Siticone.UI.WinForms.SiticoneShadowForm(this.components);
            this.siticoneBorderlessForm1 = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.siticoneCircleButton2 = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.siticonePictureBox2 = new Siticone.Desktop.UI.WinForms.SiticonePictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.siticoneCircleButton1 = new Siticone.Desktop.UI.WinForms.SiticoneCircleButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // siticoneDragControl1
            // 
            this.siticoneDragControl1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 19);
            this.label1.TabIndex = 22;
            // 
            // key
            // 
            this.key.BackColor = System.Drawing.Color.Transparent;
            this.key.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.key.Location = new System.Drawing.Point(20, 40);
            this.key.Margin = new System.Windows.Forms.Padding(2);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(71, 14);
            this.key.TabIndex = 37;
            this.key.Text = "usernameLabel";
            // 
            // expiry
            // 
            this.expiry.BackColor = System.Drawing.Color.Transparent;
            this.expiry.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expiry.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.expiry.Location = new System.Drawing.Point(20, 58);
            this.expiry.Margin = new System.Windows.Forms.Padding(2);
            this.expiry.Name = "expiry";
            this.expiry.Size = new System.Drawing.Size(56, 14);
            this.expiry.TabIndex = 38;
            this.expiry.Text = "expiryLabel";
            // 
            // subscription
            // 
            this.subscription.BackColor = System.Drawing.Color.Transparent;
            this.subscription.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subscription.Location = new System.Drawing.Point(20, 76);
            this.subscription.Margin = new System.Windows.Forms.Padding(2);
            this.subscription.Name = "subscription";
            this.subscription.Size = new System.Drawing.Size(84, 14);
            this.subscription.TabIndex = 39;
            this.subscription.Text = "subscriptionLabel";
            // 
            // chatmsg
            // 
            this.chatmsg.AllowDrop = true;
            this.chatmsg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.chatmsg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.chatmsg.DefaultText = "Your message here";
            this.chatmsg.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.chatmsg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.chatmsg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chatmsg.DisabledState.Parent = this.chatmsg;
            this.chatmsg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.chatmsg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.chatmsg.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chatmsg.FocusedState.Parent = this.chatmsg;
            this.chatmsg.HoveredState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chatmsg.HoveredState.Parent = this.chatmsg;
            this.chatmsg.Location = new System.Drawing.Point(20, 482);
            this.chatmsg.Margin = new System.Windows.Forms.Padding(4);
            this.chatmsg.Name = "chatmsg";
            this.chatmsg.PasswordChar = '\0';
            this.chatmsg.PlaceholderText = "";
            this.chatmsg.SelectedText = "";
            this.chatmsg.ShadowDecoration.Parent = this.chatmsg;
            this.chatmsg.Size = new System.Drawing.Size(337, 27);
            this.chatmsg.TabIndex = 43;
            this.chatmsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ip
            // 
            this.ip.BackColor = System.Drawing.Color.Transparent;
            this.ip.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ip.Location = new System.Drawing.Point(20, 94);
            this.ip.Margin = new System.Windows.Forms.Padding(2);
            this.ip.Name = "ip";
            this.ip.Size = new System.Drawing.Size(36, 14);
            this.ip.TabIndex = 44;
            this.ip.Text = "ipLabel";
            // 
            // hwid
            // 
            this.hwid.BackColor = System.Drawing.Color.Transparent;
            this.hwid.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hwid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hwid.Location = new System.Drawing.Point(20, 112);
            this.hwid.Margin = new System.Windows.Forms.Padding(2);
            this.hwid.Name = "hwid";
            this.hwid.Size = new System.Drawing.Size(50, 14);
            this.hwid.TabIndex = 45;
            this.hwid.Text = "hwidLabel";
            // 
            // createDate
            // 
            this.createDate.BackColor = System.Drawing.Color.Transparent;
            this.createDate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.createDate.Location = new System.Drawing.Point(20, 130);
            this.createDate.Margin = new System.Windows.Forms.Padding(2);
            this.createDate.Name = "createDate";
            this.createDate.Size = new System.Drawing.Size(76, 14);
            this.createDate.TabIndex = 46;
            this.createDate.Text = "createDateLabel";
            // 
            // lastLogin
            // 
            this.lastLogin.BackColor = System.Drawing.Color.Transparent;
            this.lastLogin.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lastLogin.Location = new System.Drawing.Point(20, 148);
            this.lastLogin.Margin = new System.Windows.Forms.Padding(2);
            this.lastLogin.Name = "lastLogin";
            this.lastLogin.Size = new System.Drawing.Size(69, 14);
            this.lastLogin.TabIndex = 47;
            this.lastLogin.Text = "lastLoginLabel";
            // 
            // subscriptionDaysLabel
            // 
            this.subscriptionDaysLabel.BackColor = System.Drawing.Color.Transparent;
            this.subscriptionDaysLabel.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subscriptionDaysLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subscriptionDaysLabel.Location = new System.Drawing.Point(20, 166);
            this.subscriptionDaysLabel.Margin = new System.Windows.Forms.Padding(2);
            this.subscriptionDaysLabel.Name = "subscriptionDaysLabel";
            this.subscriptionDaysLabel.Size = new System.Drawing.Size(105, 14);
            this.subscriptionDaysLabel.TabIndex = 53;
            this.subscriptionDaysLabel.Text = "subscriptionDaysLabel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(116, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 128);
            this.label2.TabIndex = 54;
            this.label2.Text = "MY ASS";
            // 
            // siticoneBorderlessForm1
            // 
            this.siticoneBorderlessForm1.BorderRadius = 12;
            this.siticoneBorderlessForm1.ContainerControl = this;
            this.siticoneBorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.siticoneBorderlessForm1.HasFormShadow = false;
            this.siticoneBorderlessForm1.ResizeForm = false;
            this.siticoneBorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.siticoneBorderlessForm1.TransparentWhileDrag = true;
            // 
            // siticoneCircleButton2
            // 
            this.siticoneCircleButton2.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.siticoneCircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneCircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneCircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneCircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneCircleButton2.FillColor = System.Drawing.Color.Green;
            this.siticoneCircleButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneCircleButton2.ForeColor = System.Drawing.Color.White;
            this.siticoneCircleButton2.Location = new System.Drawing.Point(426, 5);
            this.siticoneCircleButton2.Name = "siticoneCircleButton2";
            this.siticoneCircleButton2.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCircleButton2.Size = new System.Drawing.Size(15, 15);
            this.siticoneCircleButton2.TabIndex = 67;
            this.siticoneCircleButton2.Text = "siticoneCircleButton2";
            this.siticoneCircleButton2.Click += new System.EventHandler(this.siticoneCircleButton2_Click);
            // 
            // siticonePictureBox2
            // 
            this.siticonePictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("siticonePictureBox2.Image")));
            this.siticonePictureBox2.ImageRotate = 0F;
            this.siticonePictureBox2.Location = new System.Drawing.Point(-11, 187);
            this.siticonePictureBox2.Name = "siticonePictureBox2";
            this.siticonePictureBox2.Size = new System.Drawing.Size(165, 141);
            this.siticonePictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox2.TabIndex = 68;
            this.siticonePictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(319, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 141);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 69;
            this.pictureBox1.TabStop = false;
            // 
            // siticoneCircleButton1
            // 
            this.siticoneCircleButton1.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.siticoneCircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.siticoneCircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.siticoneCircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.siticoneCircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.siticoneCircleButton1.FillColor = System.Drawing.Color.Red;
            this.siticoneCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneCircleButton1.ForeColor = System.Drawing.Color.White;
            this.siticoneCircleButton1.Location = new System.Drawing.Point(447, 5);
            this.siticoneCircleButton1.Name = "siticoneCircleButton1";
            this.siticoneCircleButton1.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.siticoneCircleButton1.Size = new System.Drawing.Size(15, 15);
            this.siticoneCircleButton1.TabIndex = 70;
            this.siticoneCircleButton1.Text = "siticoneCircleButton1";
            this.siticoneCircleButton1.Click += new System.EventHandler(this.siticoneCircleButton1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(424, 279);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 71;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(473, 327);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.subscriptionDaysLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.siticoneCircleButton1);
            this.Controls.Add(this.siticoneCircleButton2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lastLogin);
            this.Controls.Add(this.createDate);
            this.Controls.Add(this.hwid);
            this.Controls.Add(this.ip);
            this.Controls.Add(this.chatmsg);
            this.Controls.Add(this.subscription);
            this.Controls.Add(this.expiry);
            this.Controls.Add(this.key);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticonePictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loader";
            this.TransparencyKey = System.Drawing.Color.Maroon;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        // Token: 0x04000001 RID: 1
        private global::System.ComponentModel.IContainer components = null;

        // Token: 0x04000002 RID: 2
        private global::Siticone.UI.WinForms.SiticoneDragControl siticoneDragControl1;

        // Token: 0x0400000A RID: 10
        private global::System.Windows.Forms.Label label1;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm;
        private Siticone.UI.WinForms.SiticoneLabel subscription;
        private Siticone.UI.WinForms.SiticoneLabel expiry;
        private Siticone.UI.WinForms.SiticoneLabel key;
        private Siticone.UI.WinForms.SiticoneRoundedTextBox chatmsg;
        private System.Windows.Forms.Timer timer1;
        private Siticone.UI.WinForms.SiticoneLabel ip;
        private Siticone.UI.WinForms.SiticoneLabel hwid;
        private Siticone.UI.WinForms.SiticoneLabel createDate;
        private Siticone.UI.WinForms.SiticoneLabel lastLogin;
        private Siticone.UI.WinForms.SiticoneLabel subscriptionDaysLabel;
        private System.Windows.Forms.Label label2;
        private Siticone.UI.WinForms.SiticoneShadowForm siticoneShadowForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm siticoneBorderlessForm1;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton siticoneCircleButton2;
        private Siticone.Desktop.UI.WinForms.SiticonePictureBox siticonePictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Siticone.Desktop.UI.WinForms.SiticoneCircleButton siticoneCircleButton1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
