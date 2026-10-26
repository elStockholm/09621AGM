using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW6
{
    internal class HW_1
    {
        //Реализовать класс для описания здания (уникальный номер здания, 
        //высота, этажность, количество квартир, подъездов). Поля сделать закрытыми, 
        //предусмотреть методы для заполнения полей и получения значений полей для печати.
        //Добавить методы вычисления высоты этажа, количества квартир в подъезде, количества
        //квартир на этаже и т.д.Предусмотреть возможность, чтобы уникальный номер здания
        //генерировался программно.Для этого в классе предусмотреть статическое поле, которое бы
        //хранило последний использованный номер здания, и предусмотреть метод, который
        //увеличивал бы значение этого поля. 

        public class Zdanie
        {
            private static int genNum = 1;
            private static int GenerateNum()
            {
                genNum += 1;
                return genNum;
            }
            private int Num;
            private int Hight;
            private int Floors;
            private int Kv;
            private int Padik;
            public Zdanie()
            {

            }
            public Zdanie(int num, int hight, int floors, int kv, int Padik)
            {
                this.Num = num;
                this.Hight = hight;
                this.Floors = floors;
                this.Kv = kv;
                this.Padik = Padik;
            }
            public void SetNum(ref int num)
            {
                this.Num = num;
            }
            public void SetHight(int hight)
            {
                this.Hight = hight;
            }
            public void SetFloors(int floors)
            {
                this.Floors = floors;
            }
            public void SetKv(int kv)
            {
                this.Kv = kv;
            }
            public void SetPadik(int padik)
            {
                this.Padik = padik;
            }
            public int GetNum()
            {
                return this.Num;
            }
            public int GetHight()
            {
                return this.Hight;
            }
            public int GetFloors()
            {
                return this.Floors;
            }
            public int GetKv()
            {
                return this.Kv;
            }
            public int GetPadik()
            {
                return this.Padik;
            }
            public void DisplayInfo()
            {
                Console.WriteLine($"Номер здания: {Num}");
                Console.WriteLine($"Высота здания: {Hight}");
                Console.WriteLine($"Количество этажей в здании: {Floors}");
                Console.WriteLine($"Количество квартир в здании: {Kv}");
                Console.WriteLine($"Количество подьездов в здании {Padik}");
            }
            public void GetHightFloor()
            {
                double HightFloor = (double)this.Hight / (double)this.Floors;
                Console.WriteLine($"Высота одного этажа в здании равна {HightFloor:F2}");
            }
            public void GetKvInPadik()
            {
                int KvInPadik = (int)this.Kv / (int)this.Padik;
                Console.WriteLine($"Количество квартир в одном подьезде равно {KvInPadik}");
            }
            static void Main(string[] args)
            {
                Zdanie building = new Zdanie();
                Console.WriteLine("---Добавьте новое здание---");
                Console.WriteLine("Как вы хотите добавить номер здания?");
                Console.WriteLine("1. Сгенерировать случаный номер здания");
                Console.WriteLine("2. Ввести номер здания вручную");
                string answer = Console.ReadLine();
                int ansNum;
                if (answer == "1" || answer == "Сгенерировать случаный номер здания")
                {
                    ansNum = genNum;
                }
                else if (answer == "2" || answer == "Ввести номер здания вручную")
                {
                    Console.WriteLine("Введите номер: ");
                    ansNum = int.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Введите номер или в точности введите текст");
                    return;
                }
                building.SetNum(ref ansNum);
                Console.WriteLine("Введите высоту здания:");
                int ansHight = int.Parse(Console.ReadLine());
                building.SetHight(ansHight);
                Console.WriteLine("Введите количество этажей в здании:");
                int ansFloors = int.Parse(Console.ReadLine());
                building.SetFloors(ansFloors);
                Console.WriteLine("Введите количество квартир в здании:");
                int ansKv = int.Parse(Console.ReadLine());
                building.SetKv(ansKv);
                Console.WriteLine("Введите количество подьездов в здании:");
                int ansPadik = int.Parse(Console.ReadLine());
                building.SetPadik(ansPadik);

                Console.WriteLine("Здании успешно добавлено");

                while (true)
                {
                    Console.WriteLine("\n---Что вы хотите сделать?---");
                    Console.WriteLine("1. Получить информацию о здании");
                    Console.WriteLine("2. Посчитать высоту одного этажа");
                    Console.WriteLine("3. Посчитать количество квартир в одном подьезде");
                    string ans = Console.ReadLine();
                    if (ans == "1" || ans == "Получить информацию о здании")
                    {
                        building.DisplayInfo();
                    }
                    if (ans == "2" || ans == "Посчитать высоту одного этажа")
                    {
                        building.GetHightFloor();
                    }
                    if (ans == "3" || ans == "Посчитать количество квартир в одном подьезде")
                    {
                        building.GetKvInPadik();
                    }
                }
            }
        }
    }
}