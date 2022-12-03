namespace Login
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.bunifuGradientPanel1 = new Bunifu.UI.WinForms.BunifuGradientPanel();
            this.circlebar = new Bunifu.UI.WinForms.BunifuCircleProgress();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderRadius = 1;
            this.bunifuGradientPanel1.Controls.Add(this.circlebar);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.RoyalBlue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(970, 428);
            this.bunifuGradientPanel1.TabIndex = 2;
            // 
            // circlebar
            // 
            this.circlebar.Animated = true;
            this.circlebar.AnimationInterval = 1;
            this.circlebar.AnimationSpeed = 1;
            this.circlebar.BackColor = System.Drawing.Color.Transparent;
            this.circlebar.CircleMargin = 10;
            this.circlebar.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold);
            this.circlebar.ForeColor = System.Drawing.Color.Black;
            this.circlebar.IsPercentage = true;
            this.circlebar.LineProgressThickness = 10;
            this.circlebar.LineThickness = 10;
            this.circlebar.Location = new System.Drawing.Point(385, 95);
            this.circlebar.Name = "circlebar";
            this.circlebar.ProgressAnimationSpeed = 200;
            this.circlebar.ProgressBackColor = System.Drawing.Color.Transparent;
            this.circlebar.ProgressColor = System.Drawing.Color.Cyan;
            this.circlebar.ProgressColor2 = System.Drawing.Color.Cyan;
            this.circlebar.ProgressEndCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.circlebar.ProgressFillStyle = Bunifu.UI.WinForms.BunifuCircleProgress.FillStyles.Solid;
            this.circlebar.ProgressStartCap = Bunifu.UI.WinForms.BunifuCircleProgress.CapStyles.Round;
            this.circlebar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.circlebar.Size = new System.Drawing.Size(184, 184);
            this.circlebar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.circlebar.SubScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circlebar.SubScriptMargin = new System.Windows.Forms.Padding(5, -20, 0, 0);
            this.circlebar.SubScriptText = "%";
            this.circlebar.SuperScriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.circlebar.SuperScriptMargin = new System.Windows.Forms.Padding(5, 50, 0, 0);
            this.circlebar.SuperScriptText = "%";
            this.circlebar.TabIndex = 16;
            this.circlebar.Text = "0";
            this.circlebar.TextMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.circlebar.ValueByTransition = 0;
            this.circlebar.ValueMargin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 428);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.UI.WinForms.BunifuCircleProgress circlebar;
        private System.Windows.Forms.Timer timer1;
    }
}