namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        int selectedNumber;
        int totalVitorias = 0;
        int sequenciaAcertos = 0;
        int somaLadoOposto = 0;
        int numeroLado = 6;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
