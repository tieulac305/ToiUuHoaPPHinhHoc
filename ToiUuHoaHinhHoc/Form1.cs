using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ToiUuHoaHinhHoc
{
    public partial class ToiUu : Form
    {
        private List<Bound> bounds = new List<Bound>();
        private int locatex = 135, locatey = 100;
        private float xwmin, ywmin, xwmax, ywmax;
        private float xvmin, yvmin, xvmax, yvmax;
        private float tlx, tly;

        private List<PointF> crossPoints = new List<PointF>();
        private List<PointF> boundPoints = new List<PointF>();
        private List<PointF> points = new List<PointF>();  // các điểm được chọn
        private List<Line> lines = new List<Line>();
        private List<Line> boundLines = new List<Line>(); // các đường để vẽ

        public ToiUu() {
            InitializeComponent();
            List<String> val = new List<String> { "max", "min" };
            mm.DataSource = val;
            mm.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private PointF ConvertPoint(PointF p) {
            float xm = tlx * (p.X - xwmin) + xvmin;
            float ym = tly * (ywmax - p.Y) + yvmin;
            return new PointF(xm, ym);
        }

        private void showGrid(int mode) {
            if (boundLines.Count == 0) return;
            Graphics surface = paintArea.CreateGraphics();
            Pen grayPen = new Pen(Color.DarkGray, 1);
            SolidBrush wBrush = new SolidBrush(Color.White);
            Point[] pA = new Point[] { new Point(0, 0), new Point(0, 420), new Point(420, 420), new Point(420, 0) };
            surface.FillPolygon(wBrush, pA);

            if (mode == 0) grayPen.Color = Color.White;
            for (int i = -1; i < (int)xwmax; i++) {
                List<PointF> gp = new List<PointF>();
                Line l = new Line(0, 1, -i);
                foreach (Line line in boundLines) {
                    PointF tmp = Line.findIntersect(l, line);
                    if (tmp.X != -1 || tmp.Y != -1) gp.Add(tmp);
                }
                surface.DrawLine(grayPen, ConvertPoint(gp[0]), ConvertPoint(gp[1]));
                l = new Line(1, 0, -i);
                foreach (Line line in boundLines) {
                    PointF tmp = Line.findIntersect(l, line);
                    if (tmp.X != -1 || tmp.Y != -1) gp.Add(tmp);
                }
                surface.DrawLine(grayPen, ConvertPoint(gp[2]), ConvertPoint(gp[3]));
            }
            draw();
        }

        private void sol_Click(object sender, EventArgs e) {
            //lấy các giá trị
            probar.Visible = true;
            probar.Value = 0;

            crossPoints.Clear();
            boundPoints.Clear();
            points.Clear();
            lines.Clear();
            boundLines.Clear();

            bool isMax = mm.SelectedValue.ToString().Equals("max");
            //MessageBox.Show("Test: " + isMax);
            float c1, c2;
            try {
                c1 = float.Parse(txtc1.Text);
                c2 = float.Parse(txtc2.Text);
                foreach (Bound b in bounds) {
                    if (!b.check()) {
                        throw new Exception();
                    }
                }
            }
            catch (Exception) {
                MessageBox.Show("Vui lòng nhập đúng các thông tin.", "Thông báo");
                return;
            }
            probar.Value = 20;

            // tính toán

            // thêm các điểm giao nhau
            foreach (Bound b in bounds) {
                lines.Add(b.getLine(isMax));
            }
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

            // thêm các điểm giao giới hạn trên và phải
            //window
            xwmin = -2; ywmin = -2; xwmax = Math.Max(maxx, maxy); ywmax = xwmax;
            boundLines.Add(new Line(1, 0, -xwmin));
            boundLines.Add(new Line(1, 0, -xwmax));
            boundLines.Add(new Line(0, 1, -ywmin));
            boundLines.Add(new Line(0, 1, -ywmax));
            for (int i = 0; i < lines.Count; i++) {
                for (int j = 0; j < 4; j++) {
                    PointF tmp = Line.findIntersect(lines[i], boundLines[j]);
                    if (tmp.X != -1 || tmp.Y != -1) boundPoints.Add(tmp);
                }
            }
            // lấy các điểm giao nhau thỏa mãn
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
                // >=
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
            probar.Value = 40;

            //vẽ
            showGrid(1);
            int mode;
            if (grid.BackColor.Equals(Color.Lime))
                mode = 1;
            else
                mode = 0;

            showGrid(mode);
        }

        private void draw() {
            //xây dựng hệ tọa độ
            xvmin = 0; yvmin = 0; xvmax = 420; yvmax = 420;
            tlx = (xvmax - xvmin) / (xwmax - xwmin);
            tly = (yvmax - yvmin) / (ywmax - ywmin);

            Graphics surface = paintArea.CreateGraphics();

            //vẽ các đường thẳng cần thiết
            Pen blackPen = new Pen(Color.Black, 2);
            Pen bluePen = new Pen(Color.Blue, 3);
            for (int i = 0; i < boundPoints.Count; i += 2) {
                if (i < boundPoints.Count - 4)
                    surface.DrawLine(bluePen, ConvertPoint(boundPoints[i]), ConvertPoint(boundPoints[i + 1]));
                else
                    surface.DrawLine(blackPen, ConvertPoint(boundPoints[i]), ConvertPoint(boundPoints[i + 1]));
            }
            probar.Value = 60;

            // vẽ vùng được chọn
            List<PointF> drawPoints = new List<PointF>();
            SolidBrush blueBrush = new SolidBrush(Color.Aquamarine);

            foreach (PointF p in points) {
                drawPoints.Add(ConvertPoint(p));
            }

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
        }

        private void restart_Click(object sender, EventArgs e) {
            Application.Restart();
        }

        private void exit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void grid_Click(object sender, EventArgs e) {
            if (grid.BackColor.Equals(Color.Lime)) {
                grid.BackColor = Color.Red;
                showGrid(0);
            }
            else {
                grid.BackColor = Color.Lime;
                showGrid(1);
            }
        }

        private void add_Click(object sender, EventArgs e) {
            Bound b = new Bound(locatex, locatey, "max");
            bounds.Add(b);
            locatey += 35;

            b.showOn(given);
        }
    }
}