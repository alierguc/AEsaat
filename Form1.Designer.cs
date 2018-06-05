namespace AEClock
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
            this.components = new System.ComponentModel.Container();
            this.aesaat1 = new Æsaat.aesaat();
            this.SuspendLayout();
            // 
            // aesaat1
            // 
            this.aesaat1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.aesaat1.BackColor = System.Drawing.Color.Black;
            this.aesaat1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.aesaat1.Location = new System.Drawing.Point(12, 12);
            this.aesaat1.Name = "aesaat1";
            this.aesaat1.Size = new System.Drawing.Size(262, 97);
            this.aesaat1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(488, 311);
            this.Controls.Add(this.aesaat1);
            this.Name = "Form1";
            this.Text = "Æ Saat";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Æsaat.aesaat aesaat1;
    }
}

