namespace Otopark_Otomasyonu
{
    partial class Aracgiris
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPlaka = new System.Windows.Forms.TextBox();
            this.cmbMarka = new System.Windows.Forms.ComboBox();
            this.cmbModel = new System.Windows.Forms.ComboBox();
            this.cmbRenk = new System.Windows.Forms.ComboBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lblTarih = new System.Windows.Forms.Label();
            this.tmrTarih = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(11, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç Plakası :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(72, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(73, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(83, 235);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Renk :";
            // 
            // txtPlaka
            // 
            this.txtPlaka.ForeColor = System.Drawing.Color.Black;
            this.txtPlaka.Location = new System.Drawing.Point(163, 102);
            this.txtPlaka.Name = "txtPlaka";
            this.txtPlaka.Size = new System.Drawing.Size(133, 20);
            this.txtPlaka.TabIndex = 4;
            // 
            // cmbMarka
            // 
            this.cmbMarka.FormattingEnabled = true;
            this.cmbMarka.Location = new System.Drawing.Point(163, 147);
            this.cmbMarka.Name = "cmbMarka";
            this.cmbMarka.Size = new System.Drawing.Size(133, 21);
            this.cmbMarka.TabIndex = 5;
            this.cmbMarka.Text = "Seçiniz";
            this.cmbMarka.SelectedIndexChanged += new System.EventHandler(this.cmbMarka_SelectedIndexChanged);
            this.cmbMarka.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbMarka_MouseClick);
            // 
            // cmbModel
            // 
            this.cmbModel.FormattingEnabled = true;
            this.cmbModel.Location = new System.Drawing.Point(163, 193);
            this.cmbModel.Name = "cmbModel";
            this.cmbModel.Size = new System.Drawing.Size(133, 21);
            this.cmbModel.TabIndex = 6;
            this.cmbModel.Text = "Seçiniz";
            this.cmbModel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbModel_MouseClick);
            // 
            // cmbRenk
            // 
            this.cmbRenk.FormattingEnabled = true;
            this.cmbRenk.Items.AddRange(new object[] {
            "Bej",
            "Beyaz",
            "Bordo",
            "Füme",
            "Gri",
            "Gümüş Gri",
            "Kahverengi",
            "Kırmızı",
            "Lacivert",
            "Mavi",
            "Mor",
            "Pembe",
            "Sarı",
            "Siyah",
            "Şampanya",
            "Turkuaz",
            "Turuncu",
            "Yeşil"});
            this.cmbRenk.Location = new System.Drawing.Point(163, 236);
            this.cmbRenk.Name = "cmbRenk";
            this.cmbRenk.Size = new System.Drawing.Size(133, 21);
            this.cmbRenk.TabIndex = 7;
            this.cmbRenk.Text = "Seçiniz";
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Location = new System.Drawing.Point(127, 282);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(124, 61);
            this.btnGiris.TabIndex = 8;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblTarih.Location = new System.Drawing.Point(71, 42);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(70, 25);
            this.lblTarih.TabIndex = 9;
            this.lblTarih.Text = "label5";
            // 
            // tmrTarih
            // 
            this.tmrTarih.Tick += new System.EventHandler(this.tmrTarih_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(34, 23);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.Visible = false;
            // 
            // Aracgiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(349, 392);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.cmbRenk);
            this.Controls.Add(this.cmbModel);
            this.Controls.Add(this.cmbMarka);
            this.Controls.Add(this.txtPlaka);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Aracgiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aracgiris";
            this.Activated += new System.EventHandler(this.Aracgiris_Activated);
            this.Load += new System.EventHandler(this.Aracgiris_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbRenk;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Timer tmrTarih;
        public System.Windows.Forms.ComboBox cmbMarka;
        public System.Windows.Forms.ComboBox cmbModel;
        private System.Windows.Forms.TextBox txtPlaka;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}