namespace Hit_the_Mole
{
	partial class HitTheMole
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HitTheMole));
			this.scoreLabel = new System.Windows.Forms.Label();
			this.startLabel = new System.Windows.Forms.Label();
			this.timeLabel = new System.Windows.Forms.Label();
			this.roundLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// scoreLabel
			// 
			this.scoreLabel.AutoSize = true;
			this.scoreLabel.Enabled = false;
			this.scoreLabel.Location = new System.Drawing.Point(5, 5);
			this.scoreLabel.Name = "scoreLabel";
			this.scoreLabel.Size = new System.Drawing.Size(47, 13);
			this.scoreLabel.TabIndex = 1;
			this.scoreLabel.Text = "Score: 0";
			this.scoreLabel.Visible = false;
			// 
			// startLabel
			// 
			this.startLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startLabel.Location = new System.Drawing.Point(12, 9);
			this.startLabel.Name = "startLabel";
			this.startLabel.Size = new System.Drawing.Size(776, 531);
			this.startLabel.TabIndex = 2;
			this.startLabel.Text = "CLICK ANYWHERE TO START";
			this.startLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.startLabel.Click += new System.EventHandler(this.startLabel_Click);
			// 
			// timeLabel
			// 
			this.timeLabel.AutoSize = true;
			this.timeLabel.Enabled = false;
			this.timeLabel.Location = new System.Drawing.Point(5, 23);
			this.timeLabel.Name = "timeLabel";
			this.timeLabel.Size = new System.Drawing.Size(0, 13);
			this.timeLabel.TabIndex = 3;
			this.timeLabel.Visible = false;
			// 
			// roundLabel
			// 
			this.roundLabel.AutoSize = true;
			this.roundLabel.Enabled = false;
			this.roundLabel.Location = new System.Drawing.Point(746, 5);
			this.roundLabel.Name = "roundLabel";
			this.roundLabel.Size = new System.Drawing.Size(48, 13);
			this.roundLabel.TabIndex = 4;
			this.roundLabel.Text = "Round 1";
			this.roundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.roundLabel.Visible = false;
			// 
			// HitTheMole
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(800, 549);
			this.Controls.Add(this.roundLabel);
			this.Controls.Add(this.timeLabel);
			this.Controls.Add(this.scoreLabel);
			this.Controls.Add(this.startLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "HitTheMole";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hit the Mole!";
			this.Load += new System.EventHandler(this.HitTheMole_Load);
			this.Click += new System.EventHandler(this.HitTheMole_Click);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HitTheMole_MouseMove);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label scoreLabel;
		private System.Windows.Forms.Label startLabel;
		private System.Windows.Forms.Label timeLabel;
		private System.Windows.Forms.Label roundLabel;
	}
}

