using Методы;
using System;
using System.Windows.Forms;
using System.Linq;
using Основной_класс;
using static Методы.Institute;

namespace Формы_РГР_
{

    public partial class Form1 : Form
    {
        private readonly Institute institute;
        public Form1()
        {
            InitializeComponent();
            // ConfigureDataGridView();
            institute = new Institute();
        }
        private void ConfigureDataGridView()
        {
            // Очищаем существующие столбцы
            employeeDataGridView.Columns.Clear();

            // Создание столбца для фамилии
            DataGridViewTextBoxColumn lastNameColumn = new DataGridViewTextBoxColumn
            {
                Name = "LastName",
                HeaderText = "Фамилия",
                DataPropertyName = "LastName"
            };
            employeeDataGridView.Columns.Add(lastNameColumn);

            // Создание столбца для имени
            DataGridViewTextBoxColumn firstNameColumn = new DataGridViewTextBoxColumn
            {
                Name = "FirstName",
                HeaderText = "Имя",
                DataPropertyName = "FirstName"
            };
            employeeDataGridView.Columns.Add(firstNameColumn);

            // Создание столбца для отчества
            DataGridViewTextBoxColumn middleNameColumn = new DataGridViewTextBoxColumn
            {
                Name = "MiddleName",
                HeaderText = "Отчество",
                DataPropertyName = "MiddleName"
            };
            employeeDataGridView.Columns.Add(middleNameColumn);

            // Создание столбца для отдела
            DataGridViewTextBoxColumn departmentColumn = new DataGridViewTextBoxColumn
            {
                Name = "Department",
                HeaderText = "Отдел",
                DataPropertyName = "Department"
            };
            employeeDataGridView.Columns.Add(departmentColumn);

            // Создание столбца для года рождения
            DataGridViewTextBoxColumn birthYearColumn = new DataGridViewTextBoxColumn
            {
                Name = "BirthYear",
                HeaderText = "Возраст",
                DataPropertyName = "BirthYear"
            };
            employeeDataGridView.Columns.Add(birthYearColumn);

            // Создание столбца для стажа работы
            DataGridViewTextBoxColumn experienceColumn = new DataGridViewTextBoxColumn
            {
                Name = "WorkExperience",
                HeaderText = "Стаж работы",
                DataPropertyName = "WorkExperience"
            };
            employeeDataGridView.Columns.Add(experienceColumn);

            // Создание столбца для должности
            DataGridViewTextBoxColumn positionColumn = new DataGridViewTextBoxColumn
            {
                Name = "Position",
                HeaderText = "Должность",
                DataPropertyName = "Position"
            };
            employeeDataGridView.Columns.Add(positionColumn);

            // Создание столбца для оклада
            DataGridViewTextBoxColumn salaryColumn = new DataGridViewTextBoxColumn
            {
                Name = "Salary",
                HeaderText = "Оклад",
                DataPropertyName = "Salary"
            };
            employeeDataGridView.Columns.Add(salaryColumn);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            sortComboBox.Items.AddRange(new string[] { "LastName", "Department", "BirthYear", "WorkExperience", "Salary" });
            RefreshEmployeeList();
        }

        private void RefreshEmployeeList()
        {
            employeeDataGridView.DataSource = null;
            employeeDataGridView.DataSource = institute.GetAllEmployees();
        }
        // Добавление сотрудника
        private void addButton_Click(object sender, EventArgs e)
        {
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm(institute);
            addEmployeeForm.ShowDialog();
            RefreshEmployeeList();
        }

        // Удаление сотрудника
        private void removeButton_Click(object sender, EventArgs e)
        {
            if (employeeDataGridView.SelectedRows.Count > 0)
            {
                var selectedEmployee = (Employee)employeeDataGridView.SelectedRows[0].DataBoundItem;
                institute.RemoveEmployee(selectedEmployee.LastName, selectedEmployee.FirstName, selectedEmployee.MiddleName);
                RefreshEmployeeList();
            }
            else
            {
                MessageBox.Show("Выберите сотрудника для удаления.");
            }
        }

        // Сортировка сотрудников по заданному полю
        private void sortButton_Click(object sender, EventArgs e)
        {
            // Преобразуем выбранное значение ComboBox в перечисление SortField
            SortField field = (SortField)Enum.Parse(typeof(SortField), sortComboBox.SelectedItem.ToString());

            try
            {
                institute.SortEmployees(field);
                RefreshEmployeeList();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }



        // Получение списка сотрудников пенсионного возраста
        private void retirementButton_Click(object sender, EventArgs e)
        {
            var retirees = institute.GetRetirementAgeEmployees();
            if (retirees.Any())
            {
                string retireeList = "Сотрудники пенсионного возраста:\n";
                foreach (var retiree in retirees)
                {
                    retireeList += $"{retiree.LastName} {retiree.FirstName} {retiree.MiddleName}, Стаж работы: {retiree.WorkExperience} лет\n";
                }
                MessageBox.Show(retireeList);
            }
            else
            {
                MessageBox.Show("Нет сотрудников пенсионного возраста.");
            }
        }

        // Получение среднего стажа работы в отделе
        private void averageExperienceButton_Click(object sender, EventArgs e)
        {
            string department = departmentTextBox.Text;
            try
            {
                double averageExperience = institute.GetAverageExperienceInDepartment(department);
                MessageBox.Show($"Средний стаж работы в отделе {department}: {averageExperience} лет.");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadData()
        {
            string fileName = "employees.txt";

            // Загружаем данные из файла.
            institute.LoadDataFromFile(fileName);

            // Отображаем загруженные данные в DataGridView.
            employeeDataGridView.DataSource = null;
            employeeDataGridView.DataSource = institute.GetAllEmployees();
        }

        private void SaveData()
        {
            string fileName = "employees.txt";
            institute.SaveDataToFile(fileName);
        }





        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}
