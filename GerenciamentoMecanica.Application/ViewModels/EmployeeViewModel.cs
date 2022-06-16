using GerenciamentoMecanica.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoMecanica.Application.ViewModels
{
    public class EmployeeViewModel
    {
        public EmployeeViewModel(int id, string fullName, string cpf, DateTime admissionDate, EmployeeStatusEnum employeeStatus)
        {
            Id = id;
            FullName = fullName;
            Cpf = cpf;
            AdmissionDate = admissionDate;
            EmployeeStatus = employeeStatus;
        }

        public int Id { get; private set; }
        public string FullName { get; private set; }
        public string Cpf { get; private set; }
        public DateTime AdmissionDate { get; private set; }
        public EmployeeStatusEnum EmployeeStatus { get; private set; }
    }
}
