namespace ProjectB

{
    partial class FormProfiel
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
            this.panelBoven = new System.Windows.Forms.Panel();
            this.labelMyAccount = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelMovis = new System.Windows.Forms.Label();
            this.iconContact = new System.Windows.Forms.PictureBox();
            this.iconMyAccount = new System.Windows.Forms.PictureBox();
            this.iconMovis = new System.Windows.Forms.PictureBox();
            this.panelAanmelden = new System.Windows.Forms.Panel();
            this.buttonAccountMaken = new System.Windows.Forms.Button();
            this.labelHerhaalWachtwoord = new System.Windows.Forms.Label();
            this.labelWachtwoord = new System.Windows.Forms.Label();
            this.labelEmailadres = new System.Windows.Forms.Label();
            this.labelNaamm = new System.Windows.Forms.Label();
            this.boxUsername = new System.Windows.Forms.TextBox();
            this.boxEmail = new System.Windows.Forms.TextBox();
            this.boxPassword = new System.Windows.Forms.TextBox();
            this.boxPasswordrepeat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonInloggen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.boxWachtwoord = new System.Windows.Forms.TextBox();
            this.boxGebruikersnaam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelMyGegevens = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labeEmail = new System.Windows.Forms.Label();
            this.labelMyReseveringen = new System.Windows.Forms.Label();
            this.panelMyProfile = new System.Windows.Forms.Panel();
            this.labelMail = new System.Windows.Forms.Label();
            this.labelNaam = new System.Windows.Forms.Label();
            this.panelBoven.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMyAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMovis)).BeginInit();
            this.panelAanmelden.SuspendLayout();
            this.panelMyProfile.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBoven
            // 
            this.panelBoven.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelBoven.Controls.Add(this.labelMyAccount);
            this.panelBoven.Controls.Add(this.labelContact);
            this.panelBoven.Controls.Add(this.labelMovis);
            this.panelBoven.Controls.Add(this.iconContact);
            this.panelBoven.Controls.Add(this.iconMyAccount);
            this.panelBoven.Controls.Add(this.iconMovis);
            this.panelBoven.Location = new System.Drawing.Point(-1, 0);
            this.panelBoven.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBoven.Name = "panelBoven";
            this.panelBoven.Size = new System.Drawing.Size(1129, 106);
            this.panelBoven.TabIndex = 0;
            // 
            // labelMyAccount
            // 
            this.labelMyAccount.AutoSize = true;
            this.labelMyAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMyAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyAccount.Location = new System.Drawing.Point(872, 37);
            this.labelMyAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMyAccount.Name = "labelMyAccount";
            this.labelMyAccount.Size = new System.Drawing.Size(236, 46);
            this.labelMyAccount.TabIndex = 14;
            this.labelMyAccount.Text = "My account";
            this.labelMyAccount.MouseLeave += new System.EventHandler(this.LabelMyAccountMouseLeave);
            this.labelMyAccount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelMyAccountMouseMove);
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.Location = new System.Drawing.Point(491, 37);
            this.labelContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(166, 46);
            this.labelContact.TabIndex = 13;
            this.labelContact.Text = "Contact";
            this.labelContact.Click += new System.EventHandler(this.LabelContactClick);
            this.labelContact.MouseLeave += new System.EventHandler(this.LabelContactMouseLeave);
            this.labelContact.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelContactMouseMove);
            // 
            // labelMovis
            // 
            this.labelMovis.AutoSize = true;
            this.labelMovis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMovis.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMovis.Location = new System.Drawing.Point(112, 37);
            this.labelMovis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMovis.Name = "labelMovis";
            this.labelMovis.Size = new System.Drawing.Size(152, 46);
            this.labelMovis.TabIndex = 12;
            this.labelMovis.Tag = "";
            this.labelMovis.Text = "Movies";
            this.labelMovis.Click += new System.EventHandler(this.LabelMovisClick);
            this.labelMovis.MouseLeave += new System.EventHandler(this.LabelMovisMouseLeave);
            this.labelMovis.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelMovisMouseMove);
            // 
            // iconContact
            // 
            this.iconContact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconContact.Image = global::HoofdschermProjectB.Properties.Resources.img_542845;
            this.iconContact.Location = new System.Drawing.Point(381, 8);
            this.iconContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconContact.Name = "iconContact";
            this.iconContact.Size = new System.Drawing.Size(93, 88);
            this.iconContact.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconContact.TabIndex = 11;
            this.iconContact.TabStop = false;
            this.iconContact.Tag = "";
            this.iconContact.Click += new System.EventHandler(this.IconContactClick);
            this.iconContact.MouseLeave += new System.EventHandler(this.LabelContactMouseLeave);
            this.iconContact.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelContactMouseMove);
            // 
            // iconMyAccount
            // 
            this.iconMyAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMyAccount.Image = global::HoofdschermProjectB.Properties.Resources.img_568656;
            this.iconMyAccount.Location = new System.Drawing.Point(761, 13);
            this.iconMyAccount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconMyAccount.Name = "iconMyAccount";
            this.iconMyAccount.Size = new System.Drawing.Size(93, 83);
            this.iconMyAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconMyAccount.TabIndex = 10;
            this.iconMyAccount.TabStop = false;
            this.iconMyAccount.Tag = "";
            this.iconMyAccount.MouseLeave += new System.EventHandler(this.LabelMyAccountMouseLeave);
            this.iconMyAccount.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelMyAccountMouseMove);
            // 
            // iconMovis
            // 
            this.iconMovis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconMovis.Image = global::HoofdschermProjectB.Properties.Resources._83519;
            this.iconMovis.Location = new System.Drawing.Point(20, 6);
            this.iconMovis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.iconMovis.Name = "iconMovis";
            this.iconMovis.Size = new System.Drawing.Size(88, 93);
            this.iconMovis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconMovis.TabIndex = 9;
            this.iconMovis.TabStop = false;
            this.iconMovis.Tag = "";
            this.iconMovis.Click += new System.EventHandler(this.IconMovisClick);
            this.iconMovis.MouseLeave += new System.EventHandler(this.LabelMovisMouseLeave);
            this.iconMovis.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelMovisMouseMove);
            // 
            // panelAanmelden
            // 
            this.panelAanmelden.BackColor = System.Drawing.SystemColors.ControlText;
            this.panelAanmelden.Controls.Add(this.buttonAccountMaken);
            this.panelAanmelden.Controls.Add(this.labelHerhaalWachtwoord);
            this.panelAanmelden.Controls.Add(this.labelWachtwoord);
            this.panelAanmelden.Controls.Add(this.labelEmailadres);
            this.panelAanmelden.Controls.Add(this.labelNaamm);
            this.panelAanmelden.Controls.Add(this.boxUsername);
            this.panelAanmelden.Controls.Add(this.boxEmail);
            this.panelAanmelden.Controls.Add(this.boxPassword);
            this.panelAanmelden.Controls.Add(this.boxPasswordrepeat);
            this.panelAanmelden.Controls.Add(this.label4);
            this.panelAanmelden.Controls.Add(this.buttonInloggen);
            this.panelAanmelden.Controls.Add(this.label3);
            this.panelAanmelden.Controls.Add(this.label2);
            this.panelAanmelden.Controls.Add(this.boxWachtwoord);
            this.panelAanmelden.Controls.Add(this.boxGebruikersnaam);
            this.panelAanmelden.Controls.Add(this.label1);
            this.panelAanmelden.Location = new System.Drawing.Point(0, 106);
            this.panelAanmelden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelAanmelden.Name = "panelAanmelden";
            this.panelAanmelden.Size = new System.Drawing.Size(1141, 665);
            this.panelAanmelden.TabIndex = 1;
            // 
            // buttonAccountMaken
            // 
            this.buttonAccountMaken.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonAccountMaken.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAccountMaken.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAccountMaken.Location = new System.Drawing.Point(234, 409);
            this.buttonAccountMaken.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAccountMaken.Name = "buttonAccountMaken";
            this.buttonAccountMaken.Size = new System.Drawing.Size(179, 41);
            this.buttonAccountMaken.TabIndex = 15;
            this.buttonAccountMaken.Text = "ACCOUNT AANMAKEN";
            this.buttonAccountMaken.UseVisualStyleBackColor = false;
            this.buttonAccountMaken.Click += new System.EventHandler(this.ButtonAccountMakenClick);
            // 
            // labelHerhaalWachtwoord
            // 
            this.labelHerhaalWachtwoord.AutoSize = true;
            this.labelHerhaalWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHerhaalWachtwoord.ForeColor = System.Drawing.Color.White;
            this.labelHerhaalWachtwoord.Location = new System.Drawing.Point(2, 325);
            this.labelHerhaalWachtwoord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelHerhaalWachtwoord.Name = "labelHerhaalWachtwoord";
            this.labelHerhaalWachtwoord.Size = new System.Drawing.Size(136, 17);
            this.labelHerhaalWachtwoord.TabIndex = 14;
            this.labelHerhaalWachtwoord.Text = "Herhaal wachtwoord";
            // 
            // labelWachtwoord
            // 
            this.labelWachtwoord.AutoSize = true;
            this.labelWachtwoord.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWachtwoord.ForeColor = System.Drawing.Color.White;
            this.labelWachtwoord.Location = new System.Drawing.Point(47, 245);
            this.labelWachtwoord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelWachtwoord.Name = "labelWachtwoord";
            this.labelWachtwoord.Size = new System.Drawing.Size(86, 17);
            this.labelWachtwoord.TabIndex = 13;
            this.labelWachtwoord.Text = "Wachtwoord";
            // 
            // labelEmailadres
            // 
            this.labelEmailadres.AutoSize = true;
            this.labelEmailadres.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmailadres.ForeColor = System.Drawing.Color.White;
            this.labelEmailadres.Location = new System.Drawing.Point(50, 165);
            this.labelEmailadres.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmailadres.Name = "labelEmailadres";
            this.labelEmailadres.Size = new System.Drawing.Size(83, 17);
            this.labelEmailadres.TabIndex = 12;
            this.labelEmailadres.Text = "E-mailadres";
            // 
            // labelNaamm
            // 
            this.labelNaamm.AutoSize = true;
            this.labelNaamm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaamm.ForeColor = System.Drawing.Color.White;
            this.labelNaamm.Location = new System.Drawing.Point(84, 87);
            this.labelNaamm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNaamm.Name = "labelNaamm";
            this.labelNaamm.Size = new System.Drawing.Size(45, 17);
            this.labelNaamm.TabIndex = 11;
            this.labelNaamm.Text = "Naam";
            // 
            // boxUsername
            // 
            this.boxUsername.Location = new System.Drawing.Point(145, 85);
            this.boxUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxUsername.Name = "boxUsername";
            this.boxUsername.Size = new System.Drawing.Size(266, 20);
            this.boxUsername.TabIndex = 10;
            // 
            // boxEmail
            // 
            this.boxEmail.Location = new System.Drawing.Point(148, 165);
            this.boxEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxEmail.Name = "boxEmail";
            this.boxEmail.Size = new System.Drawing.Size(266, 20);
            this.boxEmail.TabIndex = 9;
            // 
            // boxPassword
            // 
            this.boxPassword.Location = new System.Drawing.Point(148, 244);
            this.boxPassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxPassword.Name = "boxPassword";
            this.boxPassword.Size = new System.Drawing.Size(266, 20);
            this.boxPassword.TabIndex = 8;
            // 
            // boxPasswordrepeat
            // 
            this.boxPasswordrepeat.Location = new System.Drawing.Point(148, 325);
            this.boxPasswordrepeat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxPasswordrepeat.Name = "boxPasswordrepeat";
            this.boxPasswordrepeat.Size = new System.Drawing.Size(266, 20);
            this.boxPasswordrepeat.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(140, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(306, 31);
            this.label4.TabIndex = 6;
            this.label4.Text = "U kunt hier aanmelden";
            // 
            // buttonInloggen
            // 
            this.buttonInloggen.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonInloggen.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInloggen.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonInloggen.Location = new System.Drawing.Point(907, 232);
            this.buttonInloggen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonInloggen.Name = "buttonInloggen";
            this.buttonInloggen.Size = new System.Drawing.Size(119, 41);
            this.buttonInloggen.TabIndex = 5;
            this.buttonInloggen.Text = "INLOGGEN";
            this.buttonInloggen.UseVisualStyleBackColor = false;
            this.buttonInloggen.Click += new System.EventHandler(this.ButtonInloggenClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(664, 155);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Wachtwoord";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(642, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gebruikersnaam";
            // 
            // boxWachtwoord
            // 
            this.boxWachtwoord.Location = new System.Drawing.Point(760, 155);
            this.boxWachtwoord.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxWachtwoord.Name = "boxWachtwoord";
            this.boxWachtwoord.Size = new System.Drawing.Size(266, 20);
            this.boxWachtwoord.TabIndex = 2;
            // 
            // boxGebruikersnaam
            // 
            this.boxGebruikersnaam.Location = new System.Drawing.Point(760, 85);
            this.boxGebruikersnaam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.boxGebruikersnaam.Name = "boxGebruikersnaam";
            this.boxGebruikersnaam.Size = new System.Drawing.Size(266, 20);
            this.boxGebruikersnaam.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(766, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ik heb al een account";
            // 
            // labelMyGegevens
            // 
            this.labelMyGegevens.AutoSize = true;
            this.labelMyGegevens.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyGegevens.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMyGegevens.Location = new System.Drawing.Point(15, 42);
            this.labelMyGegevens.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMyGegevens.Name = "labelMyGegevens";
            this.labelMyGegevens.Size = new System.Drawing.Size(152, 26);
            this.labelMyGegevens.TabIndex = 0;
            this.labelMyGegevens.Text = "Mijn gegevens";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelName.Location = new System.Drawing.Point(20, 130);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(59, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Naam: ";
            // 
            // labeEmail
            // 
            this.labeEmail.AutoSize = true;
            this.labeEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeEmail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labeEmail.Location = new System.Drawing.Point(20, 205);
            this.labeEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeEmail.Name = "labeEmail";
            this.labeEmail.Size = new System.Drawing.Size(61, 20);
            this.labeEmail.TabIndex = 2;
            this.labeEmail.Text = "E-mail: ";
            // 
            // labelMyReseveringen
            // 
            this.labelMyReseveringen.AutoSize = true;
            this.labelMyReseveringen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyReseveringen.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMyReseveringen.Location = new System.Drawing.Point(682, 42);
            this.labelMyReseveringen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMyReseveringen.Name = "labelMyReseveringen";
            this.labelMyReseveringen.Size = new System.Drawing.Size(190, 26);
            this.labelMyReseveringen.TabIndex = 3;
            this.labelMyReseveringen.Text = "Mijn reserveringen";
            // 
            // panelMyProfile
            // 
            this.panelMyProfile.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelMyProfile.Controls.Add(this.labelMail);
            this.panelMyProfile.Controls.Add(this.labelNaam);
            this.panelMyProfile.Controls.Add(this.labelMyReseveringen);
            this.panelMyProfile.Controls.Add(this.labeEmail);
            this.panelMyProfile.Controls.Add(this.labelName);
            this.panelMyProfile.Controls.Add(this.labelMyGegevens);
            this.panelMyProfile.Location = new System.Drawing.Point(0, 107);
            this.panelMyProfile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelMyProfile.Name = "panelMyProfile";
            this.panelMyProfile.Size = new System.Drawing.Size(1141, 665);
            this.panelMyProfile.TabIndex = 16;
            // 
            // labelMail
            // 
            this.labelMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMail.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelMail.Location = new System.Drawing.Point(97, 202);
            this.labelMail.Name = "labelMail";
            this.labelMail.Size = new System.Drawing.Size(389, 39);
            this.labelMail.TabIndex = 5;
            this.labelMail.Text = "label13";
            // 
            // labelNaam
            // 
            this.labelNaam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNaam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelNaam.Location = new System.Drawing.Point(97, 127);
            this.labelNaam.Name = "labelNaam";
            this.labelNaam.Size = new System.Drawing.Size(349, 35);
            this.labelNaam.TabIndex = 4;
            this.labelNaam.Text = "label13";
            // 
            // FormProfiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 629);
            this.Controls.Add(this.panelBoven);
            this.Controls.Add(this.panelAanmelden);
            this.Controls.Add(this.panelMyProfile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormProfiel";
            this.Text = "CINEMA4U";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProfielFormClosed);
            this.panelBoven.ResumeLayout(false);
            this.panelBoven.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMyAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconMovis)).EndInit();
            this.panelAanmelden.ResumeLayout(false);
            this.panelAanmelden.PerformLayout();
            this.panelMyProfile.ResumeLayout(false);
            this.panelMyProfile.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBoven;
        private System.Windows.Forms.Label labelMyAccount;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelMovis;
        private System.Windows.Forms.PictureBox iconContact;
        private System.Windows.Forms.PictureBox iconMyAccount;
        private System.Windows.Forms.PictureBox iconMovis;
        private System.Windows.Forms.Panel panelAanmelden;
        private System.Windows.Forms.TextBox boxWachtwoord;
        private System.Windows.Forms.TextBox boxGebruikersnaam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonInloggen;
        private System.Windows.Forms.Button buttonAccountMaken;
        private System.Windows.Forms.Label labelHerhaalWachtwoord;
        private System.Windows.Forms.Label labelWachtwoord;
        private System.Windows.Forms.Label labelEmailadres;
        private System.Windows.Forms.Label labelNaamm;
        private System.Windows.Forms.TextBox boxUsername;
        private System.Windows.Forms.TextBox boxEmail;
        private System.Windows.Forms.TextBox boxPassword;
        private System.Windows.Forms.TextBox boxPasswordrepeat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelMyGegevens;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labeEmail;
        private System.Windows.Forms.Label labelMyReseveringen;
        private System.Windows.Forms.Panel panelMyProfile;
        private System.Windows.Forms.Label labelNaam;
        private System.Windows.Forms.Label labelMail;
    }
}

