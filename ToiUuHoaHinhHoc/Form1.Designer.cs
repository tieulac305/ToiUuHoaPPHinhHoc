namespace ToiUuHoaHinhHoc
{
    partial class ToiUu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.note = new System.Windows.Forms.Label();
            this.probar = new System.Windows.Forms.ProgressBar();
            this.line1 = new System.Windows.Forms.Label();
            this.line2 = new System.Windows.Forms.Label();
            this.txtb1 = new System.Windows.Forms.TextBox();
            this.txta12 = new System.Windows.Forms.TextBox();
            this.txtb2 = new System.Windows.Forms.TextBox();
            this.txta22 = new System.Windows.Forms.TextBox();
            this.txta21 = new System.Windows.Forms.TextBox();
            this.txta11 = new System.Windows.Forms.TextBox();
            this.dk = new System.Windows.Forms.Label();
            this.goal = new System.Windows.Forms.Label();
            this.txtc2 = new System.Windows.Forms.TextBox();
            this.txtc1 = new System.Windows.Forms.TextBox();
            this.sol = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.ans = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.paintArea = new System.Windows.Forms.Panel();
            this.mm = new System.Windows.Forms.ComboBox();
            this.scroll = new System.Windows.Forms.VScrollBar();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.ForeColor = System.Drawing.SystemColors.Highlight;
            this.note.Location = new System.Drawing.Point(12, 9);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(405, 19);
            this.note.TabIndex = 0;
            this.note.Text = "Chú ý khi sử dụng: cần đưa về dạng chuẩn tắc";
            // 
            // probar
            // 
            this.probar.Location = new System.Drawing.Point(16, 210);
            this.probar.Name = "probar";
            this.probar.Size = new System.Drawing.Size(471, 12);
            this.probar.TabIndex = 5;
            this.probar.Visible = false;
            // 
            // line1
            // 
            this.line1.AutoSize = true;
            this.line1.Location = new System.Drawing.Point(139, 88);
            this.line1.Name = "line1";
            this.line1.Size = new System.Drawing.Size(234, 19);
            this.line1.TabIndex = 6;
            this.line1.Text = "        x1 +        x2 <=";
            // 
            // line2
            // 
            this.line2.AutoSize = true;
            this.line2.Location = new System.Drawing.Point(139, 125);
            this.line2.Name = "line2";
            this.line2.Size = new System.Drawing.Size(234, 19);
            this.line2.TabIndex = 7;
            this.line2.Text = "        x1 +        x2 <=";
            // 
            // txtb1
            // 
            this.txtb1.Location = new System.Drawing.Point(379, 81);
            this.txtb1.Name = "txtb1";
            this.txtb1.Size = new System.Drawing.Size(63, 26);
            this.txtb1.TabIndex = 6;
            // 
            // txta12
            // 
            this.txta12.Location = new System.Drawing.Point(253, 81);
            this.txta12.Name = "txta12";
            this.txta12.Size = new System.Drawing.Size(63, 26);
            this.txta12.TabIndex = 5;
            // 
            // txtb2
            // 
            this.txtb2.Location = new System.Drawing.Point(379, 118);
            this.txtb2.Name = "txtb2";
            this.txtb2.Size = new System.Drawing.Size(63, 26);
            this.txtb2.TabIndex = 9;
            // 
            // txta22
            // 
            this.txta22.Location = new System.Drawing.Point(253, 118);
            this.txta22.Name = "txta22";
            this.txta22.Size = new System.Drawing.Size(63, 26);
            this.txta22.TabIndex = 8;
            // 
            // txta21
            // 
            this.txta21.Location = new System.Drawing.Point(143, 118);
            this.txta21.Name = "txta21";
            this.txta21.Size = new System.Drawing.Size(63, 26);
            this.txta21.TabIndex = 7;
            // 
            // txta11
            // 
            this.txta11.Location = new System.Drawing.Point(143, 81);
            this.txta11.Name = "txta11";
            this.txta11.Size = new System.Drawing.Size(63, 26);
            this.txta11.TabIndex = 4;
            // 
            // dk
            // 
            this.dk.AutoSize = true;
            this.dk.Location = new System.Drawing.Point(139, 147);
            this.dk.Name = "dk";
            this.dk.Size = new System.Drawing.Size(81, 19);
            this.dk.TabIndex = 17;
            this.dk.Text = "x1,x2>=0";
            // 
            // goal
            // 
            this.goal.AutoSize = true;
            this.goal.Location = new System.Drawing.Point(12, 41);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(387, 19);
            this.goal.TabIndex = 18;
            this.goal.Text = "Hàm mục tiêu:         x1 +        x2 ---> ";
            // 
            // txtc2
            // 
            this.txtc2.Location = new System.Drawing.Point(253, 34);
            this.txtc2.Name = "txtc2";
            this.txtc2.Size = new System.Drawing.Size(63, 26);
            this.txtc2.TabIndex = 2;
            // 
            // txtc1
            // 
            this.txtc1.Location = new System.Drawing.Point(143, 34);
            this.txtc1.Name = "txtc1";
            this.txtc1.Size = new System.Drawing.Size(63, 26);
            this.txtc1.TabIndex = 1;
            // 
            // sol
            // 
            this.sol.BackColor = System.Drawing.Color.Tomato;
            this.sol.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sol.ForeColor = System.Drawing.Color.Snow;
            this.sol.Location = new System.Drawing.Point(219, 167);
            this.sol.Name = "sol";
            this.sol.Size = new System.Drawing.Size(75, 40);
            this.sol.TabIndex = 10;
            this.sol.Text = "Giải";
            this.sol.UseVisualStyleBackColor = false;
            this.sol.Click += new System.EventHandler(this.sol_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.ans);
            this.panel.Controls.Add(this.label1);
            this.panel.Controls.Add(this.paintArea);
            this.panel.Controls.Add(this.mm);
            this.panel.Controls.Add(this.scroll);
            this.panel.Controls.Add(this.goal);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(510, 741);
            this.panel.TabIndex = 23;
            // 
            // ans
            // 
            this.ans.AutoSize = true;
            this.ans.Location = new System.Drawing.Point(56, 667);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(0, 19);
            this.ans.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Các ràng buộc:";
            // 
            // paintArea
            // 
            this.paintArea.BackColor = System.Drawing.SystemColors.Window;
            this.paintArea.Location = new System.Drawing.Point(41, 228);
            this.paintArea.Name = "paintArea";
            this.paintArea.Size = new System.Drawing.Size(420, 420);
            this.paintArea.TabIndex = 19;
            // 
            // mm
            // 
            this.mm.FormattingEnabled = true;
            this.mm.Items.AddRange(new object[] {
            "max",
            "min"});
            this.mm.Location = new System.Drawing.Point(394, 33);
            this.mm.Name = "mm";
            this.mm.Size = new System.Drawing.Size(74, 27);
            this.mm.TabIndex = 3;
            this.mm.SelectedIndexChanged += new System.EventHandler(this.mm_SelectedIndexChanged);
            // 
            // scroll
            // 
            this.scroll.Dock = System.Windows.Forms.DockStyle.Right;
            this.scroll.Location = new System.Drawing.Point(493, 0);
            this.scroll.Name = "scroll";
            this.scroll.Size = new System.Drawing.Size(17, 741);
            this.scroll.TabIndex = 0;
            // 
            // ToiUu
            // 
            this.ClientSize = new System.Drawing.Size(510, 741);
            this.Controls.Add(this.sol);
            this.Controls.Add(this.txtc2);
            this.Controls.Add(this.txtc1);
            this.Controls.Add(this.dk);
            this.Controls.Add(this.txta11);
            this.Controls.Add(this.txta21);
            this.Controls.Add(this.txtb2);
            this.Controls.Add(this.txta22);
            this.Controls.Add(this.txtb1);
            this.Controls.Add(this.txta12);
            this.Controls.Add(this.line2);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.probar);
            this.Controls.Add(this.note);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "ToiUu";
            this.Text = "Hình học";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label note;
        private System.Windows.Forms.ProgressBar probar;
        private System.Windows.Forms.Label line1;
        private System.Windows.Forms.Label line2;
        private System.Windows.Forms.TextBox txtb1;
        private System.Windows.Forms.TextBox txta12;
        private System.Windows.Forms.TextBox txtb2;
        private System.Windows.Forms.TextBox txta22;
        private System.Windows.Forms.TextBox txta21;
        private System.Windows.Forms.TextBox txta11;
        private System.Windows.Forms.Label dk;
        private System.Windows.Forms.Label goal;
        private System.Windows.Forms.TextBox txtc2;
        private System.Windows.Forms.TextBox txtc1;
        private System.Windows.Forms.Button sol;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.VScrollBar scroll;
        private System.Windows.Forms.ComboBox mm;
        private System.Windows.Forms.Panel paintArea;
        private System.Windows.Forms.Label ans;
        private System.Windows.Forms.Label label1;
    }
}

