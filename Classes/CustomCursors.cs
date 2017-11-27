using MiPaint.Helper;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPaint.Classes
{
    public static class CustomCursors
    {
        private static Cursor[] _customCursors = new Cursor[5];

        public static void createCursors(Form parent)
        {
            _customCursors[(int)CanvasState.CreatingCircle] = CanvasManager.CreateCursor(new Bitmap(Properties.Resources.dashed_circle, 24, 24), 12, 12);
            _customCursors[(int)CanvasState.CreatingLine] = CanvasManager.CreateCursor(new Bitmap(Properties.Resources.dashed_line, 24, 24), 12, 12);
            _customCursors[(int)CanvasState.Rotating] = CanvasManager.CreateCursor(new Bitmap(Properties.Resources.rotate_to_right_button, 24, 24), 12, 12);
            _customCursors[(int)CanvasState.Translating] = CanvasManager.CreateCursor(new Bitmap(Properties.Resources.move, 24, 24), 12, 12);
            _customCursors[(int)CanvasState.None] = parent.Cursor;
        }

        public static Cursor loadCursor(CanvasState state)
        {
            return _customCursors[(int)state];
        }
    }
}
