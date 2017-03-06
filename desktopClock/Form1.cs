using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace desktopClock
{
    public partial class Form1 : Form
    {
        int oldLeft;
        int oldTop;
        int mouseX;
        int mouseY;
        int count = 0;
        string[] tempString;
        string oldTime;
        string currentTime;
        Bitmap[] img=new Bitmap[13];
        Bitmap imgTemp;
        Bitmap numberToDraw;
        Color color1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ShowInTaskbar = false;
            try
            { 
                using (StreamReader sr = new StreamReader("config.cloc"))
                {
                    int tempX=0;
                    int tempY=0;
                    int positiveFlag = 1;
                    String line = sr.ReadToEnd();
                    String[] position = line.Split(',');
                    for (int i = 0; i < position[0].Length; i++) {
                        if (position[0][i] == '-')
                        {
                            positiveFlag = -1;
                            continue;
                        }
                        tempX = tempX * 10 + (position[0][i] - '0');
                    }
                    tempX *= positiveFlag;
                    positiveFlag = 1;
                    for (int i = 0; i < position[1].Length; i++)
                    {
                        if (position[1][i] == '-')
                        {
                            positiveFlag = -1;
                            continue;
                        }
                        tempY = tempY * 10 + (position[1][i]-'0');
                    }
                    tempY *= positiveFlag;
                    positiveFlag = 1;
                    this.Left = tempX; 
                    this.Top = tempY;
                }
            }
            catch (Exception)
            {
                using (StreamWriter sw = new StreamWriter("config.cloc"))
                {
                    sw.Write(this.Left);
                    sw.Write(",");
                    sw.Write(this.Top);
                }
            }
            img[0] = (Bitmap)num0.Image;
            img[1] = (Bitmap)num1.Image;
            img[2] = (Bitmap)num2.Image;
            img[3] = (Bitmap)num3.Image;
            img[4] = (Bitmap)num4.Image;
            img[5] = (Bitmap)num5.Image;
            img[6] = (Bitmap)num6.Image;
            img[7] = (Bitmap)num7.Image;
            img[8] = (Bitmap)num8.Image;
            img[9] = (Bitmap)num9.Image;

            img[10] =(Bitmap) AM.Image;
            img[11] = (Bitmap)PM.Image;

            img[12] = (Bitmap)bk.Image;

            imgTemp = new Bitmap(bk.Width, bk.Height);

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            oldLeft = this.Left;
            oldTop = this.Top;
            mouseX = e.X;
            mouseY = e.Y;
           
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Capture == true)        
            {
                
                this.Top = e.Y + oldTop - mouseY;
                this.Left = e.X + oldLeft - mouseX;

                oldLeft = this.Left;
                oldTop = this.Top;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentTime = DateTime.Now.ToString("hh,mm,tt", CultureInfo.InvariantCulture);
            if (currentTime != oldTime)
            {
                
                tempString = currentTime.Split(',');
                oldTime = currentTime;

                
                for (int i = 0; i < imgTemp.Width; i++)
                {
                    for (int j = 0; j < imgTemp.Height; j++)
                    {

                        color1 = img[12].GetPixel(i, j);
                        imgTemp.SetPixel(i, j, color1);
                    }
                }

                drawNumber(tempString[0][0].ToString(), 160, 57);
                drawNumber(tempString[0][1].ToString(), 223, 57);
                drawNumber(tempString[1][0].ToString(), 290, 57);
                drawNumber(tempString[1][1].ToString(), 355, 57);
                drawNumber(tempString[2].ToString(), 415, 63);
                
                pictureBox1.Image = imgTemp;
            }
           
            timer1.Interval = 1000;
            if (count == 60)
            {
                GC.Collect();
                count = 0;
            }
            else
            {
                count++;
            }
        }

        private void endToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter("config.cloc"))
            {
                sw.Write(this.Left);
                sw.Write(",");
                sw.Write(this.Top);
            }
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void repositionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Left = 140;
            this.Top = 140;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        void drawNumber(string num,int x,int y) {
           
            switch (num)
            {
                case "0":
                    numberToDraw = img[0];
                    break;
                case "1":
                    numberToDraw = img[1];
                    break;
                case "2":
                    numberToDraw = img[2];
                    break;
                case "3":
                    numberToDraw = img[3];
                    break;
                case "4":
                    numberToDraw = img[4];
                    break;
                case "5":
                    numberToDraw = img[5];
                    break;
                case "6":
                    numberToDraw = img[6];
                    break;
                case "7":
                    numberToDraw = img[7];
                    break;
                case "8":
                    numberToDraw = img[8];
                    break;
                case "9":
                    numberToDraw = img[9];
                    break;
                case "AM":
                    numberToDraw = img[10];
                    break;
                case "PM":
                    numberToDraw = img[11];
                    break;
            }
            for (int i = 0; i < numberToDraw.Width; i++)
            {
                for (int j = 0; j < numberToDraw.Height; j++)
                {

                     color1 = numberToDraw.GetPixel(i, j);
                    if ((color1.R+color1.G+color1.B)/3 ==0|| color1.A < 50)
                    {
                        continue;
                    }
                    imgTemp.SetPixel(i+x, j+y, color1);
                }
            }
        }

        private void AM_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
        }
    }
}
