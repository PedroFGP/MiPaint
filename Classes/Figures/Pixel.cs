using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPaint.Classes.Figures
{
    public class Pixel : Figure
    {
        private Point _location = new Point();

        public Pixel(Point location, float scale, Color color) : base(scale)
        {
            _location = location;
            Color = color;
        }

        public override void Draw()
        {
            Drawing.drawPixel(_location.X, _location.Y, Color);
        }
    }
}
