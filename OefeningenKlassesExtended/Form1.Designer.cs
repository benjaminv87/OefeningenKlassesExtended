namespace OefeningenKlassesExtended
{
    partial class Form1
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
            this.lblPretparkNaam = new System.Windows.Forms.Label();
            this.lbMijnLijst = new System.Windows.Forms.ListBox();
            this.rbWerknemers = new System.Windows.Forms.RadioButton();
            this.rbAttracties = new System.Windows.Forms.RadioButton();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.lblData1 = new System.Windows.Forms.Label();
            this.lblData2 = new System.Windows.Forms.Label();
            this.lblData3 = new System.Windows.Forms.Label();
            this.lblData4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPretparkNaam
            // 
            this.lblPretparkNaam.AutoSize = true;
            this.lblPretparkNaam.Location = new System.Drawing.Point(12, 9);
            this.lblPretparkNaam.Name = "lblPretparkNaam";
            this.lblPretparkNaam.Size = new System.Drawing.Size(35, 13);
            this.lblPretparkNaam.TabIndex = 0;
            this.lblPretparkNaam.Text = "label1";
            // 
            // lbMijnLijst
            // 
            this.lbMijnLijst.FormattingEnabled = true;
            this.lbMijnLijst.Location = new System.Drawing.Point(15, 87);
            this.lbMijnLijst.Name = "lbMijnLijst";
            this.lbMijnLijst.Size = new System.Drawing.Size(165, 225);
            this.lbMijnLijst.TabIndex = 1;
            this.lbMijnLijst.SelectedIndexChanged += new System.EventHandler(this.lbMijnLijst_SelectedIndexChanged);
            // 
            // rbWerknemers
            // 
            this.rbWerknemers.AutoSize = true;
            this.rbWerknemers.Location = new System.Drawing.Point(20, 45);
            this.rbWerknemers.Name = "rbWerknemers";
            this.rbWerknemers.Size = new System.Drawing.Size(85, 17);
            this.rbWerknemers.TabIndex = 4;
            this.rbWerknemers.TabStop = true;
            this.rbWerknemers.Text = "Werknemers";
            this.rbWerknemers.UseVisualStyleBackColor = true;
            this.rbWerknemers.CheckedChanged += new System.EventHandler(this.rbWerknemers_CheckedChanged);
            // 
            // rbAttracties
            // 
            this.rbAttracties.AutoSize = true;
            this.rbAttracties.Location = new System.Drawing.Point(111, 45);
            this.rbAttracties.Name = "rbAttracties";
            this.rbAttracties.Size = new System.Drawing.Size(69, 17);
            this.rbAttracties.TabIndex = 5;
            this.rbAttracties.TabStop = true;
            this.rbAttracties.Text = "Attracties";
            this.rbAttracties.UseVisualStyleBackColor = true;
            this.rbAttracties.CheckedChanged += new System.EventHandler(this.rbAttracties_CheckedChanged);
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(186, 87);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(75, 23);
            this.btnVoegToe.TabIndex = 6;
            this.btnVoegToe.Text = "Voeg Toe";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(186, 116);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijder.TabIndex = 8;
            this.btnVerwijder.Text = "Verwijder";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // lblData1
            // 
            this.lblData1.AutoSize = true;
            this.lblData1.Location = new System.Drawing.Point(6, 16);
            this.lblData1.Name = "lblData1";
            this.lblData1.Size = new System.Drawing.Size(46, 13);
            this.lblData1.TabIndex = 9;
            this.lblData1.Text = "lblData1";
            // 
            // lblData2
            // 
            this.lblData2.AutoSize = true;
            this.lblData2.Location = new System.Drawing.Point(6, 29);
            this.lblData2.Name = "lblData2";
            this.lblData2.Size = new System.Drawing.Size(46, 13);
            this.lblData2.TabIndex = 10;
            this.lblData2.Text = "lblData2";
            // 
            // lblData3
            // 
            this.lblData3.AutoSize = true;
            this.lblData3.Location = new System.Drawing.Point(6, 42);
            this.lblData3.Name = "lblData3";
            this.lblData3.Size = new System.Drawing.Size(46, 13);
            this.lblData3.TabIndex = 11;
            this.lblData3.Text = "lblData3";
            // 
            // lblData4
            // 
            this.lblData4.AutoSize = true;
            this.lblData4.Location = new System.Drawing.Point(6, 55);
            this.lblData4.Name = "lblData4";
            this.lblData4.Size = new System.Drawing.Size(46, 13);
            this.lblData4.TabIndex = 12;
            this.lblData4.Text = "lblData4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblData1);
            this.groupBox1.Controls.Add(this.lblData4);
            this.groupBox1.Controls.Add(this.lblData2);
            this.groupBox1.Controls.Add(this.lblData3);
            this.groupBox1.Location = new System.Drawing.Point(12, 318);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 73);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gegevens";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 415);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.rbAttracties);
            this.Controls.Add(this.rbWerknemers);
            this.Controls.Add(this.lbMijnLijst);
            this.Controls.Add(this.lblPretparkNaam);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPretparkNaam;
        private System.Windows.Forms.ListBox lbMijnLijst;
        private System.Windows.Forms.RadioButton rbWerknemers;
        private System.Windows.Forms.RadioButton rbAttracties;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Label lblData1;
        private System.Windows.Forms.Label lblData2;
        private System.Windows.Forms.Label lblData3;
        private System.Windows.Forms.Label lblData4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

