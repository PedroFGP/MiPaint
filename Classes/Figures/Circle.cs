using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPaint.Classes.Figures
{
    public class Circle : Figure
    {
        private Point _center;
        private int _radius;

        public int Radius
        {
            get { return _radius; }
            set
            {
                _radius = value;

                calculateBorder();
            }
        }

        public Point Center
        {
            get { return _center; }
            set{ _center = value; }
        }

        public Circle(Point center, Color color, float scale) : base(scale)
        {
            Center = center;
            Color = color;
        }

        public Circle(Point center, int radius, Color color, float scale) : base(scale)
        {
            Center = center;
            Radius = radius;
            Color = color;

            calculateBorder();
        }

        public void calculateBorder()
        {
            int x, y, size;

            x = Center.X - (int)(Radius * ScaleFactor);
            y = Center.Y - (int)(Radius * ScaleFactor);
            size = 2 * (int)(Radius * ScaleFactor);

            Border = new Rectangle(x - BORDEROFFSET, y - BORDEROFFSET, size + 2 * BORDEROFFSET, size + 2 * BORDEROFFSET);
        }

        public override void onRotate(double angle)
        {
            Point rotatedCenter = new Point();

            double radians = angle * Math.PI / 180;

            rotatedCenter.X = (int)(Math.Cos(radians) * (Center.X - MouseClick.X) - Math.Sin(radians) * (Center.Y - MouseClick.Y) + MouseClick.X);
            rotatedCenter.Y = (int)(Math.Sin(radians) * (Center.X - MouseClick.X) + Math.Cos(radians) * (Center.Y - MouseClick.Y) + MouseClick.Y);

            Center = rotatedCenter;

            calculateBorder();
        }

        public override void onScaleChanged(float scale)
        {
            ScaleFactor = scale;

            calculateBorder();
        }

        public override void onTranslate(Point mousePosition)
        {
            Point dc = new Point();

            dc.X = Center.X - MouseClick.X;
            dc.Y = Center.Y - MouseClick.Y;

            _center.X = mousePosition.X + dc.X;
            _center.Y = mousePosition.Y + dc.Y;

            calculateBorder();
        }

        public override void Draw()
        {
            Drawing.drawCircle(Center, (int)(Radius * ScaleFactor), Color);

            if (Selected)
            {
                Drawing.drawBorder(Border);
            }
        }
    }
}
