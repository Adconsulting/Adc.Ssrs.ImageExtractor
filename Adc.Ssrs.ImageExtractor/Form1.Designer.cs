namespace Adc.Ssrs.ImageExtractor
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
            this.txtRdlfile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdRdlFile = new System.Windows.Forms.OpenFileDialog();
            this.btnRdl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDestination = new System.Windows.Forms.TextBox();
            this.btnDest = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.fbdDestination = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // txtRdlfile
            // 
            this.txtRdlfile.Location = new System.Drawing.Point(106, 13);
            this.txtRdlfile.Name = "txtRdlfile";
            this.txtRdlfile.Size = new System.Drawing.Size(391, 20);
            this.txtRdlfile.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rdl file";
            // 
            // ofdRdlFile
            // 
            this.ofdRdlFile.FileName = "openFileDialog1";
            // 
            // btnRdl
            // 
            this.btnRdl.Location = new System.Drawing.Point(503, 10);
            this.btnRdl.Name = "btnRdl";
            this.btnRdl.Size = new System.Drawing.Size(28, 23);
            this.btnRdl.TabIndex = 2;
            this.btnRdl.Text = "...";
            this.btnRdl.UseVisualStyleBackColor = true;
            this.btnRdl.Click += new System.EventHandler(this.btnRdl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Destination folder";
            // 
            // txtDestination
            // 
            this.txtDestination.Location = new System.Drawing.Point(106, 47);
            this.txtDestination.Name = "txtDestination";
            this.txtDestination.Size = new System.Drawing.Size(391, 20);
            this.txtDestination.TabIndex = 4;
            // 
            // btnDest
            // 
            this.btnDest.Location = new System.Drawing.Point(503, 45);
            this.btnDest.Name = "btnDest";
            this.btnDest.Size = new System.Drawing.Size(28, 23);
            this.btnDest.TabIndex = 5;
            this.btnDest.Text = "...";
            this.btnDest.UseVisualStyleBackColor = true;
            this.btnDest.Click += new System.EventHandler(this.btnDest_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(456, 74);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 6;
            this.btnExtract.Text = "Extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 107);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.btnDest);
            this.Controls.Add(this.txtDestination);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnRdl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRdlfile);
            this.Name = "Form1";
            this.Text = "RDL Image extractor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRdlfile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofdRdlFile;
        private System.Windows.Forms.Button btnRdl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDestination;
        private System.Windows.Forms.Button btnDest;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.FolderBrowserDialog fbdDestination;
    }
}

