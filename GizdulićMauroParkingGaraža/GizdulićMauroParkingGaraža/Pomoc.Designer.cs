namespace GizdulićMauroParkingGaraža
{
    partial class Pomoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pomoc));
            this.labelNaslov = new System.Windows.Forms.Label();
            this.labelTekst = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNaslov
            // 
            this.labelNaslov.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelNaslov.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNaslov.Location = new System.Drawing.Point(0, 0);
            this.labelNaslov.Name = "labelNaslov";
            this.labelNaslov.Size = new System.Drawing.Size(472, 53);
            this.labelNaslov.TabIndex = 0;
            this.labelNaslov.Text = "Pomoć";
            this.labelNaslov.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelTekst
            // 
            this.labelTekst.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTekst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTekst.Location = new System.Drawing.Point(0, 53);
            this.labelTekst.Name = "labelTekst";
            this.labelTekst.Size = new System.Drawing.Size(472, 185);
            this.labelTekst.TabIndex = 1;
            this.labelTekst.Text = resources.GetString("labelTekst.Text");
            this.labelTekst.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Pomoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 238);
            this.Controls.Add(this.labelTekst);
            this.Controls.Add(this.labelNaslov);
            this.MaximizeBox = false;
            this.Name = "Pomoc";
            this.Text = "Pomoc";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNaslov;
        private System.Windows.Forms.Label labelTekst;
    }
}