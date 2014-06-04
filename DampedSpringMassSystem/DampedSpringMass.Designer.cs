namespace DampedHarmonicOscillator
{
    partial class DampedSpringMass
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
            this.stiffness = new System.Windows.Forms.TextBox();
            this.mass = new System.Windows.Forms.TextBox();
            this.dampingCoeff = new System.Windows.Forms.TextBox();
            this.label_k = new System.Windows.Forms.Label();
            this.label_mass = new System.Windows.Forms.Label();
            this.label_dampingCoeff = new System.Windows.Forms.Label();
            this.button_startSim = new System.Windows.Forms.Button();
            this.max_x = new System.Windows.Forms.TextBox();
            this.label_initialDisplacement = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureWall = new System.Windows.Forms.PictureBox();
            this.pictureMass = new System.Windows.Forms.PictureBox();
            this.pictureSpring = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWall)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpring)).BeginInit();
            this.SuspendLayout();
            // 
            // stiffness
            // 
            this.stiffness.Location = new System.Drawing.Point(29, 61);
            this.stiffness.Name = "stiffness";
            this.stiffness.Size = new System.Drawing.Size(100, 20);
            this.stiffness.TabIndex = 2;
            // 
            // mass
            // 
            this.mass.Location = new System.Drawing.Point(145, 61);
            this.mass.Name = "mass";
            this.mass.Size = new System.Drawing.Size(100, 20);
            this.mass.TabIndex = 3;
            // 
            // dampingCoeff
            // 
            this.dampingCoeff.Location = new System.Drawing.Point(267, 61);
            this.dampingCoeff.Name = "dampingCoeff";
            this.dampingCoeff.Size = new System.Drawing.Size(100, 20);
            this.dampingCoeff.TabIndex = 4;
            // 
            // label_k
            // 
            this.label_k.AutoSize = true;
            this.label_k.Location = new System.Drawing.Point(26, 45);
            this.label_k.Name = "label_k";
            this.label_k.Size = new System.Drawing.Size(97, 13);
            this.label_k.TabIndex = 5;
            this.label_k.Text = "Spring Constant, k:";
            this.label_k.UseWaitCursor = true;
            // 
            // label_mass
            // 
            this.label_mass.AutoSize = true;
            this.label_mass.Location = new System.Drawing.Point(142, 45);
            this.label_mass.Name = "label_mass";
            this.label_mass.Size = new System.Drawing.Size(49, 13);
            this.label_mass.TabIndex = 6;
            this.label_mass.Text = "Mass, m:";
            // 
            // label_dampingCoeff
            // 
            this.label_dampingCoeff.AutoSize = true;
            this.label_dampingCoeff.Location = new System.Drawing.Point(264, 45);
            this.label_dampingCoeff.Name = "label_dampingCoeff";
            this.label_dampingCoeff.Size = new System.Drawing.Size(95, 13);
            this.label_dampingCoeff.TabIndex = 7;
            this.label_dampingCoeff.Text = "Damping Coeff., c:";
            // 
            // button_startSim
            // 
            this.button_startSim.Location = new System.Drawing.Point(512, 61);
            this.button_startSim.Name = "button_startSim";
            this.button_startSim.Size = new System.Drawing.Size(100, 20);
            this.button_startSim.TabIndex = 8;
            this.button_startSim.Text = "Start Simulation";
            this.button_startSim.UseVisualStyleBackColor = true;
            this.button_startSim.Click += new System.EventHandler(this.button_startSim_Click);
            // 
            // max_x
            // 
            this.max_x.Location = new System.Drawing.Point(392, 61);
            this.max_x.Name = "max_x";
            this.max_x.Size = new System.Drawing.Size(100, 20);
            this.max_x.TabIndex = 9;
            // 
            // label_initialDisplacement
            // 
            this.label_initialDisplacement.AutoSize = true;
            this.label_initialDisplacement.Location = new System.Drawing.Point(389, 45);
            this.label_initialDisplacement.Name = "label_initialDisplacement";
            this.label_initialDisplacement.Size = new System.Drawing.Size(100, 13);
            this.label_initialDisplacement.TabIndex = 10;
            this.label_initialDisplacement.Text = "Max. Displacement:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DampedHarmonicOscillator.Properties.Resources.equation;
            this.pictureBox1.Location = new System.Drawing.Point(58, 295);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(530, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // pictureWall
            // 
            this.pictureWall.Image = global::DampedHarmonicOscillator.Properties.Resources.wall;
            this.pictureWall.Location = new System.Drawing.Point(29, 130);
            this.pictureWall.Name = "pictureWall";
            this.pictureWall.Size = new System.Drawing.Size(20, 178);
            this.pictureWall.TabIndex = 0;
            this.pictureWall.TabStop = false;
            // 
            // pictureMass
            // 
            this.pictureMass.Image = global::DampedHarmonicOscillator.Properties.Resources.mass;
            this.pictureMass.Location = new System.Drawing.Point(245, 164);
            this.pictureMass.Name = "pictureMass";
            this.pictureMass.Size = new System.Drawing.Size(124, 113);
            this.pictureMass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMass.TabIndex = 15;
            this.pictureMass.TabStop = false;
            // 
            // pictureSpring
            // 
            this.pictureSpring.Image = global::DampedHarmonicOscillator.Properties.Resources.SpringImage;
            this.pictureSpring.Location = new System.Drawing.Point(45, 201);
            this.pictureSpring.Name = "pictureSpring";
            this.pictureSpring.Size = new System.Drawing.Size(200, 50);
            this.pictureSpring.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSpring.TabIndex = 1;
            this.pictureSpring.TabStop = false;
            // 
            // DampedSpringMass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 393);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureWall);
            this.Controls.Add(this.pictureMass);
            this.Controls.Add(this.label_initialDisplacement);
            this.Controls.Add(this.max_x);
            this.Controls.Add(this.button_startSim);
            this.Controls.Add(this.label_dampingCoeff);
            this.Controls.Add(this.label_mass);
            this.Controls.Add(this.label_k);
            this.Controls.Add(this.dampingCoeff);
            this.Controls.Add(this.mass);
            this.Controls.Add(this.stiffness);
            this.Controls.Add(this.pictureSpring);
            this.Name = "DampedSpringMass";
            this.Text = "Underdamped Spring-Mass System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWall)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpring)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureWall;
        private System.Windows.Forms.PictureBox pictureSpring;
        private System.Windows.Forms.TextBox stiffness;
        private System.Windows.Forms.TextBox mass;
        private System.Windows.Forms.TextBox dampingCoeff;
        private System.Windows.Forms.Label label_k;
        private System.Windows.Forms.Label label_mass;
        private System.Windows.Forms.Label label_dampingCoeff;
        private System.Windows.Forms.Button button_startSim;
        private System.Windows.Forms.TextBox max_x;
        private System.Windows.Forms.Label label_initialDisplacement;
        private System.Windows.Forms.PictureBox pictureMass;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

