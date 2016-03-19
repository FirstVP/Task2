namespace Task2
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tsDraw = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRectangle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEllipse = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCircle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSquare = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTriangle = new System.Windows.Forms.ToolStripButton();
            this.tsDraw.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Location = new System.Drawing.Point(3, 28);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(694, 544);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseDown);
            this.pnlMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseMove);
            this.pnlMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseUp);
            // 
            // tsDraw
            // 
            this.tsDraw.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRectangle,
            this.toolStripButtonEllipse,
            this.toolStripButtonLine,
            this.toolStripButtonCircle,
            this.toolStripButtonSquare,
            this.toolStripButtonTriangle});
            this.tsDraw.Location = new System.Drawing.Point(0, 0);
            this.tsDraw.Name = "tsDraw";
            this.tsDraw.Size = new System.Drawing.Size(697, 25);
            this.tsDraw.TabIndex = 2;
            this.tsDraw.Text = "tsDraw";
            // 
            // toolStripButtonRectangle
            // 
            this.toolStripButtonRectangle.Image = global::Task2.Properties.Resources.drawrect;
            this.toolStripButtonRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRectangle.Name = "toolStripButtonRectangle";
            this.toolStripButtonRectangle.Size = new System.Drawing.Size(79, 22);
            this.toolStripButtonRectangle.Text = "Rectangle";
            this.toolStripButtonRectangle.Click += new System.EventHandler(this.toolStripButtonRectangle_Click);
            // 
            // toolStripButtonEllipse
            // 
            this.toolStripButtonEllipse.Image = global::Task2.Properties.Resources.drawellip;
            this.toolStripButtonEllipse.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEllipse.Name = "toolStripButtonEllipse";
            this.toolStripButtonEllipse.Size = new System.Drawing.Size(60, 22);
            this.toolStripButtonEllipse.Text = "Ellipse";
            this.toolStripButtonEllipse.Click += new System.EventHandler(this.toolStripButtonEllipse_Click);
            // 
            // toolStripButtonLine
            // 
            this.toolStripButtonLine.Image = global::Task2.Properties.Resources.line;
            this.toolStripButtonLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonLine.Name = "toolStripButtonLine";
            this.toolStripButtonLine.Size = new System.Drawing.Size(49, 22);
            this.toolStripButtonLine.Text = "Line";
            this.toolStripButtonLine.Click += new System.EventHandler(this.toolStripButtonLine_Click);
            // 
            // toolStripButtonCircle
            // 
            this.toolStripButtonCircle.Image = global::Task2.Properties.Resources.drawellip;
            this.toolStripButtonCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCircle.Name = "toolStripButtonCircle";
            this.toolStripButtonCircle.Size = new System.Drawing.Size(57, 22);
            this.toolStripButtonCircle.Text = "Circle";
            this.toolStripButtonCircle.Click += new System.EventHandler(this.toolStripButtonCircle_Click);
            // 
            // toolStripButtonSquare
            // 
            this.toolStripButtonSquare.Image = global::Task2.Properties.Resources.drawrect;
            this.toolStripButtonSquare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSquare.Name = "toolStripButtonSquare";
            this.toolStripButtonSquare.Size = new System.Drawing.Size(63, 22);
            this.toolStripButtonSquare.Text = "Square";
            this.toolStripButtonSquare.Click += new System.EventHandler(this.toolStripButtonSquare_Click);
            // 
            // toolStripButtonTriangle
            // 
            this.toolStripButtonTriangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonTriangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTriangle.Name = "toolStripButtonTriangle";
            this.toolStripButtonTriangle.Size = new System.Drawing.Size(54, 22);
            this.toolStripButtonTriangle.Text = "Triangle";
            this.toolStripButtonTriangle.Click += new System.EventHandler(this.toolStripButtonTriangle_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(697, 573);
            this.Controls.Add(this.tsDraw);
            this.Controls.Add(this.pnlMain);
            this.Name = "MainForm";
            this.Text = "Окно демонстрации";
            this.tsDraw.ResumeLayout(false);
            this.tsDraw.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.ToolStrip tsDraw;
        private System.Windows.Forms.ToolStripButton toolStripButtonRectangle;
        private System.Windows.Forms.ToolStripButton toolStripButtonEllipse;
        private System.Windows.Forms.ToolStripButton toolStripButtonLine;
        private System.Windows.Forms.ToolStripButton toolStripButtonCircle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSquare;
        private System.Windows.Forms.ToolStripButton toolStripButtonTriangle;

    }
}

