using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW4
{
    internal class _74
    {
        //Создать структуру Дед. У деда есть имя, уровень ворчливости (перечисление), массив фраз для ворчания (прим.: “Проститутки!”, “Гады!”),
        //количество синяков от ударов бабки = 0 по умолчанию. Создать 5 дедов. У каждого деда - разное количество фраз для ворчания.
        //Напишите метод (внутри структуры), который на вход принимает деда, список матерных слов (params).
        //Если дед содержит в своей лексике матерные слова из списка, то бабка ставит фингал за каждое слово. Вернуть количество фингалов.
        enum LvlOfVorchanie
        {
            Low,
            Medium,
            Hard,
            Extreme
        }

        struct Ded
        {
            public string Name;
            public LvlOfVorchanie Lvl;
            public string[] Phrases;
            public int CountFingal;
            public Ded(string name, LvlOfVorchanie lvl, string[] phrases)
            {
                Name = name;
                Lvl = lvl;
                Phrases = phrases;
                CountFingal = 0;
            }
            public int Check(params string[] coolWords)
            {
                foreach (string phrase in Phrases)
                {
                    string lowerPhrase = phrase.ToLower();
                    foreach (string word in coolWords)
                    {
                        if (lowerPhrase.Contains(word.ToLower()))
                        {
                            CountFingal++;
                        }
                    }
                }
                return CountFingal;
            }
        }

        static void Main(string[] args)
        {
            Ded d1 = new Ded("Дед Иван", LvlOfVorchanie.Low, new string[] { "Опять по телевизору одну болтовню крутят, смотреть тошно, одни дармоеды экраны занимают" });
            Ded d2 = new Ded("Дед Петр", LvlOfVorchanie.Medium, new string[] { "Ироды окаянные, опять цены в магазине подкрутили! Пенсию только дают — и тут же всё подчистую сдирают, грабители проклятые!" });
            Ded d3 = new Ded("Дед Василий", LvlOfVorchanie.Hard, new string[] { "Ходят тут всякие шалопаи, подъезд мне весь заплевали, гады! Поймаю за руку — уши оторву, дармоеды ленивые, никакой управы на вас нет!" });
            Ded d4 = new Ded("Дед Николай", LvlOfVorchanie.Hard, new string[] { "Да чтоб вас черти побрали с вашим ремонтом с самого утра! Совести ни грамма у людей, ироды бесчувственные, дармоеды несчастные!" });
            Ded d5 = new Ded("Дед Сергей", LvlOfVorchanie.Extreme, new string[] { "Это ж надо до такого додуматься, тупицы безмозглые! Руки бы вам поотрывать, вредители проклятые! Из-за вашей безалаберности всё испортили, дармоеды да бездари!" });

            Ded[] deds = { d1, d2, d3, d4, d5 };

            string[] coolWords = {"дармоеды", "ироды", "грабители", "шалопаи", "гады", "черти", "тупицы", "вредители", "безалаберность", "бездари"};

            for (int i = 0; i < deds.Length; i++)
            {
                int fingal = deds[i].Check(coolWords);

                Console.WriteLine($"Дед: {deds[i].Name} \nУровень ворчливости: {deds[i].Lvl}");
                Console.WriteLine($"Фингалов от бабки: {fingal}");
                Console.WriteLine(" ");
            }
        }
    }
}