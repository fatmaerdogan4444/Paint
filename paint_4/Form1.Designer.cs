namespace paint_4
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnColor = new System.Windows.Forms.Button();
            this.BtnLine = new System.Windows.Forms.Button();
            this.BtnPaint = new System.Windows.Forms.Button();
            this.BtnRectangle = new System.Windows.Forms.Button();
            this.BtnEllipse = new System.Windows.Forms.Button();
            this.BtnEraser = new System.Windows.Forms.Button();
            this.BtnPencil = new System.Windows.Forms.Button();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.BtnClear);
            this.panel1.Controls.Add(this.BtnColor);
            this.panel1.Controls.Add(this.BtnLine);
            this.panel1.Controls.Add(this.BtnPaint);
            this.panel1.Controls.Add(this.BtnRectangle);
            this.panel1.Controls.Add(this.BtnEllipse);
            this.panel1.Controls.Add(this.BtnEraser);
            this.panel1.Controls.Add(this.BtnPencil);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 82);
            this.panel1.TabIndex = 1;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(609, 12);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(75, 50);
            this.BtnSave.TabIndex = 9;
            this.BtnSave.Text = "Kaydet";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click_1);
            // 
            // BtnClear
            // 
            this.BtnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(690, 12);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(75, 50);
            this.BtnClear.TabIndex = 8;
            this.BtnClear.Text = "Temizle";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click_1);
            // 
            // BtnColor
            // 
            this.BtnColor.BackgroundImage = global::paint_4.Properties.Resources.png_transparent_color_scheme_color_theory_color_wheel_tints_and_shades_analogous_colors_design_angle_color_palette;
            this.BtnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnColor.ForeColor = System.Drawing.Color.White;
            this.BtnColor.Location = new System.Drawing.Point(505, 12);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(75, 50);
            this.BtnColor.TabIndex = 6;
            this.BtnColor.UseVisualStyleBackColor = true;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click_1);
            // 
            // BtnLine
            // 
            this.BtnLine.BackgroundImage = global::paint_4.Properties.Resources.png_transparent_recoil_nail_file_manufacturing_material_springfield_armory_xdm_others_miscellaneous_glass_angle;
            this.BtnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLine.ForeColor = System.Drawing.Color.White;
            this.BtnLine.Location = new System.Drawing.Point(424, 12);
            this.BtnLine.Name = "BtnLine";
            this.BtnLine.Size = new System.Drawing.Size(75, 50);
            this.BtnLine.TabIndex = 7;
            this.BtnLine.UseVisualStyleBackColor = true;
            this.BtnLine.Click += new System.EventHandler(this.BtnLine_Click_1);
            this.BtnLine.Paint += new System.Windows.Forms.PaintEventHandler(this.Pic_Paint);
            // 
            // BtnPaint
            // 
            this.BtnPaint.BackgroundImage = global::paint_4.Properties.Resources._1672749;
            this.BtnPaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPaint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPaint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnPaint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnPaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPaint.ForeColor = System.Drawing.Color.White;
            this.BtnPaint.Location = new System.Drawing.Point(343, 12);
            this.BtnPaint.Name = "BtnPaint";
            this.BtnPaint.Size = new System.Drawing.Size(75, 50);
            this.BtnPaint.TabIndex = 5;
            this.BtnPaint.UseVisualStyleBackColor = true;
            this.BtnPaint.Click += new System.EventHandler(this.BtnPaint_Click_1);
            this.BtnPaint.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseClick);
            // 
            // BtnRectangle
            // 
            this.BtnRectangle.BackgroundImage = global::paint_4.Properties.Resources.png_transparent_computer_icons_coin_miscellaneous_angle_rectangle;
            this.BtnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRectangle.ForeColor = System.Drawing.Color.White;
            this.BtnRectangle.Location = new System.Drawing.Point(262, 12);
            this.BtnRectangle.Name = "BtnRectangle";
            this.BtnRectangle.Size = new System.Drawing.Size(75, 50);
            this.BtnRectangle.TabIndex = 4;
            this.BtnRectangle.UseVisualStyleBackColor = true;
            this.BtnRectangle.Click += new System.EventHandler(this.BtnRectangle_Click_1);
            // 
            // BtnEllipse
            // 
            this.BtnEllipse.BackgroundImage = global::paint_4.Properties.Resources._455_4558345_red_ellipse_transparent_background_red_circle_vector_hd;
            this.BtnEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEllipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnEllipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnEllipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEllipse.ForeColor = System.Drawing.Color.White;
            this.BtnEllipse.Location = new System.Drawing.Point(181, 12);
            this.BtnEllipse.Name = "BtnEllipse";
            this.BtnEllipse.Size = new System.Drawing.Size(75, 50);
            this.BtnEllipse.TabIndex = 3;
            this.BtnEllipse.UseVisualStyleBackColor = true;
            this.BtnEllipse.Click += new System.EventHandler(this.BtnEllipse_Click_1);
            // 
            // BtnEraser
            // 
            this.BtnEraser.BackgroundImage = global::paint_4.Properties.Resources.kisspng_typography_graphic_designer_clip_art_gomas_5b32f53ddfc3c4_5426477015300662379166;
            this.BtnEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnEraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnEraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEraser.ForeColor = System.Drawing.Color.White;
            this.BtnEraser.Location = new System.Drawing.Point(100, 12);
            this.BtnEraser.Name = "BtnEraser";
            this.BtnEraser.Size = new System.Drawing.Size(75, 50);
            this.BtnEraser.TabIndex = 2;
            this.BtnEraser.UseVisualStyleBackColor = true;
            this.BtnEraser.Click += new System.EventHandler(this.BtnEraser_Click_1);
            // 
            // BtnPencil
            // 
            this.BtnPencil.BackgroundImage = global::paint_4.Properties.Resources.eee54bc059369ab19251813514ff7c29;
            this.BtnPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnPencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.BtnPencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPencil.ForeColor = System.Drawing.Color.White;
            this.BtnPencil.Location = new System.Drawing.Point(19, 12);
            this.BtnPencil.Name = "BtnPencil";
            this.BtnPencil.Size = new System.Drawing.Size(75, 50);
            this.BtnPencil.TabIndex = 1;
            this.BtnPencil.UseVisualStyleBackColor = true;
            this.BtnPencil.Click += new System.EventHandler(this.BtnPencil_Click);
            // 
            // Pic
            // 
            this.Pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Pic.Location = new System.Drawing.Point(0, 82);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(791, 421);
            this.Pic.TabIndex = 2;
            this.Pic.TabStop = false;
            this.Pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseDown);
            this.Pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseMove);
            this.Pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 503);
            this.Controls.Add(this.Pic);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.Button BtnLine;
        private System.Windows.Forms.Button BtnPaint;
        private System.Windows.Forms.Button BtnRectangle;
        private System.Windows.Forms.Button BtnEllipse;
        private System.Windows.Forms.Button BtnEraser;
        private System.Windows.Forms.Button BtnPencil;
        private System.Windows.Forms.PictureBox Pic;
    }
}

