using System;

namespace ResolucaoExercicio1.Entities {
    class Client {

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        public Client(string name, string email, DateTime birthDate) {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }

        public Client() {

        }

        public override string ToString() {
            return $"Client: {Name} ({BirthDate.ToString("dd/MM/yyyy")}) - {Email}";
        }
    }
}
