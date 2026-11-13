using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _09621AGM.HW7
{
    internal class HW1
    {
        //Работа со строками.Дан текстовый файл, содержащий ФИО и e - mail адрес.Разделителем между ФИО и адресом электронной почты является символ #:
        //Иванов Иван Иванович # iviviv@mail.ru Петров Петр Петрович # petr@mail.ru
        //Сформировать новый файл, содержащий список адресов электронной почты.
        //Предусмотреть метод, выделяющий из строки адрес почты.Методу в
        //качестве параметра передается символьная строка s, e-mail возвращается в той же строке s: public void SearchMail(ref string s).
        public void SearchMail(ref string s)
        {
            if (s.Contains("#"))
            {
                s = s.Split('#')[1].Trim();
            }
        }
        static void Main1(string[] args)
        {
            HW1 hw = new HW1();
            string[] lines = File.ReadAllLines("input.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                hw.SearchMail(ref lines[i]);
            }

            File.WriteAllLines("emails.txt", lines);
        }
    }
}
