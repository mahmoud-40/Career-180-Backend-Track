namespace Notepad
{
    partial class MyNotepad
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyNotepad));
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            rtb_body = new RichTextBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            open_button = new Button();
            Save = new Button();
            Clear = new Button();
            change_font_button = new Button();
            change_color_button = new Button();
            saveFD = new SaveFileDialog();
            openFD = new OpenFileDialog();
            fontDialog = new FontDialog();
            colorDialog = new ColorDialog();
            background_color = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openToolStripMenuItem, newToolStripMenuItem, saveToolStripMenuItem, saveAsToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(141, 26);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(141, 26);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(141, 26);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(141, 26);
            saveAsToolStripMenuItem.Text = "Save as";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(141, 26);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // rtb_body
            // 
            rtb_body.BackColor = SystemColors.Window;
            rtb_body.HideSelection = false;
            rtb_body.Location = new Point(0, 146);
            rtb_body.Name = "rtb_body";
            rtb_body.Size = new Size(800, 312);
            rtb_body.TabIndex = 1;
            rtb_body.Text = "";
            rtb_body.TextChanged += rtb_body_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 96);
            label1.Name = "label1";
            label1.Size = new Size(124, 28);
            label1.TabIndex = 2;
            label1.Text = "MyNotepad";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(24, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // open_button
            // 
            open_button.BackColor = Color.DarkSeaGreen;
            open_button.Cursor = Cursors.IBeam;
            open_button.Location = new Point(188, 31);
            open_button.Name = "open_button";
            open_button.Size = new Size(191, 29);
            open_button.TabIndex = 4;
            open_button.Text = "Open";
            open_button.UseVisualStyleBackColor = false;
            open_button.Click += open_button_Click;
            // 
            // Save
            // 
            Save.BackColor = SystemColors.GradientInactiveCaption;
            Save.Location = new Point(385, 31);
            Save.Name = "Save";
            Save.Size = new Size(198, 29);
            Save.TabIndex = 5;
            Save.Text = "Save";
            Save.UseVisualStyleBackColor = false;
            Save.Click += Save_Click;
            // 
            // Clear
            // 
            Clear.BackColor = SystemColors.ButtonShadow;
            Clear.Location = new Point(589, 31);
            Clear.Name = "Clear";
            Clear.Size = new Size(152, 29);
            Clear.TabIndex = 6;
            Clear.Text = "Clear";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // change_font_button
            // 
            change_font_button.BackColor = Color.Khaki;
            change_font_button.Location = new Point(385, 90);
            change_font_button.Name = "change_font_button";
            change_font_button.Size = new Size(198, 29);
            change_font_button.TabIndex = 7;
            change_font_button.Text = "Font";
            change_font_button.UseVisualStyleBackColor = false;
            change_font_button.Click += change_font_button_Click;
            // 
            // change_color_button
            // 
            change_color_button.BackColor = Color.Moccasin;
            change_color_button.Location = new Point(589, 90);
            change_color_button.Name = "change_color_button";
            change_color_button.Size = new Size(152, 29);
            change_color_button.TabIndex = 8;
            change_color_button.Text = "Color";
            change_color_button.UseVisualStyleBackColor = false;
            change_color_button.Click += change_color_button_Click;
            // 
            // openFD
            // 
            openFD.FileName = "openFileDialog1";
            // 
            // background_color
            // 
            background_color.BackColor = Color.Thistle;
            background_color.Location = new Point(188, 90);
            background_color.Name = "background_color";
            background_color.Size = new Size(191, 29);
            background_color.TabIndex = 9;
            background_color.Text = "Background Color";
            background_color.UseVisualStyleBackColor = false;
            background_color.Click += background_color_Click;
            // 
            // MyNotepad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 490);
            Controls.Add(background_color);
            Controls.Add(change_color_button);
            Controls.Add(change_font_button);
            Controls.Add(Clear);
            Controls.Add(Save);
            Controls.Add(open_button);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(rtb_body);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MyNotepad";
            Text = "MyNotepad";
            Load += MyNotepad_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private RichTextBox rtb_body;
        private Label label1;
        private PictureBox pictureBox1;
        private Button open_button;
        private Button Save;
        private Button Clear;
        private Button change_font_button;
        private Button change_color_button;
        private SaveFileDialog saveFD;
        private OpenFileDialog openFD;
        private FontDialog fontDialog;
        private ColorDialog colorDialog;
        private Button background_color;
    }
}
