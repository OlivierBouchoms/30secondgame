using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace thirtysecondgame
{
    public partial class FormMenu : Form
    {
        private Game game;
        private int i;
        private List<TextBox> tbList;

        internal Game Game { get => game; set => game = value; }

        public FormMenu()
        {
            InitializeComponent();
            CenterToScreen();
            tbList = new List<TextBox>();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Game = new Game((int)numUDMaxScore.Value);
            //spelers maken
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    Game.CreatePlayer(c.Text);
                }
            }
            Hide();
            //dialoogje laten zien

            ConfirmForm confirmForm = new ConfirmForm(game, "Klaar?", "Start!");
            confirmForm.ShowDialog();
            //ronde starten
            Roundform roundform = new Roundform(Game);
            roundform.Show();
        }

        private void buttonAddPlayer_Click(object sender, EventArgs e)
        {
            i++;
            if (i > 6) { i--; return; }
            //Textbox toevoegen

            Point point = new Point(txt2.Left, txt2.Top + 30 * i);
            TextBox textBox = new TextBox
            {
                Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular),
                Location = point,
                Size = txt2.Size
            };
            tbList.Add(textBox);
            Controls.Add(tbList.Last());
        }

        private void buttonDeletePlayer_Click(object sender, EventArgs e)
        {
            if (i > 0) { i--; }
            try { Controls.Remove(tbList.Last()); }
            catch (Exception) { return; }
            tbList.Remove(tbList.Last());
        }
    }
}
