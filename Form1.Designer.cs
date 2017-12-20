namespace ImageManipulation
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
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnGray = new System.Windows.Forms.Button();
            this.picSunlight = new System.Windows.Forms.PictureBox();
            this.btnSunlight = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.picRed = new System.Windows.Forms.PictureBox();
            this.picGreen = new System.Windows.Forms.PictureBox();
            this.picBlue = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSunlight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlue)).BeginInit();
            this.SuspendLayout();
            // 
            // picOriginal
            // 
            this.picOriginal.Location = new System.Drawing.Point(88, 12);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(411, 371);
            this.picOriginal.TabIndex = 0;
            this.picOriginal.TabStop = false;
            // 
            // picResult
            // 
            this.picResult.Location = new System.Drawing.Point(582, 12);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(404, 371);
            this.picResult.TabIndex = 1;
            this.picResult.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(194, 389);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(163, 42);
            this.btnOpen.TabIndex = 2;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnGray
            // 
            this.btnGray.Location = new System.Drawing.Point(685, 389);
            this.btnGray.Name = "btnGray";
            this.btnGray.Size = new System.Drawing.Size(163, 42);
            this.btnGray.TabIndex = 3;
            this.btnGray.Text = "Gray";
            this.btnGray.UseVisualStyleBackColor = true;
            this.btnGray.Click += new System.EventHandler(this.btnGray_Click);
            // 
            // picSunlight
            // 
            this.picSunlight.Location = new System.Drawing.Point(1058, 12);
            this.picSunlight.Name = "picSunlight";
            this.picSunlight.Size = new System.Drawing.Size(411, 371);
            this.picSunlight.TabIndex = 4;
            this.picSunlight.TabStop = false;
            // 
            // btnSunlight
            // 
            this.btnSunlight.Location = new System.Drawing.Point(1178, 389);
            this.btnSunlight.Name = "btnSunlight";
            this.btnSunlight.Size = new System.Drawing.Size(163, 42);
            this.btnSunlight.TabIndex = 5;
            this.btnSunlight.Text = "Sunlight";
            this.btnSunlight.UseVisualStyleBackColor = true;
            this.btnSunlight.Click += new System.EventHandler(this.btnSunlight_Click);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(194, 437);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(163, 42);
            this.btnRed.TabIndex = 6;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(1178, 437);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(163, 42);
            this.btnBlue.TabIndex = 7;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(685, 437);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(163, 42);
            this.btnGreen.TabIndex = 8;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // picRed
            // 
            this.picRed.Location = new System.Drawing.Point(88, 485);
            this.picRed.Name = "picRed";
            this.picRed.Size = new System.Drawing.Size(411, 371);
            this.picRed.TabIndex = 9;
            this.picRed.TabStop = false;
            // 
            // picGreen
            // 
            this.picGreen.Location = new System.Drawing.Point(582, 485);
            this.picGreen.Name = "picGreen";
            this.picGreen.Size = new System.Drawing.Size(411, 371);
            this.picGreen.TabIndex = 10;
            this.picGreen.TabStop = false;
            // 
            // picBlue
            // 
            this.picBlue.Location = new System.Drawing.Point(1058, 485);
            this.picBlue.Name = "picBlue";
            this.picBlue.Size = new System.Drawing.Size(411, 371);
            this.picBlue.TabIndex = 11;
            this.picBlue.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1526, 861);
            this.Controls.Add(this.picBlue);
            this.Controls.Add(this.picGreen);
            this.Controls.Add(this.picRed);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnBlue);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnSunlight);
            this.Controls.Add(this.picSunlight);
            this.Controls.Add(this.btnGray);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.picResult);
            this.Controls.Add(this.picOriginal);
            this.Name = "Form1";
            this.Text = "Image Manipulatiom";
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSunlight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnGray;
        private System.Windows.Forms.PictureBox picSunlight;
        private System.Windows.Forms.Button btnSunlight;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.PictureBox picRed;
        private System.Windows.Forms.PictureBox picGreen;
        private System.Windows.Forms.PictureBox picBlue;
    }
}

