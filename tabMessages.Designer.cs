namespace SOCIAL_APP_BUNIFU_FRAMEWORK_DEMO
{
    partial class tabMessages
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tabMessages));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            BunifuAnimatorNS.Animation animation3 = new BunifuAnimatorNS.Animation();
            this.bunifuDropdown1 = new Bunifu.UI.WinForms.BunifuDropdown();
            this.btnEditPhoto = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlMsgContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBody = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnMailItem6 = new SOCIAL_APP_BUNIFU_FRAMEWORK_DEMO.btnMailItem();
            this.btnMailItem5 = new SOCIAL_APP_BUNIFU_FRAMEWORK_DEMO.btnMailItem();
            this.btnMailItem4 = new SOCIAL_APP_BUNIFU_FRAMEWORK_DEMO.btnMailItem();
            this.btnMailItem3 = new SOCIAL_APP_BUNIFU_FRAMEWORK_DEMO.btnMailItem();
            this.btnMailItem2 = new SOCIAL_APP_BUNIFU_FRAMEWORK_DEMO.btnMailItem();
            this.btnMailItem1 = new SOCIAL_APP_BUNIFU_FRAMEWORK_DEMO.btnMailItem();
            this.panel1.SuspendLayout();
            this.pnlMsgContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.bunifuDropdown1.BorderRadius = 5;
            this.bunifuDropdown1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.bunifuTransition1.SetDecoration(this.bunifuDropdown1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuDropdown1.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.bunifuDropdown1.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thick;
            this.bunifuDropdown1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bunifuDropdown1.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.bunifuDropdown1.FillDropDown = true;
            this.bunifuDropdown1.FillIndicator = false;
            this.bunifuDropdown1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bunifuDropdown1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.FormattingEnabled = true;
            this.bunifuDropdown1.Icon = null;
            this.bunifuDropdown1.IndicatorColor = System.Drawing.Color.White;
            this.bunifuDropdown1.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.bunifuDropdown1.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.bunifuDropdown1.ItemBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.bunifuDropdown1.ItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.bunifuDropdown1.ItemHeight = 25;
            this.bunifuDropdown1.ItemHighLightColor = System.Drawing.Color.LightSlateGray;
            this.bunifuDropdown1.Items.AddRange(new object[] {
            "INBOX",
            "SENT",
            "MARKED",
            "DRAFTS",
            "DELETED"});
            this.bunifuDropdown1.Location = new System.Drawing.Point(21, 20);
            this.bunifuDropdown1.MinimumSize = new System.Drawing.Size(48, 0);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.Size = new System.Drawing.Size(308, 31);
            this.bunifuDropdown1.TabIndex = 0;
            this.bunifuDropdown1.Text = "INBOX";
            // 
            // btnEditPhoto
            // 
            this.btnEditPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditPhoto.BackColor = System.Drawing.Color.Transparent;
            this.btnEditPhoto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditPhoto.BackgroundImage")));
            this.btnEditPhoto.ButtonText = "   Compose";
            this.btnEditPhoto.ButtonTextMarginLeft = 0;
            this.bunifuTransition1.SetDecoration(this.btnEditPhoto, BunifuAnimatorNS.DecorationType.None);
            this.btnEditPhoto.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.btnEditPhoto.DisabledFillColor = System.Drawing.Color.Gray;
            this.btnEditPhoto.DisabledForecolor = System.Drawing.Color.White;
            this.btnEditPhoto.ForeColor = System.Drawing.Color.White;
            this.btnEditPhoto.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnEditPhoto.IconPadding = 5;
            this.btnEditPhoto.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnEditPhoto.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            this.btnEditPhoto.IdleBorderRadius = 25;
            this.btnEditPhoto.IdleBorderThickness = 2;
            this.btnEditPhoto.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.btnEditPhoto.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("btnEditPhoto.IdleIconLeftImage")));
            this.btnEditPhoto.IdleIconRightImage = null;
            this.btnEditPhoto.Location = new System.Drawing.Point(543, 16);
            this.btnEditPhoto.Name = "btnEditPhoto";
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties3.BorderRadius = 25;
            stateProperties3.BorderThickness = 1;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(58)))), ((int)(((byte)(108)))));
            stateProperties3.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("stateProperties3.IconLeftImage")));
            stateProperties3.IconRightImage = null;
            this.btnEditPhoto.onHoverState = stateProperties3;
            this.btnEditPhoto.Size = new System.Drawing.Size(147, 35);
            this.btnEditPhoto.TabIndex = 10;
            this.btnEditPhoto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditPhoto.Click += new System.EventHandler(this.btnEditPhoto_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.btnMailItem6);
            this.panel1.Controls.Add(this.btnMailItem5);
            this.panel1.Controls.Add(this.btnMailItem4);
            this.panel1.Controls.Add(this.btnMailItem3);
            this.panel1.Controls.Add(this.btnMailItem2);
            this.panel1.Controls.Add(this.btnMailItem1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(21, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 433);
            this.panel1.TabIndex = 12;
            // 
            // pnlMsgContainer
            // 
            this.pnlMsgContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMsgContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.pnlMsgContainer.Controls.Add(this.pictureBox1);
            this.pnlMsgContainer.Controls.Add(this.lblBody);
            this.pnlMsgContainer.Controls.Add(this.lblSubject);
            this.pnlMsgContainer.Controls.Add(this.lblEmail);
            this.pnlMsgContainer.Controls.Add(this.lblFirstName);
            this.bunifuTransition1.SetDecoration(this.pnlMsgContainer, BunifuAnimatorNS.DecorationType.None);
            this.pnlMsgContainer.Location = new System.Drawing.Point(237, 68);
            this.pnlMsgContainer.Name = "pnlMsgContainer";
            this.pnlMsgContainer.Size = new System.Drawing.Size(453, 433);
            this.pnlMsgContainer.TabIndex = 13;
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 48);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // lblBody
            // 
            this.bunifuTransition1.SetDecoration(this.lblBody, BunifuAnimatorNS.DecorationType.None);
            this.lblBody.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblBody.ForeColor = System.Drawing.Color.DarkGray;
            this.lblBody.Location = new System.Drawing.Point(19, 133);
            this.lblBody.Name = "lblBody";
            this.lblBody.Size = new System.Drawing.Size(396, 276);
            this.lblBody.TabIndex = 26;
            this.lblBody.Text = "email here";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblSubject, BunifuAnimatorNS.DecorationType.None);
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.lblSubject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblSubject.Location = new System.Drawing.Point(18, 92);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(176, 28);
            this.lblSubject.TabIndex = 25;
            this.lblSubject.Text = "Subject goes here";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblEmail, BunifuAnimatorNS.DecorationType.None);
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblEmail.ForeColor = System.Drawing.Color.DarkGray;
            this.lblEmail.Location = new System.Drawing.Point(79, 43);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(117, 20);
            this.lblEmail.TabIndex = 24;
            this.lblEmail.Text = "email@eail.com";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lblFirstName, BunifuAnimatorNS.DecorationType.None);
            this.lblFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFirstName.Location = new System.Drawing.Point(77, 19);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(87, 20);
            this.lblFirstName.TabIndex = 23;
            this.lblFirstName.Text = "Name Here";
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.ScaleAndHorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation3;
            // 
            // pictureBox2
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox2, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(409, 234);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(70, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // btnMailItem6
            // 
            this.btnMailItem6.Active = false;
            this.btnMailItem6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnMailItem6.Body = "This is just another body";
            this.btnMailItem6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMailItem6, BunifuAnimatorNS.DecorationType.None);
            this.btnMailItem6.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMailItem6.Email = "bunifu@bunifuFramework.com";
            this.btnMailItem6.FirstName = "Bunifu";
            this.btnMailItem6.Location = new System.Drawing.Point(0, 345);
            this.btnMailItem6.Name = "btnMailItem6";
            this.btnMailItem6.Size = new System.Drawing.Size(210, 69);
            this.btnMailItem6.Subject = "Another Subjet goes here";
            this.btnMailItem6.TabIndex = 5;
            this.btnMailItem6.Click += new System.EventHandler(this.btnMailItem1_Click);
            // 
            // btnMailItem5
            // 
            this.btnMailItem5.Active = false;
            this.btnMailItem5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnMailItem5.Body = "This is just a body";
            this.btnMailItem5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMailItem5, BunifuAnimatorNS.DecorationType.None);
            this.btnMailItem5.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMailItem5.Email = "Bunifu";
            this.btnMailItem5.FirstName = "Name Here";
            this.btnMailItem5.Location = new System.Drawing.Point(0, 276);
            this.btnMailItem5.Name = "btnMailItem5";
            this.btnMailItem5.Size = new System.Drawing.Size(210, 69);
            this.btnMailItem5.Subject = "Subject goes here";
            this.btnMailItem5.TabIndex = 4;
            this.btnMailItem5.Click += new System.EventHandler(this.btnMailItem1_Click);
            // 
            // btnMailItem4
            // 
            this.btnMailItem4.Active = false;
            this.btnMailItem4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnMailItem4.Body = resources.GetString("btnMailItem4.Body");
            this.btnMailItem4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMailItem4, BunifuAnimatorNS.DecorationType.None);
            this.btnMailItem4.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMailItem4.Email = "wilber@bunifu.com";
            this.btnMailItem4.FirstName = "WilberForce";
            this.btnMailItem4.Location = new System.Drawing.Point(0, 207);
            this.btnMailItem4.Name = "btnMailItem4";
            this.btnMailItem4.Size = new System.Drawing.Size(210, 69);
            this.btnMailItem4.Subject = "Where can I get some?";
            this.btnMailItem4.TabIndex = 3;
            this.btnMailItem4.Click += new System.EventHandler(this.btnMailItem1_Click);
            // 
            // btnMailItem3
            // 
            this.btnMailItem3.Active = false;
            this.btnMailItem3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnMailItem3.Body = resources.GetString("btnMailItem3.Body");
            this.btnMailItem3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMailItem3, BunifuAnimatorNS.DecorationType.None);
            this.btnMailItem3.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMailItem3.Email = "email@tim.com";
            this.btnMailItem3.FirstName = "Creative Tim";
            this.btnMailItem3.Location = new System.Drawing.Point(0, 138);
            this.btnMailItem3.Name = "btnMailItem3";
            this.btnMailItem3.Size = new System.Drawing.Size(210, 69);
            this.btnMailItem3.Subject = "Where does it come from?";
            this.btnMailItem3.TabIndex = 2;
            this.btnMailItem3.Click += new System.EventHandler(this.btnMailItem1_Click);
            // 
            // btnMailItem2
            // 
            this.btnMailItem2.Active = false;
            this.btnMailItem2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.btnMailItem2.Body = resources.GetString("btnMailItem2.Body");
            this.btnMailItem2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMailItem2, BunifuAnimatorNS.DecorationType.None);
            this.btnMailItem2.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMailItem2.Email = "email@email.com";
            this.btnMailItem2.FirstName = "Jon Doe";
            this.btnMailItem2.Location = new System.Drawing.Point(0, 69);
            this.btnMailItem2.Name = "btnMailItem2";
            this.btnMailItem2.Size = new System.Drawing.Size(210, 69);
            this.btnMailItem2.Subject = "Why do we use it?";
            this.btnMailItem2.TabIndex = 1;
            this.btnMailItem2.Click += new System.EventHandler(this.btnMailItem1_Click);
            // 
            // btnMailItem1
            // 
            this.btnMailItem1.Active = true;
            this.btnMailItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(36)))));
            this.btnMailItem1.Body = resources.GetString("btnMailItem1.Body");
            this.btnMailItem1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnMailItem1, BunifuAnimatorNS.DecorationType.None);
            this.btnMailItem1.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMailItem1.Email = "kimtooflex@gmail.com";
            this.btnMailItem1.FirstName = "KimTooFlex";
            this.btnMailItem1.Location = new System.Drawing.Point(0, 0);
            this.btnMailItem1.Name = "btnMailItem1";
            this.btnMailItem1.Size = new System.Drawing.Size(210, 69);
            this.btnMailItem1.Subject = "What is Lorem Ipsum?";
            this.btnMailItem1.TabIndex = 0;
            this.btnMailItem1.Click += new System.EventHandler(this.btnMailItem1_Click);
            // 
            // tabMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.pnlMsgContainer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnEditPhoto);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.pictureBox2);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.Name = "tabMessages";
            this.Size = new System.Drawing.Size(705, 526);
            this.Load += new System.EventHandler(this.tabMessages_Load);
            this.panel1.ResumeLayout(false);
            this.pnlMsgContainer.ResumeLayout(false);
            this.pnlMsgContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuDropdown bunifuDropdown1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnEditPhoto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlMsgContainer;
        private btnMailItem btnMailItem1;
        private btnMailItem btnMailItem6;
        private btnMailItem btnMailItem5;
        private btnMailItem btnMailItem4;
        private btnMailItem btnMailItem3;
        private btnMailItem btnMailItem2;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblBody;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
