using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TdInterface.CustomControls
{
    internal class RoundedPanel: Panel
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.FillRoundedRectangle(new SolidBrush(this.ForeColor), 5, 5, this.Width - 10, this.Height - 10, 10);
            //g.FillRoundedRectangle(brush, 12, 12, this.Width - 44, this.Height - 44, 10);
            //g.DrawRoundedRectangle(new Pen(ControlPaint.Light(Color.Orange, 0.00f)), 12, 12, this.Width - 44, this.Height - 44, 10);
            //g.FillRoundedRectangle(new SolidBrush(Color.Purple), 12, 12 + ((this.Height - 44) / 2), this.Width - 44, (this.Height - 44) / 2, 10);
            base.OnPaint(e);
        }
    }
}
