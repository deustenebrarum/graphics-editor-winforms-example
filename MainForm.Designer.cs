namespace StudentsPaint
{
    partial class MainForm
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
            _toolStrip = new ToolStrip();
            _pencilButton = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            _colorButton = new ToolStripButton();
            _menuStrip = new MenuStrip();
            _fileToolStripMenuItem = new ToolStripMenuItem();
            _buttonCreate = new ToolStripMenuItem();
            _statusBar = new StatusStrip();
            _coordsLabel = new ToolStripStatusLabel();
            _pictureContainer = new Panel();
            _picture = new PictureBox();
            _colorDialog = new ColorDialog();
            _toolStrip.SuspendLayout();
            _menuStrip.SuspendLayout();
            _statusBar.SuspendLayout();
            _pictureContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)_picture).BeginInit();
            SuspendLayout();
            // 
            // _toolStrip
            // 
            _toolStrip.BackColor = SystemColors.Control;
            _toolStrip.Items.AddRange(new ToolStripItem[] { _pencilButton, toolStripButton1, toolStripSeparator1, _colorButton });
            _toolStrip.Location = new Point(0, 24);
            _toolStrip.Name = "_toolStrip";
            _toolStrip.Size = new Size(800, 25);
            _toolStrip.TabIndex = 1;
            _toolStrip.Text = "toolStrip1";
            // 
            // _pencilButton
            // 
            _pencilButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _pencilButton.Image = Properties.Resources.pencil;
            _pencilButton.ImageTransparentColor = Color.Magenta;
            _pencilButton.Name = "_pencilButton";
            _pencilButton.Size = new Size(23, 22);
            _pencilButton.Text = "toolStripButton1";
            _pencilButton.Click += OnPencilChoosen;
            // 
            // toolStripButton1
            // 
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = Properties.Resources.square;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // _colorButton
            // 
            _colorButton.BackColor = Color.Black;
            _colorButton.DisplayStyle = ToolStripItemDisplayStyle.Image;
            _colorButton.ImageTransparentColor = Color.Magenta;
            _colorButton.Name = "_colorButton";
            _colorButton.Size = new Size(23, 22);
            _colorButton.Text = "toolStripButton2";
            _colorButton.Click += OnColorChoosen;
            // 
            // _menuStrip
            // 
            _menuStrip.Items.AddRange(new ToolStripItem[] { _fileToolStripMenuItem });
            _menuStrip.Location = new Point(0, 0);
            _menuStrip.Name = "_menuStrip";
            _menuStrip.Size = new Size(800, 24);
            _menuStrip.TabIndex = 2;
            _menuStrip.Text = "menuStrip1";
            // 
            // _fileToolStripMenuItem
            // 
            _fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { _buttonCreate });
            _fileToolStripMenuItem.Name = "_fileToolStripMenuItem";
            _fileToolStripMenuItem.Size = new Size(48, 20);
            _fileToolStripMenuItem.Text = "Файл";
            // 
            // _buttonCreate
            // 
            _buttonCreate.Name = "_buttonCreate";
            _buttonCreate.Size = new Size(117, 22);
            _buttonCreate.Text = "Создать";
            _buttonCreate.Click += CreateNewImage;
            // 
            // _statusBar
            // 
            _statusBar.Items.AddRange(new ToolStripItem[] { _coordsLabel });
            _statusBar.Location = new Point(0, 428);
            _statusBar.Name = "_statusBar";
            _statusBar.Size = new Size(800, 22);
            _statusBar.TabIndex = 3;
            _statusBar.Text = "statusStrip1";
            // 
            // _coordsLabel
            // 
            _coordsLabel.Name = "_coordsLabel";
            _coordsLabel.Size = new Size(51, 17);
            _coordsLabel.Text = "X: 0, Y: 0";
            // 
            // _pictureContainer
            // 
            _pictureContainer.AutoScroll = true;
            _pictureContainer.Controls.Add(_picture);
            _pictureContainer.Dock = DockStyle.Fill;
            _pictureContainer.Location = new Point(0, 49);
            _pictureContainer.Name = "_pictureContainer";
            _pictureContainer.Size = new Size(800, 379);
            _pictureContainer.TabIndex = 4;
            // 
            // _picture
            // 
            _picture.Location = new Point(16, 16);
            _picture.Name = "_picture";
            _picture.Size = new Size(100, 50);
            _picture.TabIndex = 0;
            _picture.TabStop = false;
            _picture.MouseDown += _picture_MouseDown;
            _picture.MouseMove += _picture_MouseMove;
            _picture.MouseUp += _picture_MouseUp;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(_pictureContainer);
            Controls.Add(_statusBar);
            Controls.Add(_toolStrip);
            Controls.Add(_menuStrip);
            MainMenuStrip = _menuStrip;
            Name = "MainForm";
            Text = "MainForm";
            _toolStrip.ResumeLayout(false);
            _toolStrip.PerformLayout();
            _menuStrip.ResumeLayout(false);
            _menuStrip.PerformLayout();
            _statusBar.ResumeLayout(false);
            _statusBar.PerformLayout();
            _pictureContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)_picture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip _toolStrip;
        private MenuStrip _menuStrip;
        private ToolStripMenuItem _fileToolStripMenuItem;
        private StatusStrip _statusBar;
        private Panel _pictureContainer;
        private PictureBox _picture;
        private ToolStripMenuItem _buttonCreate;
        private ToolStripStatusLabel _coordsLabel;
        private ToolStripButton _pencilButton;
        private ToolStripButton toolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton _colorButton;
        private ColorDialog _colorDialog;
    }
}
