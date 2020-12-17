namespace TemplateAssisment
{
    partial class MainForm
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
            this.Exitthegame = new System.Windows.Forms.Button();
            this.AwayShootBTN = new System.Windows.Forms.PictureBox();
            this.SpinBTN = new System.Windows.Forms.PictureBox();
            this.ReloadButton = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pict = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AwayShootBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReloadButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pict)).BeginInit();
            this.SuspendLayout();
            // 
            // Exitthegame
            // 
            this.Exitthegame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Exitthegame.ForeColor = System.Drawing.Color.Green;
            this.Exitthegame.Location = new System.Drawing.Point(712, 11);
            this.Exitthegame.Margin = new System.Windows.Forms.Padding(2);
            this.Exitthegame.Name = "Exitthegame";
            this.Exitthegame.Size = new System.Drawing.Size(95, 26);
            this.Exitthegame.TabIndex = 10;
            this.Exitthegame.Text = "Exit";
            this.Exitthegame.UseVisualStyleBackColor = false;
            this.Exitthegame.Click += new System.EventHandler(this.Exitthegame_Click);
            // 
            // AwayShootBTN
            // 
            this.AwayShootBTN.Image = global::TemplateAssisment.Properties.Resources.Away;
            this.AwayShootBTN.Location = new System.Drawing.Point(72, 179);
            this.AwayShootBTN.Name = "AwayShootBTN";
            this.AwayShootBTN.Size = new System.Drawing.Size(59, 52);
            this.AwayShootBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AwayShootBTN.TabIndex = 14;
            this.AwayShootBTN.TabStop = false;
            this.AwayShootBTN.Click += new System.EventHandler(this.AwayShootBTN_Click);
            // 
            // SpinBTN
            // 
            this.SpinBTN.Image = global::TemplateAssisment.Properties.Resources.Spin;
            this.SpinBTN.Location = new System.Drawing.Point(234, 293);
            this.SpinBTN.Name = "SpinBTN";
            this.SpinBTN.Size = new System.Drawing.Size(48, 42);
            this.SpinBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SpinBTN.TabIndex = 13;
            this.SpinBTN.TabStop = false;
            this.SpinBTN.Click += new System.EventHandler(this.SpinBTN_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.Image = global::TemplateAssisment.Properties.Resources.Reloading;
            this.ReloadButton.Location = new System.Drawing.Point(549, 293);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(51, 42);
            this.ReloadButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ReloadButton.TabIndex = 12;
            this.ReloadButton.TabStop = false;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::TemplateAssisment.Properties.Resources.icon_bullet_25;
            this.pictureBox1.Image = global::TemplateAssisment.Properties.Resources.icon_bullet_25;
            this.pictureBox1.Location = new System.Drawing.Point(653, 168);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Pict
            // 
            this.Pict.Image = global::TemplateAssisment.Properties.Resources.ImageGun;
            this.Pict.Location = new System.Drawing.Point(-5, 0);
            this.Pict.Margin = new System.Windows.Forms.Padding(2);
            this.Pict.Name = "Pict";
            this.Pict.Size = new System.Drawing.Size(824, 355);
            this.Pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pict.TabIndex = 7;
            this.Pict.TabStop = false;
            this.Pict.Click += new System.EventHandler(this.Pict_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Shoot Away";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 357);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AwayShootBTN);
            this.Controls.Add(this.SpinBTN);
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Exitthegame);
            this.Controls.Add(this.Pict);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.AwayShootBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SpinBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReloadButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Pict;
        private System.Windows.Forms.Button Exitthegame;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ReloadButton;
        private System.Windows.Forms.PictureBox SpinBTN;
        private System.Windows.Forms.PictureBox AwayShootBTN;
        private System.Windows.Forms.Label label1;
    }
}

