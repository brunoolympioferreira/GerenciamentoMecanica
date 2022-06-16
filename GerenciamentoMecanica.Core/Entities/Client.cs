using System;
using System.Collections.Generic;

namespace GerenciamentoMecanica.Core.Entities
{
    public class Client : BaseEntity
    {

        public Client(string fullName,string email, string cpf)
        {
            FullName = fullName;
            Email = email;
            Cpf = cpf;

            CreatedAt = DateTime.Now;
            Services = new List<Service>();
            Vehicles = new List<Vehicle>();
        }

        public string FullName { get; private set; }
        public string Email { get; private set; }
        public string Cpf { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? UpdatedAt {get;private set;}

        //public int AddressId { get; set; }
        public virtual Address Address { get; set; }
        public virtual List<Service> Services { get; private set; }
        public virtual List<Vehicle> Vehicles { get; private set; }

        public void ClientUpdate(string fullName, string email)
        {
            FullName=fullName;
            Email=email;
            UpdatedAt = DateTime.Now;
        }
    }
}
