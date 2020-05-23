namespace ProjectB
{
    partial class ContactForm
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
            this.labeInfo = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.panelContact = new System.Windows.Forms.Panel();
            this.panelBoven2 = new System.Windows.Forms.Panel();
            this.labelMyAccountt = new System.Windows.Forms.Label();
            this.labelContactt = new System.Windows.Forms.Label();
            this.labelMovis = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContact.SuspendLayout();
            this.panelBoven2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labeInfo
            // 
            this.labeInfo.AutoSize = true;
            this.labeInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeInfo.ForeColor = System.Drawing.Color.White;
            this.labeInfo.Location = new System.Drawing.Point(15, 214);
            this.labeInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labeInfo.Name = "labeInfo";
            this.labeInfo.Size = new System.Drawing.Size(109, 39);
            this.labeInfo.TabIndex = 2;
            this.labeInfo.Text = "label4";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Segoe Print", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelContact.Location = new System.Drawing.Point(7, 32);
            this.labelContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(179, 84);
            this.labelContact.TabIndex = 0;
            this.labelContact.Text = "label3";
            // 
            // labelInfo2
            // 
            this.labelInfo2.AutoSize = true;
            this.labelInfo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo2.ForeColor = System.Drawing.Color.White;
            this.labelInfo2.Location = new System.Drawing.Point(715, 214);
            this.labelInfo2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(109, 39);
            this.labelInfo2.TabIndex = 1;
            this.labelInfo2.Text = "label3";
            // 
            // panelContact
            // 
            this.panelContact.BackColor = System.Drawing.Color.Black;
            this.panelContact.Controls.Add(this.labeInfo);
            this.panelContact.Controls.Add(this.labelInfo2);
            this.panelContact.Controls.Add(this.labelContact);
            this.panelContact.Location = new System.Drawing.Point(0, 103);
            this.panelContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelContact.Name = "panelContact";
            this.panelContact.Size = new System.Drawing.Size(1141, 667);
            this.panelContact.TabIndex = 17;
            // 
            // panelBoven2
            // 
            this.panelBoven2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panelBoven2.Controls.Add(this.labelMyAccountt);
            this.panelBoven2.Controls.Add(this.labelContactt);
            this.panelBoven2.Controls.Add(this.labelMovis);
            this.panelBoven2.Controls.Add(this.pictureBox3);
            this.panelBoven2.Controls.Add(this.pictureBox2);
            this.panelBoven2.Controls.Add(this.pictureBox1);
            this.panelBoven2.Location = new System.Drawing.Point(2, -2);
            this.panelBoven2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelBoven2.Name = "panelBoven2";
            this.panelBoven2.Size = new System.Drawing.Size(1125, 106);
            this.panelBoven2.TabIndex = 18;
            // 
            // labelMyAccountt
            // 
            this.labelMyAccountt.AutoSize = true;
            this.labelMyAccountt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMyAccountt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMyAccountt.Location = new System.Drawing.Point(872, 37);
            this.labelMyAccountt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMyAccountt.Name = "labelMyAccountt";
            this.labelMyAccountt.Size = new System.Drawing.Size(236, 46);
            this.labelMyAccountt.TabIndex = 13;
            this.labelMyAccountt.Text = "My account";
            this.labelMyAccountt.Click += new System.EventHandler(this.LabelProfileClick);
            this.labelMyAccountt.MouseLeave += new System.EventHandler(this.LabeProfileMouseLeave);
            this.labelMyAccountt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabeProfileMouseMove);
            // 
            // labelContactt
            // 
            this.labelContactt.AutoSize = true;
            this.labelContactt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelContactt.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContactt.Location = new System.Drawing.Point(491, 37);
            this.labelContactt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContactt.Name = "labelContactt";
            this.labelContactt.Size = new System.Drawing.Size(166, 46);
            this.labelContactt.TabIndex = 12;
            this.labelContactt.Text = "Contact";
            this.labelContactt.MouseLeave += new System.EventHandler(this.LabelContacMouseLeave);
            this.labelContactt.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelContactMouseMove);
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
            this.labelMovis.TabIndex = 11;
            this.labelMovis.Tag = "";
            this.labelMovis.Text = "Movies";
            this.labelMovis.Click += new System.EventHandler(this.LabelMovisClick);
            this.labelMovis.MouseLeave += new System.EventHandler(this.LabelMovisMouseLeave);
            this.labelMovis.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelMovisMouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::HoofdschermProjectB.Properties.Resources.img_568656;
            this.pictureBox3.Location = new System.Drawing.Point(761, 13);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(93, 83);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PictureBoxProfileClick);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.LabeProfileMouseLeave);
            this.pictureBox3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabeProfileMouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::HoofdschermProjectB.Properties.Resources.img_542845;
            this.pictureBox2.Location = new System.Drawing.Point(381, 8);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(93, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseLeave += new System.EventHandler(this.LabelContacMouseLeave);
            this.pictureBox2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelContactMouseMove);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::HoofdschermProjectB.Properties.Resources._83519;
            this.pictureBox1.Location = new System.Drawing.Point(20, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 93);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "";
            this.pictureBox1.Click += new System.EventHandler(this.PictureBoxMovieClick);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.LabelMovisMouseLeave);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelMovisMouseMove);
            // 
            // contactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1112, 693);
            this.Controls.Add(this.panelBoven2);
            this.Controls.Add(this.panelContact);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "contactForm";
            this.Text = "CINEMA4U";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ContactFormFormClosed);
            this.panelContact.ResumeLayout(false);
            this.panelContact.PerformLayout();
            this.panelBoven2.ResumeLayout(false);
            this.panelBoven2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labeInfo;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelInfo2;
        private System.Windows.Forms.Panel panelContact;
        private System.Windows.Forms.Panel panelBoven2;
        private System.Windows.Forms.Label labelMyAccountt;
        private System.Windows.Forms.Label labelContactt;
        private System.Windows.Forms.Label labelMovis;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}