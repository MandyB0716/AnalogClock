namespace W5AnalogClock_BrownAmanda
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.secondhandbox = new System.Windows.Forms.PictureBox();
            this.minutebox = new System.Windows.Forms.PictureBox();
            this.hourbox = new System.Windows.Forms.PictureBox();
            this.clockbox = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.secondhandbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clockbox)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timerClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.secondhandbox);
            this.panel1.Controls.Add(this.minutebox);
            this.panel1.Controls.Add(this.hourbox);
            this.panel1.Controls.Add(this.clockbox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(903, 682);
            this.panel1.TabIndex = 0;
            // 
            // secondhandbox
            // 
            this.secondhandbox.BackColor = System.Drawing.Color.Transparent;
            this.secondhandbox.Image = global::W5AnalogClock_BrownAmanda.Properties.Resources.secondhand1;
            this.secondhandbox.Location = new System.Drawing.Point(474, 133);
            this.secondhandbox.Name = "secondhandbox";
            this.secondhandbox.Size = new System.Drawing.Size(63, 339);
            this.secondhandbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.secondhandbox.TabIndex = 3;
            this.secondhandbox.TabStop = false;
            // 
            // minutebox
            // 
            this.minutebox.BackColor = System.Drawing.Color.Transparent;
            this.minutebox.Image = global::W5AnalogClock_BrownAmanda.Properties.Resources.minutehand1;
            this.minutebox.Location = new System.Drawing.Point(474, 133);
            this.minutebox.Name = "minutebox";
            this.minutebox.Size = new System.Drawing.Size(77, 317);
            this.minutebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minutebox.TabIndex = 2;
            this.minutebox.TabStop = false;
            // 
            // hourbox
            // 
            this.hourbox.BackColor = System.Drawing.Color.Transparent;
            this.hourbox.Image = global::W5AnalogClock_BrownAmanda.Properties.Resources.hourhand1;
            this.hourbox.Location = new System.Drawing.Point(415, 159);
            this.hourbox.Name = "hourbox";
            this.hourbox.Size = new System.Drawing.Size(53, 291);
            this.hourbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hourbox.TabIndex = 1;
            this.hourbox.TabStop = false;
            // 
            // clockbox
            // 
            this.clockbox.BackColor = System.Drawing.Color.Transparent;
            this.clockbox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clockbox.Image = global::W5AnalogClock_BrownAmanda.Properties.Resources.clock2;
            this.clockbox.Location = new System.Drawing.Point(101, 37);
            this.clockbox.Name = "clockbox";
            this.clockbox.Size = new System.Drawing.Size(717, 604);
            this.clockbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.clockbox.TabIndex = 0;
            this.clockbox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 678);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Analog Clock";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.secondhandbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minutebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hourbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clockbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox secondhandbox;
        private System.Windows.Forms.PictureBox minutebox;
        private System.Windows.Forms.PictureBox hourbox;
        private System.Windows.Forms.PictureBox clockbox;
        private System.Windows.Forms.Timer timer1;
    }
}

