namespace GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.namaTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.noIndukTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lakiRbn = new System.Windows.Forms.RadioButton();
            this.perempuanRbn = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.agamaCmb = new System.Windows.Forms.ComboBox();
            this.alamatTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kotaLsb = new System.Windows.Forms.ListBox();
            this.telpTxt = new System.Windows.Forms.TextBox();
            this.tampilBtn = new System.Windows.Forms.Button();
            this.tambahBtn = new System.Windows.Forms.Button();
            this.keluarBtn = new System.Windows.Forms.Button();
            this.jurusanCmb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.jenjangCmb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(295, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entry Data Mahasiswa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Mahasiswa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // namaTxt
            // 
            this.namaTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaTxt.Location = new System.Drawing.Point(339, 117);
            this.namaTxt.Margin = new System.Windows.Forms.Padding(2);
            this.namaTxt.Name = "namaTxt";
            this.namaTxt.Size = new System.Drawing.Size(242, 26);
            this.namaTxt.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Jenis Kelamin";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // noIndukTxt
            // 
            this.noIndukTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noIndukTxt.Location = new System.Drawing.Point(339, 85);
            this.noIndukTxt.Margin = new System.Windows.Forms.Padding(2);
            this.noIndukTxt.Name = "noIndukTxt";
            this.noIndukTxt.Size = new System.Drawing.Size(242, 26);
            this.noIndukTxt.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(175, 87);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "No. Induk";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lakiRbn
            // 
            this.lakiRbn.AutoSize = true;
            this.lakiRbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lakiRbn.Location = new System.Drawing.Point(339, 150);
            this.lakiRbn.Margin = new System.Windows.Forms.Padding(2);
            this.lakiRbn.Name = "lakiRbn";
            this.lakiRbn.Size = new System.Drawing.Size(80, 22);
            this.lakiRbn.TabIndex = 7;
            this.lakiRbn.TabStop = true;
            this.lakiRbn.Text = "Laki-laki";
            this.lakiRbn.UseVisualStyleBackColor = true;
            // 
            // perempuanRbn
            // 
            this.perempuanRbn.AutoSize = true;
            this.perempuanRbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perempuanRbn.Location = new System.Drawing.Point(432, 150);
            this.perempuanRbn.Margin = new System.Windows.Forms.Padding(2);
            this.perempuanRbn.Name = "perempuanRbn";
            this.perempuanRbn.Size = new System.Drawing.Size(102, 22);
            this.perempuanRbn.TabIndex = 8;
            this.perempuanRbn.TabStop = true;
            this.perempuanRbn.Text = "Perempuan";
            this.perempuanRbn.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Agama";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // agamaCmb
            // 
            this.agamaCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agamaCmb.FormattingEnabled = true;
            this.agamaCmb.Location = new System.Drawing.Point(339, 179);
            this.agamaCmb.Margin = new System.Windows.Forms.Padding(2);
            this.agamaCmb.Name = "agamaCmb";
            this.agamaCmb.Size = new System.Drawing.Size(242, 28);
            this.agamaCmb.TabIndex = 10;
            this.agamaCmb.SelectedIndexChanged += new System.EventHandler(this.agamaCmb_SelectedIndexChanged);
            // 
            // alamatTxt
            // 
            this.alamatTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamatTxt.Location = new System.Drawing.Point(339, 285);
            this.alamatTxt.Margin = new System.Windows.Forms.Padding(2);
            this.alamatTxt.Multiline = true;
            this.alamatTxt.Name = "alamatTxt";
            this.alamatTxt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.alamatTxt.Size = new System.Drawing.Size(355, 87);
            this.alamatTxt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(175, 285);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Alamat";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(175, 382);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Kota - Telepon";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // kotaLsb
            // 
            this.kotaLsb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kotaLsb.FormattingEnabled = true;
            this.kotaLsb.ItemHeight = 18;
            this.kotaLsb.Items.AddRange(new object[] {
            "Cilacap",
            "Tangerang",
            "Bandung",
            "Jakarta Selatan",
            "Jakarta Pusat"});
            this.kotaLsb.Location = new System.Drawing.Point(342, 382);
            this.kotaLsb.Margin = new System.Windows.Forms.Padding(2);
            this.kotaLsb.Name = "kotaLsb";
            this.kotaLsb.Size = new System.Drawing.Size(185, 112);
            this.kotaLsb.TabIndex = 14;
            // 
            // telpTxt
            // 
            this.telpTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telpTxt.Location = new System.Drawing.Point(533, 382);
            this.telpTxt.Margin = new System.Windows.Forms.Padding(2);
            this.telpTxt.Name = "telpTxt";
            this.telpTxt.Size = new System.Drawing.Size(162, 26);
            this.telpTxt.TabIndex = 15;
            // 
            // tampilBtn
            // 
            this.tampilBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.tampilBtn.FlatAppearance.BorderSize = 0;
            this.tampilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tampilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tampilBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tampilBtn.Location = new System.Drawing.Point(533, 416);
            this.tampilBtn.Margin = new System.Windows.Forms.Padding(2);
            this.tampilBtn.Name = "tampilBtn";
            this.tampilBtn.Size = new System.Drawing.Size(79, 35);
            this.tampilBtn.TabIndex = 16;
            this.tampilBtn.Text = "Tampil";
            this.tampilBtn.UseVisualStyleBackColor = false;
            this.tampilBtn.Click += new System.EventHandler(this.tampilBtn_Click);
            // 
            // tambahBtn
            // 
            this.tambahBtn.BackColor = System.Drawing.Color.ForestGreen;
            this.tambahBtn.FlatAppearance.BorderSize = 0;
            this.tambahBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tambahBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambahBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tambahBtn.Location = new System.Drawing.Point(615, 416);
            this.tambahBtn.Margin = new System.Windows.Forms.Padding(2);
            this.tambahBtn.Name = "tambahBtn";
            this.tambahBtn.Size = new System.Drawing.Size(78, 35);
            this.tambahBtn.TabIndex = 17;
            this.tambahBtn.Text = "Tambah";
            this.tambahBtn.UseVisualStyleBackColor = false;
            // 
            // keluarBtn
            // 
            this.keluarBtn.BackColor = System.Drawing.Color.Red;
            this.keluarBtn.FlatAppearance.BorderSize = 0;
            this.keluarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.keluarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keluarBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.keluarBtn.Location = new System.Drawing.Point(533, 459);
            this.keluarBtn.Margin = new System.Windows.Forms.Padding(2);
            this.keluarBtn.Name = "keluarBtn";
            this.keluarBtn.Size = new System.Drawing.Size(161, 35);
            this.keluarBtn.TabIndex = 18;
            this.keluarBtn.Text = "Keluar";
            this.keluarBtn.UseVisualStyleBackColor = false;
            this.keluarBtn.Click += new System.EventHandler(this.keluarBtn_Click);
            // 
            // jurusanCmb
            // 
            this.jurusanCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jurusanCmb.FormattingEnabled = true;
            this.jurusanCmb.Items.AddRange(new object[] {
            "Teknik Informatika",
            "Teknik Mesin",
            "Teknik Elektro"});
            this.jurusanCmb.Location = new System.Drawing.Point(339, 214);
            this.jurusanCmb.Margin = new System.Windows.Forms.Padding(2);
            this.jurusanCmb.Name = "jurusanCmb";
            this.jurusanCmb.Size = new System.Drawing.Size(242, 28);
            this.jurusanCmb.TabIndex = 20;
            this.jurusanCmb.SelectedIndexChanged += new System.EventHandler(this.jurusanCmb_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(175, 216);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Jurusan";
            // 
            // jenjangCmb
            // 
            this.jenjangCmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jenjangCmb.FormattingEnabled = true;
            this.jenjangCmb.Items.AddRange(new object[] {
            "D3",
            "D4"});
            this.jenjangCmb.Location = new System.Drawing.Point(339, 249);
            this.jenjangCmb.Margin = new System.Windows.Forms.Padding(2);
            this.jenjangCmb.Name = "jenjangCmb";
            this.jenjangCmb.Size = new System.Drawing.Size(242, 28);
            this.jenjangCmb.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(175, 251);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Jenjang Studi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 523);
            this.Controls.Add(this.jenjangCmb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.jurusanCmb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.keluarBtn);
            this.Controls.Add(this.tambahBtn);
            this.Controls.Add(this.tampilBtn);
            this.Controls.Add(this.telpTxt);
            this.Controls.Add(this.kotaLsb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.alamatTxt);
            this.Controls.Add(this.agamaCmb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.perempuanRbn);
            this.Controls.Add(this.lakiRbn);
            this.Controls.Add(this.noIndukTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.namaTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DATA MAHASISWA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox namaTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox noIndukTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton lakiRbn;
        private System.Windows.Forms.RadioButton perempuanRbn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox agamaCmb;
        private System.Windows.Forms.TextBox alamatTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox kotaLsb;
        private System.Windows.Forms.TextBox telpTxt;
        private System.Windows.Forms.Button tampilBtn;
        private System.Windows.Forms.Button tambahBtn;
        private System.Windows.Forms.Button keluarBtn;
        private System.Windows.Forms.ComboBox jurusanCmb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox jenjangCmb;
        private System.Windows.Forms.Label label9;
    }
}

