namespace OefeningenKlassesExtended
{
    partial class VoegAttractieToe
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
            this.btnAnnuleren = new System.Windows.Forms.Button();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.numMaxAantal = new System.Windows.Forms.NumericUpDown();
            this.numMinLeeftijd = new System.Windows.Forms.NumericUpDown();
            this.tbKleur = new System.Windows.Forms.TextBox();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxAantal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinLeeftijd)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAnnuleren);
            this.groupBox1.Controls.Add(this.btnVoegToe);
            this.groupBox1.Controls.Add(this.numMaxAantal);
            this.groupBox1.Controls.Add(this.numMinLeeftijd);
            this.groupBox1.Controls.Add(this.tbKleur);
            this.groupBox1.Controls.Add(this.tbNaam);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblNaam);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 189);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nieuwe attractie";
            // 
            // btnAnnuleren
            // 
            this.btnAnnuleren.Location = new System.Drawing.Point(118, 128);
            this.btnAnnuleren.Name = "btnAnnuleren";
            this.btnAnnuleren.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuleren.TabIndex = 2;
            this.btnAnnuleren.Text = "Annuleren";
            this.btnAnnuleren.UseVisualStyleBackColor = true;
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(15, 128);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(75, 23);
            this.btnVoegToe.TabIndex = 2;
            this.btnVoegToe.Text = "Toevoegen";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // numMaxAantal
            // 
            this.numMaxAantal.Location = new System.Drawing.Point(118, 95);
            this.numMaxAantal.Name = "numMaxAantal";
            this.numMaxAantal.Size = new System.Drawing.Size(100, 20);
            this.numMaxAantal.TabIndex = 7;
            // 
            // numMinLeeftijd
            // 
            this.numMinLeeftijd.Location = new System.Drawing.Point(118, 69);
            this.numMinLeeftijd.Name = "numMinLeeftijd";
            this.numMinLeeftijd.Size = new System.Drawing.Size(100, 20);
            this.numMinLeeftijd.TabIndex = 6;
            // 
            // tbKleur
            // 
            this.tbKleur.Location = new System.Drawing.Point(118, 43);
            this.tbKleur.Name = "tbKleur";
            this.tbKleur.Size = new System.Drawing.Size(100, 20);
            this.tbKleur.TabIndex = 5;
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(118, 17);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(100, 20);
            this.tbNaam.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Max aantal personen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Minimum leeftijd:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kleur:";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(74, 20);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(38, 13);
            this.lblNaam.TabIndex = 0;
            this.lblNaam.Text = "Naam:";
            // 
            // VoegAttractieToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 216);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(275, 255);
            this.MinimumSize = new System.Drawing.Size(275, 255);
            this.Name = "VoegAttractieToe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMaxAantal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinLeeftijd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAnnuleren;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.NumericUpDown numMaxAantal;
        private System.Windows.Forms.NumericUpDown numMinLeeftijd;
        private System.Windows.Forms.TextBox tbKleur;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNaam;
    }
}