namespace DungeonCrawler
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void StartGame(object sender, EventArgs e)
        {
            

            
            StartBtn.Text = $"Game Starting";
            
            ////SemanticScreenReader.Announce(CounterBtn.Text);
        }



    }

    }
