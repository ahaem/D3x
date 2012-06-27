namespace Sample
{
    partial class Sample
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
            this.lstActors = new System.Windows.Forms.ListBox();
            this.lblActors = new System.Windows.Forms.Label();
            this.lstACDs = new System.Windows.Forms.ListBox();
            this.lblACDs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstActors
            // 
            this.lstActors.FormattingEnabled = true;
            this.lstActors.Location = new System.Drawing.Point(12, 25);
            this.lstActors.Name = "lstActors";
            this.lstActors.Size = new System.Drawing.Size(539, 82);
            this.lstActors.TabIndex = 0;
            // 
            // lblActors
            // 
            this.lblActors.AutoSize = true;
            this.lblActors.Location = new System.Drawing.Point(9, 9);
            this.lblActors.Name = "lblActors";
            this.lblActors.Size = new System.Drawing.Size(37, 13);
            this.lblActors.TabIndex = 1;
            this.lblActors.Text = "Actors";
            // 
            // lstACDs
            // 
            this.lstACDs.FormattingEnabled = true;
            this.lstACDs.Location = new System.Drawing.Point(12, 126);
            this.lstACDs.Name = "lstACDs";
            this.lstACDs.Size = new System.Drawing.Size(539, 82);
            this.lstACDs.TabIndex = 2;
            // 
            // lblACDs
            // 
            this.lblACDs.AutoSize = true;
            this.lblACDs.Location = new System.Drawing.Point(12, 110);
            this.lblACDs.Name = "lblACDs";
            this.lblACDs.Size = new System.Drawing.Size(34, 13);
            this.lblACDs.TabIndex = 3;
            this.lblACDs.Text = "ACDs";
            // 
            // Sample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 223);
            this.Controls.Add(this.lblACDs);
            this.Controls.Add(this.lstACDs);
            this.Controls.Add(this.lblActors);
            this.Controls.Add(this.lstActors);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Sample";
            this.Text = "D3x Sample";
            this.Load += new System.EventHandler(this.Sample_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstActors;
        private System.Windows.Forms.Label lblActors;
        private System.Windows.Forms.ListBox lstACDs;
        private System.Windows.Forms.Label lblACDs;
    }
}

