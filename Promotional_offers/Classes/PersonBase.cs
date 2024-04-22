using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promotional_offers.Classes
{
    public abstract class PersonBase : IPerson
    {
        private static readonly HashSet<string> usedEmails = new HashSet<string>();
        private static readonly HashSet<string> usedPasswords = new HashSet<string>();

        private string email;
        private string password;

        public string Email
        {
            get { return email; }
            set
            {
                do
                {
                    if (!string.IsNullOrEmpty(value) && value.Length >= 3 && value.Contains("@"))
                    {
                        if (!usedEmails.Contains(value))
                        {
                            email = value;
                            usedEmails.Add(value);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Помилка: Ця адреса електронної пошти вже використовується.");
                            Console.WriteLine("Введіть адресу електронної пошти ще раз:");
                            value = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Помилка: Некоректна адреса електронної пошти. Адреса повинна містити символ '@' та бути не менше трьох символів.");
                        Console.WriteLine("Введіть адресу електронної пошти ще раз:");
                        value = Console.ReadLine();
                    }
                } while (true);
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                do
                {
                    if (!string.IsNullOrEmpty(value) && value.Length <= 14 && value.All(char.IsLetter))
                    {
                        if (!usedPasswords.Contains(value))
                        {
                            password = value;
                            usedPasswords.Add(value);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Помилка: Цей пароль вже використовується.");
                            Console.WriteLine("Введіть пароль ще раз:");
                            value = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Помилка: Некоректний пароль. Пароль повинен містити не більше 10 символів та складатися лише з літер латинського алфавіту.");
                        Console.WriteLine("Введіть пароль ще раз:");
                        value = Console.ReadLine();
                    }
                } while (true);
            }
        }

        public virtual string Get_Full_Info()
        {
            return $"Email: {Email}, Password: {Password}";
        }
    }
}
