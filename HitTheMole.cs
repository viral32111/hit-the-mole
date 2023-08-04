using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Hit_the_Mole
{
	public partial class HitTheMole : Form
	{
		private bool started = false;

		private System.Windows.Forms.Timer roundTimer = new System.Windows.Forms.Timer();
		private Stopwatch swRoundTimer = new Stopwatch();
		private int roundTime = 5;

		private System.Windows.Forms.Timer moleTimer = new System.Windows.Forms.Timer();

		private Random rand = new Random();

		private List<PictureBox> moles = new List<PictureBox>();
		private List<Point> locations = new List<Point>();

		private int score = 0;
		PictureBox cursor = new PictureBox();

		private int round = 1;

		public HitTheMole()
		{
			InitializeComponent();

			roundTimer.Interval = 1000;
			roundTimer.Tick += new EventHandler(roundTimerTick);

			moleTimer.Interval = 700;
			moleTimer.Tick += new EventHandler(moleTimerTick);

			cursor.Image = Properties.Resources.mousePress;
			cursor.Parent = this;
			cursor.Location = PointToClient(Cursor.Position);
			cursor.SizeMode = PictureBoxSizeMode.StretchImage;
			cursor.BackColor = Color.Transparent;
			cursor.Visible = false;
		}

		private void HitTheMole_Load(object sender, EventArgs e)
		{
			//totalMoles = (roundTime * 1000)/moleTimer.Interval;
			//scoreLabel.Text = "Score: 0/" + totalMoles;
		}

		private void reset()
		{
			started = false;

			cursor.Visible = false;
			
			startLabel.Visible = true;
			startLabel.Enabled = true;

			scoreLabel.Enabled = false;
			scoreLabel.Visible = false;

			timeLabel.Enabled = false;
			timeLabel.Visible = false;

			roundLabel.Enabled = false;
			roundLabel.Visible = false;

			Cursor = Cursors.Default;

			roundTimer.Stop();
			swRoundTimer.Stop();
			swRoundTimer.Reset();
			moleTimer.Stop();

			foreach (PictureBox mole in moles)
			{
				mole.Visible = false;
				mole.Enabled = false;
				mole.Dispose();
			}
		}

		private void start()
		{
			started = true;
			
			startLabel.Visible = false;
			startLabel.Enabled = false;

			scoreLabel.Enabled = true;
			scoreLabel.Visible = true;

			timeLabel.Enabled = true;
			timeLabel.Visible = true;

			roundLabel.Enabled = true;
			roundLabel.Visible = true;

			MemoryStream stream = new MemoryStream(Properties.Resources.nothing);
			//Cursor = new Cursor(stream);
			//cursor.Visible = true;

			roundTimer.Start();
			swRoundTimer.Start();

			moleTimer.Start();
		}

		private void moleTimerTick(object sender, EventArgs e)
		{
			int width = Properties.Resources.mole.Size.Width / 5;
			int height = Properties.Resources.mole.Size.Height / 5;
			Size size = new Size(width, height);

			int xPos = rand.Next(80, Width-80);
			int yPos = rand.Next(80, Height-80);
			Point point = new Point(xPos, yPos);

			/*foreach (Point loc in locations)
			{
				Console.WriteLine("X: " + (loc.X) + "[" + (loc.X+Width) + "], Y: " + (loc.Y) + " [" + (loc.Y+height) + "]");
			}*/

			PictureBox mole = new PictureBox();
			mole.Click += new EventHandler(anyMoleClicked);
			mole.Parent = this;
			mole.Location = point;
			mole.Size = size;
			mole.SizeMode = PictureBoxSizeMode.StretchImage;
			mole.Image = Properties.Resources.mole;
			mole.BackColor = Color.Transparent;

			moles.Add(mole);
			//locations.Add(point);
		}

		private void anyMoleClicked(object mole, EventArgs e)
		{
			score += 1;
			scoreLabel.Text = "Score: " + score; // + "/" + totalMoles;

			PictureBox box = (PictureBox)mole;
			box.Visible = false;
			box.Enabled = false;
			box.Dispose();
		}

		private void roundTimerTick(object sender, EventArgs e)
		{
			var seconds = swRoundTimer.ElapsedMilliseconds / 1000;

			if (seconds >= roundTime+1)
			{
				reset();
				MessageBox.Show("Round 1 has finished.\n\nScore: " + score + "\nTime: " + roundTime + "s.\nMoles spawned: " + moles.Count + ".\nSpawn interval: " + moleTimer.Interval + "ms.", "Times up!", MessageBoxButtons.OK);
				score = 0;
				scoreLabel.Text = "Score: 0";
				return;
			}
			else
			{
				timeLabel.Text = "Time: " + seconds + "s/" + roundTime + "s";
			}
		}

		private void HitTheMole_Click(object sender, EventArgs e)
		{
			if (!started) {
				start();
			}
		}

		private void startLabel_Click(object sender, EventArgs e)
		{
			if (!started)
			{
				start();
			}
		}

		private void HitTheMole_MouseMove(object sender, MouseEventArgs e)
		{
			if (started)
			{
				cursor.Location = PointToClient(Cursor.Position);
			}
		}
	}
}
