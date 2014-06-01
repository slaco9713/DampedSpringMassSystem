namespace MovingBall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.football = new System.Windows.Forms.PictureBox();
            this.upperWall = new System.Windows.Forms.PictureBox();
            this.lowerWall = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.football)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerWall)).BeginInit();
            this.SuspendLayout();
            // 
            // football
            // 
            this.football.Image = global::MovingBall.Properties.Resources.football1;
            this.football.InitialImage = global::MovingBall.Properties.Resources.football1;
            this.football.Location = new System.Drawing.Point(156, 289);
            this.football.Name = "football";
            this.football.Size = new System.Drawing.Size(170, 163);
            this.football.TabIndex = 0;
            this.football.TabStop = false;
            // 
            // upperWall
            // 
            this.upperWall.Image = ((System.Drawing.Image)(resources.GetObject("upperWall.Image")));
            this.upperWall.Location = new System.Drawing.Point(92, 0);
            this.upperWall.Name = "upperWall";
            this.upperWall.Size = new System.Drawing.Size(298, 17);
            this.upperWall.TabIndex = 1;
            this.upperWall.TabStop = false;
            // 
            // lowerWall
            // 
            this.lowerWall.Image = ((System.Drawing.Image)(resources.GetObject("lowerWall.Image")));
            this.lowerWall.Location = new System.Drawing.Point(92, 458);
            this.lowerWall.Name = "lowerWall";
            this.lowerWall.Size = new System.Drawing.Size(298, 17);
            this.lowerWall.TabIndex = 2;
            this.lowerWall.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-2, 452);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Move Ball";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickHandler);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 477);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lowerWall);
            this.Controls.Add(this.upperWall);
            this.Controls.Add(this.football);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.football)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerWall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox football;
        private System.Windows.Forms.PictureBox upperWall;
        private System.Windows.Forms.PictureBox lowerWall;
        private System.Windows.Forms.Button button1;
    }
}

