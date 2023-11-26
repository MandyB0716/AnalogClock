using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W5AnalogClock_BrownAmanda
{
    public partial class Form1 : Form
    {
        Bitmap clock, hour, minute, second;
        public Form1()
        {
            InitializeComponent();
            clock = new Bitmap(".\\clock2.png");
            hour = new Bitmap(".\\hourhand1.png");
            minute = new Bitmap(".\\minutehand1.png");
            second = new Bitmap(".\\secondhand1.png");
        }

        private void timerClick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            int Hour = now.Hour;
            int Minute = now.Minute;
            int Second = now.Second;

            Single AngleS = Second * 6;
            Single AngleM = Minute * 6 + AngleS / 60;
            Single AngleH = Hour * 30 + AngleM / 12;

            clockbox.Image = clock;
            clockbox.Controls.Add(hourbox);
            hourbox.Location = new Point(130,109);
            hourbox.Image = rotateImage(hour, AngleH);
            hourbox.Controls.Add(minutebox);
            minutebox.Location = new Point(4, 5);
            minutebox.Image = rotateImage(minute, AngleM);
            minutebox.Controls.Add(secondhandbox);
            secondhandbox.Location = new Point(-30, -18);
            secondhandbox.Image = rotateImage(second, AngleS);
        }
        private Bitmap rotateImage(Bitmap rotateme, float angle) 
        {
            Bitmap rotatedImage = new Bitmap(rotateme.Width, rotateme.Height);
            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform(rotateme.Width/2, rotateme.Height/2);
                g.RotateTransform(angle);
                g.TranslateTransform(-rotateme.Width/2, -rotateme.Height/2);
                g.DrawImage(rotateme, new Point(0,0));
            }
            return rotatedImage;
        }
    }
}
