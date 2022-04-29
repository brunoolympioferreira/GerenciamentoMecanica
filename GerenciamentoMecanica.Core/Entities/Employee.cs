using GerenciamentoMecanica.Core.Enums;
using System;

namespace GerenciamentoMecanica.Core.Entities
{
    public class Employee : BaseEntity
    {
        public Employee(string fullName, DateTime birthdayDate,string cpf, string rg, string carteiraTrabalho, string pis, string reservista, EmployeeFunctionEnum function, decimal salary, DateTime admissionDate, DateTime? resignationDate)
        {
            FullName = fullName;
            BirthdayDate = birthdayDate;
            Cpf = cpf;
            Rg = rg;
            CarteiraTrabalho = carteiraTrabalho;
            Pis = pis;
            Reservista = reservista;
            Function = function;
            Salary = salary;
            AdmissionDate = admissionDate;
            ResignationDate = resignationDate;

            EmployeeStatus = EmployeeStatusEnum.Ativo;
            Age = DateTime.Now.Year - birthdayDate.Year;
        }

        public string FullName { get; private set; }
        public DateTime BirthdayDate { get; private set; }
        public int Age { get; private set; }
        public string Cpf { get; private set; }
        public string Rg { get; private set; }
        public string CarteiraTrabalho { get; private set; }
        public string Pis { get; private set; }
        public string Reservista { get; private set; }
        public decimal Salary { get; private set; }
        public EmployeeFunctionEnum Function { get; private set; }
        public DateTime AdmissionDate { get; private set; }
        public DateTime? ResignationDate { get; private set; }
        public DateTime? FinishVacation { get; private set; }
        public DateTime? EmployeeLeave { get; private set; }
        public EmployeeStatusEnum EmployeeStatus { get; private set; }

        public virtual Address Address { get; set; }

        public void Admission()
        {
            if (EmployeeStatus == EmployeeStatusEnum.Ativo)
            {
                AdmissionDate = DateTime.Now;
            }
        }

        public void Resignation()
        {
            if (EmployeeStatus == EmployeeStatusEnum.Ativo)
            {
                EmployeeStatus = EmployeeStatusEnum.Inativo;
            }
        }

        public void Vacation(int days)
        {
            if (EmployeeStatus == EmployeeStatusEnum.Ativo)
            {
                EmployeeStatus = EmployeeStatusEnum.Inativo;
                FinishVacation = DateTime.Now.AddDays(days);

                if (FinishVacation == DateTime.Now)
                {
                    EmployeeStatus = EmployeeStatusEnum.Ativo;
                }
            }
        }

        public void EmployeeAfastament(int days)
        {
            if (EmployeeStatus == EmployeeStatusEnum.Ativo)
            {
                EmployeeStatus = EmployeeStatusEnum.Inativo;
                EmployeeLeave = DateTime.Now.AddDays(days);
                if (EmployeeLeave == DateTime.Now)
                {
                    EmployeeStatus = EmployeeStatusEnum.Ativo;
                }
            }
        }

        public void UpdateEmployee(string fullName, EmployeeFunctionEnum function, decimal salary)
        {
            FullName = fullName;
            Function = function;
            Salary = salary;
        }
    }
}
