using System;
using System.Collections.Generic;

namespace GerenciamentoMecanica.Core.Entities
{
    public class Client : BaseEntity
    {

        public Client(string fullName,string email, int idAdress, string cpf)
        {
            FullName = fullName;
            Email = email;
            IdAdress = idAdress;
            CPF = cpf;

            CreatedAt = DateTime.Now;
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public int IdAdress { get; private set; }
        public Address Address { get; set; }
        public string CPF { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt {get;private set;}
        public List<Service> Services { get; private set; }
        public List<Vehicle> Vehicles { get; private set; }

        public void ClientUpdate(string fullName, string email)
        {
            FullName=fullName;
            Email=email;
            UpdatedAt = DateTime.Now;
        }
    }
}
