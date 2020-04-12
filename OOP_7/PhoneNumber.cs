using System;

namespace OOP_7
{
    public class PhoneNumber
    {
        public string _address;
        public string _surname;
        public double _payment;
        public double _credit;
        
        public double Credit {
            get { return _credit; }
            set { _credit = value; }
        }
        
        public void Init(string address, string surname, double payment, double credit) {
            _address = address;
            _surname = surname;
            _payment = payment;
            Credit = credit;
        }
        
        public void Read () {
            string address;
            string surname;
            double payment;
            double credit;

            Console.Write("Введите адресс абонента: ");
            address = Console.ReadLine();
            Console.Write("Введите фамилию: ");
            surname = Console.ReadLine();
            Console.Write("Введите сумму оплаты: ");
            payment = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите сумму долга: ");
            credit = Convert.ToDouble(Console.ReadLine());
            Init(address, surname, payment, credit);
        }
        
        public bool Display () {
            Console.WriteLine("Ваша информация.");
            Console.WriteLine("Фамилия {0}.", Get_surname());
            Console.WriteLine("Адресс: {0}.", Get_address());
            Console.WriteLine("Сумма оплаты: {0}.", Get_payment());
            Console.WriteLine("Долг: {0}.", Credit);

            return true;
        }
        
        public PhoneNumber Add (PhoneNumber obj_1, PhoneNumber obj_2) {
            PhoneNumber obj_3 = new PhoneNumber();
            obj_3._address = obj_1._address;
            obj_3._surname = String.Concat(obj_1._surname, " - " , obj_2._surname);
            obj_3._payment = obj_1._payment + obj_2._payment;
            if (obj_1._credit > obj_2._credit) obj_3._credit = obj_1._credit;
            else obj_3._credit = obj_2._credit;

            return obj_3;
        }

        public string Get_address() { return _address; }
        public string Get_surname() { return _surname; }
        public double Get_payment() { return _payment; }
          
    }
}
