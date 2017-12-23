namespace SantaHelper
{
    partial class ResultForm
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
            this.resultTitle = new System.Windows.Forms.Label();
            this.resultCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.loader = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loader)).BeginInit();
            this.SuspendLayout();
            // 
            // resultTitle
            // 
            this.resultTitle.AutoSize = true;
            this.resultTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold);
            this.resultTitle.Location = new System.Drawing.Point(90, 382);
            this.resultTitle.Name = "resultTitle";
            this.resultTitle.Size = new System.Drawing.Size(513, 28);
            this.resultTitle.TabIndex = 1;
            this.resultTitle.Text = "Yeey! You helped Santa to give gifts to kids";
            // 
            // resultCheckedListBox
            // 
            this.resultCheckedListBox.BackColor = System.Drawing.Color.Cornsilk;
            this.resultCheckedListBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultCheckedListBox.FormattingEnabled = true;
            this.resultCheckedListBox.Location = new System.Drawing.Point(90, 434);
            this.resultCheckedListBox.Name = "resultCheckedListBox";
            this.resultCheckedListBox.Size = new System.Drawing.Size(513, 172);
            this.resultCheckedListBox.TabIndex = 2;
            // 
            // loader
            // 
            this.loader.Dock = System.Windows.Forms.DockStyle.Top;
            this.loader.Image = global::SantaHelper.Properties.Resources.loader;
            this.loader.Location = new System.Drawing.Point(0, 0);
            this.loader.Name = "loader";
            this.loader.Size = new System.Drawing.Size(692, 364);
            this.loader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loader.TabIndex = 0;
            this.loader.TabStop = false;
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(692, 620);
            this.Controls.Add(this.resultCheckedListBox);
            this.Controls.Add(this.resultTitle);
            this.Controls.Add(this.loader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hohoho, thanks dear!";
            ((System.ComponentModel.ISupportInitialize)(this.loader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loader;
        private System.Windows.Forms.Label resultTitle;
        private System.Windows.Forms.CheckedListBox resultCheckedListBox;
    }
}