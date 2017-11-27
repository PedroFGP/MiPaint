using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPaint.Classes.Figures
{
    public class Line : Figure
    {
        private Point _a, _b;

        public Point A
        {
            get { return _a; }
            set { _a = value; }
        }

        public Point B
        {
            get { return _b; }
            set
            {
                _b = value;

                calculateBorder();
            }
        }

        public Line(Point a, Color color, float scale) : base(scale)
        {
            A = a;
            Color = color;
        }

        public Line(Point a, Point b, Color color, float scale) : base(scale)
        {
            A = a;
            B = b;
            Color = color;

            calculateBorder();
        }

        public void calculateBorder()
        {
            int x, y, width, height;

            if (A.X < B.X)
            {
                x = A.X;
            }
            else
            {
                x = (int)(B.X * ScaleFactor);
            }

            if (A.Y < B.Y)
            {
                y = A.Y;
            }
            else
            {
                y = (int)(B.Y * ScaleFactor);
            }

            width = Math.Abs(A.X - (int)(B.X * ScaleFactor));
            height = Math.Abs(A.Y - (int)(B.Y * ScaleFactor));

            Border = new Rectangle(x - BORDEROFFSET, y - BORDEROFFSET, width + 2 * BORDEROFFSET, height + 2 * BORDEROFFSET);
        }

        public override void onRotate(double angle)
        {
            Point rotatedA = new Point();
            Point rotatedB = new Point();

            double radians = angle * Math.PI / 180;

            rotatedA.X = (int)(Math.Cos(radians) * (A.X - MouseClick.X) - Math.Sin(radians) * (A.Y - MouseClick.Y) + MouseClick.X);
            rotatedA.Y = (int)(Math.Sin(radians) * (A.X - MouseClick.X) + Math.Cos(radians) * (A.Y - MouseClick.Y) + MouseClick.Y);

            rotatedB.X = (int)(Math.Cos(radians) * (B.X - MouseClick.X) - Math.Sin(radians) * (B.Y - MouseClick.Y) + MouseClick.X);
            rotatedB.Y = (int)(Math.Sin(radians) * (B.X - MouseClick.X) + Math.Cos(radians) * (B.Y - MouseClick.Y) + MouseClick.Y);

            A = rotatedA;
            B = rotatedB;

            calculateBorder();
        }

        public override void onScaleChanged(float scale)
        {
            ScaleFactor = scale;

            calculateBorder();
        }

        public override void onTranslate(Point mousePosition)
        {
            Point da = new Point();
            Point db = new Point();

            da.X = A.X - MouseClick.X;
            da.Y = A.Y - MouseClick.Y;

            db.X = B.X - MouseClick.X;
            db.Y = B.Y - MouseClick.Y;

            A = new Point(mousePosition.X + da.X, mousePosition.Y + da.Y);
            B = new Point((int)((mousePosition.X + db.X) * ScaleFactor), (int)((mousePosition.Y + db.Y) * ScaleFactor));

            calculateBorder();
        }

        public override void Draw()
        {
            Drawing.drawLine(A, new Point((int)(B.X * ScaleFactor), (int)(B.Y * ScaleFactor)), Color);

            if(Selected)
            {
                Drawing.drawBorder(Border);
            }
        }
    }
}
