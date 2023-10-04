using System.Globalization;

namespace ApiPizzaria.Model.Domain
{
    public class Usuario
    {
        public int Id { get; private set; }

        public string Username { get; private set; }

        public string Password { get; private set; }

        public string Email { get; private set; }
        public string CPF { get; private set; }
    }
}
