
namespace photo
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ımageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.layerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialFiltersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brightnessContrastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originalSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.main_photo_pictureBox = new System.Windows.Forms.PictureBox();
            this.brightness_value_textBox = new System.Windows.Forms.TextBox();
            this.contrast_value_textBox = new System.Windows.Forms.TextBox();
            this.brightness_label = new System.Windows.Forms.Label();
            this.contrast_label = new System.Windows.Forms.Label();
            this.interface_panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.contrast_apply_button = new System.Windows.Forms.Button();
            this.brightness_apply_button = new System.Windows.Forms.Button();
            this.contrast_trackBar = new System.Windows.Forms.TrackBar();
            this.brightness_trackBar = new System.Windows.Forms.TrackBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mean_filter_button = new System.Windows.Forms.Button();
            this.gaussian_button = new System.Windows.Forms.Button();
            this.sobel_button = new System.Windows.Forms.Button();
            this.sharpen_button = new System.Windows.Forms.Button();
            this.prewitt_button = new System.Windows.Forms.Button();
            this.laplacian_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.red_value_textBox = new System.Windows.Forms.TextBox();
            this.blue_value_textBox = new System.Windows.Forms.TextBox();
            this.green_value_textBox = new System.Windows.Forms.TextBox();
            this.red_trackbar = new System.Windows.Forms.TrackBar();
            this.green_trackbar = new System.Windows.Forms.TrackBar();
            this.blue_trackbar = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_photo_pictureBox)).BeginInit();
            this.interface_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrast_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightness_trackBar)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.red_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_trackbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_trackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.ımageToolStripMenuItem,
            this.layerToolStripMenuItem,
            this.typeToolStripMenuItem,
            this.selectToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1384, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(40, 21);
            this.toolStripMenuItem1.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(199, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.SaveAsToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(42, 21);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // ımageToolStripMenuItem
            // 
            this.ımageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem});
            this.ımageToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ımageToolStripMenuItem.Name = "ımageToolStripMenuItem";
            this.ımageToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.ımageToolStripMenuItem.Text = "Image";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.LoadToolStripMenuItem_Click);
            // 
            // layerToolStripMenuItem
            // 
            this.layerToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.layerToolStripMenuItem.Name = "layerToolStripMenuItem";
            this.layerToolStripMenuItem.Size = new System.Drawing.Size(52, 21);
            this.layerToolStripMenuItem.Text = "Layer";
            // 
            // typeToolStripMenuItem
            // 
            this.typeToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.typeToolStripMenuItem.Name = "typeToolStripMenuItem";
            this.typeToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.typeToolStripMenuItem.Text = "Type";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colorFilterToolStripMenuItem,
            this.specialFiltersToolStripMenuItem});
            this.filterToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(49, 21);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // colorFilterToolStripMenuItem
            // 
            this.colorFilterToolStripMenuItem.Name = "colorFilterToolStripMenuItem";
            this.colorFilterToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorFilterToolStripMenuItem.Text = "Color Filter";
            this.colorFilterToolStripMenuItem.Click += new System.EventHandler(this.ColorFilterToolStripMenuItem_Click);
            // 
            // specialFiltersToolStripMenuItem
            // 
            this.specialFiltersToolStripMenuItem.Name = "specialFiltersToolStripMenuItem";
            this.specialFiltersToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.specialFiltersToolStripMenuItem.Text = "Particular Filters";
            this.specialFiltersToolStripMenuItem.Click += new System.EventHandler(this.SpecialFiltersToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brightnessContrastToolStripMenuItem});
            this.viewToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // brightnessContrastToolStripMenuItem
            // 
            this.brightnessContrastToolStripMenuItem.Name = "brightnessContrastToolStripMenuItem";
            this.brightnessContrastToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.brightnessContrastToolStripMenuItem.Text = "Brightness / Contrast";
            this.brightnessContrastToolStripMenuItem.Click += new System.EventHandler(this.BrightnessContrastToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.originalSizeToolStripMenuItem,
            this.fullscreenToolStripMenuItem});
            this.windowToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // originalSizeToolStripMenuItem
            // 
            this.originalSizeToolStripMenuItem.Name = "originalSizeToolStripMenuItem";
            this.originalSizeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.originalSizeToolStripMenuItem.Text = "Original Size";
            this.originalSizeToolStripMenuItem.Click += new System.EventHandler(this.OriginalSizeToolStripMenuItem_Click);
            // 
            // fullscreenToolStripMenuItem
            // 
            this.fullscreenToolStripMenuItem.Checked = true;
            this.fullscreenToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fullscreenToolStripMenuItem.Name = "fullscreenToolStripMenuItem";
            this.fullscreenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fullscreenToolStripMenuItem.Text = "Fullscreen";
            this.fullscreenToolStripMenuItem.Click += new System.EventHandler(this.FullscreenToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // main_photo_pictureBox
            // 
            this.main_photo_pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.main_photo_pictureBox.Location = new System.Drawing.Point(12, 28);
            this.main_photo_pictureBox.Name = "main_photo_pictureBox";
            this.main_photo_pictureBox.Size = new System.Drawing.Size(1065, 721);
            this.main_photo_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.main_photo_pictureBox.TabIndex = 1;
            this.main_photo_pictureBox.TabStop = false;
            // 
            // brightness_value_textBox
            // 
            this.brightness_value_textBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.brightness_value_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.brightness_value_textBox.Location = new System.Drawing.Point(114, 14);
            this.brightness_value_textBox.Name = "brightness_value_textBox";
            this.brightness_value_textBox.Size = new System.Drawing.Size(29, 21);
            this.brightness_value_textBox.TabIndex = 3;
            this.brightness_value_textBox.Text = "0";
            this.brightness_value_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Brightness_value_textBox_KeyDown);
            // 
            // contrast_value_textBox
            // 
            this.contrast_value_textBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.contrast_value_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contrast_value_textBox.Location = new System.Drawing.Point(114, 111);
            this.contrast_value_textBox.Name = "contrast_value_textBox";
            this.contrast_value_textBox.Size = new System.Drawing.Size(29, 21);
            this.contrast_value_textBox.TabIndex = 3;
            this.contrast_value_textBox.Text = "0";
            this.contrast_value_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Contrast_value_textBox_KeyDown);
            // 
            // brightness_label
            // 
            this.brightness_label.AutoSize = true;
            this.brightness_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.brightness_label.Location = new System.Drawing.Point(38, 15);
            this.brightness_label.Name = "brightness_label";
            this.brightness_label.Size = new System.Drawing.Size(70, 17);
            this.brightness_label.TabIndex = 5;
            this.brightness_label.Text = "Brightness:";
            // 
            // contrast_label
            // 
            this.contrast_label.AutoSize = true;
            this.contrast_label.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.contrast_label.Location = new System.Drawing.Point(46, 112);
            this.contrast_label.Name = "contrast_label";
            this.contrast_label.Size = new System.Drawing.Size(62, 17);
            this.contrast_label.TabIndex = 5;
            this.contrast_label.Text = "Contrast:";
            // 
            // interface_panel
            // 
            this.interface_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.interface_panel.Controls.Add(this.panel3);
            this.interface_panel.Controls.Add(this.panel2);
            this.interface_panel.Controls.Add(this.panel1);
            this.interface_panel.Location = new System.Drawing.Point(1083, 28);
            this.interface_panel.Name = "interface_panel";
            this.interface_panel.Size = new System.Drawing.Size(291, 721);
            this.interface_panel.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.contrast_value_textBox);
            this.panel3.Controls.Add(this.brightness_value_textBox);
            this.panel3.Controls.Add(this.contrast_apply_button);
            this.panel3.Controls.Add(this.brightness_label);
            this.panel3.Controls.Add(this.brightness_apply_button);
            this.panel3.Controls.Add(this.contrast_label);
            this.panel3.Controls.Add(this.contrast_trackBar);
            this.panel3.Controls.Add(this.brightness_trackBar);
            this.panel3.Location = new System.Drawing.Point(3, 503);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(285, 188);
            this.panel3.TabIndex = 3;
            this.panel3.Visible = false;
            // 
            // contrast_apply_button
            // 
            this.contrast_apply_button.Location = new System.Drawing.Point(182, 121);
            this.contrast_apply_button.Name = "contrast_apply_button";
            this.contrast_apply_button.Size = new System.Drawing.Size(75, 23);
            this.contrast_apply_button.TabIndex = 8;
            this.contrast_apply_button.Text = "Apply";
            this.contrast_apply_button.UseVisualStyleBackColor = true;
            this.contrast_apply_button.Click += new System.EventHandler(this.Contrast_apply_button_Click);
            // 
            // brightness_apply_button
            // 
            this.brightness_apply_button.Location = new System.Drawing.Point(182, 24);
            this.brightness_apply_button.Name = "brightness_apply_button";
            this.brightness_apply_button.Size = new System.Drawing.Size(75, 23);
            this.brightness_apply_button.TabIndex = 8;
            this.brightness_apply_button.Text = "Apply";
            this.brightness_apply_button.UseVisualStyleBackColor = true;
            this.brightness_apply_button.Click += new System.EventHandler(this.Brightness_apply_button_Click);
            // 
            // contrast_trackBar
            // 
            this.contrast_trackBar.LargeChange = 10;
            this.contrast_trackBar.Location = new System.Drawing.Point(32, 136);
            this.contrast_trackBar.Maximum = 100;
            this.contrast_trackBar.Minimum = -100;
            this.contrast_trackBar.Name = "contrast_trackBar";
            this.contrast_trackBar.Size = new System.Drawing.Size(124, 45);
            this.contrast_trackBar.TabIndex = 6;
            this.contrast_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.contrast_trackBar.Scroll += new System.EventHandler(this.Contrast_trackBar_Scroll);
            // 
            // brightness_trackBar
            // 
            this.brightness_trackBar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.brightness_trackBar.LargeChange = 10;
            this.brightness_trackBar.Location = new System.Drawing.Point(32, 42);
            this.brightness_trackBar.Maximum = 100;
            this.brightness_trackBar.Minimum = -100;
            this.brightness_trackBar.Name = "brightness_trackBar";
            this.brightness_trackBar.Size = new System.Drawing.Size(124, 45);
            this.brightness_trackBar.TabIndex = 6;
            this.brightness_trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.brightness_trackBar.Scroll += new System.EventHandler(this.Brightness_trackBar_Scroll);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.mean_filter_button);
            this.panel2.Controls.Add(this.gaussian_button);
            this.panel2.Controls.Add(this.sobel_button);
            this.panel2.Controls.Add(this.sharpen_button);
            this.panel2.Controls.Add(this.prewitt_button);
            this.panel2.Controls.Add(this.laplacian_button);
            this.panel2.Location = new System.Drawing.Point(3, 334);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 149);
            this.panel2.TabIndex = 13;
            this.panel2.Visible = false;
            // 
            // mean_filter_button
            // 
            this.mean_filter_button.Location = new System.Drawing.Point(30, 25);
            this.mean_filter_button.Name = "mean_filter_button";
            this.mean_filter_button.Size = new System.Drawing.Size(108, 23);
            this.mean_filter_button.TabIndex = 9;
            this.mean_filter_button.Text = "Mean Filter";
            this.mean_filter_button.UseVisualStyleBackColor = true;
            this.mean_filter_button.Click += new System.EventHandler(this.Mean_filter_button_Click);
            // 
            // gaussian_button
            // 
            this.gaussian_button.Location = new System.Drawing.Point(149, 97);
            this.gaussian_button.Name = "gaussian_button";
            this.gaussian_button.Size = new System.Drawing.Size(108, 23);
            this.gaussian_button.TabIndex = 12;
            this.gaussian_button.Text = "Gaussian Filter";
            this.gaussian_button.UseVisualStyleBackColor = true;
            this.gaussian_button.Click += new System.EventHandler(this.Gaussian_button_Click);
            // 
            // sobel_button
            // 
            this.sobel_button.Location = new System.Drawing.Point(31, 61);
            this.sobel_button.Name = "sobel_button";
            this.sobel_button.Size = new System.Drawing.Size(108, 23);
            this.sobel_button.TabIndex = 10;
            this.sobel_button.Text = "Sobel Filter";
            this.sobel_button.UseVisualStyleBackColor = true;
            this.sobel_button.Click += new System.EventHandler(this.Sobel_button_Click);
            // 
            // sharpen_button
            // 
            this.sharpen_button.Location = new System.Drawing.Point(149, 61);
            this.sharpen_button.Name = "sharpen_button";
            this.sharpen_button.Size = new System.Drawing.Size(108, 23);
            this.sharpen_button.TabIndex = 12;
            this.sharpen_button.Text = "Sharpen Filter";
            this.sharpen_button.UseVisualStyleBackColor = true;
            this.sharpen_button.Click += new System.EventHandler(this.Sharpen_button_Click);
            // 
            // prewitt_button
            // 
            this.prewitt_button.Location = new System.Drawing.Point(31, 97);
            this.prewitt_button.Name = "prewitt_button";
            this.prewitt_button.Size = new System.Drawing.Size(108, 23);
            this.prewitt_button.TabIndex = 11;
            this.prewitt_button.Text = "Prewitt Filter";
            this.prewitt_button.UseVisualStyleBackColor = true;
            this.prewitt_button.Click += new System.EventHandler(this.Prewitt_button_Click);
            // 
            // laplacian_button
            // 
            this.laplacian_button.Location = new System.Drawing.Point(149, 25);
            this.laplacian_button.Name = "laplacian_button";
            this.laplacian_button.Size = new System.Drawing.Size(108, 23);
            this.laplacian_button.TabIndex = 11;
            this.laplacian_button.Text = "Laplacian Filter";
            this.laplacian_button.UseVisualStyleBackColor = true;
            this.laplacian_button.Click += new System.EventHandler(this.Laplacian_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.red_value_textBox);
            this.panel1.Controls.Add(this.blue_value_textBox);
            this.panel1.Controls.Add(this.green_value_textBox);
            this.panel1.Controls.Add(this.red_trackbar);
            this.panel1.Controls.Add(this.green_trackbar);
            this.panel1.Controls.Add(this.blue_trackbar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 325);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // red_value_textBox
            // 
            this.red_value_textBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.red_value_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.red_value_textBox.Location = new System.Drawing.Point(107, 37);
            this.red_value_textBox.Name = "red_value_textBox";
            this.red_value_textBox.Size = new System.Drawing.Size(29, 21);
            this.red_value_textBox.TabIndex = 3;
            this.red_value_textBox.Text = "0";
            this.red_value_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Red_value_textBox_KeyDown);
            // 
            // blue_value_textBox
            // 
            this.blue_value_textBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.blue_value_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.blue_value_textBox.Location = new System.Drawing.Point(107, 213);
            this.blue_value_textBox.Name = "blue_value_textBox";
            this.blue_value_textBox.Size = new System.Drawing.Size(29, 21);
            this.blue_value_textBox.TabIndex = 3;
            this.blue_value_textBox.Text = "0";
            this.blue_value_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Blue_value_textBox_KeyDown);
            // 
            // green_value_textBox
            // 
            this.green_value_textBox.BackColor = System.Drawing.SystemColors.ControlDark;
            this.green_value_textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.green_value_textBox.Location = new System.Drawing.Point(107, 125);
            this.green_value_textBox.Name = "green_value_textBox";
            this.green_value_textBox.Size = new System.Drawing.Size(29, 21);
            this.green_value_textBox.TabIndex = 3;
            this.green_value_textBox.Text = "0";
            this.green_value_textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Green_value_textBox_KeyDown);
            // 
            // red_trackbar
            // 
            this.red_trackbar.Location = new System.Drawing.Point(37, 58);
            this.red_trackbar.Maximum = 255;
            this.red_trackbar.Name = "red_trackbar";
            this.red_trackbar.Size = new System.Drawing.Size(124, 45);
            this.red_trackbar.TabIndex = 3;
            this.red_trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.red_trackbar.Scroll += new System.EventHandler(this.Red_trackbar_Scroll);
            // 
            // green_trackbar
            // 
            this.green_trackbar.Location = new System.Drawing.Point(37, 149);
            this.green_trackbar.Maximum = 255;
            this.green_trackbar.Name = "green_trackbar";
            this.green_trackbar.Size = new System.Drawing.Size(124, 45);
            this.green_trackbar.TabIndex = 3;
            this.green_trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.green_trackbar.Scroll += new System.EventHandler(this.Green_trackbar_Scroll);
            // 
            // blue_trackbar
            // 
            this.blue_trackbar.Location = new System.Drawing.Point(37, 240);
            this.blue_trackbar.Maximum = 255;
            this.blue_trackbar.Name = "blue_trackbar";
            this.blue_trackbar.Size = new System.Drawing.Size(124, 45);
            this.blue_trackbar.TabIndex = 3;
            this.blue_trackbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.blue_trackbar.Scroll += new System.EventHandler(this.Blue_trackbar_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Red:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Green:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Blue:";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1384, 761);
            this.Controls.Add(this.interface_panel);
            this.Controls.Add(this.main_photo_pictureBox);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Photo Editor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_photo_pictureBox)).EndInit();
            this.interface_panel.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contrast_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.brightness_trackBar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.red_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.green_trackbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blue_trackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ımageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem layerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.PictureBox main_photo_pictureBox;
        private System.Windows.Forms.TextBox brightness_value_textBox;
        private System.Windows.Forms.TextBox contrast_value_textBox;
        private System.Windows.Forms.Label brightness_label;
        private System.Windows.Forms.Label contrast_label;
        private System.Windows.Forms.Panel interface_panel;
        private System.Windows.Forms.TrackBar brightness_trackBar;
        private System.Windows.Forms.TrackBar contrast_trackBar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar blue_trackbar;
        private System.Windows.Forms.TrackBar green_trackbar;
        private System.Windows.Forms.TrackBar red_trackbar;
        private System.Windows.Forms.Button brightness_apply_button;
        private System.Windows.Forms.Button contrast_apply_button;
        private System.Windows.Forms.Button gaussian_button;
        private System.Windows.Forms.Button sharpen_button;
        private System.Windows.Forms.Button laplacian_button;
        private System.Windows.Forms.Button prewitt_button;
        private System.Windows.Forms.Button sobel_button;
        private System.Windows.Forms.Button mean_filter_button;
        private System.Windows.Forms.TextBox red_value_textBox;
        private System.Windows.Forms.TextBox green_value_textBox;
        private System.Windows.Forms.TextBox blue_value_textBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem colorFilterToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem originalSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullscreenToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem specialFiltersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brightnessContrastToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
    }
}

