using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace superBits
{
    public partial class mainForm : Form
    {
        private Engine eng;

        public mainForm()
        {
            InitializeComponent();
            eng = new Engine();
        }

        private void panelPaintEvent(object sender, PaintEventArgs e)
        {
            var p = sender as Panel;
            var g = e.Graphics;

            var color = System.Drawing.Color.FromArgb(128, 0, 128);
            var pen = new System.Drawing.Pen(color);
            g.DrawRectangle(pen, 20, 40, 100, 200);

            var brush = new System.Drawing.SolidBrush(color);
            g.FillRectangle(brush, 40, 80, 200, 400);




            var bmp = new Bitmap(100, 100, g);
            for (var y = 0; y < bmp.Height; ++y)
                for (var x = 0; x < bmp.Width; ++x)
                    bmp.SetPixel(x, y, Color.FromArgb( 64, 255, 128, 0));

            g.DrawImage(bmp, 0, 0);


        }

        private void keyDownEvent(object sender, KeyEventArgs e)
        {
            if (eng.closeKeys.Contains(e.KeyCode))
                this.Close();
            else if (eng.upKeys.Contains(e.KeyCode))
                eng.moveUp();
            else if (eng.downKeys.Contains(e.KeyCode))
                eng.moveDown();
            else if (eng.leftKeys.Contains(e.KeyCode))
                eng.moveLeft();
            else if (eng.rightKeys.Contains(e.KeyCode))
                eng.moveRight();
            else
                Console.WriteLine("Key down:" + e.KeyData + " (" + e.KeyValue + ")");
        }

        private void keyUpEvent(object sender, KeyEventArgs e)
        {
            //Console.WriteLine("Key up:" + e.KeyData + " (" + e.KeyValue + ")");
        }
    }
}
