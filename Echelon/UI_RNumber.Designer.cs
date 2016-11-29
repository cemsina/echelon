namespace Echelon
{
    partial class UI_RNumber
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DivideLine = new System.Windows.Forms.PictureBox();
            this.Label_Numarator = new System.Windows.Forms.Label();
            this.Label_Denominator = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DivideLine)).BeginInit();
            this.SuspendLayout();
            // 
            // DivideLine
            // 
            this.DivideLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DivideLine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DivideLine.Location = new System.Drawing.Point(3, 47);
            this.DivideLine.Margin = new System.Windows.Forms.Padding(0);
            this.DivideLine.Name = "DivideLine";
            this.DivideLine.Size = new System.Drawing.Size(100, 2);
            this.DivideLine.TabIndex = 0;
            this.DivideLine.TabStop = false;
            // 
            // Label_Numarator
            // 
            this.Label_Numarator.AutoSize = true;
            this.Label_Numarator.Location = new System.Drawing.Point(37, 7);
            this.Label_Numarator.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Numarator.Name = "Label_Numarator";
            this.Label_Numarator.Size = new System.Drawing.Size(35, 13);
            this.Label_Numarator.TabIndex = 1;
            this.Label_Numarator.Text = "label1";
            this.Label_Numarator.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Label_Denominator
            // 
            this.Label_Denominator.AutoSize = true;
            this.Label_Denominator.Location = new System.Drawing.Point(64, 31);
            this.Label_Denominator.Margin = new System.Windows.Forms.Padding(0);
            this.Label_Denominator.Name = "Label_Denominator";
            this.Label_Denominator.Size = new System.Drawing.Size(35, 13);
            this.Label_Denominator.TabIndex = 2;
            this.Label_Denominator.Text = "label2";
            this.Label_Denominator.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // UI_RNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Label_Denominator);
            this.Controls.Add(this.Label_Numarator);
            this.Controls.Add(this.DivideLine);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UI_RNumber";
            this.Size = new System.Drawing.Size(125, 106);
            this.SizeChanged += new System.EventHandler(this.UI_RNumber_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.DivideLine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DivideLine;
        private System.Windows.Forms.Label Label_Numarator;
        private System.Windows.Forms.Label Label_Denominator;
    }
}
