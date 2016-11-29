namespace Echelon
{
    partial class UI_Move
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
            this.FromMatrixPanel = new System.Windows.Forms.Panel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ToMatrixPanel = new System.Windows.Forms.Panel();
            this.DetailsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DetailsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FromMatrixPanel
            // 
            this.FromMatrixPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.FromMatrixPanel.Location = new System.Drawing.Point(0, 0);
            this.FromMatrixPanel.Name = "FromMatrixPanel";
            this.FromMatrixPanel.Size = new System.Drawing.Size(200, 200);
            this.FromMatrixPanel.TabIndex = 0;
            // 
            // ToMatrixPanel
            // 
            this.ToMatrixPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ToMatrixPanel.Location = new System.Drawing.Point(510, 0);
            this.ToMatrixPanel.Name = "ToMatrixPanel";
            this.ToMatrixPanel.Size = new System.Drawing.Size(200, 200);
            this.ToMatrixPanel.TabIndex = 1;
            // 
            // DetailsPanel
            // 
            this.DetailsPanel.Controls.Add(this.label1);
            this.DetailsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DetailsPanel.Location = new System.Drawing.Point(200, 0);
            this.DetailsPanel.Name = "DetailsPanel";
            this.DetailsPanel.Size = new System.Drawing.Size(310, 200);
            this.DetailsPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1\r\nasd";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_Move
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DetailsPanel);
            this.Controls.Add(this.ToMatrixPanel);
            this.Controls.Add(this.FromMatrixPanel);
            this.MinimumSize = new System.Drawing.Size(500, 200);
            this.Name = "UI_Move";
            this.Size = new System.Drawing.Size(710, 200);
            this.DetailsPanel.ResumeLayout(false);
            this.DetailsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FromMatrixPanel;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel ToMatrixPanel;
        private System.Windows.Forms.Panel DetailsPanel;
        private System.Windows.Forms.Label label1;
    }
}
