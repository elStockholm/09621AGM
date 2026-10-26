using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW5
{
    internal class _73
    {
        //3.	Создать бабулю. У бабули есть Имя, возраст, болезнь и лекарство от этой болезни, которое она принимает (болезней может быть у бабули несколько). Реализуйте список бабуль.
        //Также есть больница (у больницы есть название, список болезней, которые они лечат и вместимость). Больниц также, как и бабуль несколько. Бабули по очереди
        //поступают(реализовать ввод с клавиатуры) и дальше идут в больницу, в зависимости от заполненности больницы и списка болезней, которые лечатся в данной больнице,
        //реализовать функционал, который будет распределять бабулю в нужную больницу.Если бабуля не имеет болезней, то она хочет только спросить -она может попасть в первую
        //свободную клинику.Если бабулю ни одна из больниц не лечит, то бабуля остаётся на улице плакать. На экран выводить список всех бабуль, список всех больниц, болезни, которые там лечат и сколько бабуль в данный момент находится в больнице, также
        //вывести процент заполненности больницы.P.S.Бабуля попадает в больницу, если там лечат более 50% ее болезней. Больницы реализовать в виде стека, бабуль в виде
        //очереди.

        class Grandmother
        {
            public string Name;
            public int Age;
            public List<string> Diseases;
            public Grandmother(string name, int age, List<string> diseases)
            {
                Name = name;
                Age = age;
                Diseases = diseases;
            }
        }
        class Hospital
        {
            public string Title;
            public List<string> HospitalDiseases;
            public int Capacity;
            public List<Grandmother> Grandmothers;
            public Hospital(string title, List<string> hospitalDiseases, int capacity)
            {
                Title = title;
                HospitalDiseases = hospitalDiseases;
                Capacity = capacity;
                Grandmothers = new List<Grandmother>();
            }
        }
        static public void Main6(string[] args)
        {
            Queue<Grandmother> grandmothersQueue = new Queue<Grandmother>();
            Stack<Hospital> hospitalsStack = new Stack<Hospital>();

            hospitalsStack.Push(new Hospital("Больница 1", new List<string> { "давление", "кашель", "насморк", "бессонница" }, 2));
            hospitalsStack.Push(new Hospital("Больница 2", new List<string> { "давление", "аритмия", "тахикардия" }, 3));
            hospitalsStack.Push(new Hospital("Больница 3", new List<string> { "ковид", "пневмония", "грипп" }, 1));
            hospitalsStack.Push(new Hospital("Больница 4", new List<string> { "грипп", "кашель", "насморк" }, 2));
            hospitalsStack.Push(new Hospital("Городская дурка", new List<string> { "шизофрения" }, 2));
            Console.WriteLine("ВВОД БАБУЛЬ");
            while (true)
            {
                Console.Write("Хотите добавить новую бабулю?: ");
                string answer = Console.ReadLine();

                if (answer != null && answer.Trim().ToLower() != "да")
                {
                    break; 
                }

                Console.Write("Введите имя бабули: ");
                string name = Console.ReadLine();

                Console.Write("Введите возраст бабули: ");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Введите болезни бабули через запятую: ");
                string diseasesInput = Console.ReadLine();

                List<string> diseases = new List<string>();
                if (!string.IsNullOrWhiteSpace(diseasesInput))
                {
                    string[] splitDiseases = diseasesInput.Split(',');
                    foreach (var disease in splitDiseases)
                    {
                        diseases.Add(disease.Trim());
                    }
                }
                Grandmother grandma = new Grandmother(name, age, diseases);
                grandmothersQueue.Enqueue(grandma);
                Console.WriteLine($"Бабуля {name} добавлена в очередь!\n");
            }

            List<Grandmother> cryingGrandmothers = new List<Grandmother>();

            while (grandmothersQueue.Count > 0)
            {
                Grandmother currentGrandma = grandmothersQueue.Dequeue();
                bool isAssigned = false;
                foreach (Hospital hospital in hospitalsStack)
                {
                    if (currentGrandma.Diseases.Count == 0)
                    {
                        if (hospital.Grandmothers.Count < hospital.Capacity)
                        {
                            hospital.Grandmothers.Add(currentGrandma);
                            isAssigned = true;
                            break;
                        }
                    }
                    else
                    {
                        int matches = 0;
                        foreach (string grandmaDisease in currentGrandma.Diseases)
                        {
                            foreach (string hospitalDisease in hospital.HospitalDiseases)
                            {
                                if (grandmaDisease.Equals(hospitalDisease, StringComparison.OrdinalIgnoreCase))
                                {
                                    matches++;
                                }
                            }
                        }
                        if (matches > currentGrandma.Diseases.Count / 2.0 && hospital.Grandmothers.Count < hospital.Capacity)
                        {
                            hospital.Grandmothers.Add(currentGrandma);
                            isAssigned = true;
                            break;
                        }
                    }
                }
                if (!isAssigned)
                {
                    cryingGrandmothers.Add(currentGrandma);
                }
            }
            Console.WriteLine("\nСПИСОК БОЛЬНИЦ");
            foreach (Hospital hospital in hospitalsStack)
            {
                double fillPercentage = 0;
                if (hospital.Capacity > 0)
                {
                    fillPercentage = ((double)hospital.Grandmothers.Count / hospital.Capacity) * 100;
                }

                Console.WriteLine($"\nБольница: {hospital.Title}");
                Console.WriteLine($"Вместимость: {hospital.Capacity}");
                Console.WriteLine($"Лечат болезни: {string.Join(", ", hospital.HospitalDiseases)}");
                Console.WriteLine($"Количество пациентов: {hospital.Grandmothers.Count}");
                Console.WriteLine($"Заполненность: {fillPercentage:F1}%");

                if (hospital.Grandmothers.Count > 0)
                {
                    Console.WriteLine("Пациенты в больнице:");
                    foreach (var patient in hospital.Grandmothers)
                    {
                        Console.WriteLine($"  - Бабуля {patient.Name}, возраст: {patient.Age}");
                    }
                }
            }
            Console.WriteLine("\nБАБУЛИ НА УЛИЦЕ");
            if (cryingGrandmothers.Count == 0)
            {
                Console.WriteLine("Все бабули распределены по больницам");
            }
            else
            {
                foreach (var patient in cryingGrandmothers)
                {
                    Console.WriteLine($"  - Бабуля {patient.Name} (возраст: {patient.Age}) осталась без больницы.");
                }
            }
            Console.WriteLine("---");
        }
    }
}