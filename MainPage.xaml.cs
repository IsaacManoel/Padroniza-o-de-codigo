namespace DiceRoller
{
    public partial class MainPage : ContentPage
    {
        int valor = 0;
        public MainPage()
        {
            InitializeComponent();
            SidesPicker.SelectedIndex = 0;
        }

        private void RollBtn_Clicked(object sender, EventArgs e)
        {
            //Pegar o valor que foi selecionado pelo usuário no picker
            valor = Convert.ToInt32(SidesPicker.SelectedItem);
            //Jogar esse valor em uma variável
            //Sortear um número em um dado utilizando o Random
            //Colocar o valor sorteado em uma variável
            int valorSorteado = 0;
            valorSorteado = new Random().Next(valor) + 1;
            //Exibir o valor para o usuário na ResultLabel
            ResultLabel.Text = valorSorteado.ToString();
        }
    }
}
