namespace GerenciamentoMecanica.Application.ViewModels
{
    public class ClientViewModel
    {
        public ClientViewModel(int id, string fullName, string email)
        {
            Id = id;
            FullName = fullName;
            Email = email;
        }

        public int Id { get; set; }
        public string FullName { get; private set; }
        public string Email { get; private set; }
    }
}
