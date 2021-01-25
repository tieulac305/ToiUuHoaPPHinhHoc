using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ToiUuHoaHinhHoc
{
    public partial class ToiUu : Form
    {
        public ToiUu() {
            InitializeComponent();
            List<String> val = new List<String> { "max", "min" };
            mm.DataSource = val;
            mm.DropDownStyle = ComboBoxStyle.DropDownList;
            Controls.Add(scroll);
        }

        private void sol_Click(object sender, EventArgs e) {
            //lấy các giá trị
            probar.Visible = true;
            probar.Value = 0;
            float c1, c2, a11, a12, a21, a22, b1, b2;
            try {
                c1 = float.Parse(txtc1.Text);
                c2 = float.Parse(txtc2.Text);
                a11 = float.Parse(txta11.Text);
                a12 = float.Parse(txta12.Text);
                a21 = float.Parse(txta21.Text);
                a22 = float.Parse(txta22.Text);
                b1 = float.Parse(txtb1.Text);
                b2 = float.Parse(txtb2.Text);
            }
            catch (Exception) {
                MessageBox.Show("Vui lòng nhập đúng các thông tin.", "Thông báo");
                return;
            }
            probar.Value = 20;

            // tính toán
            List<PointF> crossPoints = new List<PointF>();
            List<PointF> boundPoints = new List<PointF>();
            List<PointF> points = new List<PointF>();

            // thêm các điểm giao nhau
            List<Line> lines = new List<Line>();
            lines.Add(new Line(a11, a12, -b1));
            lines.Add(new Line(a21, a22, -b2));
            lines.Add(new Line(0, 1, 0));
            lines.Add(new Line(1, 0, 0));

            float maxx = 0, maxy = 0;
            for (int i = 0; i < lines.Count; i++) {
                for (int j = i + 1; j < lines.Count; j++) {
                    PointF tmp = Line.findIntersect(lines[i], lines[j]);
                    if (tmp.X > -1 && tmp.Y > -1) crossPoints.Add(tmp);
                    maxx = Math.Max(maxx, tmp.X);
                    maxy = Math.Max(maxy, tmp.Y);
                }
            }

            maxx += 3;
            maxy += 3;

            // thêm các điểm giao giới hạn trên và phải'
            //window
            float xwmin = -2, ywmin = -2, xwmax = Math.Max(maxx, maxy), ywmax = xwmax;
            List<Line> bounds = new List<Line>();
            bounds.Add(new Line(1, 0, -xwmin));
            bounds.Add(new Line(1, 0, -xwmax));
            bounds.Add(new Line(0, 1, -ywmin));
            bounds.Add(new Line(0, 1, -ywmax));
            for (int i = 0; i < lines.Count; i++) {
                for (int j = 0; j < 4; j++) {
                    PointF tmp = Line.findIntersect(lines[i], bounds[j]);
                    if (tmp.X != -1 || tmp.Y != -1) boundPoints.Add(tmp);
                }
            }
            // lấy các điểm giao nhau thỏa mãn
            bool isMax = mm.SelectedValue.ToString().Equals("max");
            //MessageBox.Show("Test: " + isMax);
            float eps = 0.001f;
            if (isMax) {
                // <=
                foreach (PointF p in boundPoints) {
                    bool canGet = true;
                    if (p.X < 0 || p.Y < 0) {
                        canGet = false;
                    }
                    for (int i = 0; i < lines.Count - 2; i++) {
                        if (lines[i].f(p) > eps) {
                            canGet = false;
                            break;
                        }
                    }
                    if (canGet) points.Add(p);
                }
                foreach (PointF p in crossPoints) {
                    bool canGet = true;
                    if (p.X < 0 || p.Y < 0) {
                        canGet = false;
                    }
                    for (int i = 0; i < lines.Count - 2; i++) {
                        if (lines[i].f(p) > eps) {
                            canGet = false;
                            break;
                        }
                    }
                    if (canGet) points.Add(p);
                }
            }
            else {
                // all >=
                foreach (PointF p in boundPoints) {
                    bool canGet = true;
                    if (p.X < 0 || p.Y < 0) {
                        canGet = false;
                    }
                    for (int i = 0; i < lines.Count - 2; i++) {
                        if (lines[i].f(p) < -eps) {
                            canGet = false;
                            break;
                        }
                    }
                    if (canGet) points.Add(p);
                }
                foreach (PointF p in crossPoints) {
                    bool canGet = true;
                    if (p.X < 0 || p.Y < 0) {
                        canGet = false;
                    }
                    for (int i = 0; i < lines.Count - 2; i++) {
                        if (lines[i].f(p) < -eps) {
                            canGet = false;
                            break;
                        }
                    }
                    if (canGet) points.Add(p);
                }
            }
            probar.Value = 40;

            //tìm điểm tối ưu
            Line def = new Line(c1, c2, 0);
            float ansValue = 0;
            PointF ansPoint = new PointF(0, 0);

            if (isMax) {
                ansValue = -1000000;
                foreach (PointF p in points) {
                    float tmp = def.f(p);
                    if (tmp > ansValue) {
                        ansValue = tmp;
                        ansPoint = p;
                    }
                }
            }
            else {
                ansValue = 1000000;
                foreach (PointF p in points) {
                    float tmp = def.f(p);
                    if (tmp < ansValue) {
                        ansValue = tmp;
                        ansPoint = p;
                    }
                }
            }
            bool isOk = true;
            if (points.Count == 0 || boundPoints.Contains(ansPoint)) isOk = false;

            if (isOk)
                ans.Text = "Điểm tối ưu là (" + ansPoint.X + " , " + ansPoint.Y + ")\n với giá trị hàm mục tiêu: " + ansValue;
            else
                ans.Text = "Không có lời giải tối ưu cho bài toán.";
            probar.Value = 60;

            //vẽ
            //xây dựng hệ tọa độ
            float xvmin = 0, yvmin = 0, xvmax = 420, yvmax = 420;
            float tlx, tly;
            tlx = (xvmax - xvmin) / (xwmax - xwmin);
            tly = (yvmax - yvmin) / (ywmax - ywmin);

            Graphics surface = paintArea.CreateGraphics();

            PointF ConvertPoint(PointF p) {
                float xm = tlx * (p.X - xwmin) + xvmin;
                float ym = tly * (ywmax - p.Y) + yvmin;
                return new PointF(xm, ym);
            }

            //vẽ các đường thẳng cần thiết
            Pen blackPen = new Pen(Color.Black, 2);
            Pen bluePen = new Pen(Color.Blue, 3);
            for (int i = 0; i < boundPoints.Count; i += 2) {
                if (i < boundPoints.Count - 4)
                    surface.DrawLine(bluePen, ConvertPoint(boundPoints[i]), ConvertPoint(boundPoints[i + 1]));
                else
                    surface.DrawLine(blackPen, ConvertPoint(boundPoints[i]), ConvertPoint(boundPoints[i + 1]));
            }
            // surface.DrawLine(blackPen, );
            probar.Value = 80;

            // vẽ vùng được chọn
            List<PointF> drawPoints = new List<PointF>();
            SolidBrush blueBrush = new SolidBrush(Color.Aquamarine);

            foreach (PointF p in points) {
                drawPoints.Add(ConvertPoint(p));
            }

            //drawPoints = drawPoints.OrderBy(x => Math.Atan2(x.X, x.Y)).ToList();
            //MessageBox.Show("Test: " + points.Count);

            // vẽee
            if (drawPoints.Count > 2) {
                PointF midP = new PointF((drawPoints[0].X + drawPoints[1].X) / 2, (drawPoints[0].Y + drawPoints[1].Y) / 2);
                midP.X = (midP.X + drawPoints[2].X) / 2;
                midP.Y = (midP.Y + drawPoints[2].Y) / 2;

                surface.FillPolygon(blueBrush, drawPoints.OrderBy(x => Math.Atan2(x.X - midP.X, x.Y - midP.Y)).ToArray());
            }
            Pen redPen = new Pen(Color.Red, 8);
            foreach (PointF p in drawPoints) {
                surface.DrawLine(redPen, new PointF(p.X - 4, p.Y), new PointF(p.X + 4, p.Y));
            }
            probar.Value = 100;

            //in ra kết quả
        }

        private void mm_SelectedIndexChanged(object sender, EventArgs e) {
            if (mm.SelectedValue.ToString() == "max") {
                line1.Text = "        x1 +        x2 <=";
                line2.Text = "        x1 +        x2 <=";
            }
            else {
                line1.Text = "        x1 +        x2 >=";
                line2.Text = "        x1 +        x2 >=";
            }
        }
    }
}