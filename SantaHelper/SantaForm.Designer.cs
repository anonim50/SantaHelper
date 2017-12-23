namespace SantaHelper
{
    partial class SantaForm
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
            this.giftsTextBox = new System.Windows.Forms.RichTextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.numberOfKidsTrackBar = new System.Windows.Forms.TrackBar();
            this.executeButton = new System.Windows.Forms.Button();
            this.numberOfKidsLabel = new System.Windows.Forms.Label();
            this.kidNumber = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfKidsTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // giftsTextBox
            // 
            this.giftsTextBox.Font = new System.Drawing.Font("Century Gothic", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.giftsTextBox.Location = new System.Drawing.Point(32, 116);
            this.giftsTextBox.Name = "giftsTextBox";
            this.giftsTextBox.Size = new System.Drawing.Size(457, 141);
            this.giftsTextBox.TabIndex = 0;
            this.giftsTextBox.Text = " ball, pizza, airplane, robot, puzzle, bike ";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.titleLabel.Location = new System.Drawing.Point(80, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(360, 34);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Welcome to Santa Helper";
            // 
            // numberOfKidsTrackBar
            // 
            this.numberOfKidsTrackBar.Location = new System.Drawing.Point(54, 307);
            this.numberOfKidsTrackBar.Maximum = 50;
            this.numberOfKidsTrackBar.Minimum = 1;
            this.numberOfKidsTrackBar.Name = "numberOfKidsTrackBar";
            this.numberOfKidsTrackBar.Size = new System.Drawing.Size(413, 56);
            this.numberOfKidsTrackBar.TabIndex = 2;
            this.numberOfKidsTrackBar.Value = 4;
            this.numberOfKidsTrackBar.ValueChanged += new System.EventHandler(this.numberOfKidsTrackBar_ValueChanged);
            // 
            // executeButton
            // 
            this.executeButton.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.executeButton.Location = new System.Drawing.Point(108, 399);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(305, 67);
            this.executeButton.TabIndex = 3;
            this.executeButton.Text = "Help Santa ! 🎅";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // numberOfKidsLabel
            // 
            this.numberOfKidsLabel.AutoSize = true;
            this.numberOfKidsLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numberOfKidsLabel.Location = new System.Drawing.Point(183, 284);
            this.numberOfKidsLabel.Name = "numberOfKidsLabel";
            this.numberOfKidsLabel.Size = new System.Drawing.Size(121, 20);
            this.numberOfKidsLabel.TabIndex = 4;
            this.numberOfKidsLabel.Text = "Number of kids:";
            // 
            // kidNumber
            // 
            this.kidNumber.AutoSize = true;
            this.kidNumber.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kidNumber.Location = new System.Drawing.Point(313, 285);
            this.kidNumber.Name = "kidNumber";
            this.kidNumber.Size = new System.Drawing.Size(16, 18);
            this.kidNumber.TabIndex = 5;
            this.kidNumber.Text = "4";
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.infoLabel.Location = new System.Drawing.Point(29, 68);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(402, 20);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = "Write below list of gifts separated by comma and help";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(32, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Santa to give this gifts to selected number of kids:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SantaHelper.Properties.Resources.sound_on;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(472, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 34);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SantaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(517, 487);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.kidNumber);
            this.Controls.Add(this.numberOfKidsLabel);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.numberOfKidsTrackBar);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.giftsTextBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SantaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Santa helper";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfKidsTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox giftsTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TrackBar numberOfKidsTrackBar;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Label numberOfKidsLabel;
        private System.Windows.Forms.Label kidNumber;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

