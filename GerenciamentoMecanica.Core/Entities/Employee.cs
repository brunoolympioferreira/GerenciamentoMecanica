using GerenciamentoMecanica.Core.Enums;
using System;

namespace GerenciamentoMecanica.Core.Entities
{
    public class Employee : BaseEntity
    {
        public Employee(string fullName, DateTime birthdayDate,int idAdress, string cPF, string rG, string carteiraTrabalho, string pIS, string reservista, EmployeeFunctionEnum functionEnum, decimal salary, DateTime admissionDate, DateTime? resignationDate)
        {
            FullName = fullName;
            BirthdayDate = birthdayDate;
            IdAddress = idAdress;
            CPF = cPF;
            RG = rG;
            CarteiraTrabalho = carteiraTrabalho;
            PIS = pIS;
            Reservista = reservista;
            FunctionEnum = functionEnum;
            Salary = salary;
            AdmissionDate = admissionDate;
            ResignationDate = resignationDate;

            EmployeeStatus = EmployeeStatusEnum.Ativo;
            Age = DateTime.Now.Year - birthdayDate.Year;
        }

        public string FullName { get; private set; }
        public DateTime BirthdayDate { get; private set; }
        public int Age { get; private set; }
        public int IdAddress { get; private set; }
        public Address Address { get; set; }
        public string CPF { get; private set; }
        public string RG { get; private set; }
        public string CarteiraTrabalho { get; private set; }
        public string PIS { get; private set; }
        public string Reservista { get; private set; }
        public EmployeeFunctionEnum FunctionEnum { get; private set; }
        public decimal Salary { get; private set; }
        public EmployeeFunctionEnum Function { get; private set; }
        public DateTime AdmissionDate { get; private set; }
        public DateTime? ResignationDate { get; private set; }
        public DateTime? FinishVacation { get; private set; }
        public DateTime? EmployeeLeave { get; private set; }
        public EmployeeStatusEnum EmployeeStatus { get; private set; }

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
