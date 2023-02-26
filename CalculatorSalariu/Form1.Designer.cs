namespace CalculatorSalariu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CalculatorLabel = new System.Windows.Forms.Label();
            this.textLabel_SBrut = new System.Windows.Forms.TextBox();
            this.CalculeazaButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label_DP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_Deducere = new System.Windows.Forms.Label();
            this.label_CAS = new System.Windows.Forms.Label();
            this.label_CASS = new System.Windows.Forms.Label();
            this.label_Impozit = new System.Windows.Forms.Label();
            this.label_SalariuNET = new System.Windows.Forms.Label();
            this.label_SNET = new System.Windows.Forms.Label();
            this.label_SBRUT = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox_impozit = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label_CAM_Angajator = new System.Windows.Forms.Label();
            this.label_CASS_Angajator = new System.Windows.Forms.Label();
            this.label_CAS_Angajator = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalculatorLabel
            // 
            this.CalculatorLabel.AutoSize = true;
            this.CalculatorLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalculatorLabel.Location = new System.Drawing.Point(37, 33);
            this.CalculatorLabel.Name = "CalculatorLabel";
            this.CalculatorLabel.Size = new System.Drawing.Size(114, 23);
            this.CalculatorLabel.TabIndex = 1;
            this.CalculatorLabel.Text = "Salariu BRUT";
            // 
            // textLabel_SBrut
            // 
            this.textLabel_SBrut.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textLabel_SBrut.ForeColor = System.Drawing.SystemColors.Desktop;
            this.textLabel_SBrut.Location = new System.Drawing.Point(171, 32);
            this.textLabel_SBrut.Name = "textLabel_SBrut";
            this.textLabel_SBrut.Size = new System.Drawing.Size(262, 25);
            this.textLabel_SBrut.TabIndex = 3;
            this.textLabel_SBrut.TabStop = false;
            this.textLabel_SBrut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SalariuTextBox_OnKeyPress);
            // 
            // CalculeazaButton
            // 
            this.CalculeazaButton.Location = new System.Drawing.Point(460, 30);
            this.CalculeazaButton.Name = "CalculeazaButton";
            this.CalculeazaButton.Size = new System.Drawing.Size(122, 29);
            this.CalculeazaButton.TabIndex = 4;
            this.CalculeazaButton.Text = "Calculeaza";
            this.CalculeazaButton.UseVisualStyleBackColor = true;
            this.CalculeazaButton.Click += new System.EventHandler(this.CalculeazaButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(49, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "ANGAJAT";
            // 
            // label_DP
            // 
            this.label_DP.AutoSize = true;
            this.label_DP.Location = new System.Drawing.Point(49, 167);
            this.label_DP.Name = "label_DP";
            this.label_DP.Size = new System.Drawing.Size(150, 20);
            this.label_DP.TabIndex = 6;
            this.label_DP.Text = "Deducerea personala";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(255, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contributia la Asigurari Sociale (CAS)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Contributia la Asigurari Sociale de Sanatate (CASS)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Impozit pe venit";
            // 
            // label_Deducere
            // 
            this.label_Deducere.AutoSize = true;
            this.label_Deducere.Location = new System.Drawing.Point(498, 167);
            this.label_Deducere.Name = "label_Deducere";
            this.label_Deducere.Size = new System.Drawing.Size(26, 20);
            this.label_Deducere.TabIndex = 10;
            this.label_Deducere.Text = ". . .";
            // 
            // label_CAS
            // 
            this.label_CAS.AutoSize = true;
            this.label_CAS.Location = new System.Drawing.Point(498, 198);
            this.label_CAS.Name = "label_CAS";
            this.label_CAS.Size = new System.Drawing.Size(26, 20);
            this.label_CAS.TabIndex = 11;
            this.label_CAS.Text = ". . .";
            // 
            // label_CASS
            // 
            this.label_CASS.AutoSize = true;
            this.label_CASS.Location = new System.Drawing.Point(498, 231);
            this.label_CASS.Name = "label_CASS";
            this.label_CASS.Size = new System.Drawing.Size(26, 20);
            this.label_CASS.TabIndex = 12;
            this.label_CASS.Text = ". . .";
            // 
            // label_Impozit
            // 
            this.label_Impozit.AutoSize = true;
            this.label_Impozit.Location = new System.Drawing.Point(498, 260);
            this.label_Impozit.Name = "label_Impozit";
            this.label_Impozit.Size = new System.Drawing.Size(26, 20);
            this.label_Impozit.TabIndex = 13;
            this.label_Impozit.Text = ". . .";
            // 
            // label_SalariuNET
            // 
            this.label_SalariuNET.AutoSize = true;
            this.label_SalariuNET.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_SalariuNET.Location = new System.Drawing.Point(34, 302);
            this.label_SalariuNET.Name = "label_SalariuNET";
            this.label_SalariuNET.Size = new System.Drawing.Size(102, 23);
            this.label_SalariuNET.TabIndex = 14;
            this.label_SalariuNET.Text = "Salariu NET";
            // 
            // label_SNET
            // 
            this.label_SNET.AutoSize = true;
            this.label_SNET.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_SNET.Location = new System.Drawing.Point(498, 302);
            this.label_SNET.Name = "label_SNET";
            this.label_SNET.Size = new System.Drawing.Size(35, 23);
            this.label_SNET.TabIndex = 15;
            this.label_SNET.Text = ". . .";
            // 
            // label_SBRUT
            // 
            this.label_SBRUT.AutoSize = true;
            this.label_SBRUT.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_SBRUT.ForeColor = System.Drawing.Color.LightCoral;
            this.label_SBRUT.Location = new System.Drawing.Point(224, 60);
            this.label_SBRUT.Name = "label_SBRUT";
            this.label_SBRUT.Size = new System.Drawing.Size(152, 19);
            this.label_SBRUT.TabIndex = 16;
            this.label_SBRUT.Text = "Introduceti salariul brut";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "Scutit impozit";
            // 
            // checkBox_impozit
            // 
            this.checkBox_impozit.AutoSize = true;
            this.checkBox_impozit.Location = new System.Drawing.Point(171, 82);
            this.checkBox_impozit.Name = "checkBox_impozit";
            this.checkBox_impozit.Size = new System.Drawing.Size(18, 17);
            this.checkBox_impozit.TabIndex = 19;
            this.checkBox_impozit.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(49, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "ANGAJATOR";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 377);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(309, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Contributie Asiguratorie pentru Munca (CAM)";
            // 
            // label_CAM_Angajator
            // 
            this.label_CAM_Angajator.AutoSize = true;
            this.label_CAM_Angajator.Location = new System.Drawing.Point(498, 377);
            this.label_CAM_Angajator.Name = "label_CAM_Angajator";
            this.label_CAM_Angajator.Size = new System.Drawing.Size(26, 20);
            this.label_CAM_Angajator.TabIndex = 27;
            this.label_CAM_Angajator.Text = ". . .";
            // 
            // label_CASS_Angajator
            // 
            this.label_CASS_Angajator.AutoSize = true;
            this.label_CASS_Angajator.Location = new System.Drawing.Point(497, 443);
            this.label_CASS_Angajator.Name = "label_CASS_Angajator";
            this.label_CASS_Angajator.Size = new System.Drawing.Size(26, 20);
            this.label_CASS_Angajator.TabIndex = 26;
            this.label_CASS_Angajator.Text = ". . .";
            // 
            // label_CAS_Angajator
            // 
            this.label_CAS_Angajator.AutoSize = true;
            this.label_CAS_Angajator.Location = new System.Drawing.Point(497, 410);
            this.label_CAS_Angajator.Name = "label_CAS_Angajator";
            this.label_CAS_Angajator.Size = new System.Drawing.Size(26, 20);
            this.label_CAS_Angajator.TabIndex = 25;
            this.label_CAS_Angajator.Text = ". . .";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(49, 443);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(346, 20);
            this.label11.TabIndex = 23;
            this.label11.Text = "Contributia la Asigurari Sociale de Sanatate (CASS)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 410);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(255, 20);
            this.label12.TabIndex = 22;
            this.label12.Text = "Contributia la Asigurari Sociale (CAS)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 522);
            this.Controls.Add(this.label_CAM_Angajator);
            this.Controls.Add(this.label_CASS_Angajator);
            this.Controls.Add(this.label_CAS_Angajator);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox_impozit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_SBRUT);
            this.Controls.Add(this.label_SNET);
            this.Controls.Add(this.label_SalariuNET);
            this.Controls.Add(this.label_Impozit);
            this.Controls.Add(this.label_CASS);
            this.Controls.Add(this.label_CAS);
            this.Controls.Add(this.label_Deducere);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_DP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CalculeazaButton);
            this.Controls.Add(this.textLabel_SBrut);
            this.Controls.Add(this.CalculatorLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(628, 569);
            this.MinimumSize = new System.Drawing.Size(628, 569);
            this.Name = "Form1";
            this.Text = "Calculator Salariu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label CalculatorLabel;
        private TextBox textLabel_SBrut;
        private Button CalculeazaButton;
        private Label label3;
        private Label label_DP;
        private Label label5;
        private Label label6;
        private Label label_Deducere;
        private Label label_CAS;
        private Label label_CASS;
        private Label label_Impozit;
        private Label label_SalariuNET;
        private Label label_SNET;
        private Label label_SBRUT;
        private Label label4;
        private CheckBox checkBox_impozit;
        private Label label1;
        private Label label9;
        private Label label_CAM_Angajator;
        private Label label_CASS_Angajator;
        private Label label_CAS_Angajator;
        private Label label11;
        private Label label12;
    }
}