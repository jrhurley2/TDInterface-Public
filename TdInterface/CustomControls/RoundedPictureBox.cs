using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace TdInterface.CustomControls
{
    internal class RoundedPictureBox : PictureBox
    {
        //Constructor
        public RoundedPictureBox()
        {
            this.Size = new Size(100, 100);
            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        //Overridden methods
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Size = new Size(this.Width, this.Width);
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            // Fields
            var graph = pe.Graphics;
            var rectContourSmooth = Rectangle.Inflate(this.ClientRectangle, -1, -1);
            var smoothSize = 1;
            using (var pathRegion = new GraphicsPath())
            using (var penSmooth = new Pen(this.Parent.BackColor, smoothSize))
            {
                graph.SmoothingMode = SmoothingMode.HighQuality;
                pathRegion.AddEllipse(rectContourSmooth);
                this.Region = new Region(pathRegion);

                //Drawing
                graph.DrawEllipse(penSmooth, rectContourSmooth); //Draw contour smoothing
            }
        }
    }
}
