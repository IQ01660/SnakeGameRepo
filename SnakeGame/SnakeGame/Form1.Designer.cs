namespace SnakeGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.upBtn = new System.Windows.Forms.Button();
            this.leftBtn = new System.Windows.Forms.Button();
            this.downBtn = new System.Windows.Forms.Button();
            this.rightBtn = new System.Windows.Forms.Button();
            this.upTimer = new System.Windows.Forms.Timer(this.components);
            this.downTimer = new System.Windows.Forms.Timer(this.components);
            this.leftTimer = new System.Windows.Forms.Timer(this.components);
            this.rightTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // upBtn
            // 
            this.upBtn.Location = new System.Drawing.Point(1037, 384);
            this.upBtn.Name = "upBtn";
            this.upBtn.Size = new System.Drawing.Size(75, 52);
            this.upBtn.TabIndex = 1;
            this.upBtn.Text = "UP";
            this.upBtn.UseVisualStyleBackColor = true;
            this.upBtn.Click += new System.EventHandler(this.upBtn_Click);
            // 
            // leftBtn
            // 
            this.leftBtn.Location = new System.Drawing.Point(945, 442);
            this.leftBtn.Name = "leftBtn";
            this.leftBtn.Size = new System.Drawing.Size(75, 52);
            this.leftBtn.TabIndex = 2;
            this.leftBtn.Text = "LEFT";
            this.leftBtn.UseVisualStyleBackColor = true;
            this.leftBtn.Click += new System.EventHandler(this.leftBtn_Click);
            // 
            // downBtn
            // 
            this.downBtn.Location = new System.Drawing.Point(1037, 442);
            this.downBtn.Name = "downBtn";
            this.downBtn.Size = new System.Drawing.Size(75, 52);
            this.downBtn.TabIndex = 3;
            this.downBtn.Text = "DOWN";
            this.downBtn.UseVisualStyleBackColor = true;
            this.downBtn.Click += new System.EventHandler(this.downBtn_Click);
            // 
            // rightBtn
            // 
            this.rightBtn.Location = new System.Drawing.Point(1132, 442);
            this.rightBtn.Name = "rightBtn";
            this.rightBtn.Size = new System.Drawing.Size(75, 52);
            this.rightBtn.TabIndex = 4;
            this.rightBtn.Text = "RIGHT";
            this.rightBtn.UseVisualStyleBackColor = true;
            this.rightBtn.Click += new System.EventHandler(this.rightBtn_Click);
            // 
            // upTimer
            // 
            this.upTimer.Interval = 200;
            this.upTimer.Tick += new System.EventHandler(this.upTimer_Tick);
            // 
            // downTimer
            // 
            this.downTimer.Interval = 200;
            this.downTimer.Tick += new System.EventHandler(this.downTimer_Tick);
            // 
            // leftTimer
            // 
            this.leftTimer.Interval = 200;
            this.leftTimer.Tick += new System.EventHandler(this.leftTimer_Tick);
            // 
            // rightTimer
            // 
            this.rightTimer.Interval = 200;
            this.rightTimer.Tick += new System.EventHandler(this.rightTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::SnakeGame.Properties.Resources.treesBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1240, 500);
            this.Controls.Add(this.rightBtn);
            this.Controls.Add(this.downBtn);
            this.Controls.Add(this.leftBtn);
            this.Controls.Add(this.upBtn);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "SnakeGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button upBtn;
        private System.Windows.Forms.Button leftBtn;
        private System.Windows.Forms.Button downBtn;
        private System.Windows.Forms.Button rightBtn;
        private System.Windows.Forms.Timer upTimer;
        private System.Windows.Forms.Timer downTimer;
        private System.Windows.Forms.Timer leftTimer;
        private System.Windows.Forms.Timer rightTimer;
    }
}

