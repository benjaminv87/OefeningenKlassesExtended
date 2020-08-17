namespace OefeningenKlassesExtended
{
    partial class VoegPersoonToe
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
            this.dtGeboorteDatum = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGeslacht = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFamilieNaam = new System.Windows.Forms.TextBox();
            this.tbVoornaam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGeboorteDatum
            // 
            this.dtGeboorteDatum.Location = new System.Drawing.Point(95, 65);
            this.dtGeboorteDatum.Name = "dtGeboorteDatum";
            this.dtGeboorteDatum.Size = new System.Drawing.Size(200, 20);
            this.dtGeboorteDatum.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAnnuleren);
            this.groupBox1.Controls.Add(this.btnVoegToe);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbGeslacht);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbFamilieNaam);
            this.groupBox1.Controls.Add(this.tbVoornaam);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtGeboorteDatum);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nieuwe Werknemer";
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(154, 132);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(108, 23);
            this.btnAnnuleren.TabIndex = 6;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            this.btnAnnuleren.Click += new System.EventHandler(this.btnAnnuleren_Click);
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(40, 132);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(108, 23);
            this.btnVoegToe.TabIndex = 5;
            this.btnVoegToe.Text = "Toevoegen";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Geslacht:";
            // 
            // cbGeslacht
            // 
            this.cbGeslacht.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbGeslacht.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbGeslacht.FormattingEnabled = true;
            this.cbGeslacht.Location = new System.Drawing.Point(95, 88);
            this.cbGeslacht.Name = "cbGeslacht";
            this.cbGeslacht.Size = new System.Drawing.Size(200, 21);
            this.cbGeslacht.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Familienaam :";
            // 
            // tbFamilieNaam
            // 
            this.tbFamilieNaam.Location = new System.Drawing.Point(95, 39);
            this.tbFamilieNaam.Name = "tbFamilieNaam";
            this.tbFamilieNaam.Size = new System.Drawing.Size(200, 20);
            this.tbFamilieNaam.TabIndex = 2;
            // 
            // tbVoornaam
            // 
            this.tbVoornaam.Location = new System.Drawing.Point(95, 13);
            this.tbVoornaam.Name = "tbVoornaam";
            this.tbVoornaam.Size = new System.Drawing.Size(200, 20);
            this.tbVoornaam.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Geboortedatum:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 99;
            this.label1.Text = "Voornaam :";
            // 
            // VoegPersoonToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 196);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(355, 235);
            this.MinimumSize = new System.Drawing.Size(355, 235);
            this.Name = "VoegPersoonToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.VoegPersoonToe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtGeboorteDatum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbGeslacht;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFamilieNaam;
        private System.Windows.Forms.TextBox tbVoornaam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}