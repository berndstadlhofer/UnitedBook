namespace UnitedBook
{
    partial class Userverwaltung
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstUser = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblRolle = new System.Windows.Forms.Label();
            this.lblBenutzername = new System.Windows.Forms.Label();
            this.lblNachname = new System.Windows.Forms.Label();
            this.lblVorname = new System.Windows.Forms.Label();
            this.cmdBearbeiten = new System.Windows.Forms.Button();
            this.cmdNeu = new System.Windows.Forms.Button();
            this.cmdLoeschen = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(659, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doppelklicken Sie einen User, um ihn zu bearbeiten, oder drücken Sie \"Neu\", um ei" +
    "nen neuen User anzulegen!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Userverwaltung";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 110);
            this.panel1.TabIndex = 1;
            // 
            // lstUser
            // 
            this.lstUser.FormattingEnabled = true;
            this.lstUser.ItemHeight = 16;
            this.lstUser.Location = new System.Drawing.Point(11, 114);
            this.lstUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstUser.Name = "lstUser";
            this.lstUser.Size = new System.Drawing.Size(344, 292);
            this.lstUser.TabIndex = 2;
            this.lstUser.SelectedIndexChanged += new System.EventHandler(this.lstUser_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(380, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Vorname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(380, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nachname:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "Benutzername: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 295);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Rolle:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(508, 114);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(11, 16);
            this.lblID.TabIndex = 8;
            this.lblID.Text = "-";
            // 
            // lblRolle
            // 
            this.lblRolle.AutoSize = true;
            this.lblRolle.Location = new System.Drawing.Point(508, 295);
            this.lblRolle.Name = "lblRolle";
            this.lblRolle.Size = new System.Drawing.Size(11, 16);
            this.lblRolle.TabIndex = 9;
            this.lblRolle.Text = "-";
            // 
            // lblBenutzername
            // 
            this.lblBenutzername.AutoSize = true;
            this.lblBenutzername.Location = new System.Drawing.Point(508, 250);
            this.lblBenutzername.Name = "lblBenutzername";
            this.lblBenutzername.Size = new System.Drawing.Size(11, 16);
            this.lblBenutzername.TabIndex = 10;
            this.lblBenutzername.Text = "-";
            // 
            // lblNachname
            // 
            this.lblNachname.AutoSize = true;
            this.lblNachname.Location = new System.Drawing.Point(508, 199);
            this.lblNachname.Name = "lblNachname";
            this.lblNachname.Size = new System.Drawing.Size(11, 16);
            this.lblNachname.TabIndex = 11;
            this.lblNachname.Text = "-";
            // 
            // lblVorname
            // 
            this.lblVorname.AutoSize = true;
            this.lblVorname.Location = new System.Drawing.Point(508, 154);
            this.lblVorname.Name = "lblVorname";
            this.lblVorname.Size = new System.Drawing.Size(11, 16);
            this.lblVorname.TabIndex = 12;
            this.lblVorname.Text = "-";
            // 
            // cmdBearbeiten
            // 
            this.cmdBearbeiten.Location = new System.Drawing.Point(11, 426);
            this.cmdBearbeiten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdBearbeiten.Name = "cmdBearbeiten";
            this.cmdBearbeiten.Size = new System.Drawing.Size(109, 30);
            this.cmdBearbeiten.TabIndex = 13;
            this.cmdBearbeiten.Text = "Bearbeiten";
            this.cmdBearbeiten.UseVisualStyleBackColor = true;
            this.cmdBearbeiten.Click += new System.EventHandler(this.cmdBearbeiten_Click);
            // 
            // cmdNeu
            // 
            this.cmdNeu.Location = new System.Drawing.Point(145, 426);
            this.cmdNeu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdNeu.Name = "cmdNeu";
            this.cmdNeu.Size = new System.Drawing.Size(109, 30);
            this.cmdNeu.TabIndex = 14;
            this.cmdNeu.Text = "Neu";
            this.cmdNeu.UseVisualStyleBackColor = true;
            this.cmdNeu.Click += new System.EventHandler(this.cmdNeu_Click);
            // 
            // cmdLoeschen
            // 
            this.cmdLoeschen.Location = new System.Drawing.Point(284, 426);
            this.cmdLoeschen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdLoeschen.Name = "cmdLoeschen";
            this.cmdLoeschen.Size = new System.Drawing.Size(109, 30);
            this.cmdLoeschen.TabIndex = 15;
            this.cmdLoeschen.Text = "Löschen";
            this.cmdLoeschen.UseVisualStyleBackColor = true;
            this.cmdLoeschen.Click += new System.EventHandler(this.cmdLoeschen_Click);
            // 
            // Userverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 492);
            this.Controls.Add(this.cmdLoeschen);
            this.Controls.Add(this.cmdNeu);
            this.Controls.Add(this.cmdBearbeiten);
            this.Controls.Add(this.lblVorname);
            this.Controls.Add(this.lblNachname);
            this.Controls.Add(this.lblBenutzername);
            this.Controls.Add(this.lblRolle);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstUser);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Userverwaltung";
            this.Text = "Userverwaltung";
            this.Load += new System.EventHandler(this.Userverwaltung_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblRolle;
        private System.Windows.Forms.Label lblBenutzername;
        private System.Windows.Forms.Label lblNachname;
        private System.Windows.Forms.Label lblVorname;
        private System.Windows.Forms.Button cmdBearbeiten;
        private System.Windows.Forms.Button cmdNeu;
        private System.Windows.Forms.Button cmdLoeschen;
    }
}