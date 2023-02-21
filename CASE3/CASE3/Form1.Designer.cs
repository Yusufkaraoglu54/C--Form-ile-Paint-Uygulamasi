namespace CASE3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.color = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_white = new System.Windows.Forms.Button();
            this.btn_brown = new System.Windows.Forms.Button();
            this.btn_purple = new System.Windows.Forms.Button();
            this.btn_orange = new System.Windows.Forms.Button();
            this.brn_black = new System.Windows.Forms.Button();
            this.btn_yellow = new System.Windows.Forms.Button();
            this.btn_red = new System.Windows.Forms.Button();
            this.brn_blue = new System.Windows.Forms.Button();
            this.btn_green = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_ellipse = new System.Windows.Forms.Button();
            this.btn_silgi = new System.Windows.Forms.Button();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.btn_rect = new System.Windows.Forms.Button();
            this.btn_ucgen = new System.Windows.Forms.Button();
            this.btn_altigen = new System.Windows.Forms.Button();
            this.pic = new System.Windows.Forms.PictureBox();
            this.color.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // color
            // 
            this.color.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.color.Controls.Add(this.btn_open);
            this.color.Controls.Add(this.groupBox1);
            this.color.Controls.Add(this.btn_kaydet);
            this.color.Controls.Add(this.btn_clear);
            this.color.Controls.Add(this.btn_ellipse);
            this.color.Controls.Add(this.btn_silgi);
            this.color.Controls.Add(this.btn_pencil);
            this.color.Controls.Add(this.groupBox2);
            this.color.Dock = System.Windows.Forms.DockStyle.Right;
            this.color.Location = new System.Drawing.Point(667, 0);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(195, 503);
            this.color.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_white);
            this.groupBox1.Controls.Add(this.btn_brown);
            this.groupBox1.Controls.Add(this.btn_purple);
            this.groupBox1.Controls.Add(this.btn_orange);
            this.groupBox1.Controls.Add(this.brn_black);
            this.groupBox1.Controls.Add(this.btn_yellow);
            this.groupBox1.Controls.Add(this.btn_red);
            this.groupBox1.Controls.Add(this.brn_blue);
            this.groupBox1.Controls.Add(this.btn_green);
            this.groupBox1.Location = new System.Drawing.Point(0, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(195, 196);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btn_white
            // 
            this.btn_white.BackColor = System.Drawing.Color.White;
            this.btn_white.Location = new System.Drawing.Point(140, 129);
            this.btn_white.Name = "btn_white";
            this.btn_white.Size = new System.Drawing.Size(55, 55);
            this.btn_white.TabIndex = 9;
            this.btn_white.UseVisualStyleBackColor = false;
            this.btn_white.Click += new System.EventHandler(this.btn_white_Click);
            // 
            // btn_brown
            // 
            this.btn_brown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_brown.Location = new System.Drawing.Point(79, 129);
            this.btn_brown.Name = "btn_brown";
            this.btn_brown.Size = new System.Drawing.Size(55, 55);
            this.btn_brown.TabIndex = 8;
            this.btn_brown.UseVisualStyleBackColor = false;
            this.btn_brown.Click += new System.EventHandler(this.btn_brown_Click);
            // 
            // btn_purple
            // 
            this.btn_purple.BackColor = System.Drawing.Color.Purple;
            this.btn_purple.Location = new System.Drawing.Point(18, 129);
            this.btn_purple.Name = "btn_purple";
            this.btn_purple.Size = new System.Drawing.Size(55, 55);
            this.btn_purple.TabIndex = 7;
            this.btn_purple.UseVisualStyleBackColor = false;
            this.btn_purple.Click += new System.EventHandler(this.btn_purple_Click);
            // 
            // btn_orange
            // 
            this.btn_orange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_orange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_orange.Location = new System.Drawing.Point(18, 68);
            this.btn_orange.Name = "btn_orange";
            this.btn_orange.Size = new System.Drawing.Size(55, 55);
            this.btn_orange.TabIndex = 6;
            this.btn_orange.UseVisualStyleBackColor = false;
            this.btn_orange.Click += new System.EventHandler(this.btn_orange_Click);
            // 
            // brn_black
            // 
            this.brn_black.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.brn_black.Location = new System.Drawing.Point(79, 68);
            this.brn_black.Name = "brn_black";
            this.brn_black.Size = new System.Drawing.Size(55, 55);
            this.brn_black.TabIndex = 5;
            this.brn_black.UseVisualStyleBackColor = false;
            this.brn_black.Click += new System.EventHandler(this.brn_black_Click);
            // 
            // btn_yellow
            // 
            this.btn_yellow.BackColor = System.Drawing.Color.Yellow;
            this.btn_yellow.Location = new System.Drawing.Point(140, 68);
            this.btn_yellow.Name = "btn_yellow";
            this.btn_yellow.Size = new System.Drawing.Size(55, 55);
            this.btn_yellow.TabIndex = 4;
            this.btn_yellow.UseVisualStyleBackColor = false;
            this.btn_yellow.Click += new System.EventHandler(this.btn_yellow_Click);
            // 
            // btn_red
            // 
            this.btn_red.BackColor = System.Drawing.Color.Red;
            this.btn_red.Location = new System.Drawing.Point(18, 7);
            this.btn_red.Name = "btn_red";
            this.btn_red.Size = new System.Drawing.Size(55, 55);
            this.btn_red.TabIndex = 3;
            this.btn_red.UseVisualStyleBackColor = false;
            this.btn_red.Click += new System.EventHandler(this.btn_red_Click);
            // 
            // brn_blue
            // 
            this.brn_blue.BackColor = System.Drawing.Color.Blue;
            this.brn_blue.Location = new System.Drawing.Point(79, 7);
            this.brn_blue.Name = "brn_blue";
            this.brn_blue.Size = new System.Drawing.Size(55, 55);
            this.brn_blue.TabIndex = 2;
            this.brn_blue.UseVisualStyleBackColor = false;
            this.brn_blue.Click += new System.EventHandler(this.brn_blue_Click);
            // 
            // btn_green
            // 
            this.btn_green.BackColor = System.Drawing.Color.Lime;
            this.btn_green.Location = new System.Drawing.Point(140, 7);
            this.btn_green.Name = "btn_green";
            this.btn_green.Size = new System.Drawing.Size(55, 55);
            this.btn_green.TabIndex = 1;
            this.btn_green.UseVisualStyleBackColor = false;
            this.btn_green.Click += new System.EventHandler(this.btn_green_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_rect);
            this.groupBox2.Controls.Add(this.btn_ucgen);
            this.groupBox2.Controls.Add(this.btn_altigen);
            this.groupBox2.Location = new System.Drawing.Point(0, -8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 178);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 493);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(667, 10);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(667, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(195, 122);
            this.panel1.TabIndex = 3;
            // 
            // btn_open
            // 
            this.btn_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_open.ForeColor = System.Drawing.Color.Black;
            this.btn_open.Image = global::CASE3.Properties.Resources.png_transparent_line_point_angle_line_angle_hand_icon_download;
            this.btn_open.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_open.Location = new System.Drawing.Point(70, 432);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(64, 55);
            this.btn_open.TabIndex = 13;
            this.btn_open.Text = "Aç";
            this.btn_open.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kaydet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_kaydet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_kaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kaydet.ForeColor = System.Drawing.Color.Black;
            this.btn_kaydet.Image = global::CASE3.Properties.Resources.download__3_;
            this.btn_kaydet.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_kaydet.Location = new System.Drawing.Point(0, 432);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(64, 55);
            this.btn_kaydet.TabIndex = 12;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.Black;
            this.btn_clear.Image = global::CASE3.Properties.Resources.download__1_;
            this.btn_clear.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_clear.Location = new System.Drawing.Point(122, 371);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(55, 55);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Yeni ";
            this.btn_clear.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_ellipse
            // 
            this.btn_ellipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ellipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ellipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_ellipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ellipse.ForeColor = System.Drawing.Color.White;
            this.btn_ellipse.Image = global::CASE3.Properties.Resources.circle;
            this.btn_ellipse.Location = new System.Drawing.Point(104, 3);
            this.btn_ellipse.Name = "btn_ellipse";
            this.btn_ellipse.Size = new System.Drawing.Size(88, 81);
            this.btn_ellipse.TabIndex = 6;
            this.btn_ellipse.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ellipse.UseVisualStyleBackColor = true;
            this.btn_ellipse.Click += new System.EventHandler(this.btn_ellipse_Click);
            // 
            // btn_silgi
            // 
            this.btn_silgi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_silgi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_silgi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_silgi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_silgi.ForeColor = System.Drawing.Color.Black;
            this.btn_silgi.Image = global::CASE3.Properties.Resources.eraser;
            this.btn_silgi.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_silgi.Location = new System.Drawing.Point(61, 371);
            this.btn_silgi.Name = "btn_silgi";
            this.btn_silgi.Size = new System.Drawing.Size(55, 55);
            this.btn_silgi.TabIndex = 5;
            this.btn_silgi.Text = "Silgi";
            this.btn_silgi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_silgi.UseVisualStyleBackColor = true;
            this.btn_silgi.Click += new System.EventHandler(this.btn_silgi_Click);
            // 
            // btn_pencil
            // 
            this.btn_pencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.ForeColor = System.Drawing.Color.Black;
            this.btn_pencil.Image = global::CASE3.Properties.Resources.pencil;
            this.btn_pencil.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pencil.Location = new System.Drawing.Point(0, 371);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(55, 55);
            this.btn_pencil.TabIndex = 4;
            this.btn_pencil.Text = "Kalem";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = true;
            this.btn_pencil.Click += new System.EventHandler(this.btn_pencil_Click);
            // 
            // btn_rect
            // 
            this.btn_rect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_rect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_rect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_rect.ForeColor = System.Drawing.Color.White;
            this.btn_rect.Image = global::CASE3.Properties.Resources.rectangle;
            this.btn_rect.Location = new System.Drawing.Point(18, 8);
            this.btn_rect.Name = "btn_rect";
            this.btn_rect.Size = new System.Drawing.Size(80, 84);
            this.btn_rect.TabIndex = 7;
            this.btn_rect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rect.UseVisualStyleBackColor = true;
            this.btn_rect.Click += new System.EventHandler(this.btn_rect_Click);
            // 
            // btn_ucgen
            // 
            this.btn_ucgen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ucgen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ucgen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_ucgen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ucgen.ForeColor = System.Drawing.Color.White;
            this.btn_ucgen.Image = global::CASE3.Properties.Resources.download;
            this.btn_ucgen.Location = new System.Drawing.Point(18, 98);
            this.btn_ucgen.Name = "btn_ucgen";
            this.btn_ucgen.Size = new System.Drawing.Size(80, 74);
            this.btn_ucgen.TabIndex = 8;
            this.btn_ucgen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ucgen.UseVisualStyleBackColor = true;
            this.btn_ucgen.Click += new System.EventHandler(this.btn_ucgen_Click);
            // 
            // btn_altigen
            // 
            this.btn_altigen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_altigen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_altigen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.btn_altigen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_altigen.ForeColor = System.Drawing.Color.White;
            this.btn_altigen.Image = global::CASE3.Properties.Resources.f40b4fdf8143f14007a864be61ec9fe9;
            this.btn_altigen.Location = new System.Drawing.Point(104, 98);
            this.btn_altigen.Name = "btn_altigen";
            this.btn_altigen.Size = new System.Drawing.Size(88, 73);
            this.btn_altigen.TabIndex = 9;
            this.btn_altigen.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_altigen.UseVisualStyleBackColor = true;
            this.btn_altigen.Click += new System.EventHandler(this.button3_Click);
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 0);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(862, 503);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 503);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.color);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.color.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel color;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btn_rect;
        private System.Windows.Forms.Button btn_ellipse;
        private System.Windows.Forms.Button btn_silgi;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.Button btn_ucgen;
        private System.Windows.Forms.Button btn_altigen;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_kaydet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_orange;
        private System.Windows.Forms.Button brn_black;
        private System.Windows.Forms.Button btn_yellow;
        private System.Windows.Forms.Button btn_red;
        private System.Windows.Forms.Button brn_blue;
        private System.Windows.Forms.Button btn_green;
        private System.Windows.Forms.Button btn_white;
        private System.Windows.Forms.Button btn_brown;
        private System.Windows.Forms.Button btn_purple;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_open;
    }
}

