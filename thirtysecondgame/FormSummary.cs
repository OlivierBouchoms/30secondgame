using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace thirtysecondgame
{
    public partial class FormSummary : Form
    {
        private Game game;

        public FormSummary(Game game, string Playername)
        {
            InitializeComponent();
            this.game = game;
            Text = Playername + " heeft gewonnen!";
        }

        private void FormSummary_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            int i = 0;
            foreach (Player p in game.PlayerList.OrderByDescending(play => play.Score)) //spelers sorteren op basis van score
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
            BringToFront();
        }

        private void Restart(object sender, EventArgs e)
        {
            //reset spelers
            foreach (Player p in game.PlayerList)
            {
                p.ResetScore();
                p.ResetTurns();
            }
            //nieuwe game
            Game g = new Game(game.Maxscore);
            Hide();
            //dialoogje laten zien
            ConfirmForm confirmForm = new ConfirmForm(g);
            confirmForm.ShowDialog();
            //ronde starten
            Roundform roundform = new Roundform(g);
            roundform.Show();
        }

        

        private void Exit(object sender, EventArgs e)
        {
            if (MessageBox.Show("Weet je zeker dat je wil afsluiten?", "Raad het Woord", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
