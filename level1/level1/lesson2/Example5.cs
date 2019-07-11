using System;
namespace level1.lesson2
{

    class Example5
    {

        static bool Check(string login, string Password)
        {
            return (login == "root" && Password == "GeekBrains");
        }
        //static bool Check(string login, string Password){
        //    if (login == "root" && Password == "GeekBrains") return true;
        //    else return false;
        //}

        static void MainEx5(string[] arg)
        {
            // Реализовать метод проверки логина и пароля.
            // На вход метода подается логин и пароль.
            // На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
            // Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
            // программа пропускает его дальше или не пропускает.
            // С помощью цикла do while ограничить ввод пароля тремя попытками.


            for (int i = 0; i < 3; i++)
            {
                Console.Write("Log in : "); string login = Console.ReadLine();
                Console.Write("passworld  : "); string passworld = Console.ReadLine();
                
                if( Check(login, passworld) ) Console.WriteLine("Welcome! ");
                else Console.WriteLine("Try again! ");
            }
        }
    }

}
