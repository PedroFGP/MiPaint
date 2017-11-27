using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MiPaint.Classes
{
    public class Figure
    {
        private int _index;
        private FigureType _type;
        private float _scaleFactor;
        private Size _size;
        private bool _selected;
        private Color _color;
        private Rectangle _border;
        private Point _mouseClick;

        public const int BORDEROFFSET = 2;

        public float ScaleFactor
        { 
            get { return _scaleFactor; }
            set
            {
                _scaleFactor = value;
            }
        }

        public FigureType Type
        {
            get { return _type; }
            set { _type = value; }
        }

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }

        public Size Size
        {
            get { return _size; }
            set { _size = value; }
        }

        public bool Selected
        {
            get { return _selected; }
            set { _selected = value; }
        }

        public Figure(float scale)
        {
            ScaleFactor = scale;
            Selected = false;
        }

        public Color Color
        {
            get { return _color; }
            set { _color = value; }
        }

        public Rectangle Border
        {
            get { return _border; }
            set { _border = value; }
        }

        public Point MouseClick
        {
            get { return _mouseClick; }
            set { _mouseClick = value; }
        }

        public string typeToString()
        {
            switch(Type)
            {
                case FigureType.Line:
                    return "Linha";

                case FigureType.Circle:
                    return "Circle";

                default:
                    return "NA";
            }
        }

        public virtual void onChangeColor(Color color)
        {
            Color = Color;
        }
        
        public virtual void onScaleChanged(float scale)
        {

        }

        public virtual void onRotate(double angle)
        {

        }

        public virtual void onTranslate(Point mousePosition)
        {

        }

        public virtual void Draw()
        {

        }
    }
}
