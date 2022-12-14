namespace WindowsFormsApp1.Properties
{
    partial class MainScreen
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
            this.PlayButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.UpperImage = new System.Windows.Forms.PictureBox();
            this.DownImage = new System.Windows.Forms.PictureBox();
            this.Heading = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.UpperImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownImage)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayButton
            // 
            this.PlayButton.BackColor = System.Drawing.Color.White;
            this.PlayButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlayButton.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayButton.Location = new System.Drawing.Point(35, 352);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(200, 60);
            this.PlayButton.TabIndex = 0;
            this.PlayButton.Text = "Играть!";
            this.PlayButton.UseVisualStyleBackColor = false;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(253, 352);
            this.NameBox.MaxLength = 16;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(224, 21);
            this.NameBox.TabIndex = 1;
            this.NameBox.TextChanged += new System.EventHandler(this.NameBox_TextChanged);
            // 
            // UpperImage
            // 
            this.UpperImage.Image = global::NewWorldLauncher.Properties.Resources.UpperImage;
            this.UpperImage.Location = new System.Drawing.Point(0, 0);
            this.UpperImage.Name = "UpperImage";
            this.UpperImage.Size = new System.Drawing.Size(803, 81);
            this.UpperImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpperImage.TabIndex = 2;
            this.UpperImage.TabStop = false;
            // 
            // DownImage
            // 
            this.DownImage.Image = global::NewWorldLauncher.Properties.Resources.UpperImage;
            this.DownImage.Location = new System.Drawing.Point(0, 316);
            this.DownImage.Name = "DownImage";
            this.DownImage.Size = new System.Drawing.Size(803, 136);
            this.DownImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DownImage.TabIndex = 3;
            this.DownImage.TabStop = false;
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.BackColor = System.Drawing.Color.MediumOrchid;
            this.Heading.Cursor = System.Windows.Forms.Cursors.Default;
            this.Heading.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Heading.ForeColor = System.Drawing.Color.Black;
            this.Heading.Location = new System.Drawing.Point(12, 9);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(324, 58);
            this.Heading.TabIndex = 4;
            this.Heading.Text = "НОВЫЙ МИР";
            this.Heading.Click += new System.EventHandler(this.Heading_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.DownImage);
            this.Controls.Add(this.UpperImage);
            this.Name = "MainScreen";
            this.Text = "Новый мир";
            ((System.ComponentModel.ISupportInitialize)(this.UpperImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayButton;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.PictureBox UpperImage;
        private System.Windows.Forms.PictureBox DownImage;
        private System.Windows.Forms.Label Heading;
    }
}