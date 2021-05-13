using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Compile
{
    class LeftArrowButton : Button
    {
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            int height = this.Height, width = this.Width;
            Point[] polygon = new Point[]
            {
                new Point(0, height/2),
                new Point(width/3, 0),
                new Point(width/3, height/3),
                new Point(width, height/3),
                new Point(width, (2*height)/3),
                new Point(width/3, (2*height)/3),
                new Point(width/3, height),
                new Point(0,height/2)
            };

            GraphicsPath gp = new GraphicsPath();
            gp.AddPolygon(polygon);
            Pen p = new Pen(this.BackColor);
            pevent.Graphics.DrawPath(p, gp);
        }
    }
}
