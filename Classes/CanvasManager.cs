using MiPaint.Classes;
using MiPaint.Classes.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPaint.Helper
{
    public static class CanvasManager
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetIconInfo(IntPtr hIcon, ref IconInfo pIconInfo);

        [DllImport("user32.dll")]
        public static extern IntPtr CreateIconIndirect(ref IconInfo icon);

        public static List<Figure> Figures = new List<Figure>();
        private static Figure _newFigure = null;
        private static Figure _selectedFigure = null;
        private static Point _mouseDragging;
        private static bool _dragging;
        private static bool _firsPointPlaced;

        public static bool Dragging
        {
            get { return _dragging; }
            set { _dragging = value; }
        }

        public static bool FirstPointPlaced
        {
            get { return _firsPointPlaced; }
            set { _firsPointPlaced = value; }
        }

        public static Point MouseDragging
        {
            get { return _mouseDragging; }
            set { _mouseDragging = value; }
        }

        public static Figure NewFigure
        {
            get { return _newFigure; }
            set { _newFigure = value; }
        }

        public static Figure SelectedFigure
        {
            get { return _selectedFigure; }
            set { _selectedFigure = value; }
        }

        public struct IconInfo
        {
            public bool fIcon;
            public int xHotspot;
            public int yHotspot;
            public IntPtr hbmMask;
            public IntPtr hbmColor;
        }

        public static Cursor CreateCursor(Bitmap bmp, int xHotSpot, int yHotSpot)
        {
            IntPtr ptr = bmp.GetHicon();
            IconInfo tmp = new IconInfo();
            GetIconInfo(ptr, ref tmp);
            tmp.xHotspot = xHotSpot;
            tmp.yHotspot = yHotSpot;
            tmp.fIcon = false;
            ptr = CreateIconIndirect(ref tmp);
            return new Cursor(ptr);
        }

        public static int Distance(Point p1, Point p2)
        {
            int dx = p1.X - p2.X;
            int dy = p1.Y - p2.Y;

            double distance = Math.Sqrt(dx * dx + dy * dy);

            return (int)Math.Round(distance, MidpointRounding.AwayFromZero);
        }

        private static bool inRectangle(Point pt, Rectangle area)
        {
            if (pt.X >= area.X && pt.X <= (area.X + area.Width) && pt.Y >= area.Y && pt.Y <= (area.Y + area.Height))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool inArea(Figure figure, Point mouse)
        {
            return inRectangle(mouse, figure.Border);
        }
    }
}
