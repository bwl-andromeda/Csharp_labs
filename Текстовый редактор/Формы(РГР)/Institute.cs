using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Основной_класс;

namespace Методы
{
    public class Institute
    {
        private List<Employee> employees;

        public Institute()
        {
            employees = new List<Employee>();
            LoadDataFromFile("employees.txt");
        }
        public enum SortField
        {
            LastName,
            FirstName,
            MiddleName,
            Department,
            BirthYear,
            WorkExperience,
            Position,
            Salary
        }


        // Загрузка данных из файла
        public void LoadDataFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                var lines = File.ReadAllLines(fileName);
                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    var employee = new Employee
                    {
                        LastName = data[0],
                        FirstName = data[1],
                        MiddleName = data[2],
                        Department = data[3],
                        BirthYear = int.Parse(data[4]),
                        WorkExperience = int.Parse(data[5]),
                        Position = data[6],
                        Salary = decimal.Parse(data[7])
                    };
                    employees.Add(employee);
                }
            }
        }

        // Сохранение данных в файл
        public void SaveDataToFile(string fileName)
        {
            var lines = employees.Select(e => $"{e.LastName},{e.FirstName},{e.MiddleName},{e.Department},{e.BirthYear},{e.WorkExperience},{e.Position},{e.Salary}");
            File.WriteAllLines(fileName, lines);
        }

        // Добавление сотрудника
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
            SaveDataToFile("employees.txt");
        }

        // Удаление сотрудника
        public void RemoveEmployee(string lastName, string firstName, string middleName)
        {
            var employeeToRemove = employees.FirstOrDefault(e => e.LastName == lastName && e.FirstName == firstName && e.MiddleName == middleName);
            if (employeeToRemove != null)
            {
                employees.Remove(employeeToRemove);
                SaveDataToFile("employees.txt");
            }
        }

        // Сортировка сотрудников по заданному полю
        public void SortEmployees(SortField field)
        {
            switch (field)
            {
                case SortField.LastName:
                    employees = employees.OrderBy(e => e.LastName).ToList();
                    break;
                case SortField.FirstName:
                    employees = employees.OrderBy(e => e.FirstName).ToList();
                    break;
                case SortField.MiddleName:
                    employees = employees.OrderBy(e => e.MiddleName).ToList();
                    break;
                case SortField.Department:
                    employees = employees.OrderBy(e => e.Department).ToList();
                    break;
                case SortField.BirthYear:
                    employees = employees.OrderBy(e => e.BirthYear).ToList();
                    break;
                case SortField.WorkExperience:
                    employees = employees.OrderBy(e => e.WorkExperience).ToList();
                    break;
                case SortField.Position:
                    employees = employees.OrderBy(e => e.Position).ToList();
                    break;
                case SortField.Salary:
                    employees = employees.OrderBy(e => e.Salary).ToList();
                    break;
                default:
                    throw new ArgumentException("Некорректное поле для сортировки.");
            }
            SaveDataToFile("employees.txt");
        }


        public List<Employee> GetRetirementAgeEmployees()
        {
            int currentYear = DateTime.Now.Year;
            return employees
                .Where(e => (currentYear - e.BirthYear >= 65) ||
                            (currentYear - e.BirthYear >= 55))
                .ToList();
        }

        // Получение среднего стажа работы в отделе
        public double GetAverageExperienceInDepartment(string department)
        {
            var deptEmployees = employees.Where(e => e.Department == department).ToList();
            return deptEmployees.Count == 0 ? 0 : deptEmployees.Average(e => e.WorkExperience);
        }

        // Получение всех сотрудников
        public List<Employee> GetAllEmployees()
        {
            return new List<Employee>(employees);
        }
    }
}
