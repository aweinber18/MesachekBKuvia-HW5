using System.Collections;

namespace MesachekBKuvia
{
    public partial class MesachekBekuvia : Form
    {
        IList<RichTextBox> winningBoxes = new List<RichTextBox>(6);
        IList<RichTextBox> playerBoxes = new List<RichTextBox>(6);
        IList<int> winningNumbers = new List<int>(6);
        IList<int> playerNumbers = new List<int>(6);
        public MesachekBekuvia()
        {
            InitializeComponent();
            InitWinningBoxes();
            InitPlayerBoxes();
        }

        private void SetWinningNums()
        {
            Random rnd = new Random();
            winningNumbers.Clear();
            for (int i = 0; i < winningBoxes.Count; i++)
            {
                winningNumbers.Add(rnd.Next(1, 100));
                winningBoxes.ElementAt(i).Text = winningNumbers.ElementAt(i).ToString();
            }
        }

        private void GetPlayerNumbers()
        {
            playerNumbers.Clear();
            for (int i = 0; i < playerBoxes.Count; i++)
            {
                playerNumbers.Add(Convert.ToInt32(playerBoxes.ElementAt(i).Text.ToString()));
            }
        }

        private void InitWinningBoxes()
        {
            winningBoxes.Add(TB0);
            winningBoxes.Add(TB1);
            winningBoxes.Add(TB2);
            winningBoxes.Add(TB3);
            winningBoxes.Add(TB4);
            winningBoxes.Add(TB5);
        }

        private void InitPlayerBoxes()
        {
            playerBoxes.Add(ETB0);
            playerBoxes.Add(ETB1);
            playerBoxes.Add(ETB2);
            playerBoxes.Add(ETB3);
            playerBoxes.Add(ETB4);
            playerBoxes.Add(ETB5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < playerBoxes.Count; i++) {
                playerBoxes[i].BackColor = Color.LightGray;
            }
            SetWinningNums();
            GetPlayerNumbers();
            score.Text = Score().ToString();

        }

        private int Score()
        {
            int score = 0;
            for (int i = 0; i < playerBoxes.Count; i++)
            {
                if (playerNumbers.ElementAt(i) == winningNumbers.ElementAt(i))
                {
                    score++;
                    playerBoxes.ElementAt(i).BackColor = Color.Green;
                }
            }
            return score;
        }

        private void richTextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}