namespace ProjectB
{
    partial class FormStoelenScherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStoelenScherm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelMyaccount = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelMovis = new System.Windows.Forms.Label();
            this.pictureBoxContact = new System.Windows.Forms.PictureBox();
            this.pictureBoxMovies = new System.Windows.Forms.PictureBox();
            this.pictureBoxMyProfile = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelKleurVrij = new System.Windows.Forms.Panel();
            this.panelKleurBezet = new System.Windows.Forms.Panel();
            this.panelKleurJouwStoel = new System.Windows.Forms.Panel();
            this.buttonReserveerKnop = new System.Windows.Forms.Button();
            this.panelStoelen = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.stoelNummer = new System.Windows.Forms.Label();
            this.Helper = new System.Windows.Forms.Button();
            this.buttonVolgende = new System.Windows.Forms.Button();
            this.labelJouwStoel = new System.Windows.Forms.Label();
            this.labelStoelBezet = new System.Windows.Forms.Label();
            this.labelStoelVrij = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyProfile)).BeginInit();
            this.panelStoelen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Controls.Add(this.labelMyaccount);
            this.panel2.Controls.Add(this.labelContact);
            this.panel2.Controls.Add(this.labelMovis);
            this.panel2.Controls.Add(this.pictureBoxContact);
            this.panel2.Controls.Add(this.pictureBoxMovies);
            this.panel2.Controls.Add(this.pictureBoxMyProfile);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1500, 130);
            this.panel2.TabIndex = 0;
            // 
            // labelMyaccount
            // 
            this.labelMyaccount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelMyaccount.AutoSize = true;
            this.labelMyaccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMyaccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyaccount.Location = new System.Drawing.Point(1176, 37);
            this.labelMyaccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMyaccount.Name = "labelMyaccount";
            this.labelMyaccount.Size = new System.Drawing.Size(236, 46);
            this.labelMyaccount.TabIndex = 133;
            this.labelMyaccount.Text = "My account";
            this.labelMyaccount.Click += new System.EventHandler(this.LabelMyaccountClick);
            this.labelMyaccount.MouseLeave += new System.EventHandler(this.LabelMyaccountMouseLeave);
            this.labelMyaccount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelMyaccountMouseMove);
            // 
            // labelContact
            // 
            this.labelContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelContact.AutoSize = true;
            this.labelContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.Location = new System.Drawing.Point(710, 37);
            this.labelContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(166, 46);
            this.labelContact.TabIndex = 132;
            this.labelContact.Text = "Contact";
            this.labelContact.Click += new System.EventHandler(this.LabelContactClick);
            this.labelContact.MouseLeave += new System.EventHandler(this.LabelContactMouseLeave);
            this.labelContact.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelContactMouseMove);
            // 
            // labelMovis
            // 
            this.labelMovis.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.labelMovis.AutoSize = true;
            this.labelMovis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMovis.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovis.Location = new System.Drawing.Point(245, 37);
            this.labelMovis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMovis.Name = "labelMovis";
            this.labelMovis.Size = new System.Drawing.Size(152, 46);
            this.labelMovis.TabIndex = 131;
            this.labelMovis.Tag = "";
            this.labelMovis.Text = "Movies";
            this.labelMovis.Click += new System.EventHandler(this.LabelMovisClick);
            this.labelMovis.MouseLeave += new System.EventHandler(this.LabelMovisMouseLeave);
            this.labelMovis.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelMovisMouseMove);
            // 
            // pictureBoxContact
            // 
            this.pictureBoxContact.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxContact.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxContact.Image")));
            this.pictureBoxContact.Location = new System.Drawing.Point(591, 11);
            this.pictureBoxContact.Name = "pictureBoxContact";
            this.pictureBoxContact.Size = new System.Drawing.Size(93, 88);
            this.pictureBoxContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxContact.TabIndex = 130;
            this.pictureBoxContact.TabStop = false;
            this.pictureBoxContact.Click += new System.EventHandler(this.PictureBoxContactClick);
            this.pictureBoxContact.MouseLeave += new System.EventHandler(this.LabelContactMouseLeave);
            this.pictureBoxContact.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelContactMouseMove);
            // 
            // pictureBoxMovies
            // 
            this.pictureBoxMovies.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxMovies.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMovies.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMovies.Image")));
            this.pictureBoxMovies.Location = new System.Drawing.Point(137, 11);
            this.pictureBoxMovies.Name = "pictureBoxMovies";
            this.pictureBoxMovies.Size = new System.Drawing.Size(88, 93);
            this.pictureBoxMovies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMovies.TabIndex = 129;
            this.pictureBoxMovies.TabStop = false;
            this.pictureBoxMovies.Click += new System.EventHandler(this.PictureBoxMovisClick);
            this.pictureBoxMovies.MouseLeave += new System.EventHandler(this.LabelMovisMouseLeave);
            this.pictureBoxMovies.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelMovisMouseMove);
            // 
            // pictureBoxMyProfile
            // 
            this.pictureBoxMyProfile.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pictureBoxMyProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMyProfile.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMyProfile.Image")));
            this.pictureBoxMyProfile.Location = new System.Drawing.Point(1059, 16);
            this.pictureBoxMyProfile.Name = "pictureBoxMyProfile";
            this.pictureBoxMyProfile.Size = new System.Drawing.Size(93, 83);
            this.pictureBoxMyProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMyProfile.TabIndex = 128;
            this.pictureBoxMyProfile.TabStop = false;
            this.pictureBoxMyProfile.Click += new System.EventHandler(this.PictureBoxMyProfileClick);
            this.pictureBoxMyProfile.MouseLeave += new System.EventHandler(this.LabelMyaccountMouseLeave);
            this.pictureBoxMyProfile.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelMyaccountMouseMove);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel3.Location = new System.Drawing.Point(375, 30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(750, 50);
            this.panel3.TabIndex = 121;
            // 
            // panelKleurVrij
            // 
            this.panelKleurVrij.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelKleurVrij.BackColor = System.Drawing.Color.PeachPuff;
            this.panelKleurVrij.Location = new System.Drawing.Point(45, 104);
            this.panelKleurVrij.Name = "panelKleurVrij";
            this.panelKleurVrij.Size = new System.Drawing.Size(45, 45);
            this.panelKleurVrij.TabIndex = 122;
            // 
            // panelKleurBezet
            // 
            this.panelKleurBezet.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelKleurBezet.BackColor = System.Drawing.Color.Red;
            this.panelKleurBezet.Location = new System.Drawing.Point(45, 168);
            this.panelKleurBezet.Name = "panelKleurBezet";
            this.panelKleurBezet.Size = new System.Drawing.Size(45, 45);
            this.panelKleurBezet.TabIndex = 123;
            // 
            // panelKleurJouwStoel
            // 
            this.panelKleurJouwStoel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelKleurJouwStoel.BackColor = System.Drawing.Color.Blue;
            this.panelKleurJouwStoel.Location = new System.Drawing.Point(45, 232);
            this.panelKleurJouwStoel.Name = "panelKleurJouwStoel";
            this.panelKleurJouwStoel.Size = new System.Drawing.Size(45, 45);
            this.panelKleurJouwStoel.TabIndex = 123;
            // 
            // buttonReserveerKnop
            // 
            this.buttonReserveerKnop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReserveerKnop.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonReserveerKnop.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReserveerKnop.Location = new System.Drawing.Point(1186, 367);
            this.buttonReserveerKnop.Name = "buttonReserveerKnop";
            this.buttonReserveerKnop.Size = new System.Drawing.Size(226, 89);
            this.buttonReserveerKnop.TabIndex = 127;
            this.buttonReserveerKnop.Text = "Bestellen";
            this.buttonReserveerKnop.UseVisualStyleBackColor = false;
            this.buttonReserveerKnop.Visible = false;
            this.buttonReserveerKnop.Click += new System.EventHandler(this.ReserveerKnopClick);
            // 
            // panelStoelen
            // 
            this.panelStoelen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelStoelen.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panelStoelen.Controls.Add(this.btnBack);
            this.panelStoelen.Controls.Add(this.stoelNummer);
            this.panelStoelen.Controls.Add(this.Helper);
            this.panelStoelen.Controls.Add(this.buttonVolgende);
            this.panelStoelen.Controls.Add(this.labelJouwStoel);
            this.panelStoelen.Controls.Add(this.labelStoelBezet);
            this.panelStoelen.Controls.Add(this.labelStoelVrij);
            this.panelStoelen.Controls.Add(this.buttonReserveerKnop);
            this.panelStoelen.Controls.Add(this.panelKleurJouwStoel);
            this.panelStoelen.Controls.Add(this.panelKleurBezet);
            this.panelStoelen.Controls.Add(this.panelKleurVrij);
            this.panelStoelen.Controls.Add(this.panel3);
            this.panelStoelen.Location = new System.Drawing.Point(0, 130);
            this.panelStoelen.Name = "panelStoelen";
            this.panelStoelen.Size = new System.Drawing.Size(1500, 900);
            this.panelStoelen.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.GreenYellow;
            this.btnBack.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBack.Location = new System.Drawing.Point(43, 478);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(182, 82);
            this.btnBack.TabIndex = 134;
            this.btnBack.Text = "Terug";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // stoelNummer
            // 
            this.stoelNummer.AutoSize = true;
            this.stoelNummer.BackColor = System.Drawing.SystemColors.Desktop;
            this.stoelNummer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stoelNummer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stoelNummer.Location = new System.Drawing.Point(1125, 130);
            this.stoelNummer.Name = "stoelNummer";
            this.stoelNummer.Size = new System.Drawing.Size(0, 37);
            this.stoelNummer.TabIndex = 133;
            // 
            // Helper
            // 
            this.Helper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Helper.BackColor = System.Drawing.Color.LightYellow;
            this.Helper.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Helper.Location = new System.Drawing.Point(45, 392);
            this.Helper.Name = "Helper";
            this.Helper.Size = new System.Drawing.Size(41, 45);
            this.Helper.TabIndex = 132;
            this.Helper.UseVisualStyleBackColor = false;
            this.Helper.Visible = false;
            // 
            // buttonVolgende
            // 
            this.buttonVolgende.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonVolgende.BackColor = System.Drawing.Color.GreenYellow;
            this.buttonVolgende.Enabled = false;
            this.buttonVolgende.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVolgende.Location = new System.Drawing.Point(1184, 212);
            this.buttonVolgende.Name = "buttonVolgende";
            this.buttonVolgende.Size = new System.Drawing.Size(155, 45);
            this.buttonVolgende.TabIndex = 131;
            this.buttonVolgende.Text = "Volgende";
            this.buttonVolgende.UseVisualStyleBackColor = false;
            this.buttonVolgende.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelJouwStoel
            // 
            this.labelJouwStoel.AutoSize = true;
            this.labelJouwStoel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJouwStoel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelJouwStoel.Location = new System.Drawing.Point(97, 248);
            this.labelJouwStoel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelJouwStoel.Name = "labelJouwStoel";
            this.labelJouwStoel.Size = new System.Drawing.Size(266, 29);
            this.labelJouwStoel.TabIndex = 130;
            this.labelJouwStoel.Text = "Deze stoel is jouw stoel";
            // 
            // labelStoelBezet
            // 
            this.labelStoelBezet.AutoSize = true;
            this.labelStoelBezet.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStoelBezet.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelStoelBezet.Location = new System.Drawing.Point(97, 176);
            this.labelStoelBezet.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStoelBezet.Name = "labelStoelBezet";
            this.labelStoelBezet.Size = new System.Drawing.Size(216, 29);
            this.labelStoelBezet.TabIndex = 129;
            this.labelStoelBezet.Text = "Deze stoel is bezet";
            // 
            // labelStoelVrij
            // 
            this.labelStoelVrij.AutoSize = true;
            this.labelStoelVrij.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStoelVrij.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelStoelVrij.Location = new System.Drawing.Point(97, 112);
            this.labelStoelVrij.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStoelVrij.Name = "labelStoelVrij";
            this.labelStoelVrij.Size = new System.Drawing.Size(188, 29);
            this.labelStoelVrij.TabIndex = 128;
            this.labelStoelVrij.Text = "Deze stoel is vrij";
            // 
            // FormStoelenScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 761);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelStoelen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStoelenScherm";
            this.Text = "CINEMA4U";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormStoelenSchermFormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMovies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMyProfile)).EndInit();
            this.panelStoelen.ResumeLayout(false);
            this.panelStoelen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxMyProfile;
        private System.Windows.Forms.PictureBox pictureBoxContact;
        private System.Windows.Forms.PictureBox pictureBoxMovies;
        private System.Windows.Forms.Label labelMyaccount;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelMovis;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelKleurVrij;
        private System.Windows.Forms.Panel panelKleurBezet;
        private System.Windows.Forms.Panel panelKleurJouwStoel;
        private System.Windows.Forms.Button buttonReserveerKnop;
        private System.Windows.Forms.Panel panelStoelen;
        private System.Windows.Forms.Label labelJouwStoel;
        private System.Windows.Forms.Label labelStoelBezet;
        private System.Windows.Forms.Label labelStoelVrij;
        private System.Windows.Forms.Button buttonVolgende;
        private System.Windows.Forms.Button Helper;
        private System.Windows.Forms.Label stoelNummer;
        private System.Windows.Forms.Button btnBack;
    }
}

