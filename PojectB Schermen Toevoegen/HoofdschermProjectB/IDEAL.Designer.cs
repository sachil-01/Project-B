﻿namespace ProjectB
{
    partial class IDEAL
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
            this.BankBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BankNrLabel = new System.Windows.Forms.Label();
            this.BevestigenKnop = new System.Windows.Forms.Button();
            this.Transactie = new System.Windows.Forms.Label();
            this.check = new System.Windows.Forms.PictureBox();
            this.BankLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MailLabel = new System.Windows.Forms.Label();
            this.BankNrBox = new System.Windows.Forms.TextBox();
            this.GebruikersNaamLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.GebruikersNaamBox = new System.Windows.Forms.TextBox();
            this.WachtWoordBox = new System.Windows.Forms.TextBox();
            this.WachtwoordLabel = new System.Windows.Forms.Label();
            this.LogInKnop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.check)).BeginInit();
            this.SuspendLayout();
            // 
            // BankBox
            // 
            this.BankBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankBox.Location = new System.Drawing.Point(658, 346);
            this.BankBox.Margin = new System.Windows.Forms.Padding(4);
            this.BankBox.Name = "BankBox";
            this.BankBox.Size = new System.Drawing.Size(399, 28);
            this.BankBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 5;
            // 
            // BankNrLabel
            // 
            this.BankNrLabel.AutoSize = true;
            this.BankNrLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankNrLabel.Location = new System.Drawing.Point(151, 428);
            this.BankNrLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BankNrLabel.Name = "BankNrLabel";
            this.BankNrLabel.Size = new System.Drawing.Size(202, 24);
            this.BankNrLabel.TabIndex = 8;
            this.BankNrLabel.Text = "Bankrekening nummer";
            // 
            // BevestigenKnop
            // 
            this.BevestigenKnop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BevestigenKnop.Location = new System.Drawing.Point(669, 538);
            this.BevestigenKnop.Margin = new System.Windows.Forms.Padding(4);
            this.BevestigenKnop.Name = "BevestigenKnop";
            this.BevestigenKnop.Size = new System.Drawing.Size(316, 105);
            this.BevestigenKnop.TabIndex = 12;
            this.BevestigenKnop.Text = "Bevestigen";
            this.BevestigenKnop.UseVisualStyleBackColor = true;
            this.BevestigenKnop.Click += new System.EventHandler(this.Button2Click);
            // 
            // Transactie
            // 
            this.Transactie.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Transactie.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Transactie.Location = new System.Drawing.Point(1238, 467);
            this.Transactie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Transactie.Name = "Transactie";
            this.Transactie.Size = new System.Drawing.Size(307, 50);
            this.Transactie.TabIndex = 13;
            this.Transactie.Text = "Transactie voltooid";
            this.Transactie.Visible = false;
            // 
            // check
            // 
            this.check.Image = global::HoofdschermProjectB.Properties.Resources.confirm_icon_png;
            this.check.Location = new System.Drawing.Point(1185, 206);
            this.check.Margin = new System.Windows.Forms.Padding(4);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(267, 246);
            this.check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.check.TabIndex = 14;
            this.check.TabStop = false;
            this.check.Visible = false;
            // 
            // BankLabel
            // 
            this.BankLabel.AutoSize = true;
            this.BankLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankLabel.Location = new System.Drawing.Point(151, 350);
            this.BankLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BankLabel.Name = "BankLabel";
            this.BankLabel.Size = new System.Drawing.Size(52, 24);
            this.BankLabel.TabIndex = 4;
            this.BankLabel.Text = "Bank";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 149);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 24);
            this.label3.TabIndex = 16;
            this.label3.Text = "Gebruikersnaam: ";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailLabel.Location = new System.Drawing.Point(151, 224);
            this.MailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(68, 24);
            this.MailLabel.TabIndex = 17;
            this.MailLabel.Text = "E-mail:";
            // 
            // BankNrBox
            // 
            this.BankNrBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BankNrBox.Location = new System.Drawing.Point(658, 424);
            this.BankNrBox.Margin = new System.Windows.Forms.Padding(4);
            this.BankNrBox.Name = "BankNrBox";
            this.BankNrBox.Size = new System.Drawing.Size(399, 28);
            this.BankNrBox.TabIndex = 18;
            // 
            // GebruikersNaamLabel
            // 
            this.GebruikersNaamLabel.AutoSize = true;
            this.GebruikersNaamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GebruikersNaamLabel.Location = new System.Drawing.Point(665, 145);
            this.GebruikersNaamLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GebruikersNaamLabel.Name = "GebruikersNaamLabel";
            this.GebruikersNaamLabel.Size = new System.Drawing.Size(149, 24);
            this.GebruikersNaamLabel.TabIndex = 19;
            this.GebruikersNaamLabel.Text = "Gebruikersnaam";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(665, 223);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(63, 24);
            this.EmailLabel.TabIndex = 20;
            this.EmailLabel.Text = "E-mail";
            // 
            // GebruikersNaamBox
            // 
            this.GebruikersNaamBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GebruikersNaamBox.Location = new System.Drawing.Point(658, 141);
            this.GebruikersNaamBox.Margin = new System.Windows.Forms.Padding(4);
            this.GebruikersNaamBox.Name = "GebruikersNaamBox";
            this.GebruikersNaamBox.Size = new System.Drawing.Size(399, 28);
            this.GebruikersNaamBox.TabIndex = 21;
            this.GebruikersNaamBox.Visible = false;
            // 
            // WachtWoordBox
            // 
            this.WachtWoordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WachtWoordBox.Location = new System.Drawing.Point(658, 219);
            this.WachtWoordBox.Margin = new System.Windows.Forms.Padding(4);
            this.WachtWoordBox.Name = "WachtWoordBox";
            this.WachtWoordBox.Size = new System.Drawing.Size(399, 28);
            this.WachtWoordBox.TabIndex = 22;
            this.WachtWoordBox.Visible = false;
            // 
            // WachtwoordLabel
            // 
            this.WachtwoordLabel.AutoSize = true;
            this.WachtwoordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WachtwoordLabel.Location = new System.Drawing.Point(151, 224);
            this.WachtwoordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WachtwoordLabel.Name = "WachtwoordLabel";
            this.WachtwoordLabel.Size = new System.Drawing.Size(121, 24);
            this.WachtwoordLabel.TabIndex = 23;
            this.WachtwoordLabel.Text = "Wachtwoord:";
            this.WachtwoordLabel.Visible = false;
            // 
            // LogInKnop
            // 
            this.LogInKnop.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInKnop.Location = new System.Drawing.Point(783, 307);
            this.LogInKnop.Margin = new System.Windows.Forms.Padding(4);
            this.LogInKnop.Name = "LogInKnop";
            this.LogInKnop.Size = new System.Drawing.Size(147, 53);
            this.LogInKnop.TabIndex = 24;
            this.LogInKnop.Text = "LogIn";
            this.LogInKnop.UseVisualStyleBackColor = true;
            this.LogInKnop.Visible = false;
            this.LogInKnop.Click += new System.EventHandler(this.LogInKnop_Click);
            // 
            // IDEAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1471, 747);
            this.Controls.Add(this.LogInKnop);
            this.Controls.Add(this.WachtwoordLabel);
            this.Controls.Add(this.WachtWoordBox);
            this.Controls.Add(this.GebruikersNaamBox);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.GebruikersNaamLabel);
            this.Controls.Add(this.BankNrBox);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.check);
            this.Controls.Add(this.Transactie);
            this.Controls.Add(this.BevestigenKnop);
            this.Controls.Add(this.BankNrLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BankLabel);
            this.Controls.Add(this.BankBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IDEAL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CINEMA4U";
            ((System.ComponentModel.ISupportInitialize)(this.check)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BankBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label BankNrLabel;
        private System.Windows.Forms.Button BevestigenKnop;
        private System.Windows.Forms.Label Transactie;
        private System.Windows.Forms.PictureBox check;
        private System.Windows.Forms.Label BankLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.TextBox BankNrBox;
        private System.Windows.Forms.Label GebruikersNaamLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox GebruikersNaamBox;
        private System.Windows.Forms.TextBox WachtWoordBox;
        private System.Windows.Forms.Label WachtwoordLabel;
        private System.Windows.Forms.Button LogInKnop;
    }
}