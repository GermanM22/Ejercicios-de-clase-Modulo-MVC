// See https://aka.ms/new-console-template for more information
using Ejercicio6;
using Ejercicio6.Entities;
using Ejercicio6.Working;

ICompany<Investor> company = new Company<Investor>();
company.Contrat(new Investor());

ICompany<Employee> multinational = new Multinational<Employee>();
multinational.Contrat(new Employee());