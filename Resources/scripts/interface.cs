using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParadoxModLauncher.Resources.scripts
{
    public class TransparentPanel : Panel
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x00000020;
                return cp;
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (Parent != null)
            {
                using (var brush = new SolidBrush(Color.FromArgb(128, BackColor)))
                {
                    e.Graphics.FillRectangle(brush, ClientRectangle);
                }
            }
        }
    }



    public class TransparentLabel : Label
    {
        public TransparentLabel()
        {
            SetStyle(ControlStyles.Opaque, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;
                return cp;
            }
        }
    }

    public class TransparentLinkLabel : LinkLabel
    {
        public TransparentLinkLabel()
        {
            SetStyle(ControlStyles.Opaque, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
            SetStyle(ControlStyles.Opaque, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
            this.LinkBehavior = LinkBehavior.NeverUnderline;
            this.LinkColor = Color.Cyan;
            this.ActiveLinkColor = Color.Red;
        }


        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;
                return cp;
            }
        }


        protected override void OnPaintBackground(PaintEventArgs pevent)
        {

        }
    }
}
