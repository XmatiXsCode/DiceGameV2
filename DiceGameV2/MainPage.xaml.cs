namespace DiceGameV2
{
    public partial class MainPage : ContentPage
    {
        int gameResult = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        public void NewDraw(object sender, EventArgs e)
        {
            int result = 0;
            List<int> draws = new List<int> { 0, 0, 0, 0, 0 };
            for (int i = 0; i < draws.Count(); i++)
            {
                draws[i] = new Random().Next(1, 7);
            }
            firstDice.Source = $"kostka{draws[0]}.png";
            secondDice.Source = $"kostka{draws[1]}.png";
            thirdDice.Source = $"kostka{draws[2]}.png";
            fourthDice.Source = $"kostka{draws[3]}.png";
            fifthDice.Source = $"kostka{draws[4]}.png";
            List<int> drawInDraws = new List<int> { 0, 0, 0, 0, 0, 0 };
            for (int i = 0; i < draws.Count(); i++)
            {
                for (int j = 0; j < drawInDraws.Count(); j++)
                {
                    if (draws[i] == j+1)
                    {
                        drawInDraws[j]++;
                    }
                }
            }
            for (int i = 0; i < drawInDraws.Count(); i++)
            {
                if (drawInDraws[i] > 1)
                {
                    result = result + drawInDraws[i]*(i+1);
                }
            }
            gameResult = gameResult + result;
            recentDraw.Text = $"Wynik tego losowania: {result}";
            allDraws.Text = $"Wynik gry: {gameResult}";
        }
        private void ResetDraws(object sender, EventArgs e)
        {
            firstDice.Source = "kostka0.png";
            secondDice.Source = "kostka0.png";
            thirdDice.Source = "kostka0.png";
            fourthDice.Source = "kostka0.png";
            fifthDice.Source = "kostka0.png";
            recentDraw.Text = "Wynik tego losowania:";
            allDraws.Text = "Wynik gry:";
            gameResult = 0;
        }
    }
}