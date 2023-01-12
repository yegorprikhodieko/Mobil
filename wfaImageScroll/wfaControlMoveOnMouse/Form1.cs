using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wfaControlMoveOnMouse
{
    public partial class Form1 : Form
    {
        private Point startPoint;

        public Form1()
        {
            InitializeComponent();

            panel1.MouseDown += MouseDown; ;
            panel2.MouseDown += MouseDown; ;
            pictureBox1.MouseDown += MouseDown; ;

            panel1.MouseMove += MouseMove;
            panel2.MouseMove += MouseMove;
            pictureBox1.MouseMove += MouseMove;

            panel1.MouseWheel += MouseWheel;
            panel2.MouseWheel += MouseWheel;
            pictureBox1.MouseWheel += MouseWheel;
        }

        private void MouseWheel(object? sender, MouseEventArgs e)
        {
            int xDelta = e.Delta > 0 ? 2 : -2;
            if (sender is Control c)
            {
                c.Location = new Point(
                        c.Location.X - xDelta,
                        c.Location.Y - xDelta
                    );
                c.Width += xDelta * 2;
                c.Height += xDelta * 2;

            }
        }

        private void MouseMove(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (sender is Control c)
                {
                    c.Location = new Point(
                        c.Location.X + e.X - startPoint.X,
                        c.Location.Y + e.Y - startPoint.Y
                        );
                }
            }
        }

        private void MouseDown(object? sender, MouseEventArgs e)
        {
            startPoint = e.Location;

            if (sender is Control c)
            {
                c.BringToFront(); // перенос на передний план
            }
        }
    }
}
