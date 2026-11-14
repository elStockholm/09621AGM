using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09621AGM.HW7
{
    internal class LAB1
    {
        enum TaskTarget
        {
            Management,
            SysAdmins,
            Developers,
            Accounting
        }

        class Employee
        {
            public string Name;
            public TaskTarget Department;
            public Employee Boss1;
            public Employee Boss2;

            public Employee(string name, TaskTarget department, Employee boss1 = null, Employee boss2 = null)
            {
                Name = name;
                Department = department;
                Boss1 = boss1;
                Boss2 = boss2;
            }

            public void GiveTask(Employee worker, string taskTitle, TaskTarget target)
            {
                Console.WriteLine($"От {Name} даётся задача {taskTitle} человеку {worker.Name}");

                bool isMyBoss = (worker.Boss1 == this || worker.Boss2 == this);
                bool isMyDepartment = (worker.Department == target);

                if (isMyBoss && isMyDepartment)
                {
                    Console.WriteLine($"{worker.Name} берёт задачу.\n");
                }
                else
                {
                    Console.WriteLine($"{worker.Name} не берёт задачу.\n");
                }
            }
            static void Main1(string[] args)
            {
                Employee timur = new Employee("Тимур", TaskTarget.Management);

                Employee rashid = new Employee("Рашид", TaskTarget.Management, timur);
                Employee ilham = new Employee("О Ильхам", TaskTarget.Management, timur);

                Employee lukas = new Employee("Лукас", TaskTarget.Accounting, rashid);

                Employee orkadiy = new Employee("Оркадий", TaskTarget.Management, ilham);
                Employee volodya = new Employee("Володя", TaskTarget.Management, ilham);

                Employee ilshat = new Employee("Ильшат", TaskTarget.SysAdmins, orkadiy, volodya);
                Employee ivanych = new Employee("Иваныч", TaskTarget.SysAdmins, ilshat);
                Employee ilya = new Employee("Илья", TaskTarget.SysAdmins, ivanych);
                Employee vitya = new Employee("Витя", TaskTarget.SysAdmins, ivanych);
                Employee zhenya = new Employee("Женя", TaskTarget.SysAdmins, ivanych);

                Employee sergey = new Employee("Сергей", TaskTarget.Developers, orkadiy, volodya);
                Employee lyaysan = new Employee("Ляйсан", TaskTarget.Developers, sergey);
                Employee marat = new Employee("Марат", TaskTarget.Developers, lyaysan);
                Employee dina = new Employee("Дина", TaskTarget.Developers, lyaysan);
                Employee ildar = new Employee("Ильдар", TaskTarget.Developers, lyaysan);
                Employee anton = new Employee("Антон", TaskTarget.Developers, lyaysan);

                lukas.GiveTask(sergey, "Автоматизировать бухгалтерию", TaskTarget.Developers);
                timur.GiveTask(ilham, "Автоматизировать бухгалтерию", TaskTarget.Management);
                ilham.GiveTask(orkadiy, "Автоматизировать бухгалтерию", TaskTarget.Management);

                orkadiy.GiveTask(sergey, "Сделать кнопку для бухгалтерии", TaskTarget.Developers);
                orkadiy.GiveTask(dina, "Сделать кнопку для бухгалтерии", TaskTarget.Developers);
                sergey.GiveTask(lyaysan, "Сделать кнопку для бухгалтерии", TaskTarget.Developers);
                lyaysan.GiveTask(dina, "Сделать кнопку для бухгалтерии", TaskTarget.Developers);

                volodya.GiveTask(ilshat, "Настроить сеть", TaskTarget.SysAdmins);
                ilshat.GiveTask(ivanych, "Настроить сеть", TaskTarget.SysAdmins);
                ivanych.GiveTask(vitya, "Настроить сеть", TaskTarget.SysAdmins);
                sergey.GiveTask(ilya, "Настроить сеть", TaskTarget.SysAdmins);
            }
        }
    }
}