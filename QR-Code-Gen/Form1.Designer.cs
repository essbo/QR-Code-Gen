namespace QR_Code_Gen
{
    partial class QRGen
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbURL = new System.Windows.Forms.Label();
            this.txturl = new System.Windows.Forms.TextBox();
            this.btnQRGen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(204, 190);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Location = new System.Drawing.Point(19, 208);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(59, 13);
            this.lbURL.TabIndex = 1;
            this.lbURL.Text = "Video URL";
            // 
            // txturl
            // 
            this.txturl.Location = new System.Drawing.Point(22, 224);
            this.txturl.Name = "txturl";
            this.txturl.Size = new System.Drawing.Size(204, 20);
            this.txturl.TabIndex = 2;
            this.txturl.TextChanged += new System.EventHandler(this.URLBOX_TextChanged);
            // 
            // btnQRGen
            // 
            this.btnQRGen.Location = new System.Drawing.Point(62, 273);
            this.btnQRGen.Name = "btnQRGen";
            this.btnQRGen.Size = new System.Drawing.Size(121, 37);
            this.btnQRGen.TabIndex = 3;
            this.btnQRGen.Text = "QR-Code generieren";
            this.btnQRGen.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 318);
            this.Controls.Add(this.btnQRGen);
            this.Controls.Add(this.txturl);
            this.Controls.Add(this.lbURL);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.TextBox txturl;
        private System.Windows.Forms.Button btnQRGen;
    }
}

