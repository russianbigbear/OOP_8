using System;


namespace OOP_7
{
    public class Programm
    {
        static void Main(string[] args)
        {
            PhoneBook obj = new PhoneBook();
            obj.Init_Phone_Number
                (
                "ул. Малахова 141", "Гоголь", 145, 56,
                "ул. Малахова 145", "Пушкин", 100, 90,
                "ул. Малахова 149", "Тургенев", 50, 23,
                10000
                );

            obj.Display_Phone_Number();
            obj.Insert();
            obj.Display_Phone_Number();
            obj.Delete();
            obj.Display_Phone_Number();

            Console.WriteLine("Общая сумма: {0}.", obj.Sum());
            Console.WriteLine("Максимальный долг у абонента телефона №{0}.", obj.MaxCredit());

            
        }
    }
}
