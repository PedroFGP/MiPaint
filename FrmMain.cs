using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using MiPaint.Classes;
using MiPaint.Helper;
using MiPaint.Classes.Figures;
using System.Reflection;

/*Colors
    Icons: #32C7B8
*/

namespace MiPaint
{
    public partial class FrmMain : MaterialForm
    {
        #region Variables & Constructor

        public FrmMain()
        {
            InitializeComponent();

            MaterialSkinManager SkinManager = MaterialSkinManager.Instance;
            SkinManager.AddFormToManage(this);
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            CustomCursors.createCursors(this);
        }

        #endregion

        #region Events

        #region TabCanvas

        private void ToolsLine_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CanvasState = (int)CanvasState.CreatingLine;

            this.Cursor = CustomCursors.loadCursor(CanvasState.CreatingLine);
        }

        private void ToolsCircle_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CanvasState = (int)CanvasState.CreatingCircle;

            this.Cursor = CustomCursors.loadCursor(CanvasState.CreatingCircle);
        }

        private void ToolsTranslate_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CanvasState = (int)CanvasState.Translating;

            this.Cursor = CustomCursors.loadCursor(CanvasState.Translating);
        }

        private void ToolsRotate_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.CanvasState = (int)CanvasState.Rotating;

            this.Cursor = CustomCursors.loadCursor(CanvasState.Rotating); ;
        }

        private void RmoveFigure_Click(object sender, EventArgs e)
        {
            if (CanvasManager.SelectedFigure != null)
            {
                CanvasManager.Figures.Remove(CanvasManager.SelectedFigure);
            }

            Canvas.Invalidate();
        }

        private void ButtonChooseColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();

            colorDialog.ShowDialog();

            if (colorDialog.Color != null)
            {
                ColorPanel.BackColor = colorDialog.Color;

                if(CanvasManager.SelectedFigure != null)
                {
                    CanvasManager.SelectedFigure.Color = colorDialog.Color;

                    Canvas.Invalidate();
                }
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (CanvasManager.Dragging)
            {
                if (CanvasManager.SelectedFigure != null)
                {
                    switch (Properties.Settings.Default.CanvasState)
                    {
                        case (int)CanvasState.Rotating:
                            {

                            }
                            break;

                        case (int)CanvasState.Translating:
                            {
                                CanvasManager.MouseDragging = new Point(e.X - 12, e.Y - 12);
                            }
                            break;
                    }
                }
            }
            else
            {
                CanvasManager.MouseDragging = new Point();

                Status.Text = String.Format("X: {0} Y: {1}", e.X, e.Y);
            }

            if (Properties.Settings.Default.InvalidateOnMove)
            {
                Canvas.Invalidate();
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Drawing.Graphics = e.Graphics;

            foreach (Figure figure in CanvasManager.Figures)
            {
                figure.Draw();
            }

            if (Properties.Settings.Default.InvalidateOnMove && TabControl.SelectedTab == TabCanvas)
            {
                Canvas.Invalidate();
            }
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                CanvasManager.Dragging = true;

                if (Properties.Settings.Default.CanvasState >= 3 || Properties.Settings.Default.CanvasState == 0)
                {
                    CanvasManager.SelectedFigure = null;

                    ColorPanel.BackColor = Color.Black;

                    CanvasManager.Figures.Where(i => i.Selected == true).ToList().ForEach(i => i.Selected = false);

                    ScaleFactor.Value = 10;

                    foreach (Figure figure in CanvasManager.Figures.Reverse<Figure>())
                    {
                        if (CanvasManager.inArea(figure, e.Location) == true)
                        {
                            figure.Selected = true;
                            figure.MouseClick = e.Location;
                            CanvasManager.SelectedFigure = figure;
                            ScaleFactor.Value = (int)(figure.ScaleFactor * 10);
                            ColorPanel.BackColor = figure.Color;
                            break;
                        }
                    }
                }
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                resetCanvasState();
            }
            else if (e.Button == MouseButtons.Left)
            {
                CanvasManager.Dragging = false;

                switch (Properties.Settings.Default.CanvasState)
                {
                    case (int)CanvasState.Translating:
                        {
                            if (CanvasManager.SelectedFigure != null && CanvasManager.MouseDragging.X != 0 && CanvasManager.MouseDragging.Y != 0)
                            {
                                CanvasManager.SelectedFigure.onTranslate(e.Location);
                            }
                        }
                        break;

                    case (int)CanvasState.Rotating:
                        {
                            if (CanvasManager.SelectedFigure != null)
                            {
                                CanvasManager.SelectedFigure.onRotate((double)RotationFactor.Value);
                            }
                        }
                        break;

                    case (int)CanvasState.CreatingLine:
                        {
                            if (CanvasManager.FirstPointPlaced == false)
                            {
                                CanvasManager.NewFigure = new Line(e.Location, ColorPanel.BackColor, (float)ScaleFactor.Value / 10);

                                CanvasManager.FirstPointPlaced = true;
                            }
                            else
                            {
                                ((Line)CanvasManager.NewFigure).B = e.Location;

                                CanvasManager.Figures.Add(CanvasManager.NewFigure);

                                resetCanvasState();
                            }
                        }
                        break;

                    case (int)CanvasState.CreatingCircle:
                        {
                            if (CanvasManager.FirstPointPlaced == false)
                            {
                                CanvasManager.NewFigure = new Circle(e.Location, ColorPanel.BackColor, (float)ScaleFactor.Value / 10);

                                CanvasManager.FirstPointPlaced = true;
                            }
                            else
                            {
                                ((Circle)CanvasManager.NewFigure).Radius = CanvasManager.Distance(((Circle)CanvasManager.NewFigure).Center, e.Location);

                                CanvasManager.Figures.Add(CanvasManager.NewFigure);

                                resetCanvasState();
                            }
                        }
                        break;
                }
            }

            Canvas.Invalidate();
        }

        private void FrmMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && Properties.Settings.Default.CanvasState != (int)CanvasState.None)
            {
                resetCanvasState();
            }
        }

        private void ScaleFactor_ValueChanged(object sender, EventArgs e)
        {
            Scale.Text = String.Format("Escala({0}x)", (double)ScaleFactor.Value / 10);

            if (CanvasManager.SelectedFigure != null)
            {
                CanvasManager.SelectedFigure.onScaleChanged((float)ScaleFactor.Value / 10);
            }

            Canvas.Invalidate();
        }

        private void RotationFactor_ValueChanged(object sender, EventArgs e)
        {
            DegreesLabel.Text = String.Format("Graus {0}º", RotationFactor.Value);
        }

        #endregion

        #region TabSettings

        private void RadioButtonDDA_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UseDDA = RadioButtonDDA.Checked;
        }

        private void CheckDoubleBuffering_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.UseDoubleBuffering = CheckDoubleBuffering.Checked;

            Type controlType = Canvas.GetType();
            PropertyInfo pi = controlType.GetProperty("DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(Canvas, CheckDoubleBuffering.Checked, null);

        }

        private void CheckUpdateCanvasOnMouseMove_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.InvalidateOnMove = CheckUpdateCanvasOnMouseMove.Checked;
        }

        #endregion

        #region TabAbout

        #endregion

        #endregion

        #region Methods

        private void resetCanvasState()
        {
            if (CanvasManager.FirstPointPlaced)
            {
                CanvasManager.FirstPointPlaced = false;
                CanvasManager.NewFigure = null;
            }

            this.Cursor = CustomCursors.loadCursor(CanvasState.None);

            Properties.Settings.Default.CanvasState = (int)CanvasState.None;
        }

        #endregion
    }
}
