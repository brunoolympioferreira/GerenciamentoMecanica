using GerenciamentoMecanica.Core.Enums;
using System;

namespace GerenciamentoMecanica.Application.ViewModels
{
    public class EmployeeDetailsViewModel
    {
        public EmployeeDetailsViewModel(int id,string fullName, DateTime birthdayDate, int age, string cpf, string rg, string carteiraTrabalho,
                                       string pis, string reservista, decimal salary, DateTime admissionDate, DateTime? resignationDate,
                                       EmployeeStatusEnum employeeStatus)
        {
            Id = id;
            FullName = fullName;
            BirthdayDate = birthdayDate;
            Age = age;
            Cpf = cpf;
            Rg = rg;
            CarteiraTrabalho = carteiraTrabalho;
            Pis = pis;
            Reservista = reservista;
            Salary = salary;
            AdmissionDate = admissionDate;
            ResignationDate = resignationDate;
            EmployeeStatus = employeeStatus;
        }

        public int Id { get; private set; }
        public string FullName { get; private set; }
        public DateTime BirthdayDate { get; private set; }
        public int Age { get; private set; }
        public string Cpf { get; private set; }
        public string Rg { get; private set; }
        public string CarteiraTrabalho { get; private set; }
        public string Pis { get; private set; }
        public string Reservista { get; private set; }
        public decimal Salary { get; private set; }
        public DateTime AdmissionDate { get; private set; }
        public DateTime? ResignationDate { get; private set; }
        public EmployeeStatusEnum EmployeeStatus { get; private set; }
    }
}
