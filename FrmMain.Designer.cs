namespace MiPaint
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.TabCanvas = new System.Windows.Forms.TabPage();
            this.RotationFactor = new System.Windows.Forms.TrackBar();
            this.DegreesLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RmoveFigure = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ButtonChooseColor = new MaterialSkin.Controls.MaterialRaisedButton();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.ScaleFactor = new System.Windows.Forms.TrackBar();
            this.Scale = new MaterialSkin.Controls.MaterialLabel();
            this.ToolsRotate = new System.Windows.Forms.Button();
            this.ToolsTranslate = new System.Windows.Forms.Button();
            this.ToolsCircle = new System.Windows.Forms.Button();
            this.ToolsLine = new System.Windows.Forms.Button();
            this.Status = new MaterialSkin.Controls.MaterialLabel();
            this.Canvas = new System.Windows.Forms.Panel();
            this.TabSettings = new System.Windows.Forms.TabPage();
            this.CheckDoubleBuffering = new MaterialSkin.Controls.MaterialCheckBox();
            this.CheckUpdateCanvasOnMouseMove = new MaterialSkin.Controls.MaterialCheckBox();
            this.RadioButtonBresenham = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadioButtonDDA = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TabAbout = new System.Windows.Forms.TabPage();
            this.AboutLabel = new MaterialSkin.Controls.MaterialLabel();
            this.TabControl.SuspendLayout();
            this.TabCanvas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotationFactor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleFactor)).BeginInit();
            this.TabSettings.SuspendLayout();
            this.TabAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialTabSelector1.BaseTabControl = this.TabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 64);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(740, 48);
            this.materialTabSelector1.TabIndex = 19;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.TabCanvas);
            this.TabControl.Controls.Add(this.TabSettings);
            this.TabControl.Controls.Add(this.TabAbout);
            this.TabControl.Depth = 0;
            this.TabControl.Location = new System.Drawing.Point(0, 111);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(740, 449);
            this.TabControl.TabIndex = 20;
            // 
            // TabCanvas
            // 
            this.TabCanvas.BackColor = System.Drawing.Color.White;
            this.TabCanvas.Controls.Add(this.RotationFactor);
            this.TabCanvas.Controls.Add(this.DegreesLabel);
            this.TabCanvas.Controls.Add(this.RmoveFigure);
            this.TabCanvas.Controls.Add(this.ButtonChooseColor);
            this.TabCanvas.Controls.Add(this.ColorPanel);
            this.TabCanvas.Controls.Add(this.ScaleFactor);
            this.TabCanvas.Controls.Add(this.Scale);
            this.TabCanvas.Controls.Add(this.ToolsRotate);
            this.TabCanvas.Controls.Add(this.ToolsTranslate);
            this.TabCanvas.Controls.Add(this.ToolsCircle);
            this.TabCanvas.Controls.Add(this.ToolsLine);
            this.TabCanvas.Controls.Add(this.Status);
            this.TabCanvas.Controls.Add(this.Canvas);
            this.TabCanvas.Location = new System.Drawing.Point(4, 22);
            this.TabCanvas.Name = "TabCanvas";
            this.TabCanvas.Padding = new System.Windows.Forms.Padding(3);
            this.TabCanvas.Size = new System.Drawing.Size(732, 423);
            this.TabCanvas.TabIndex = 0;
            this.TabCanvas.Text = "Canvas";
            // 
            // RotationFactor
            // 
            this.RotationFactor.LargeChange = 10;
            this.RotationFactor.Location = new System.Drawing.Point(6, 228);
            this.RotationFactor.Maximum = 180;
            this.RotationFactor.Minimum = 1;
            this.RotationFactor.Name = "RotationFactor";
            this.RotationFactor.Size = new System.Drawing.Size(134, 45);
            this.RotationFactor.TabIndex = 16;
            this.RotationFactor.Value = 10;
            this.RotationFactor.ValueChanged += new System.EventHandler(this.RotationFactor_ValueChanged);
            // 
            // DegreesLabel
            // 
            this.DegreesLabel.AutoSize = true;
            this.DegreesLabel.Depth = 0;
            this.DegreesLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.DegreesLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DegreesLabel.Location = new System.Drawing.Point(6, 206);
            this.DegreesLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.DegreesLabel.Name = "DegreesLabel";
            this.DegreesLabel.Size = new System.Drawing.Size(67, 19);
            this.DegreesLabel.TabIndex = 15;
            this.DegreesLabel.Text = "Graus 0º";
            // 
            // RmoveFigure
            // 
            this.RmoveFigure.AutoSize = true;
            this.RmoveFigure.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RmoveFigure.Depth = 0;
            this.RmoveFigure.Icon = null;
            this.RmoveFigure.Location = new System.Drawing.Point(5, 274);
            this.RmoveFigure.MaximumSize = new System.Drawing.Size(135, 36);
            this.RmoveFigure.MinimumSize = new System.Drawing.Size(135, 36);
            this.RmoveFigure.MouseState = MaterialSkin.MouseState.HOVER;
            this.RmoveFigure.Name = "RmoveFigure";
            this.RmoveFigure.Primary = true;
            this.RmoveFigure.Size = new System.Drawing.Size(135, 36);
            this.RmoveFigure.TabIndex = 14;
            this.RmoveFigure.Text = "Remover Figura";
            this.RmoveFigure.UseVisualStyleBackColor = true;
            this.RmoveFigure.Click += new System.EventHandler(this.RmoveFigure_Click);
            // 
            // ButtonChooseColor
            // 
            this.ButtonChooseColor.AutoSize = true;
            this.ButtonChooseColor.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonChooseColor.Depth = 0;
            this.ButtonChooseColor.Icon = null;
            this.ButtonChooseColor.Location = new System.Drawing.Point(5, 316);
            this.ButtonChooseColor.MinimumSize = new System.Drawing.Size(134, 36);
            this.ButtonChooseColor.MouseState = MaterialSkin.MouseState.HOVER;
            this.ButtonChooseColor.Name = "ButtonChooseColor";
            this.ButtonChooseColor.Primary = true;
            this.ButtonChooseColor.Size = new System.Drawing.Size(134, 36);
            this.ButtonChooseColor.TabIndex = 13;
            this.ButtonChooseColor.Text = "Escolher Cor";
            this.ButtonChooseColor.UseVisualStyleBackColor = true;
            this.ButtonChooseColor.Click += new System.EventHandler(this.ButtonChooseColor_Click);
            // 
            // ColorPanel
            // 
            this.ColorPanel.BackColor = System.Drawing.Color.Black;
            this.ColorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ColorPanel.Location = new System.Drawing.Point(5, 358);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(134, 39);
            this.ColorPanel.TabIndex = 11;
            // 
            // ScaleFactor
            // 
            this.ScaleFactor.LargeChange = 1;
            this.ScaleFactor.Location = new System.Drawing.Point(6, 167);
            this.ScaleFactor.Maximum = 20;
            this.ScaleFactor.Minimum = 5;
            this.ScaleFactor.Name = "ScaleFactor";
            this.ScaleFactor.Size = new System.Drawing.Size(134, 45);
            this.ScaleFactor.TabIndex = 10;
            this.ScaleFactor.Value = 10;
            this.ScaleFactor.ValueChanged += new System.EventHandler(this.ScaleFactor_ValueChanged);
            // 
            // Scale
            // 
            this.Scale.AutoSize = true;
            this.Scale.Depth = 0;
            this.Scale.Font = new System.Drawing.Font("Roboto", 11F);
            this.Scale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Scale.Location = new System.Drawing.Point(6, 145);
            this.Scale.MouseState = MaterialSkin.MouseState.HOVER;
            this.Scale.Name = "Scale";
            this.Scale.Size = new System.Drawing.Size(79, 19);
            this.Scale.TabIndex = 9;
            this.Scale.Text = "Escala(1x)";
            // 
            // ToolsRotate
            // 
            this.ToolsRotate.BackColor = System.Drawing.Color.Transparent;
            this.ToolsRotate.BackgroundImage = global::MiPaint.Properties.Resources.rotate_to_right_button;
            this.ToolsRotate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToolsRotate.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ToolsRotate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolsRotate.Location = new System.Drawing.Point(76, 76);
            this.ToolsRotate.Name = "ToolsRotate";
            this.ToolsRotate.Size = new System.Drawing.Size(64, 64);
            this.ToolsRotate.TabIndex = 8;
            this.ToolsRotate.UseVisualStyleBackColor = false;
            this.ToolsRotate.Click += new System.EventHandler(this.ToolsRotate_Click);
            // 
            // ToolsTranslate
            // 
            this.ToolsTranslate.BackColor = System.Drawing.Color.Transparent;
            this.ToolsTranslate.BackgroundImage = global::MiPaint.Properties.Resources.move;
            this.ToolsTranslate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToolsTranslate.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ToolsTranslate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolsTranslate.Location = new System.Drawing.Point(6, 76);
            this.ToolsTranslate.Name = "ToolsTranslate";
            this.ToolsTranslate.Size = new System.Drawing.Size(64, 64);
            this.ToolsTranslate.TabIndex = 7;
            this.ToolsTranslate.UseVisualStyleBackColor = false;
            this.ToolsTranslate.Click += new System.EventHandler(this.ToolsTranslate_Click);
            // 
            // ToolsCircle
            // 
            this.ToolsCircle.BackColor = System.Drawing.Color.Transparent;
            this.ToolsCircle.BackgroundImage = global::MiPaint.Properties.Resources.dashed_circle;
            this.ToolsCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToolsCircle.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ToolsCircle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolsCircle.Location = new System.Drawing.Point(76, 6);
            this.ToolsCircle.Name = "ToolsCircle";
            this.ToolsCircle.Size = new System.Drawing.Size(64, 64);
            this.ToolsCircle.TabIndex = 6;
            this.ToolsCircle.UseVisualStyleBackColor = false;
            this.ToolsCircle.Click += new System.EventHandler(this.ToolsCircle_Click);
            // 
            // ToolsLine
            // 
            this.ToolsLine.BackColor = System.Drawing.Color.Transparent;
            this.ToolsLine.BackgroundImage = global::MiPaint.Properties.Resources.dashed_line;
            this.ToolsLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ToolsLine.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.ToolsLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ToolsLine.Location = new System.Drawing.Point(6, 6);
            this.ToolsLine.Name = "ToolsLine";
            this.ToolsLine.Size = new System.Drawing.Size(64, 64);
            this.ToolsLine.TabIndex = 5;
            this.ToolsLine.UseVisualStyleBackColor = false;
            this.ToolsLine.Click += new System.EventHandler(this.ToolsLine_Click);
            // 
            // Status
            // 
            this.Status.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Status.AutoSize = true;
            this.Status.Depth = 0;
            this.Status.Font = new System.Drawing.Font("Roboto", 11F);
            this.Status.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Status.Location = new System.Drawing.Point(142, 401);
            this.Status.MouseState = MaterialSkin.MouseState.HOVER;
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(72, 19);
            this.Status.TabIndex = 2;
            this.Status.Text = "Status: ...";
            // 
            // Canvas
            // 
            this.Canvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Canvas.BackColor = System.Drawing.Color.White;
            this.Canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Canvas.Location = new System.Drawing.Point(146, 6);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(580, 391);
            this.Canvas.TabIndex = 0;
            this.Canvas.Paint += new System.Windows.Forms.PaintEventHandler(this.Canvas_Paint);
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // TabSettings
            // 
            this.TabSettings.BackColor = System.Drawing.Color.White;
            this.TabSettings.Controls.Add(this.CheckDoubleBuffering);
            this.TabSettings.Controls.Add(this.CheckUpdateCanvasOnMouseMove);
            this.TabSettings.Controls.Add(this.RadioButtonBresenham);
            this.TabSettings.Controls.Add(this.RadioButtonDDA);
            this.TabSettings.Controls.Add(this.materialLabel1);
            this.TabSettings.Location = new System.Drawing.Point(4, 22);
            this.TabSettings.Name = "TabSettings";
            this.TabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.TabSettings.Size = new System.Drawing.Size(732, 423);
            this.TabSettings.TabIndex = 1;
            this.TabSettings.Text = "Configurações";
            // 
            // CheckDoubleBuffering
            // 
            this.CheckDoubleBuffering.AutoSize = true;
            this.CheckDoubleBuffering.Depth = 0;
            this.CheckDoubleBuffering.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckDoubleBuffering.Location = new System.Drawing.Point(10, 138);
            this.CheckDoubleBuffering.Margin = new System.Windows.Forms.Padding(0);
            this.CheckDoubleBuffering.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckDoubleBuffering.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckDoubleBuffering.Name = "CheckDoubleBuffering";
            this.CheckDoubleBuffering.Ripple = true;
            this.CheckDoubleBuffering.Size = new System.Drawing.Size(229, 30);
            this.CheckDoubleBuffering.TabIndex = 4;
            this.CheckDoubleBuffering.Text = "Usar double buffering no canvas";
            this.CheckDoubleBuffering.UseVisualStyleBackColor = true;
            this.CheckDoubleBuffering.CheckedChanged += new System.EventHandler(this.CheckDoubleBuffering_CheckedChanged);
            // 
            // CheckUpdateCanvasOnMouseMove
            // 
            this.CheckUpdateCanvasOnMouseMove.AutoSize = true;
            this.CheckUpdateCanvasOnMouseMove.Depth = 0;
            this.CheckUpdateCanvasOnMouseMove.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckUpdateCanvasOnMouseMove.Location = new System.Drawing.Point(10, 108);
            this.CheckUpdateCanvasOnMouseMove.Margin = new System.Windows.Forms.Padding(0);
            this.CheckUpdateCanvasOnMouseMove.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckUpdateCanvasOnMouseMove.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckUpdateCanvasOnMouseMove.Name = "CheckUpdateCanvasOnMouseMove";
            this.CheckUpdateCanvasOnMouseMove.Ripple = true;
            this.CheckUpdateCanvasOnMouseMove.Size = new System.Drawing.Size(474, 30);
            this.CheckUpdateCanvasOnMouseMove.TabIndex = 3;
            this.CheckUpdateCanvasOnMouseMove.Text = "Atualizar canvas a cada frame (Recomendado ativar o Double Buffering)";
            this.CheckUpdateCanvasOnMouseMove.UseVisualStyleBackColor = true;
            this.CheckUpdateCanvasOnMouseMove.CheckedChanged += new System.EventHandler(this.CheckUpdateCanvasOnMouseMove_CheckedChanged);
            // 
            // RadioButtonBresenham
            // 
            this.RadioButtonBresenham.AutoSize = true;
            this.RadioButtonBresenham.Checked = true;
            this.RadioButtonBresenham.Depth = 0;
            this.RadioButtonBresenham.Font = new System.Drawing.Font("Roboto", 10F);
            this.RadioButtonBresenham.Location = new System.Drawing.Point(10, 67);
            this.RadioButtonBresenham.Margin = new System.Windows.Forms.Padding(0);
            this.RadioButtonBresenham.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadioButtonBresenham.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadioButtonBresenham.Name = "RadioButtonBresenham";
            this.RadioButtonBresenham.Ripple = true;
            this.RadioButtonBresenham.Size = new System.Drawing.Size(99, 30);
            this.RadioButtonBresenham.TabIndex = 2;
            this.RadioButtonBresenham.TabStop = true;
            this.RadioButtonBresenham.Text = "Bresenham";
            this.RadioButtonBresenham.UseVisualStyleBackColor = true;
            // 
            // RadioButtonDDA
            // 
            this.RadioButtonDDA.AutoSize = true;
            this.RadioButtonDDA.Depth = 0;
            this.RadioButtonDDA.Font = new System.Drawing.Font("Roboto", 10F);
            this.RadioButtonDDA.Location = new System.Drawing.Point(10, 37);
            this.RadioButtonDDA.Margin = new System.Windows.Forms.Padding(0);
            this.RadioButtonDDA.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadioButtonDDA.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadioButtonDDA.Name = "RadioButtonDDA";
            this.RadioButtonDDA.Ripple = true;
            this.RadioButtonDDA.Size = new System.Drawing.Size(241, 30);
            this.RadioButtonDDA.TabIndex = 1;
            this.RadioButtonDDA.Text = "DDA( Digital Differential Analyser )";
            this.RadioButtonDDA.UseVisualStyleBackColor = true;
            this.RadioButtonDDA.CheckedChanged += new System.EventHandler(this.RadioButtonDDA_CheckedChanged);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(6, 12);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(197, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Técnica de desenho da reta:";
            // 
            // TabAbout
            // 
            this.TabAbout.BackColor = System.Drawing.Color.White;
            this.TabAbout.Controls.Add(this.AboutLabel);
            this.TabAbout.Location = new System.Drawing.Point(4, 22);
            this.TabAbout.Name = "TabAbout";
            this.TabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.TabAbout.Size = new System.Drawing.Size(732, 423);
            this.TabAbout.TabIndex = 2;
            this.TabAbout.Text = "Sobre";
            // 
            // AboutLabel
            // 
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.Depth = 0;
            this.AboutLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.AboutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AboutLabel.Location = new System.Drawing.Point(8, 15);
            this.AboutLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(433, 171);
            this.AboutLabel.TabIndex = 0;
            this.AboutLabel.Text = "μPaint, V1.0\r\n\r\nCriado por Pedro Ferreira Glenadel Pereira, 2017.\r\n\r\nUtilizado o " +
    "MaterialSkin para elaboração do tema do programa.\r\n\r\nLink:\r\n\r\nhttps://github.com" +
    "/IgnaceMaes/MaterialSkin";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 560);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.TabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "μPaint";
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FrmMain_MouseClick);
            this.TabControl.ResumeLayout(false);
            this.TabCanvas.ResumeLayout(false);
            this.TabCanvas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RotationFactor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScaleFactor)).EndInit();
            this.TabSettings.ResumeLayout(false);
            this.TabSettings.PerformLayout();
            this.TabAbout.ResumeLayout(false);
            this.TabAbout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage TabCanvas;
        private System.Windows.Forms.TabPage TabSettings;
        private System.Windows.Forms.TabPage TabAbout;
        private MaterialSkin.Controls.MaterialLabel Status;
        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.Button ToolsLine;
        private System.Windows.Forms.Button ToolsCircle;
        private System.Windows.Forms.Button ToolsRotate;
        private System.Windows.Forms.Button ToolsTranslate;
        private System.Windows.Forms.TrackBar ScaleFactor;
        private MaterialSkin.Controls.MaterialLabel Scale;
        private MaterialSkin.Controls.MaterialRadioButton RadioButtonBresenham;
        private MaterialSkin.Controls.MaterialRadioButton RadioButtonDDA;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialRaisedButton ButtonChooseColor;
        private System.Windows.Forms.Panel ColorPanel;
        private MaterialSkin.Controls.MaterialRaisedButton RmoveFigure;
        private MaterialSkin.Controls.MaterialLabel AboutLabel;
        private MaterialSkin.Controls.MaterialCheckBox CheckDoubleBuffering;
        private MaterialSkin.Controls.MaterialCheckBox CheckUpdateCanvasOnMouseMove;
        private System.Windows.Forms.TrackBar RotationFactor;
        private MaterialSkin.Controls.MaterialLabel DegreesLabel;
    }
}

