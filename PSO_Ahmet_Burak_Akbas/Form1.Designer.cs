namespace PSO_Ahmet_Burak_Akbas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtParticleCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtC1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtC2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtW = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxIterations = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBestFitness = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBestPosition = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 483);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtParticleCount);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtC1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtC2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtW);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtMaxIterations);
            this.panel2.Controls.Add(this.btnRun);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtBestFitness);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtBestPosition);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 483);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 255);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PSO_Ahmet_Burak_Akbas.Properties.Resources.UfQ94;
            this.pictureBox2.Location = new System.Drawing.Point(763, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(292, 246);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(245, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(410, 27);
            this.label9.TabIndex = 18;
            this.label9.Text = "Six-hump Camel-back Function\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PSO_Ahmet_Burak_Akbas.Properties.Resources.camel62;
            this.pictureBox1.Location = new System.Drawing.Point(250, 160);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(428, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Particle Count:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtParticleCount
            // 
            this.txtParticleCount.Location = new System.Drawing.Point(130, 20);
            this.txtParticleCount.Name = "txtParticleCount";
            this.txtParticleCount.Size = new System.Drawing.Size(80, 22);
            this.txtParticleCount.TabIndex = 1;
            this.txtParticleCount.Text = "10";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "C1:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtC1
            // 
            this.txtC1.Location = new System.Drawing.Point(130, 50);
            this.txtC1.Name = "txtC1";
            this.txtC1.Size = new System.Drawing.Size(80, 22);
            this.txtC1.TabIndex = 5;
            this.txtC1.Text = "2.0";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "C2:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtC2
            // 
            this.txtC2.Location = new System.Drawing.Point(130, 80);
            this.txtC2.Name = "txtC2";
            this.txtC2.Size = new System.Drawing.Size(80, 22);
            this.txtC2.TabIndex = 7;
            this.txtC2.Text = "2.0";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(20, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "W:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(130, 110);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(80, 22);
            this.txtW.TabIndex = 9;
            this.txtW.Text = "0.7";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(20, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Max Iterations:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaxIterations
            // 
            this.txtMaxIterations.Location = new System.Drawing.Point(130, 140);
            this.txtMaxIterations.Name = "txtMaxIterations";
            this.txtMaxIterations.Size = new System.Drawing.Size(80, 22);
            this.txtMaxIterations.TabIndex = 11;
            this.txtMaxIterations.Text = "20";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(60, 180);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(120, 43);
            this.btnRun.TabIndex = 16;
            this.btnRun.Text = "Run PSO";
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(250, 40);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Best Fitness:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBestFitness
            // 
            this.txtBestFitness.Location = new System.Drawing.Point(360, 40);
            this.txtBestFitness.Margin = new System.Windows.Forms.Padding(4);
            this.txtBestFitness.Name = "txtBestFitness";
            this.txtBestFitness.ReadOnly = true;
            this.txtBestFitness.Size = new System.Drawing.Size(180, 22);
            this.txtBestFitness.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(250, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Best Position:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtBestPosition
            // 
            this.txtBestPosition.Location = new System.Drawing.Point(360, 80);
            this.txtBestPosition.Margin = new System.Windows.Forms.Padding(4);
            this.txtBestPosition.Name = "txtBestPosition";
            this.txtBestPosition.ReadOnly = true;
            this.txtBestPosition.Size = new System.Drawing.Size(250, 22);
            this.txtBestPosition.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 738);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "PSO Algorithm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtParticleCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtC1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtC2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxIterations;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBestFitness;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBestPosition;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
#endregion