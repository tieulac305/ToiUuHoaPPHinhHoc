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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ToiUu));
            this.dk = new System.Windows.Forms.Label();
            this.sol = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.credit = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.given = new System.Windows.Forms.Panel();
            this.infor = new System.Windows.Forms.Label();
            this.mm = new System.Windows.Forms.ComboBox();
            this.txtc2 = new System.Windows.Forms.TextBox();
            this.txtc1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.note = new System.Windows.Forms.Label();
            this.goal = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.solve = new System.Windows.Forms.Panel();
            this.grid = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.restart = new System.Windows.Forms.Button();
            this.ans = new System.Windows.Forms.Label();
            this.probar = new System.Windows.Forms.ProgressBar();
            this.paintArea = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.credit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.given.SuspendLayout();
            this.solve.SuspendLayout();
            this.SuspendLayout();
            // 
            // dk
            // 
            this.dk.AutoSize = true;
            this.dk.Location = new System.Drawing.Point(141, 77);
            this.dk.Name = "dk";
            this.dk.Size = new System.Drawing.Size(81, 19);
            this.dk.TabIndex = 17;
            this.dk.Text = "x1,x2>=0";
            // 
            // sol
            // 
            this.sol.BackColor = System.Drawing.Color.Tomato;
            this.sol.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sol.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sol.ForeColor = System.Drawing.Color.Snow;
            this.sol.Location = new System.Drawing.Point(0, 261);
            this.sol.Name = "sol";
            this.sol.Size = new System.Drawing.Size(510, 40);
            this.sol.TabIndex = 10;
            this.sol.Text = "Giải";
            this.sol.UseVisualStyleBackColor = false;
            this.sol.Click += new System.EventHandler(this.sol_Click);
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Controls.Add(this.credit);
            this.panel.Controls.Add(this.given);
            this.panel.Controls.Add(this.solve);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(994, 581);
            this.panel.TabIndex = 23;
            // 
            // credit
            // 
            this.credit.Controls.Add(this.pictureBox2);
            this.credit.Controls.Add(this.pictureBox1);
            this.credit.Location = new System.Drawing.Point(11, 334);
            this.credit.Name = "credit";
            this.credit.Size = new System.Drawing.Size(510, 233);
            this.credit.TabIndex = 24;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ToiUuHoaHinhHoc.Properties.Resources.giphy;
            this.pictureBox2.Location = new System.Drawing.Point(3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(195, 226);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ToiUuHoaHinhHoc.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(205, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(302, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // given
            // 
            this.given.AutoScroll = true;
            this.given.Controls.Add(this.infor);
            this.given.Controls.Add(this.mm);
            this.given.Controls.Add(this.txtc2);
            this.given.Controls.Add(this.txtc1);
            this.given.Controls.Add(this.label1);
            this.given.Controls.Add(this.note);
            this.given.Controls.Add(this.goal);
            this.given.Controls.Add(this.sol);
            this.given.Controls.Add(this.add);
            this.given.Controls.Add(this.dk);
            this.given.Location = new System.Drawing.Point(11, 12);
            this.given.Name = "given";
            this.given.Size = new System.Drawing.Size(510, 301);
            this.given.TabIndex = 0;
            // 
            // infor
            // 
            this.infor.AutoSize = true;
            this.infor.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.infor.Location = new System.Drawing.Point(248, 82);
            this.infor.Name = "infor";
            this.infor.Size = new System.Drawing.Size(105, 14);
            this.infor.TabIndex = 27;
            this.infor.Text = "Thêm ràng buộc";
            // 
            // mm
            // 
            this.mm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mm.FormattingEnabled = true;
            this.mm.Items.AddRange(new object[] {
            "max",
            "min"});
            this.mm.Location = new System.Drawing.Point(384, 44);
            this.mm.Name = "mm";
            this.mm.Size = new System.Drawing.Size(74, 27);
            this.mm.TabIndex = 26;
            // 
            // txtc2
            // 
            this.txtc2.Location = new System.Drawing.Point(244, 45);
            this.txtc2.Name = "txtc2";
            this.txtc2.Size = new System.Drawing.Size(63, 26);
            this.txtc2.TabIndex = 25;
            // 
            // txtc1
            // 
            this.txtc1.Location = new System.Drawing.Point(135, 45);
            this.txtc1.Name = "txtc1";
            this.txtc1.Size = new System.Drawing.Size(63, 26);
            this.txtc1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 23;
            this.label1.Text = "Các ràng buộc:";
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.ForeColor = System.Drawing.SystemColors.Highlight;
            this.note.Location = new System.Drawing.Point(3, 13);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(405, 19);
            this.note.TabIndex = 21;
            this.note.Text = "Chú ý khi sử dụng: cần đưa về dạng chuẩn tắc";
            // 
            // goal
            // 
            this.goal.AutoSize = true;
            this.goal.Location = new System.Drawing.Point(3, 48);
            this.goal.Name = "goal";
            this.goal.Size = new System.Drawing.Size(387, 19);
            this.goal.TabIndex = 22;
            this.goal.Text = "Hàm mục tiêu:         x1 +        x2 ---> ";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(228, 73);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(20, 23);
            this.add.TabIndex = 0;
            this.add.Text = "+";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // solve
            // 
            this.solve.Controls.Add(this.grid);
            this.solve.Controls.Add(this.exit);
            this.solve.Controls.Add(this.restart);
            this.solve.Controls.Add(this.ans);
            this.solve.Controls.Add(this.probar);
            this.solve.Controls.Add(this.paintArea);
            this.solve.Controls.Add(this.label2);
            this.solve.Location = new System.Drawing.Point(527, 9);
            this.solve.Name = "solve";
            this.solve.Size = new System.Drawing.Size(451, 558);
            this.solve.TabIndex = 23;
            // 
            // grid
            // 
            this.grid.BackColor = System.Drawing.Color.Lime;
            this.grid.Location = new System.Drawing.Point(406, 448);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(28, 23);
            this.grid.TabIndex = 27;
            this.grid.UseVisualStyleBackColor = false;
            this.grid.Click += new System.EventHandler(this.grid_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Orchid;
            this.exit.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.exit.Location = new System.Drawing.Point(235, 522);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(102, 33);
            this.exit.TabIndex = 26;
            this.exit.Text = "Kết thúc";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // restart
            // 
            this.restart.BackColor = System.Drawing.Color.Turquoise;
            this.restart.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.restart.Location = new System.Drawing.Point(127, 522);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(102, 33);
            this.restart.TabIndex = 25;
            this.restart.Text = "Làm tiếp";
            this.restart.UseVisualStyleBackColor = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // ans
            // 
            this.ans.AutoSize = true;
            this.ans.Location = new System.Drawing.Point(30, 466);
            this.ans.Name = "ans";
            this.ans.Size = new System.Drawing.Size(216, 19);
            this.ans.TabIndex = 24;
            this.ans.Text = "Lời giải sẽ hiện ở đây.";
            // 
            // probar
            // 
            this.probar.Dock = System.Windows.Forms.DockStyle.Top;
            this.probar.Location = new System.Drawing.Point(0, 0);
            this.probar.Name = "probar";
            this.probar.Size = new System.Drawing.Size(451, 17);
            this.probar.TabIndex = 22;
            this.probar.Visible = false;
            // 
            // paintArea
            // 
            this.paintArea.BackColor = System.Drawing.SystemColors.Window;
            this.paintArea.Location = new System.Drawing.Point(15, 25);
            this.paintArea.Name = "paintArea";
            this.paintArea.Size = new System.Drawing.Size(420, 420);
            this.paintArea.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(320, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 14);
            this.label2.TabIndex = 29;
            this.label2.Text = "Grid on/off";
            // 
            // ToiUu
            // 
            this.ClientSize = new System.Drawing.Size(994, 581);
            this.Controls.Add(this.panel);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ToiUu";
            this.Text = "Phương pháp hình học - Quy hoạch tuyến tính";
            this.panel.ResumeLayout(false);
            this.credit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.given.ResumeLayout(false);
            this.given.PerformLayout();
            this.solve.ResumeLayout(false);
            this.solve.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label dk;
        private System.Windows.Forms.Button sol;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Panel paintArea;
        private System.Windows.Forms.Panel given;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.ProgressBar probar;
        private System.Windows.Forms.Panel solve;
        private System.Windows.Forms.Label ans;
        private System.Windows.Forms.Panel credit;
        private System.Windows.Forms.ComboBox mm;
        private System.Windows.Forms.TextBox txtc2;
        private System.Windows.Forms.TextBox txtc1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label note;
        private System.Windows.Forms.Label goal;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Label infor;
        private System.Windows.Forms.Button grid;
        private System.Windows.Forms.Label label2;
    }
}

