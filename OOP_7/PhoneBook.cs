using System;

namespace OOP_7
{
    public class PhoneBook
    {
        const int N = 100;

        public PhoneNumber[] _phone = new PhoneNumber[N];
        public double _internet_payment;
        public int _size;

        public void New_Array() {
            _phone[0] = new PhoneNumber();
            _phone[1] = new PhoneNumber();
            _phone[2] = new PhoneNumber();
            _size = 3;
        }

        public void Insert() {

            Console.Write("Введите порядковый номер в массиве для добавления: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n - 1 > _size)
            {
                _phone[_size++] = new PhoneNumber();
                n = _size;
            }
            else
            {
                if (n - 1 < 0)
                    n = 1;

                for (int i = _size; i > n - 1; i--)
                    _phone[i] = _phone[i - 1];

                _phone[n - 1] = new PhoneNumber();
                _size++;
            }

            //Проверка на ввод
            Console.WriteLine("Проверка на ввод.");
            _phone[n - 1].Read();
           
        }

        public void Delete() {
            Console.Write("Введите порядковый номер в массиве для удаления: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n - 1 >= _size)
                _phone[_size--] = null;
            else
            {
                if (n - 1 < 0)
                    n = 1;

                for (int i = 0; i < _size; i++)
                    if(i > n - 1)
                        _phone[i - 1] = _phone[i];

                _phone[--_size] = null;
                
            }
        }

        public void Read_Phone_Number() {
            New_Array();
            _phone[0].Read(); _phone[1].Read(); _phone[2].Read();
            Console.Write("Введите общую сумму за интеренет: ");
            _internet_payment = Convert.ToDouble(Console.ReadLine());
        }

        public void Init_Phone_Number
            (
            string address1, string surname1, double payment1, double credit1,
            string address2, string surname2, double payment2, double credit2,
            string address3, string surname3, double payment3, double credit3,
            double internet_payment
            )
        {
            New_Array();
            _phone[0].Init(address1, surname1, payment1, credit1);
            _phone[1].Init(address2, surname2, payment2, credit2);
            _phone[2].Init(address3, surname3, payment3, credit3);
            _internet_payment = internet_payment;
            
        }

        public bool Display_Phone_Number() {
            for (int i = 0; i < _size; i++)
                _phone[i].Display();

            return true;
        }

        public double Sum() {
            double credit = _phone[0].Credit + _phone[1].Credit + _phone[2].Credit;
            double payment = _phone[0].Get_payment() + _phone[1].Get_payment() + _phone[2].Get_payment();
            return credit + payment + _internet_payment;
        }

        public int MaxCredit()
        {
            double max;
            int numP;

            if (_phone[0].Credit > _phone[1].Credit) { 
                max = _phone[0].Credit; numP = 1; 
            }
            else {
                max = _phone[1].Credit; numP = 2; 
            }

            if (_phone[2].Credit > max) 
                numP = 3; 
           
            return numP;
        }

    }
}
