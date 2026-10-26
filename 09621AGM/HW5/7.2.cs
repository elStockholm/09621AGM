using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _09621AGM.HW5
{
    internal class _72
    {
        //Создать студента из вашей группы (фамилия, имя, год рождения, с каким экзаменом поступил, баллы). Создать словарь для студентов из вашей группы (10 человек).
        //Необходимо прочитать информацию о студентах с файла.В консоли необходимо создать меню:
        //a.Если пользователь вводит: Новый студент, то необходимо ввести информацию о новом студенте и добавить его в List
        //b.Если пользователь вводит: Удалить, то по фамилии и имени удаляется студент
        //c.Если пользователь вводит: Сортировать, то происходит сортировка по баллам (по возрастанию)
        class Student
        {
            public string Surname;
            public string Name;
            public int Year;
            public string Exam;
            public int PointsExam;

            public Student(string surname, string name, int year, string exam, int pointsExam)
            {
                Surname = surname;
                Name = name;
                Year = year;
                Exam = exam;
                PointsExam = pointsExam;
            }
        }
        static void Main7(string[] args)
        {
            List<Student> studentsList = new List<Student>();
            Dictionary<string, Student> studentsDict = new Dictionary<string, Student>();
            string[] lines = File.ReadAllLines("students.txt");
            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                string[] parts = line.Split('|');

                if (parts.Length == 5)
                {
                    string surname = parts[0];
                    string name = parts[1];
                    int year = int.Parse(parts[2].Trim());
                    string exam = parts[3];
                    int points = int.Parse(parts[4].Trim());

                    Student student = new Student(surname, name, year, exam, points);
                    studentsList.Add(student);

                    string key = surname + " " + name;
                    if (!studentsDict.ContainsKey(key))
                    {
                        studentsDict.Add(key, student);
                    }
                }
            }
            while (true)
            {
                Console.WriteLine("\nМЕНЮ");
                Console.WriteLine("1. Новый студент");
                Console.WriteLine("2. Удалить");
                Console.WriteLine("3. Сортировать");
                Console.WriteLine("4. Выход");
                Console.Write("Выберите пункт меню: ");

                string choice = Console.ReadLine();

                if (choice == "1" || choice.ToLower() == "новый студент")
                {
                    try
                    {
                        Console.WriteLine("Введите фамилию студента:");
                        string surname = Console.ReadLine();

                        Console.WriteLine("Введите имя студента:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Введите год рождения студента:");
                        int year = int.Parse(Console.ReadLine());

                        Console.WriteLine("Введите экзамен студента:");
                        string exam = Console.ReadLine();

                        Console.WriteLine("Введите баллы за экзамен студента:");
                        int points = int.Parse(Console.ReadLine());
                        Student student = new Student(surname, name, year, exam, points);
                        studentsList.Add(student);
                        string lineToAdd = $"{surname}|{name}|{year}|{exam}|{points}";
                        File.AppendAllText("students.txt", lineToAdd + Environment.NewLine);
                    }
                    catch
                    {
                        Console.WriteLine("Введите данные правильно");
                        return;
                    }
                }
                else if (choice == "2" || choice.ToLower() == "удалить")
                {
                   
                    Console.WriteLine("Введите фамилию студента");
                    string targetSurname = Console.ReadLine();
                    Console.WriteLine("Введите имя студента");
                    string targetName = Console.ReadLine();
                    studentsList.RemoveAll(s => s.Surname.Equals(targetSurname, StringComparison.OrdinalIgnoreCase) && s.Name.Equals(targetName, StringComparison.OrdinalIgnoreCase));
                    string key = targetSurname + " " + targetName;
                    if (studentsDict.ContainsKey(key))
                    {
                        studentsDict.Remove(key);
                        Console.WriteLine("Студент успешно удален!");
                    }
                    else
                    {
                        Console.WriteLine("Студент с такими данными не найден в словаре.");
                    }
                }
                else if (choice == "3" || choice.ToLower() == "сортировать")
                {
                    studentsList = studentsList.OrderBy(s => s.PointsExam).ToList();
                    Console.WriteLine("\nСПИСОК СТУДЕНТОВ (ОТСОРТИРОВАНО ПО БАЛЛАМ)");
                    foreach (var student in studentsList)
                    {
                        Console.WriteLine($"\nФамилия: {student.Surname}, \nИмя: {student.Name}, \nГод: {student.Year}, \nЭкзамен: {student.Exam}, \nБаллы: {student.PointsExam}");
                    }
                }
                else if (choice == "4" || choice.ToLower() == "выход")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                }
            }
        }
    }
}