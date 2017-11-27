using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPaint.Classes
{
    public static class Drawing
    {
        private static Pen _dashedPen = new Pen(Color.Black, 1.0f);

        private static FrmMain _mainForm = new FrmMain();

        private static Graphics _graphics = null;

        private static Bitmap _texture = new Bitmap(1, 1);

        public static Graphics Graphics
        {
            get { return _graphics; }
            set { _graphics = value; }
        }

        public static void drawPixel(int x, int y, Color color)
        {
            _texture.SetPixel(0, 0, color);

            _graphics.DrawImageUnscaled(_texture, x, y);
        }

        private static void drawLineBresenham(Point a, Point b, Color color)
        {
            int cons1, cons2, factor, drawx, drawy, dx, dy, xincr, yincr;

            dx = b.X - a.X;
            dy = b.Y - a.Y;
            factor = 2 * dy - dx;

            if (dx < 0)
            {
                xincr = -1;
                dx = -dx;
            }
            else
            {
                xincr = 1;
            }
            if (dy < 0)
            {
                yincr = -1;
                dy = -dy;
            }
            else
            {
                yincr = 1;
            }

            drawx = a.X;
            drawy = a.Y;

            drawPixel(drawx, drawy, color);

            if (dx > dy) //first case
            {
                factor = 2 * dy - dx;
                cons1 = 2 * dy;
                cons2 = 2 * (dy - dx);

                for (int i = 0; i < dx; i++)
                {
                    drawx += xincr;

                    if (factor < 0)
                    {
                        factor += cons1;
                    }
                    else
                    {
                        factor += cons2;
                        drawy += yincr;
                    }

                    drawPixel(drawx, drawy, color);
                }
            }
            else //second case
            {
                factor = 2 * dx - dy;
                cons1 = 2 * dx;
                cons2 = 2 * (dx - dy);

                for (int i = 0; i < dy; i++)
                {
                    drawy += yincr;

                    if (factor < 0)
                    {
                        factor += cons1;
                    }
                    else
                    {
                        factor += cons2;
                        drawx += xincr;
                    }

                    drawPixel(drawx, drawy, color);
                }
            }
        }

        private static void drawLineDDA(Point a, Point b, Color color)
        {
            int steps;
            double xincr, yincr, drawx, drawy;

            int dx = Math.Abs(b.X - a.X);
            int dy = Math.Abs(b.Y - a.Y);

            if (dx >= dy)
            {
                steps = dx;
            }
            else
            { 
                steps = dy;
            }

            xincr = (double)dx / (double)steps;
            yincr = (double)dy / (double)steps;
            drawx = a.X;
            drawy = a.Y;

            drawPixel((int)Math.Round(drawx), (int)Math.Round(drawy), color);

            for (int i = 1; i <= steps; i++)
            {
                drawx += xincr;
                drawy += yincr;

                drawPixel((int)Math.Round(drawx), (int)Math.Round(drawy), color);
            }
        }

        public static void drawLine(Point a, Point b, Color color)
        {
            if(Properties.Settings.Default.UseDDA)
            {
                drawLineDDA(a, b, color);
            }
            else
            {
                drawLineBresenham(a, b, color);
            }
        }

        public static void drawCircle(Point center, int radius, Color color)
        {
            int drawx, drawy, factor;

            drawx = 0;
            drawy = radius;

            factor = 3 - 2 * radius;

            drawSymmetricalPoints(new Point(drawx, drawy), center, color);

            while(drawx < drawy)
            {
                if(factor < 0)
                {
                    factor += 4 * drawx + 6;
                }
                else
                {
                    factor += 4 * (drawx - drawy) + 10;
                    drawy--;
                }

                drawx++;

                drawSymmetricalPoints(new Point(drawx, drawy), center, color);
            }
        }

        private static void drawSymmetricalPoints(Point draw, Point center, Color color)
        {
            drawPixel(center.X + draw.X, center.Y + draw.Y, color);
            drawPixel(center.X - draw.X, center.Y - draw.Y, color);
            drawPixel(center.X + draw.X, center.Y - draw.Y, color);
            drawPixel(center.X - draw.X, center.Y + draw.Y, color);
            drawPixel(center.X + draw.Y, center.Y + draw.X, color);
            drawPixel(center.X - draw.Y, center.Y - draw.X, color);
            drawPixel(center.X + draw.Y, center.Y - draw.X, color);
            drawPixel(center.X - draw.Y, center.Y + draw.X, color);
        }

        public static void drawBorder(Rectangle border)
        {
            _dashedPen.DashStyle = DashStyle.Dash;

            _graphics.DrawRectangle(_dashedPen, border.X, border.Y, border.Width, border.Height);
        }
    }
}
