namespace Steganography
{
    partial class Steganography
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
            this.pbBaseImage = new System.Windows.Forms.PictureBox();
            this.pbHideImage = new System.Windows.Forms.PictureBox();
            this.btnOpenBaseImage = new System.Windows.Forms.Button();
            this.btnOpenHideImage = new System.Windows.Forms.Button();
            this.btnHideImage = new System.Windows.Forms.Button();
            this.btnRecoverImage = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBaseImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHideImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBaseImage
            // 
            this.pbBaseImage.BackColor = System.Drawing.SystemColors.GrayText;
            this.pbBaseImage.Location = new System.Drawing.Point(12, 37);
            this.pbBaseImage.Name = "pbBaseImage";
            this.pbBaseImage.Size = new System.Drawing.Size(334, 317);
            this.pbBaseImage.TabIndex = 0;
            this.pbBaseImage.TabStop = false;
            // 
            // pbHideImage
            // 
            this.pbHideImage.BackColor = System.Drawing.SystemColors.GrayText;
            this.pbHideImage.Location = new System.Drawing.Point(397, 37);
            this.pbHideImage.Name = "pbHideImage";
            this.pbHideImage.Size = new System.Drawing.Size(338, 317);
            this.pbHideImage.TabIndex = 1;
            this.pbHideImage.TabStop = false;
            // 
            // btnOpenBaseImage
            // 
            this.btnOpenBaseImage.Location = new System.Drawing.Point(12, 360);
            this.btnOpenBaseImage.Name = "btnOpenBaseImage";
            this.btnOpenBaseImage.Size = new System.Drawing.Size(75, 23);
            this.btnOpenBaseImage.TabIndex = 2;
            this.btnOpenBaseImage.Text = "Open File";
            this.btnOpenBaseImage.UseVisualStyleBackColor = true;
            this.btnOpenBaseImage.Click += new System.EventHandler(this.btnOpenBaseImage_Click);
            // 
            // btnOpenHideImage
            // 
            this.btnOpenHideImage.Location = new System.Drawing.Point(397, 360);
            this.btnOpenHideImage.Name = "btnOpenHideImage";
            this.btnOpenHideImage.Size = new System.Drawing.Size(75, 23);
            this.btnOpenHideImage.TabIndex = 3;
            this.btnOpenHideImage.Text = "Open File";
            this.btnOpenHideImage.UseVisualStyleBackColor = true;
            this.btnOpenHideImage.Click += new System.EventHandler(this.btnOpenHideImage_Click);
            // 
            // btnHideImage
            // 
            this.btnHideImage.Location = new System.Drawing.Point(397, 389);
            this.btnHideImage.Name = "btnHideImage";
            this.btnHideImage.Size = new System.Drawing.Size(75, 23);
            this.btnHideImage.TabIndex = 4;
            this.btnHideImage.Text = "Hide Image";
            this.btnHideImage.UseVisualStyleBackColor = true;
            this.btnHideImage.Click += new System.EventHandler(this.btnHideImage_Click);
            // 
            // btnRecoverImage
            // 
            this.btnRecoverImage.Location = new System.Drawing.Point(12, 389);
            this.btnRecoverImage.Name = "btnRecoverImage";
            this.btnRecoverImage.Size = new System.Drawing.Size(118, 23);
            this.btnRecoverImage.TabIndex = 5;
            this.btnRecoverImage.Text = "Recover Image";
            this.btnRecoverImage.UseVisualStyleBackColor = true;
            this.btnRecoverImage.Click += new System.EventHandler(this.btnRecoverImage_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Base Image";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Image to hide";
            // 
            // Steganography
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(747, 422);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRecoverImage);
            this.Controls.Add(this.btnHideImage);
            this.Controls.Add(this.btnOpenHideImage);
            this.Controls.Add(this.btnOpenBaseImage);
            this.Controls.Add(this.pbHideImage);
            this.Controls.Add(this.pbBaseImage);
            this.Name = "Steganography";
            this.Text = "Steganography";
            ((System.ComponentModel.ISupportInitialize)(this.pbBaseImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHideImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBaseImage;
        private System.Windows.Forms.PictureBox pbHideImage;
        private System.Windows.Forms.Button btnOpenBaseImage;
        private System.Windows.Forms.Button btnOpenHideImage;
        private System.Windows.Forms.Button btnHideImage;
        private System.Windows.Forms.Button btnRecoverImage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

