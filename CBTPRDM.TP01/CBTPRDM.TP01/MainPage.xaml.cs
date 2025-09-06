namespace CBTPRDM.TP01
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnOkClicked(object sender, EventArgs e)
        {
            string id = IdEntry.Text;
            string senha = PassEntry.Text;

            if (id == "admin" && senha == "senha@dmin")
            {
                DisplayAlert("Sucesso", "Logou com sucesso", "OK");
            }
            else
            {
                DisplayAlert("Erro", "Login não autorizado.", "Tentar Novamente");
            }
        }

        private void OnLimparClicked(object sender, EventArgs e)
        {
            IdEntry.Text = string.Empty;
            PassEntry.Text = string.Empty;

            IdEntry.Focus();
        }

        private void OnCreditosClicked(object sender, EventArgs e)
        {
            string autores = "Desenvolvido por:\n- Beatriz Bastos Borges\n- Miguel Luizatto Alves";
            DisplayAlert("Créditos", autores, "Fechar");
        }
    }

}
