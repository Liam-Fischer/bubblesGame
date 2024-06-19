namespace bubblesGame
{
    partial class gameSpace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gameSpace));
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.testLabel = new System.Windows.Forms.Label();
            this.pointMoveTimer = new System.Windows.Forms.Timer(this.components);
            this.pointLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.infoLabel1 = new System.Windows.Forms.Label();
            this.infoLabel2 = new System.Windows.Forms.Label();
            this.infoLabel3 = new System.Windows.Forms.Label();
            this.infoLabel4 = new System.Windows.Forms.Label();
            this.infoLabel5 = new System.Windows.Forms.Label();
            this.infoLabel6 = new System.Windows.Forms.Label();
            this.infoLabel7 = new System.Windows.Forms.Label();
            this.infoLabel8 = new System.Windows.Forms.Label();
            this.infoLabel9 = new System.Windows.Forms.Label();
            this.infoLabel10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 50;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // testLabel
            // 
            this.testLabel.AutoSize = true;
            this.testLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testLabel.Location = new System.Drawing.Point(385, 60);
            this.testLabel.Name = "testLabel";
            this.testLabel.Size = new System.Drawing.Size(0, 16);
            this.testLabel.TabIndex = 0;
            // 
            // pointMoveTimer
            // 
            this.pointMoveTimer.Interval = 210;
            this.pointMoveTimer.Tick += new System.EventHandler(this.pointMoveTimer_Tick);
            // 
            // pointLabel
            // 
            this.pointLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(34)))), ((int)(((byte)(254)))));
            this.pointLabel.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pointLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.pointLabel.Location = new System.Drawing.Point(75, 25);
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(112, 30);
            this.pointLabel.TabIndex = 1;
            this.pointLabel.Text = "Points: ";
            this.pointLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.titleLabel.Location = new System.Drawing.Point(180, 119);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(360, 118);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "B u b b l e s";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // infoLabel1
            // 
            this.infoLabel1.AutoSize = true;
            this.infoLabel1.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.infoLabel1.Location = new System.Drawing.Point(301, 192);
            this.infoLabel1.Name = "infoLabel1";
            this.infoLabel1.Size = new System.Drawing.Size(98, 19);
            this.infoLabel1.TabIndex = 3;
            this.infoLabel1.Text = "This is you";
            this.infoLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoLabel2
            // 
            this.infoLabel2.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.infoLabel2.Location = new System.Drawing.Point(139, 207);
            this.infoLabel2.Name = "infoLabel2";
            this.infoLabel2.Size = new System.Drawing.Size(112, 30);
            this.infoLabel2.TabIndex = 4;
            this.infoLabel2.Text = "Touch these";
            this.infoLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoLabel3
            // 
            this.infoLabel3.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.infoLabel3.Location = new System.Drawing.Point(438, 207);
            this.infoLabel3.Name = "infoLabel3";
            this.infoLabel3.Size = new System.Drawing.Size(159, 41);
            this.infoLabel3.TabIndex = 5;
            this.infoLabel3.Text = " Don\'t touch these";
            this.infoLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoLabel4
            // 
            this.infoLabel4.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel4.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.infoLabel4.Location = new System.Drawing.Point(524, 262);
            this.infoLabel4.Name = "infoLabel4";
            this.infoLabel4.Size = new System.Drawing.Size(113, 71);
            this.infoLabel4.TabIndex = 6;
            this.infoLabel4.Text = "unless your max size then 110 pts";
            this.infoLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoLabel5
            // 
            this.infoLabel5.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.infoLabel5.Location = new System.Drawing.Point(357, 382);
            this.infoLabel5.Name = "infoLabel5";
            this.infoLabel5.Size = new System.Drawing.Size(140, 41);
            this.infoLabel5.TabIndex = 7;
            this.infoLabel5.Text = "Or these";
            this.infoLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // infoLabel6
            // 
            this.infoLabel6.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel6.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.infoLabel6.Location = new System.Drawing.Point(205, 249);
            this.infoLabel6.Name = "infoLabel6";
            this.infoLabel6.Size = new System.Drawing.Size(106, 33);
            this.infoLabel6.TabIndex = 8;
            this.infoLabel6.Text = "= 50 pts";
            this.infoLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoLabel7
            // 
            this.infoLabel7.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel7.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.infoLabel7.Location = new System.Drawing.Point(205, 313);
            this.infoLabel7.Name = "infoLabel7";
            this.infoLabel7.Size = new System.Drawing.Size(106, 33);
            this.infoLabel7.TabIndex = 9;
            this.infoLabel7.Text = "= 70 pts";
            this.infoLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoLabel8
            // 
            this.infoLabel8.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel8.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.infoLabel8.Location = new System.Drawing.Point(205, 377);
            this.infoLabel8.Name = "infoLabel8";
            this.infoLabel8.Size = new System.Drawing.Size(106, 33);
            this.infoLabel8.TabIndex = 10;
            this.infoLabel8.Text = "= 90 pts";
            this.infoLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoLabel9
            // 
            this.infoLabel9.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel9.Font = new System.Drawing.Font("Cooper Black", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.infoLabel9.Location = new System.Drawing.Point(278, 436);
            this.infoLabel9.Name = "infoLabel9";
            this.infoLabel9.Size = new System.Drawing.Size(139, 30);
            this.infoLabel9.TabIndex = 11;
            this.infoLabel9.Text = "Space to start!";
            this.infoLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoLabel10
            // 
            this.infoLabel10.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel10.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(220)))), ((int)(((byte)(225)))));
            this.infoLabel10.Location = new System.Drawing.Point(305, 337);
            this.infoLabel10.Name = "infoLabel10";
            this.infoLabel10.Size = new System.Drawing.Size(112, 45);
            this.infoLabel10.TabIndex = 12;
            this.infoLabel10.Text = "Never touch this";
            this.infoLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameSpace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(700, 550);
            this.Controls.Add(this.infoLabel10);
            this.Controls.Add(this.infoLabel9);
            this.Controls.Add(this.infoLabel8);
            this.Controls.Add(this.infoLabel7);
            this.Controls.Add(this.infoLabel6);
            this.Controls.Add(this.infoLabel5);
            this.Controls.Add(this.infoLabel4);
            this.Controls.Add(this.infoLabel3);
            this.Controls.Add(this.infoLabel2);
            this.Controls.Add(this.infoLabel1);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.pointLabel);
            this.Controls.Add(this.testLabel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "gameSpace";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label testLabel;
        private System.Windows.Forms.Timer pointMoveTimer;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label infoLabel1;
        private System.Windows.Forms.Label infoLabel2;
        private System.Windows.Forms.Label infoLabel3;
        private System.Windows.Forms.Label infoLabel4;
        private System.Windows.Forms.Label infoLabel5;
        private System.Windows.Forms.Label infoLabel6;
        private System.Windows.Forms.Label infoLabel7;
        private System.Windows.Forms.Label infoLabel8;
        private System.Windows.Forms.Label infoLabel9;
        private System.Windows.Forms.Label infoLabel10;
    }
}

