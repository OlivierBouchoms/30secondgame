using System.ComponentModel;
using System.Windows.Forms;

namespace thirtysecondgame
{
    partial class Roundform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Roundform));
            this.labelWord1 = new System.Windows.Forms.Label();
            this.labelWord2 = new System.Windows.Forms.Label();
            this.labelWord3 = new System.Windows.Forms.Label();
            this.labelWord4 = new System.Windows.Forms.Label();
            this.labelWord5 = new System.Windows.Forms.Label();
            this.labelCurrentplayer = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonNextRound = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelWord1
            // 
            this.labelWord1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelWord1.ForeColor = System.Drawing.Color.Black;
            this.labelWord1.Location = new System.Drawing.Point(12, 138);
            this.labelWord1.Name = "labelWord1";
            this.labelWord1.Size = new System.Drawing.Size(440, 26);
            this.labelWord1.TabIndex = 0;
            this.labelWord1.Text = "woord 1";
            this.labelWord1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelWord1.Click += new System.EventHandler(this.labelWord_Click);
            this.labelWord1.DoubleClick += new System.EventHandler(this.labelWord_Click);
            // 
            // labelWord2
            // 
            this.labelWord2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelWord2.ForeColor = System.Drawing.Color.Black;
            this.labelWord2.Location = new System.Drawing.Point(12, 216);
            this.labelWord2.Name = "labelWord2";
            this.labelWord2.Size = new System.Drawing.Size(440, 26);
            this.labelWord2.TabIndex = 1;
            this.labelWord2.Text = "woord 2";
            this.labelWord2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelWord2.Click += new System.EventHandler(this.labelWord_Click);
            this.labelWord2.DoubleClick += new System.EventHandler(this.labelWord_Click);
            // 
            // labelWord3
            // 
            this.labelWord3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelWord3.ForeColor = System.Drawing.Color.Black;
            this.labelWord3.Location = new System.Drawing.Point(12, 294);
            this.labelWord3.Name = "labelWord3";
            this.labelWord3.Size = new System.Drawing.Size(440, 26);
            this.labelWord3.TabIndex = 2;
            this.labelWord3.Text = "woord 3";
            this.labelWord3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelWord3.Click += new System.EventHandler(this.labelWord_Click);
            this.labelWord3.DoubleClick += new System.EventHandler(this.labelWord_Click);
            // 
            // labelWord4
            // 
            this.labelWord4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelWord4.ForeColor = System.Drawing.Color.Black;
            this.labelWord4.Location = new System.Drawing.Point(12, 372);
            this.labelWord4.Name = "labelWord4";
            this.labelWord4.Size = new System.Drawing.Size(440, 26);
            this.labelWord4.TabIndex = 3;
            this.labelWord4.Text = "woord 4";
            this.labelWord4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelWord4.Click += new System.EventHandler(this.labelWord_Click);
            this.labelWord4.DoubleClick += new System.EventHandler(this.labelWord_Click);
            // 
            // labelWord5
            // 
            this.labelWord5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelWord5.ForeColor = System.Drawing.Color.Black;
            this.labelWord5.Location = new System.Drawing.Point(12, 450);
            this.labelWord5.Name = "labelWord5";
            this.labelWord5.Size = new System.Drawing.Size(440, 26);
            this.labelWord5.TabIndex = 4;
            this.labelWord5.Text = "woord 5";
            this.labelWord5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelWord5.Click += new System.EventHandler(this.labelWord_Click);
            this.labelWord5.DoubleClick += new System.EventHandler(this.labelWord_Click);
            // 
            // labelCurrentplayer
            // 
            this.labelCurrentplayer.AutoSize = true;
            this.labelCurrentplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurrentplayer.Location = new System.Drawing.Point(12, 9);
            this.labelCurrentplayer.Name = "labelCurrentplayer";
            this.labelCurrentplayer.Size = new System.Drawing.Size(154, 25);
            this.labelCurrentplayer.TabIndex = 5;
            this.labelCurrentplayer.Text = "Current player:";
            // 
            // labelScore
            // 
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelScore.Location = new System.Drawing.Point(268, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(184, 25);
            this.labelScore.TabIndex = 6;
            this.labelScore.Text = "Score";
            this.labelScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // buttonNextRound
            // 
            this.buttonNextRound.Location = new System.Drawing.Point(377, 646);
            this.buttonNextRound.Name = "buttonNextRound";
            this.buttonNextRound.Size = new System.Drawing.Size(75, 23);
            this.buttonNextRound.TabIndex = 7;
            this.buttonNextRound.Text = "Next";
            this.buttonNextRound.UseVisualStyleBackColor = true;
            this.buttonNextRound.Visible = false;
            this.buttonNextRound.Click += new System.EventHandler(this.buttonNextRound_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.Red;
            this.labelTime.Location = new System.Drawing.Point(207, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(55, 39);
            this.labelTime.TabIndex = 8;
            this.labelTime.Text = "30";
            // 
            // Roundform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 681);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.buttonNextRound);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelCurrentplayer);
            this.Controls.Add(this.labelWord5);
            this.Controls.Add(this.labelWord4);
            this.Controls.Add(this.labelWord3);
            this.Controls.Add(this.labelWord2);
            this.Controls.Add(this.labelWord1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(480, 720);
            this.MinimumSize = new System.Drawing.Size(480, 720);
            this.Name = "Roundform";
            this.Text = "Round";
            this.Load += new System.EventHandler(this.Roundform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelWord1;
        private Label labelWord2;
        private Label labelWord3;
        private Label labelWord4;
        private Label labelWord5;
        private Label labelCurrentplayer;
        private Label labelScore;
        private Button buttonNextRound;
        private Timer timer;
        private Label labelTime;
    }
}