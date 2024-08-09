namespace XAMLTequila
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var upArrow = (Frame)this.FindByName("UpArrow");
            var downArrow = (Frame)this.FindByName("DownArrow");

            if (upArrow != null)
            {
                upArrow.GestureRecognizers.Add(new TapGestureRecognizer
                {
                    Command = new Command(OnUpArrowClicked)
                });
            }

            if (downArrow != null)
            {
                downArrow.GestureRecognizers.Add(new TapGestureRecognizer
                {
                    Command = new Command(OnDownArrowClicked)
                });
            }
        }

        private async void OnUpArrowClicked()
        {
            await BodyScrollView.ScrollToAsync(0, BodyScrollView.ScrollY - 100, true); // Adjust the 100 as needed
        }

        private async void OnDownArrowClicked()
        {
            await BodyScrollView.ScrollToAsync(0, BodyScrollView.ScrollY + 100, true); // Adjust the 100 as needed
        }
    }

}
