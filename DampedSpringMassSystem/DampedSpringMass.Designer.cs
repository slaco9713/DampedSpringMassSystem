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
            this.label_stiffness = new System.Windows.Forms.Label();
            this.label_mass = new System.Windows.Forms.Label();
            this.label_dampcoeff = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.max_x = new System.Windows.Forms.TextBox();
            this.label_max_x = new System.Windows.Forms.Label();
            this.cycles = new System.Windows.Forms.TextBox();
            this.moveButton = new System.Windows.Forms.Button();
            this.label_steps = new System.Windows.Forms.Label();
            this.pictureMass = new System.Windows.Forms.PictureBox();
            this.pictureSpring = new System.Windows.Forms.PictureBox();
            this.pictureWall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpring)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWall)).BeginInit();
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
            // label_stiffness
            // 
            this.label_stiffness.AutoSize = true;
            this.label_stiffness.Location = new System.Drawing.Point(26, 45);
            this.label_stiffness.Name = "label_stiffness";
            this.label_stiffness.Size = new System.Drawing.Size(62, 13);
            this.label_stiffness.TabIndex = 5;
            this.label_stiffness.Text = "Stiffness, k:";
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
            // label_dampcoeff
            // 
            this.label_dampcoeff.AutoSize = true;
            this.label_dampcoeff.Location = new System.Drawing.Point(264, 45);
            this.label_dampcoeff.Name = "label_dampcoeff";
            this.label_dampcoeff.Size = new System.Drawing.Size(95, 13);
            this.label_dampcoeff.TabIndex = 7;
            this.label_dampcoeff.Text = "Damping Coeff., c:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(512, 61);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(100, 20);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start Simulation";
            this.startButton.UseVisualStyleBackColor = true;
            // 
            // max_x
            // 
            this.max_x.Location = new System.Drawing.Point(392, 61);
            this.max_x.Name = "max_x";
            this.max_x.Size = new System.Drawing.Size(100, 20);
            this.max_x.TabIndex = 9;
            // 
            // label_max_x
            // 
            this.label_max_x.AutoSize = true;
            this.label_max_x.Location = new System.Drawing.Point(389, 45);
            this.label_max_x.Name = "label_max_x";
            this.label_max_x.Size = new System.Drawing.Size(62, 13);
            this.label_max_x.TabIndex = 10;
            this.label_max_x.Text = "Maximum x:";
            // 
            // cycles
            // 
            this.cycles.Location = new System.Drawing.Point(392, 346);
            this.cycles.Name = "cycles";
            this.cycles.ReadOnly = true;
            this.cycles.Size = new System.Drawing.Size(100, 20);
            this.cycles.TabIndex = 12;
            // 
            // moveButton
            // 
            this.moveButton.Location = new System.Drawing.Point(512, 346);
            this.moveButton.Name = "moveButton";
            this.moveButton.Size = new System.Drawing.Size(75, 20);
            this.moveButton.TabIndex = 13;
            this.moveButton.Text = "Move Mass";
            this.moveButton.UseVisualStyleBackColor = true;
            this.moveButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // label_steps
            // 
            this.label_steps.AutoSize = true;
            this.label_steps.Location = new System.Drawing.Point(389, 330);
            this.label_steps.Name = "label_steps";
            this.label_steps.Size = new System.Drawing.Size(71, 13);
            this.label_steps.TabIndex = 14;
            this.label_steps.Text = "Steps Taken:";
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
            // pictureWall
            // 
            this.pictureWall.Image = global::DampedHarmonicOscillator.Properties.Resources.wall;
            this.pictureWall.Location = new System.Drawing.Point(29, 130);
            this.pictureWall.Name = "pictureWall";
            this.pictureWall.Size = new System.Drawing.Size(20, 178);
            this.pictureWall.TabIndex = 0;
            this.pictureWall.TabStop = false;
            // 
            // DampedSpringMass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 393);
            this.Controls.Add(this.pictureWall);
            this.Controls.Add(this.pictureMass);
            this.Controls.Add(this.label_steps);
            this.Controls.Add(this.moveButton);
            this.Controls.Add(this.cycles);
            this.Controls.Add(this.label_max_x);
            this.Controls.Add(this.max_x);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label_dampcoeff);
            this.Controls.Add(this.label_mass);
            this.Controls.Add(this.label_stiffness);
            this.Controls.Add(this.dampingCoeff);
            this.Controls.Add(this.mass);
            this.Controls.Add(this.stiffness);
            this.Controls.Add(this.pictureSpring);
            this.Name = "DampedSpringMass";
            this.Text = "Underdamped Spring-Mass System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureMass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSpring)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureWall)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureWall;
        private System.Windows.Forms.PictureBox pictureSpring;
        private System.Windows.Forms.TextBox stiffness;
        private System.Windows.Forms.TextBox mass;
        private System.Windows.Forms.TextBox dampingCoeff;
        private System.Windows.Forms.Label label_stiffness;
        private System.Windows.Forms.Label label_mass;
        private System.Windows.Forms.Label label_dampcoeff;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox max_x;
        private System.Windows.Forms.Label label_max_x;
        private System.Windows.Forms.TextBox cycles;
        private System.Windows.Forms.Button moveButton;
        private System.Windows.Forms.Label label_steps;
        private System.Windows.Forms.PictureBox pictureMass;
    }
}

