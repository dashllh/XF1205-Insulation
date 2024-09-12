
namespace XF1205_Insulation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnNewTest = new Button();
            btnAbout = new Button();
            btnQuit = new Button();
            SuspendLayout();
            // 
            // btnNewTest
            // 
            btnNewTest.BackColor = Color.FromArgb(79, 105, 145);
            btnNewTest.FlatAppearance.BorderColor = Color.White;
            btnNewTest.FlatStyle = FlatStyle.Flat;
            btnNewTest.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNewTest.ForeColor = Color.White;
            btnNewTest.Image = (Image)resources.GetObject("btnNewTest.Image");
            btnNewTest.ImageAlign = ContentAlignment.TopCenter;
            btnNewTest.Location = new Point(46, 423);
            btnNewTest.Margin = new Padding(2, 3, 2, 3);
            btnNewTest.Name = "btnNewTest";
            btnNewTest.Size = new Size(109, 37);
            btnNewTest.TabIndex = 0;
            btnNewTest.Text = "试验记录";
            btnNewTest.TextAlign = ContentAlignment.MiddleLeft;
            btnNewTest.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnNewTest.UseVisualStyleBackColor = false;
            btnNewTest.Click += btnNewTest_Click;
            // 
            // btnAbout
            // 
            btnAbout.BackColor = Color.FromArgb(79, 105, 145);
            btnAbout.FlatAppearance.BorderColor = Color.White;
            btnAbout.FlatStyle = FlatStyle.Flat;
            btnAbout.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAbout.ForeColor = Color.White;
            btnAbout.Image = (Image)resources.GetObject("btnAbout.Image");
            btnAbout.ImageAlign = ContentAlignment.TopCenter;
            btnAbout.Location = new Point(183, 423);
            btnAbout.Margin = new Padding(2, 3, 2, 3);
            btnAbout.Name = "btnAbout";
            btnAbout.Size = new Size(109, 37);
            btnAbout.TabIndex = 1;
            btnAbout.Text = "关于系统";
            btnAbout.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnAbout.UseVisualStyleBackColor = false;
            btnAbout.Click += btnAbout_Click;
            // 
            // btnQuit
            // 
            btnQuit.BackColor = Color.FromArgb(79, 105, 145);
            btnQuit.FlatAppearance.BorderColor = Color.White;
            btnQuit.FlatStyle = FlatStyle.Flat;
            btnQuit.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnQuit.ForeColor = Color.White;
            btnQuit.Image = (Image)resources.GetObject("btnQuit.Image");
            btnQuit.ImageAlign = ContentAlignment.MiddleLeft;
            btnQuit.Location = new Point(320, 423);
            btnQuit.Margin = new Padding(2, 3, 2, 3);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(109, 37);
            btnQuit.TabIndex = 2;
            btnQuit.Text = "退出";
            btnQuit.TextAlign = ContentAlignment.MiddleRight;
            btnQuit.TextImageRelation = TextImageRelation.TextBeforeImage;
            btnQuit.UseVisualStyleBackColor = false;
            btnQuit.Click += btnQuit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1052, 592);
            Controls.Add(btnQuit);
            Controls.Add(btnAbout);
            Controls.Add(btnNewTest);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "灭火毯绝缘性能试验系统  版本 2.0";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNewTest;
        private Button btnAbout;
        private Button btnQuit;
    }
}
