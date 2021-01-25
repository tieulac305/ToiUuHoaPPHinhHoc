using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToiUuHoaHinhHoc
{
    internal class Bound
    {
        public Label lbl { get; set; }
        public TextBox a1 { get; set; }
        public TextBox a2 { get; set; }
        public TextBox b { get; set; }
        public int posx { get; set; }
        public int posy { get; set; }

        public Bound(int posx, int posy, String s) {
            this.posx = posx;
            this.posy = posy;
            lbl = new Label();
            if (s.Equals("max")) {
                lbl.Text = "       x1 +        x2 <=";
            }
            else {
                lbl.Text = "       x1 +        x2 >=";
            }
            lbl.Location = new System.Drawing.Point(posx, posy);
            lbl.AutoSize = true;
            a1 = new TextBox();
            a1.Location = new System.Drawing.Point(posx, posy - 2);
            a1.Size = new System.Drawing.Size(63, 26);
            a2 = new TextBox();
            a2.Location = new System.Drawing.Point(posx + 110, posy - 2);
            a2.Size = new System.Drawing.Size(63, 26);
            b = new TextBox();
            b.Location = new System.Drawing.Point(posx + 220, posy - 2);
            b.Size = new System.Drawing.Size(63, 26);
        }

        public void changeType(String s) {
            if (s.Equals("max")) {
                lbl.Text = "       x1 +        x2 <=";
            }
            else {
                lbl.Text = "       x1 +        x2 >=";
            }
        }

        public Line getLine() {
            float aa = float.Parse(a1.Text);
            float bb = float.Parse(a2.Text);
            float cc = float.Parse(b.Text);
            return new Line(aa, bb, -cc);
        }

        public bool check() {
            return float.TryParse(a1.Text, out float a) && float.TryParse(a2.Text, out a) && float.TryParse(b.Text, out a);
        }
    }
}