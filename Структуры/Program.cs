namespace Struct
{
    struct Student
    {
        private string fio;
        private int[] grades;
        private double amount;
        public Student(string fio, int[] grades, double amount)
        {
            this.fio = fio;
            this.grades = grades;
            this.amount = amount;
        }
        public string FIO
        {
            get { return fio; }
        }
        public int[] Grades
        {
            get { return grades; }
        }
        public double Amount
        {
            get { return amount; }
        }
        public double CalculateAverageGrade()
        {
            int sum = 0;
            foreach (var grade in grades)
            {
                sum += grade;
            }
            return (double)sum / grades.Length;
        }
    }

    class Program
    {
        static void Main()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student("Иванов Иван Иванович", [ 4, 5, 3, 4 ], 100));
            students.Add(new Student("Петров Петр Петрович", [ 3, 3, 2, 4 ], 50));
            students.Add(new Student("Сидоров Сидор Сидорович", [5, 5, 5, 5], 150));
            Student worstStudent = FindWorstStudent(students);
            Console.WriteLine($"Студент с наименьшим средним баллом: {worstStudent.FIO}");
            Console.WriteLine($"Оценки: {string.Join(", ", worstStudent.Grades)}");
            Console.WriteLine($"Размер стипендии: {worstStudent.Amount}");
            Console.ReadLine();
        }

        static Student FindWorstStudent(List<Student> students)
        {
            double minAverageGrade = double.MaxValue;
            Student worstStudent = new Student();
            foreach (var student in students)
            {
                double averageGrade = student.CalculateAverageGrade();
                if (averageGrade < minAverageGrade)
                {
                    minAverageGrade = averageGrade;
                    worstStudent = student;
                }
            }
            return worstStudent;
        }
    }
}
