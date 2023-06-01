namespace KNN_Diabet_Tahmin
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
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGlucose = new System.Windows.Forms.TextBox();
            this.txtBloodP = new System.Windows.Forms.TextBox();
            this.txtSkinT = new System.Windows.Forms.TextBox();
            this.txtInsulin = new System.Windows.Forms.TextBox();
            this.txtDiabetPF = new System.Windows.Forms.TextBox();
            this.txtBMI = new System.Windows.Forms.TextBox();
            this.txtPregnancies = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 234);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Öğren";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 34);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(333, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kişi Bİlgileri";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(113, 106);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(164, 23);
            this.txtAge.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Yaşınız:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(113, 71);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(164, 23);
            this.txtSoyad.TabIndex = 3;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(116, 38);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(164, 23);
            this.txtAd.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadınız:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adınız:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtGlucose);
            this.groupBox2.Controls.Add(this.txtBloodP);
            this.groupBox2.Controls.Add(this.txtSkinT);
            this.groupBox2.Controls.Add(this.txtInsulin);
            this.groupBox2.Controls.Add(this.txtDiabetPF);
            this.groupBox2.Controls.Add(this.txtBMI);
            this.groupBox2.Controls.Add(this.txtPregnancies);
            this.groupBox2.Location = new System.Drawing.Point(393, 34);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1038, 320);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Veriler";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(490, 261);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(377, 16);
            this.label12.TabIndex = 16;
            this.label12.Text = "DiabetSoya Ağacı: Ailedeki Şeker Hastalığı Oranı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(222, 261);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(191, 16);
            this.label11.TabIndex = 15;
            this.label11.Text = "BMI: Vücut Kitle İndeksi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(698, 139);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 16);
            this.label10.TabIndex = 14;
            this.label10.Text = "Diabet Soy Ağacı:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(836, 38);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 16);
            this.label9.TabIndex = 13;
            this.label9.Text = "Cilt Kalınlığı:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(253, 139);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "İnsulin:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(476, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "BMI";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(620, 38);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Tansiyon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Glikoz:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Doğum Sayısı:";
            // 
            // txtGlucose
            // 
            this.txtGlucose.Location = new System.Drawing.Point(369, 68);
            this.txtGlucose.Margin = new System.Windows.Forms.Padding(4);
            this.txtGlucose.Name = "txtGlucose";
            this.txtGlucose.Size = new System.Drawing.Size(164, 23);
            this.txtGlucose.TabIndex = 7;
            // 
            // txtBloodP
            // 
            this.txtBloodP.Location = new System.Drawing.Point(584, 68);
            this.txtBloodP.Margin = new System.Windows.Forms.Padding(4);
            this.txtBloodP.Name = "txtBloodP";
            this.txtBloodP.Size = new System.Drawing.Size(164, 23);
            this.txtBloodP.TabIndex = 6;
            // 
            // txtSkinT
            // 
            this.txtSkinT.Location = new System.Drawing.Point(816, 68);
            this.txtSkinT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSkinT.Name = "txtSkinT";
            this.txtSkinT.Size = new System.Drawing.Size(164, 23);
            this.txtSkinT.TabIndex = 5;
            // 
            // txtInsulin
            // 
            this.txtInsulin.Location = new System.Drawing.Point(258, 170);
            this.txtInsulin.Margin = new System.Windows.Forms.Padding(4);
            this.txtInsulin.Name = "txtInsulin";
            this.txtInsulin.Size = new System.Drawing.Size(164, 23);
            this.txtInsulin.TabIndex = 4;
            // 
            // txtDiabetPF
            // 
            this.txtDiabetPF.Location = new System.Drawing.Point(703, 170);
            this.txtDiabetPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtDiabetPF.Name = "txtDiabetPF";
            this.txtDiabetPF.Size = new System.Drawing.Size(164, 23);
            this.txtDiabetPF.TabIndex = 2;
            // 
            // txtBMI
            // 
            this.txtBMI.Location = new System.Drawing.Point(477, 170);
            this.txtBMI.Margin = new System.Windows.Forms.Padding(4);
            this.txtBMI.Name = "txtBMI";
            this.txtBMI.Size = new System.Drawing.Size(164, 23);
            this.txtBMI.TabIndex = 1;
            this.txtBMI.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtPregnancies
            // 
            this.txtPregnancies.Location = new System.Drawing.Point(140, 68);
            this.txtPregnancies.Margin = new System.Windows.Forms.Padding(4);
            this.txtPregnancies.Name = "txtPregnancies";
            this.txtPregnancies.Size = new System.Drawing.Size(164, 23);
            this.txtPregnancies.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(152, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 24);
            this.button2.TabIndex = 3;
            this.button2.Text = "Kayıtlar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(1449, 389);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGlucose;
        private System.Windows.Forms.TextBox txtBloodP;
        private System.Windows.Forms.TextBox txtSkinT;
        private System.Windows.Forms.TextBox txtInsulin;
        private System.Windows.Forms.TextBox txtDiabetPF;
        private System.Windows.Forms.TextBox txtBMI;
        private System.Windows.Forms.TextBox txtPregnancies;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}

