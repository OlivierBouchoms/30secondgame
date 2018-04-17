using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace thirtysecondgame
{
    public partial class ConfirmForm : Form
    {
        private int ticks;
        private Game _game;

        public ConfirmForm(Game game)
        {
            InitializeComponent();
            _game = game;
        }

        public ConfirmForm(Game game, string title, string buttontext)
        {
            InitializeComponent();
            _game = game;
            labelTitle.Text = title;
            buttonStart.Text = buttontext;
        }

        private void UIDesign(int i)
        {
            CenterToScreen();
            if (_game.PlayerList.Count <= 3) {buttonStart.Top = (ClientSize.Height - buttonStart.Height) / 2; } 
            else
            {
                if (i == 9) { buttonStart.Top = labelTitle.Top + (71 * i) - 37; buttonStart.Height = (int)Convert.ToDouble(buttonStart.Height * 0.5); } //nodig om knop passend te maken
                else { buttonStart.Top = labelTitle.Top + 74 * i; };
            }
            
        }

        private void startCountdown(object sender, EventArgs e)
        {
            buttonStart.Enabled = false;
            buttonStart.Text = (5 - ticks).ToString();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ticks++;
            buttonStart.Text = (5 - ticks).ToString();
            if (ticks >= 5)
            {
                timer.Stop();
                Close();
            }
        }

        private void ConfirmForm_Load(object sender, EventArgs e)
        {
            int i = 0;
            if (_game.PlayerList.First().Turns == 0)
            {
                goto UIDesign;
            }
            foreach (Player p in _game.PlayerList.OrderByDescending(play => play.Score)) //spelers sorteren op basis van score
            {
                i++;
                Point point = new Point(labelTitle.Left, labelTitle.Top + 74 * i);
                Label label = new Label
                {
                    Font = new Font("Microsoft Sans Serif", 24, FontStyle.Regular),
                    ForeColor = Color.Black,
                    Text = p.ToStringOverview(),
                    Height = labelTitle.Height,
                    Width = labelTitle.Width,
                    Left = point.X,
                    Top = point.Y
                };
                Controls.Add(label);
            }
            UIDesign:
            i++;
            UIDesign(i);
            BringToFront();
            
        }
    }
}
