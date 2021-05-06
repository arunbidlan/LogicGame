namespace LogicGame
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
            this.LoadBtn = new System.Windows.Forms.Button();
            this.Spin = new System.Windows.Forms.Button();
            this.ShootAt = new System.Windows.Forms.Button();
            this.ShootHd = new System.Windows.Forms.Button();
            this.PLyAgn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadBtn
            // 
            this.LoadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoadBtn.Location = new System.Drawing.Point(29, 479);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(166, 46);
            this.LoadBtn.TabIndex = 0;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = false;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // Spin
            // 
            this.Spin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Spin.Enabled = false;
            this.Spin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Spin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Spin.Location = new System.Drawing.Point(213, 479);
            this.Spin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Spin.Name = "Spin";
            this.Spin.Size = new System.Drawing.Size(166, 46);
            this.Spin.TabIndex = 1;
            this.Spin.Text = "Spin";
            this.Spin.UseVisualStyleBackColor = false;
            this.Spin.Click += new System.EventHandler(this.Spin_Click);
            // 
            // ShootAt
            // 
            this.ShootAt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShootAt.Enabled = false;
            this.ShootAt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootAt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShootAt.Location = new System.Drawing.Point(397, 479);
            this.ShootAt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShootAt.Name = "ShootAt";
            this.ShootAt.Size = new System.Drawing.Size(221, 46);
            this.ShootAt.TabIndex = 2;
            this.ShootAt.Text = "Shoot At head";
            this.ShootAt.UseVisualStyleBackColor = false;
            this.ShootAt.Click += new System.EventHandler(this.ShootAt_Click);
            // 
            // ShootHd
            // 
            this.ShootHd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ShootHd.Enabled = false;
            this.ShootHd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShootHd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ShootHd.Location = new System.Drawing.Point(637, 479);
            this.ShootHd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ShootHd.Name = "ShootHd";
            this.ShootHd.Size = new System.Drawing.Size(229, 46);
            this.ShootHd.TabIndex = 3;
            this.ShootHd.Text = "Shoot Away";
            this.ShootHd.UseVisualStyleBackColor = false;
            this.ShootHd.Click += new System.EventHandler(this.ShootHd_Click);
            // 
            // PLyAgn
            // 
            this.PLyAgn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PLyAgn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLyAgn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PLyAgn.Location = new System.Drawing.Point(874, 479);
            this.PLyAgn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PLyAgn.Name = "PLyAgn";
            this.PLyAgn.Size = new System.Drawing.Size(166, 46);
            this.PLyAgn.TabIndex = 4;
            this.PLyAgn.Text = "Try again";
            this.PLyAgn.UseVisualStyleBackColor = false;
            this.PLyAgn.Click += new System.EventHandler(this.PLyAgn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LogicGame.Resource1.background;
            this.pictureBox1.Location = new System.Drawing.Point(16, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1035, 570);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.PLyAgn);
            this.Controls.Add(this.ShootHd);
            this.Controls.Add(this.ShootAt);
            this.Controls.Add(this.Spin);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button Spin;
        private System.Windows.Forms.Button ShootAt;
        private System.Windows.Forms.Button ShootHd;
        private System.Windows.Forms.Button PLyAgn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

