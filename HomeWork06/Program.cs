using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace HomeWork06
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ₸ не получилось из-за кодировки добавить((

            Console.WriteLine(Constants.firstConstant + " Мы работаем с " + Constants.secondConstant);

            Console.WriteLine("Добро пожаловать! \nДанные о пользователе:");

            Person person = new Person
            {
                SurName = "Idrissov",
                Name = "Aimurat",
                FatherName = "Nurlanuly",
                Age = 20
            };

            string InformationAboutPerson = PersonInfo.GetPersonInfo(person);

            Console.WriteLine(InformationAboutPerson);

            int maxTry= 3;
            string Password = "1234";
            bool isAuthenticated = false;

            for (int trys = 1; trys <= maxTry; trys++)
            {
                Console.Write("Введите пароль кредитной карточки: \n");
                string isPassword = Console.ReadLine();

                if (isPassword == Password) 
                {
                    isAuthenticated = true;
                    Console.WriteLine("\nВход выполнен успешно!");
                    break;
                }
                else
                {
                    Console.WriteLine($"\nПопытка {trys} неудачна. Попробуйте еще раз.");
                }
            }

            if (isAuthenticated)
            {
                bool exit = false;
                decimal balance = 1000;

                while (!exit)
                {
                    Console.WriteLine("\nВы можете выбрать одно из следующих действий: ");
                    Console.WriteLine("а.   Вывод баланса на экран. ");
                    Console.WriteLine("b.   Пополнение счета. ");
                    Console.WriteLine("c.   Снять деньги со счёта. ");
                    Console.WriteLine("d.   Выход. ");


                    char choice = Console.ReadKey().KeyChar;
                    Console.WriteLine();

                    switch (choice)
                    {
                        case 'a':
                            Console.WriteLine($"Баланс: {balance} тенге");
                            break;

                        case 'b':
                            Console.Write("\nВведите сумму для пополнения: ");

                            if (decimal.TryParse(Console.ReadLine(), out decimal depositSumma))
                            {
                                balance += depositSumma;
                                Console.WriteLine($"Счёт пополнен на {depositSumma} тенге. Новый баланс: {balance} тенге");
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод. Пополнение счёта не выполнено (Ты больше не Армянин).\nВы были переведены обратно в меню.");
                            }
                            break;

                        case 'c':
                            Console.Write("\nВведите сумму для снятия: ");

                            if (decimal.TryParse(Console.ReadLine(), out decimal VyvodSumma))
                            {
                                if (VyvodSumma > balance)
                                {
                                    Console.WriteLine("Недостаточно средств на счете (Ты больше не Армянин). \nВы были переведены обратно в меню.");
                                }
                                else
                                {
                                    balance -= VyvodSumma;
                                    Console.WriteLine($"Сумма {VyvodSumma} тенге снята со счёта. Новый баланс: {balance} тенге");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Некорректный ввод. Снятие средств не выполнено (Ты больше не Армянин).\nВы были переведены обратно в меню.");
                            }
                            break;
                            
                        case 'd':
                            exit= true;
                            break;

                        default:
                            Console.WriteLine("Неверный выбор.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Попытки были исчерпаны, доступ для входа запрещен. Ты больше не Армянин.");
            }
            Thread.Sleep(2500); ///
        }
    }
}