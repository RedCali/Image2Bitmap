using System.Collections.Generic;
using System.Windows.Forms;

namespace Image2Bitmap
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.num_Width = new System.Windows.Forms.NumericUpDown();
            this.num_Height = new System.Windows.Forms.NumericUpDown();
            this.btn_open = new System.Windows.Forms.Button();
            this.txt_imgSize = new System.Windows.Forms.Label();
            this.selBox_Format = new System.Windows.Forms.ComboBox();
            this.tabBox = new System.Windows.Forms.TabControl();
            this.page_Code = new System.Windows.Forms.TabPage();
            this.GeneratedCode = new System.Windows.Forms.TextBox();
            this.page_Image0 = new System.Windows.Forms.TabPage();
            this.imageBox0 = new System.Windows.Forms.PictureBox();
            this.page_Image1 = new System.Windows.Forms.TabPage();
            this.imageBox1 = new System.Windows.Forms.PictureBox();
            this.page_Image2 = new System.Windows.Forms.TabPage();
            this.imageBox2 = new System.Windows.Forms.PictureBox();
            this.page_Image3 = new System.Windows.Forms.TabPage();
            this.imageBox3 = new System.Windows.Forms.PictureBox();
            this.page_Image4 = new System.Windows.Forms.TabPage();
            this.imageBox4 = new System.Windows.Forms.PictureBox();
            this.page_Image5 = new System.Windows.Forms.TabPage();
            this.imageBox5 = new System.Windows.Forms.PictureBox();
            this.page_Image6 = new System.Windows.Forms.TabPage();
            this.imageBox6 = new System.Windows.Forms.PictureBox();
            this.page_Image7 = new System.Windows.Forms.TabPage();
            this.imageBox7 = new System.Windows.Forms.PictureBox();
            this.page_Image8 = new System.Windows.Forms.TabPage();
            this.imageBox8 = new System.Windows.Forms.PictureBox();
            this.page_Image9 = new System.Windows.Forms.TabPage();
            this.imageBox9 = new System.Windows.Forms.PictureBox();
            this.page_Image10 = new System.Windows.Forms.TabPage();
            this.imageBox10 = new System.Windows.Forms.PictureBox();
            this.txt_ZoomMode = new LinkLabel();
            this.btn_Convert = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.convertProgress = new System.Windows.Forms.ProgressBar();
            this.num_byteWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Width)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Height)).BeginInit();
            this.tabBox.SuspendLayout();
            this.page_Code.SuspendLayout();
            this.page_Image0.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox0)).BeginInit();
            this.page_Image1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.page_Image2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.page_Image3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).BeginInit();
            this.page_Image4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).BeginInit();
            this.page_Image5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).BeginInit();
            this.page_Image6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox6)).BeginInit();
            this.page_Image7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox7)).BeginInit();
            this.page_Image8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox8)).BeginInit();
            this.page_Image9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox9)).BeginInit();
            this.page_Image10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox10)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_byteWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.num_Width);
            this.groupBox1.Controls.Add(this.num_Height);
            this.groupBox1.Controls.Add(this.btn_open);
            this.groupBox1.Controls.Add(this.txt_imgSize);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Original image:";
            // 
            // btn_Save
            // 
            this.btn_Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Save.Location = new System.Drawing.Point(103, 100);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(91, 29);
            this.btn_Save.TabIndex = 9;
            this.btn_Save.Text = "Save image";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Height:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Width:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // num_Width
            // 
            this.num_Width.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.num_Width.Location = new System.Drawing.Point(134, 48);
            this.num_Width.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_Width.Name = "num_Width";
            this.num_Width.Size = new System.Drawing.Size(60, 20);
            this.num_Width.TabIndex = 5;
            this.num_Width.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // num_Height
            // 
            this.num_Height.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.num_Height.Location = new System.Drawing.Point(134, 74);
            this.num_Height.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_Height.Name = "num_Height";
            this.num_Height.Size = new System.Drawing.Size(60, 20);
            this.num_Height.TabIndex = 6;
            this.num_Height.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_open
            // 
            this.btn_open.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_open.Location = new System.Drawing.Point(9, 100);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(91, 29);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "Open image(s)";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.Btn_open_Click);
            // 
            // txt_imgSize
            // 
            this.txt_imgSize.AutoSize = true;
            this.txt_imgSize.Location = new System.Drawing.Point(6, 16);
            this.txt_imgSize.Name = "txt_imgSize";
            this.txt_imgSize.Size = new System.Drawing.Size(117, 26);
            this.txt_imgSize.TabIndex = 4;
            this.txt_imgSize.Text = "Open image from file\r\nOr put code for convert";
            // 
            // selBox_Format
            // 
            this.selBox_Format.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.selBox_Format.FormattingEnabled = true;
            this.selBox_Format.Location = new System.Drawing.Point(6, 19);
            this.selBox_Format.Name = "selBox_Format";
            this.selBox_Format.Size = new System.Drawing.Size(188, 21);
            this.selBox_Format.TabIndex = 1;
            // 
            // tabBox
            // 
            this.tabBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabBox.Controls.Add(this.page_Code);
            this.tabBox.Controls.Add(this.page_Image0);
            this.tabBox.Controls.Add(this.page_Image1);
            this.tabBox.Controls.Add(this.page_Image2);
            this.tabBox.Controls.Add(this.page_Image3);
            this.tabBox.Controls.Add(this.page_Image4);
            this.tabBox.Controls.Add(this.page_Image5);
            this.tabBox.Controls.Add(this.page_Image6);
            this.tabBox.Controls.Add(this.page_Image7);
            this.tabBox.Controls.Add(this.page_Image8);
            this.tabBox.Controls.Add(this.page_Image9);
            this.tabBox.Controls.Add(this.page_Image10);
            this.tabBox.Location = new System.Drawing.Point(218, 12);
            this.tabBox.Name = "tabBox";
            this.tabBox.SelectedIndex = 0;
            this.tabBox.Size = new System.Drawing.Size(654, 277);
            this.tabBox.TabIndex = 3;
            this.tabBox.SelectedIndexChanged += new System.EventHandler(this.tabBox_SelectedIndexChanged);
            // 
            // page_Code
            // 
            this.page_Code.Controls.Add(this.GeneratedCode);
            this.page_Code.Location = new System.Drawing.Point(4, 22);
            this.page_Code.Name = "page_Code";
            this.page_Code.Padding = new System.Windows.Forms.Padding(3);
            this.page_Code.Size = new System.Drawing.Size(646, 251);
            this.page_Code.TabIndex = 1;
            this.page_Code.Text = "Code";
            this.page_Code.UseVisualStyleBackColor = true;
            // 
            // GeneratedCode
            // 
            this.GeneratedCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GeneratedCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GeneratedCode.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GeneratedCode.Location = new System.Drawing.Point(3, 3);
            this.GeneratedCode.MaxLength = 9999999;
            this.GeneratedCode.Multiline = true;
            this.GeneratedCode.Name = "GeneratedCode";
            this.GeneratedCode.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.GeneratedCode.Size = new System.Drawing.Size(640, 245);
            this.GeneratedCode.TabIndex = 0;
            this.GeneratedCode.WordWrap = false;
            // 
            // page_Image0
            // 
            this.page_Image0.AutoScroll = true;
            this.page_Image0.Controls.Add(this.imageBox0);
            this.page_Image0.Location = new System.Drawing.Point(4, 22);
            this.page_Image0.Name = "page_Image0";
            this.page_Image0.Padding = new System.Windows.Forms.Padding(3);
            this.page_Image0.Size = new System.Drawing.Size(646, 251);
            this.page_Image0.TabIndex = 0;
            this.page_Image0.Text = "Image0";
            this.page_Image0.UseVisualStyleBackColor = true;
            // 
            // imageBox0
            // 
            this.imageBox0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageBox0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox0.Location = new System.Drawing.Point(3, 3);
            this.imageBox0.Name = "imageBox0";
            this.imageBox0.Size = new System.Drawing.Size(640, 245);
            this.imageBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox0.TabIndex = 2;
            this.imageBox0.TabStop = false;
            // 
            // page_Image1
            // 
            this.page_Image1.AutoScroll = true;
            this.page_Image1.Controls.Add(this.imageBox1);
            this.page_Image1.Location = new System.Drawing.Point(4, 22);
            this.page_Image1.Name = "page_Image1";
            this.page_Image1.Padding = new System.Windows.Forms.Padding(3);
            this.page_Image1.Size = new System.Drawing.Size(646, 251);
            this.page_Image1.TabIndex = 1;
            this.page_Image1.Text = "Image1";
            this.page_Image1.UseVisualStyleBackColor = true;
            // 
            // imageBox1
            // 
            this.imageBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox1.Location = new System.Drawing.Point(3, 3);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(640, 245);
            this.imageBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // page_Image2
            // 
            this.page_Image2.AutoScroll = true;
            this.page_Image2.Controls.Add(this.imageBox2);
            this.page_Image2.Location = new System.Drawing.Point(4, 22);
            this.page_Image2.Name = "page_Image2";
            this.page_Image2.Padding = new System.Windows.Forms.Padding(3);
            this.page_Image2.Size = new System.Drawing.Size(646, 251);
            this.page_Image2.TabIndex = 2;
            this.page_Image2.Text = "Image2";
            this.page_Image2.UseVisualStyleBackColor = true;
            // 
            // imageBox2
            // 
            this.imageBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox2.Location = new System.Drawing.Point(3, 3);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(640, 245);
            this.imageBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // page_Image3
            // 
            this.page_Image3.AutoScroll = true;
            this.page_Image3.Controls.Add(this.imageBox3);
            this.page_Image3.Location = new System.Drawing.Point(4, 22);
            this.page_Image3.Name = "page_Image3";
            this.page_Image3.Padding = new System.Windows.Forms.Padding(3);
            this.page_Image3.Size = new System.Drawing.Size(646, 251);
            this.page_Image3.TabIndex = 3;
            this.page_Image3.Text = "Image3";
            this.page_Image3.UseVisualStyleBackColor = true;
            // 
            // imageBox3
            // 
            this.imageBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox3.Location = new System.Drawing.Point(3, 3);
            this.imageBox3.Name = "imageBox3";
            this.imageBox3.Size = new System.Drawing.Size(640, 245);
            this.imageBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox3.TabIndex = 2;
            this.imageBox3.TabStop = false;
            // 
            // page_Image4
            // 
            this.page_Image4.AutoScroll = true;
            this.page_Image4.Controls.Add(this.imageBox4);
            this.page_Image4.Location = new System.Drawing.Point(4, 22);
            this.page_Image4.Name = "page_Image4";
            this.page_Image4.Padding = new System.Windows.Forms.Padding(3);
            this.page_Image4.Size = new System.Drawing.Size(646, 251);
            this.page_Image4.TabIndex = 4;
            this.page_Image4.Text = "Image4";
            this.page_Image4.UseVisualStyleBackColor = true;
            // 
            // imageBox4
            // 
            this.imageBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox4.Location = new System.Drawing.Point(3, 3);
            this.imageBox4.Name = "imageBox4";
            this.imageBox4.Size = new System.Drawing.Size(640, 245);
            this.imageBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox4.TabIndex = 2;
            this.imageBox4.TabStop = false;
            // 
            // page_Image5
            // 
            this.page_Image5.AutoScroll = true;
            this.page_Image5.Controls.Add(this.imageBox5);
            this.page_Image5.Location = new System.Drawing.Point(4, 22);
            this.page_Image5.Name = "page_Image5";
            this.page_Image5.Padding = new System.Windows.Forms.Padding(3);
            this.page_Image5.Size = new System.Drawing.Size(646, 251);
            this.page_Image5.TabIndex = 5;
            this.page_Image5.Text = "Image5";
            this.page_Image5.UseVisualStyleBackColor = true;
            // 
            // imageBox5
            // 
            this.imageBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox5.Location = new System.Drawing.Point(3, 3);
            this.imageBox5.Name = "imageBox5";
            this.imageBox5.Size = new System.Drawing.Size(640, 245);
            this.imageBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox5.TabIndex = 2;
            this.imageBox5.TabStop = false;
            // 
            // page_Image6
            // 
            this.page_Image6.AutoScroll = true;
            this.page_Image6.Controls.Add(this.imageBox6);
            this.page_Image6.Location = new System.Drawing.Point(4, 22);
            this.page_Image6.Name = "page_Image6";
            this.page_Image6.Padding = new System.Windows.Forms.Padding(3);
            this.page_Image6.Size = new System.Drawing.Size(646, 251);
            this.page_Image6.TabIndex = 6;
            this.page_Image6.Text = "Image6";
            this.page_Image6.UseVisualStyleBackColor = true;
            // 
            // imageBox6
            // 
            this.imageBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox6.Location = new System.Drawing.Point(3, 3);
            this.imageBox6.Name = "imageBox6";
            this.imageBox6.Size = new System.Drawing.Size(640, 245);
            this.imageBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox6.TabIndex = 2;
            this.imageBox6.TabStop = false;
            // 
            // page_Image7
            // 
            this.page_Image7.AutoScroll = true;
            this.page_Image7.Controls.Add(this.imageBox7);
            this.page_Image7.Location = new System.Drawing.Point(4, 22);
            this.page_Image7.Name = "page_Image7";
            this.page_Image7.Padding = new System.Windows.Forms.Padding(3);
            this.page_Image7.Size = new System.Drawing.Size(646, 251);
            this.page_Image7.TabIndex = 7;
            this.page_Image7.Text = "Image7";
            this.page_Image7.UseVisualStyleBackColor = true;
            // 
            // imageBox7
            // 
            this.imageBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox7.Location = new System.Drawing.Point(3, 3);
            this.imageBox7.Name = "imageBox7";
            this.imageBox7.Size = new System.Drawing.Size(640, 245);
            this.imageBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox7.TabIndex = 2;
            this.imageBox7.TabStop = false;
            // 
            // page_Image8
            // 
            this.page_Image8.AutoScroll = true;
            this.page_Image8.Controls.Add(this.imageBox8);
            this.page_Image8.Location = new System.Drawing.Point(4, 22);
            this.page_Image8.Name = "page_Image8";
            this.page_Image8.Padding = new System.Windows.Forms.Padding(3);
            this.page_Image8.Size = new System.Drawing.Size(646, 251);
            this.page_Image8.TabIndex = 8;
            this.page_Image8.Text = "Image8";
            this.page_Image8.UseVisualStyleBackColor = true;
            // 
            // imageBox8
            // 
            this.imageBox8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox8.Location = new System.Drawing.Point(3, 3);
            this.imageBox8.Name = "imageBox8";
            this.imageBox8.Size = new System.Drawing.Size(640, 245);
            this.imageBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox8.TabIndex = 2;
            this.imageBox8.TabStop = false;
            // 
            // page_Image9
            // 
            this.page_Image9.AutoScroll = true;
            this.page_Image9.Controls.Add(this.imageBox9);
            this.page_Image9.Location = new System.Drawing.Point(4, 22);
            this.page_Image9.Name = "page_Image9";
            this.page_Image9.Padding = new System.Windows.Forms.Padding(3);
            this.page_Image9.Size = new System.Drawing.Size(646, 251);
            this.page_Image9.TabIndex = 9;
            this.page_Image9.Text = "Image9";
            this.page_Image9.UseVisualStyleBackColor = true;
            // 
            // imageBox9
            // 
            this.imageBox9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox9.Location = new System.Drawing.Point(3, 3);
            this.imageBox9.Name = "imageBox9";
            this.imageBox9.Size = new System.Drawing.Size(640, 245);
            this.imageBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox9.TabIndex = 2;
            this.imageBox9.TabStop = false;
            // 
            // page_Image10
            // 
            this.page_Image10.AutoScroll = true;
            this.page_Image10.Controls.Add(this.imageBox10);
            this.page_Image10.Location = new System.Drawing.Point(4, 22);
            this.page_Image10.Name = "page_Image10";
            this.page_Image10.Padding = new System.Windows.Forms.Padding(3);
            this.page_Image10.Size = new System.Drawing.Size(646, 251);
            this.page_Image10.TabIndex = 10;
            this.page_Image10.Text = "Image10";
            this.page_Image10.UseVisualStyleBackColor = true;
            // 
            // imageBox10
            // 
            this.imageBox10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imageBox10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageBox10.Location = new System.Drawing.Point(3, 3);
            this.imageBox10.Name = "imageBox10";
            this.imageBox10.Size = new System.Drawing.Size(640, 245);
            this.imageBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageBox10.TabIndex = 2;
            this.imageBox10.TabStop = false;
            // 
            // txt_ZoomMode
            // 
            this.txt_ZoomMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_ZoomMode.AutoSize = true;
            this.txt_ZoomMode.Location = new System.Drawing.Point(221, 247);
            this.txt_ZoomMode.Name = "txt_ZoomMode";
            this.txt_ZoomMode.Size = new System.Drawing.Size(96, 13);
            this.txt_ZoomMode.TabIndex = 6;
            this.txt_ZoomMode.TabStop = true;
            this.txt_ZoomMode.Text = "Zoom mode: Zoom";
            this.txt_ZoomMode.VisitedLinkColor = System.Drawing.Color.Navy;
            this.txt_ZoomMode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.Txt_ZoomMode_LinkClicked);
            // 
            // btn_Convert
            // 
            this.btn_Convert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Convert.Location = new System.Drawing.Point(6, 46);
            this.btn_Convert.Name = "btn_Convert";
            this.btn_Convert.Size = new System.Drawing.Size(188, 29);
            this.btn_Convert.TabIndex = 2;
            this.btn_Convert.Text = "Convert!";
            this.btn_Convert.UseVisualStyleBackColor = true;
            this.btn_Convert.Click += new System.EventHandler(this.Btn_Convert_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.convertProgress);
            this.groupBox2.Controls.Add(this.btn_Convert);
            this.groupBox2.Controls.Add(this.selBox_Format);
            this.groupBox2.Location = new System.Drawing.Point(12, 178);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 111);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Convert from/to:";
            // 
            // convertProgress
            // 
            this.convertProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.convertProgress.Location = new System.Drawing.Point(6, 81);
            this.convertProgress.Name = "convertProgress";
            this.convertProgress.Size = new System.Drawing.Size(188, 23);
            this.convertProgress.Step = 1;
            this.convertProgress.TabIndex = 4;
            // 
            // num_byteWidth
            // 
            this.num_byteWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.num_byteWidth.Location = new System.Drawing.Point(146, 153);
            this.num_byteWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.num_byteWidth.Name = "num_byteWidth";
            this.num_byteWidth.Size = new System.Drawing.Size(60, 20);
            this.num_byteWidth.TabIndex = 10;
            this.num_byteWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.num_byteWidth.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Array byte width:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 302);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.num_byteWidth);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txt_ZoomMode);
            this.Controls.Add(this.tabBox);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(800, 340);
            this.Name = "Form1";
            this.Text = "Image2Bitmap";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_Width)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_Height)).EndInit();
            this.tabBox.ResumeLayout(false);
            this.page_Code.ResumeLayout(false);
            this.page_Code.PerformLayout();
            this.page_Image0.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox0)).EndInit();
            this.page_Image1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.page_Image2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.page_Image3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox3)).EndInit();
            this.page_Image4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox4)).EndInit();
            this.page_Image5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox5)).EndInit();
            this.page_Image6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox6)).EndInit();
            this.page_Image7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox7)).EndInit();
            this.page_Image8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox8)).EndInit();
            this.page_Image9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox9)).EndInit();
            this.page_Image10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imageBox10)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_byteWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label txt_imgSize;
        private ComboBox selBox_Format;
        private Button btn_open;
        private TabControl tabBox;
        private TabPage page_Image0;
        private LinkLabel txt_ZoomMode;
        private PictureBox imageBox0;
        private TabPage page_Image1;
        private PictureBox imageBox1;
        private TabPage page_Image2;
        private PictureBox imageBox2;
        private TabPage page_Image3;
        private PictureBox imageBox3;
        private TabPage page_Image4;
        private PictureBox imageBox4;
        private TabPage page_Image5;
        private PictureBox imageBox5;
        private TabPage page_Image6;
        private PictureBox imageBox6;
        private TabPage page_Image7;
        private PictureBox imageBox7;
        private TabPage page_Image8;
        private PictureBox imageBox8;
        private TabPage page_Image9;
        private PictureBox imageBox9;
        private TabPage page_Image10;
        private PictureBox imageBox10;
        private TabPage page_Code;
        private TextBox GeneratedCode;
        private GroupBox groupBox2;
        private Button btn_Convert;
        private ProgressBar convertProgress;
        private Label label2;
        private Label label1;
        private NumericUpDown num_Width;
        private NumericUpDown num_Height;
        private Button btn_Save;
        private NumericUpDown num_byteWidth;
        private Label label3;
    }
}

