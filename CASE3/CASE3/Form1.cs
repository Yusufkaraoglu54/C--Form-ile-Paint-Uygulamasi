using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CASE3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Width = 900;
            this.Height= 700;
            bm=new Bitmap(pic.Width,pic.Height);
            g=Graphics.FromImage(bm);
            g.Clear(System.Drawing.Color.White);
            pic.Image= bm;
        }

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py; 
        Pen p = new Pen(System.Drawing.Color.Black, 1);
        Pen silgi = new Pen(System.Drawing.Color.White, 10);
        int index;
        int x,y,sX,sY,cX,cY,aX,aY,bX,bY,dX,dY,eX,eY;

        ColorDialog cd = new ColorDialog();
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btn_rect_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            if(paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                    
                }
                if (index == 5)
                {
                    Point[] p2 = { new Point(aX, aY), new Point(sX, sY), new Point(cX,cY)};
                    g.DrawPolygon(p, p2);
                }
                if(index==6)
                {
                    Point[] p3 =
                    {
                        new Point(aX, aY),
                        new Point(sX, sY),
                        new Point(cX, cY),
                        new Point(bX,bY),
                        new Point(dX,dY),
                        new Point(eX,eY)

                    };
                    g.DrawPolygon(p, p3);
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            g.Clear(System.Drawing.Color.White);
            pic.Image= bm;
            index = 0;

        }
        private void renkColor(Color color)
        {
            this.p.Color= color;
        }
        private void btn_red_Click(object sender, EventArgs e)
        {
            this.renkColor(Color.Red);
        }

        private void brn_blue_Click(object sender, EventArgs e)
        {
            this.renkColor(Color.Blue);
        }

        private void btn_green_Click(object sender, EventArgs e)
        {
            this.renkColor(Color.Green);
        }

        private void btn_orange_Click(object sender, EventArgs e)
        {
            this.renkColor(Color.Orange);
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog(); 
            sfd.Filter = "PNG Image| *.png | BIK | *.bik";;
            if (sfd.ShowDialog()==DialogResult.OK)
            {
                Bitmap btm = bm.Clone(new Rectangle(0,0,pic.Width,bm.Height),bm.PixelFormat);
                btm.Save(sfd.FileName,ImageFormat.Jpeg);
                
            }
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open Image";
            ofd.Filter = "PNG Image|*.png|BIK|*.bik";
            if(ofd.ShowDialog() ==System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(ofd.SafeFileName);
            }
        }

        private void brn_black_Click(object sender, EventArgs e)
        {
            this.renkColor(Color.Black);
        }

        private void btn_yellow_Click(object sender, EventArgs e)
        {
            this.renkColor(Color.Yellow);
        }

        private void btn_purple_Click(object sender, EventArgs e)
        {
            this.renkColor(Color.Purple);
        }

        private void btn_brown_Click(object sender, EventArgs e)
        {
            this.renkColor(Color.Brown);
        }

        private void btn_white_Click(object sender, EventArgs e)
        {
            this.renkColor(Color.White);
        }

        private void btn_ucgen_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            index= 6;
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX=e.X;
            cY=e.Y;
            
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if(paint)
            {
                if(index==1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(silgi, px, py);
                    py = px;
                }
            }
            pic.Refresh();

            x = e.X;
            y= e.Y;
            sX= e.X - cX;
            sY= e.Y - cY;
           

        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX; 
            sY = y - cY;

            if(index==3)
            {
                g.DrawEllipse(p,cX,cY,sX,sY);
            }
            if (index == 4)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }
            if (index == 5)
            {
                Point[] p2 = { new Point(cX, cY), new Point(sX, sY), new Point(aX, aY), new Point(bX, bY), new Point(cX, cY) };
                g.DrawPolygon(p, p2);
            }
            if (index == 6)
            {
                Point[] p3 =
                {
                        new Point(aX, aY),
                        new Point(sX, sY),
                        new Point(cX, cY),
                        new Point(bX,bY),
                        new Point(dX,dY),
                        new Point(eX,eY)

                    };
                g.DrawPolygon(p, p3);
            }



        }

        private void btn_silgi_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btn_ellipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }
 

    }
}
