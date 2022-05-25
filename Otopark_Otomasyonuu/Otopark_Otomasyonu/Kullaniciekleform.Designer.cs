namespace Otopark_Otomasyonu
{
    partial class Kullaniciekleform
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
            this.txtekKadi = new System.Windows.Forms.TextBox();
            this.txtekSifre = new System.Windows.Forms.TextBox();
            this.btnekEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre :";
            // 
            // txtekKadi
            // 
            this.txtekKadi.Location = new System.Drawing.Point(107, 50);
            this.txtekKadi.Name = "txtekKadi";
            this.txtekKadi.Size = new System.Drawing.Size(100, 20);
            this.txtekKadi.TabIndex = 2;
            // 
            // txtekSifre
            // 
            this.txtekSifre.Location = new System.Drawing.Point(107, 93);
            this.txtekSifre.Name = "txtekSifre";
            this.txtekSifre.PasswordChar = '*';
            this.txtekSifre.Size = new System.Drawing.Size(100, 20);
            this.txtekSifre.TabIndex = 3;
            // 
            // btnekEkle
            // 
            this.btnekEkle.Location = new System.Drawing.Point(93, 148);
            this.btnekEkle.Name = "btnekEkle";
            this.btnekEkle.Size = new System.Drawing.Size(94, 42);
            this.btnekEkle.TabIndex = 4;
            this.btnekEkle.Text = "Ekle";
            this.btnekEkle.UseVisualStyleBackColor = true;
            this.btnekEkle.Click += new System.EventHandler(this.btnekEkle_Click);
            // 
            // Kullaniciekleform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(278, 221);
            this.Controls.Add(this.btnekEkle);
            this.Controls.Add(this.txtekSifre);
            this.Controls.Add(this.txtekKadi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Kullaniciekleform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullaniciekleform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnekEkle;
        public System.Windows.Forms.TextBox txtekKadi;
        public System.Windows.Forms.TextBox txtekSifre;
    }
}