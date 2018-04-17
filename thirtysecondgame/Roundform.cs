using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace thirtysecondgame
{
    public partial class Roundform : Form
    {
        private Player player;
        private Game game;
        private Round round;
        private string[] words;
        private Random r;
        private int ticks;

        internal Player Player { get => player; private set => player = value; }
        internal Game Game { get => game; private set => game = value; }

        public Roundform(Game game)
        {
            InitializeComponent();
            this.game = game;
            UIDesign();
            timer.Start();
        }

        private void UIDesign()
        {
            CenterToScreen();
            labelTime.Left = (ClientSize.Width - labelTime.Width) / 2;
        }

        private void Roundform_Load(object sender, EventArgs e)
        {
            round = new Round(game);
            Player = round.Player;
            Text = round.Player.Name + " is aan de beurt!";
            //ronde moet speler hebben
            labelCurrentplayer.Text = Player.Name;
            labelScore.Text = "Score: " + Player.Score;
            //woorden vullen
            FillWords();
            Player.IncreaseTurns();
            BringToFront();
        }

        private void buttonNextRound_Click(object sender, EventArgs e)
        {
            //als game over is
            if (player.Score >= game.Maxscore)
            {
                MessageBox.Show(player.Name + " heeft gewonnen.");
                FormSummary formSummary = new FormSummary(game, player.Name);
                Close();
                formSummary.Show();
            }
            //als game niet over is
            else
            {
                Hide();
                ConfirmForm confirmForm = new ConfirmForm(game);
                confirmForm.ShowDialog();
                Roundform round = new Roundform(Game);
                round.Show();
            }
        }

        private void labelWord_Click(object sender, EventArgs e)
        {
            if ((sender as Label).ForeColor == Color.Black)
            {
                (sender as Label).ForeColor = Color.Green;
                Player.IncreaseScore();
                labelScore.Text = "Score: " + Player.Score;
            }
            else
            {
                (sender as Label).ForeColor = Color.Black;
                Player.DecreaseScore();
                labelScore.Text = "Score: " + Player.Score;
            }
        }

        private void FillWords()
        {
            r = new Random();
            words = File.ReadAllLines(Application.StartupPath + @"\words.txt");
            foreach (Control c in Controls)
            {
                if (c is Label && c.Name.Contains("Word"))
                {
                    c.Text = GetWord();
                }
            }
        }

        private string GetWord()
        {
            int index = r.Next(words.Length);
            string word = words[index];
            foreach (Control control in Controls) //elk label nagaan
            {
                if (control is Label)
                {
                    if (control.Name.Contains("Word") && control.Text == word) //komt het woord voor (niet goed)
                    {
                        word = GetWord(); //opnieuw methode uitvoeren (nieuw woord halen)
                    }
                }
            }
            return word; //is klaar
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ticks++;
            labelTime.Text = (30 - ticks).ToString();
            labelTime.Left = (ClientSize.Width - labelTime.Width) / 2; //update locatie
            if (ticks >= 30)
            {
                timer.Stop();
                ticks = 0;
                buttonNextRound_Click(sender, e);
            }
        }
    }
}
