namespace Otopark_Otomasyonu
{
    partial class Abonesilform
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtaid = new System.Windows.Forms.TextBox();
            this.txtasfAd = new System.Windows.Forms.TextBox();
            this.txtasfPlaka = new System.Windows.Forms.TextBox();
            this.btnasfSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(79, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(12, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(48, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Plaka :";
            // 
            // txtaid
            // 
            this.txtaid.Enabled = false;
            this.txtaid.Location = new System.Drawing.Point(126, 63);
            this.txtaid.Name = "txtaid";
            this.txtaid.Size = new System.Drawing.Size(132, 20);
            this.txtaid.TabIndex = 3;
            // 
            // txtasfAd
            // 
            this.txtasfAd.Enabled = false;
            this.txtasfAd.Location = new System.Drawing.Point(126, 105);
            this.txtasfAd.Name = "txtasfAd";
            this.txtasfAd.Size = new System.Drawing.Size(132, 20);
            this.txtasfAd.TabIndex = 4;
            // 
            // txtasfPlaka
            // 
            this.txtasfPlaka.Enabled = false;
            this.txtasfPlaka.Location = new System.Drawing.Point(126, 145);
            this.txtasfPlaka.Name = "txtasfPlaka";
            this.txtasfPlaka.Size = new System.Drawing.Size(132, 20);
            this.txtasfPlaka.TabIndex = 5;
            // 
            // btnasfSil
            // 
            this.btnasfSil.Location = new System.Drawing.Point(83, 186);
            this.btnasfSil.Name = "btnasfSil";
            this.btnasfSil.Size = new System.Drawing.Size(105, 39);
            this.btnasfSil.TabIndex = 6;
            this.btnasfSil.Text = "Sil";
            this.btnasfSil.UseVisualStyleBackColor = true;
            this.btnasfSil.Click += new System.EventHandler(this.btnasfSil_Click);
            // 
            // Abonesilform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnasfSil);
            this.Controls.Add(this.txtasfPlaka);
            this.Controls.Add(this.txtasfAd);
            this.Controls.Add(this.txtaid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Abonesilform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Abonesilform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtaid;
        public System.Windows.Forms.TextBox txtasfAd;
        public System.Windows.Forms.TextBox txtasfPlaka;
        private System.Windows.Forms.Button btnasfSil;
    }
}