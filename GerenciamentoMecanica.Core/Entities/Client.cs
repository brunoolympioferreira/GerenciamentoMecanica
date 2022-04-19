using System;
using System.Collections.Generic;

namespace GerenciamentoMecanica.Core.Entities
{
    public class Client : BaseEntity
    {

        public Client(string fullName, int idAdress, string cpf)
        {
            FullName = fullName;
            IdAdress = idAdress;
            CPF = cpf;

            CreatedAt = DateTime.Now;
        }

        public string FullName { get; private set; }
        public int IdAdress { get; private set; }
        public Address Address { get; set; }
        public string CPF { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public List<Service> Services { get; private set; }
        public List<Vehicle> Vehicles { get; private set; }
    }
}
