using System;
using System.Windows.Forms;
using Методы;
using Основной_класс;

namespace Формы_РГР_
{
    public partial class AddEmployeeForm : Form
    {

        private readonly Institute institute;

        public AddEmployeeForm(Institute institute)
        {
            InitializeComponent();
            this.institute = institute;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                string lastName = lastNameTextBox.Text;
                string firstName = firstNameTextBox.Text;
                string middleName = middleNameTextBox.Text;
                string department = departmentTextBox.Text;
                int birthYear = int.Parse(birthYearTextBox.Text);
                int workExperience = int.Parse(workExperienceTextBox.Text);
                string position = positionTextBox.Text;
                decimal salary = decimal.Parse(salaryTextBox.Text);

                Employee newEmployee = new Employee
                {
                    LastName = lastName,
                    FirstName = firstName,
                    MiddleName = middleName,
                    Department = department,
                    BirthYear = birthYear,
                    WorkExperience = workExperience,
                    Position = position,
                    Salary = salary
                };

                institute.AddEmployee(newEmployee);
                MessageBox.Show("Сотрудник добавлен.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
