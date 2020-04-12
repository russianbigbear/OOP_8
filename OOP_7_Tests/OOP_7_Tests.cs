using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP_7;
using System;
using System.Diagnostics;
using System.Drawing;

namespace OOP_7_Tests
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void TestPhoneNumberInitMethod()
        {
            string address = "Ленина";
            string surname = "Ленин";
            double payment = 100;
            double credit = 300;

            OOP_7.PhoneNumber phone_number_test = new OOP_7.PhoneNumber();
            phone_number_test.Init(address, surname, payment, credit);

            Assert.AreEqual(address, phone_number_test._address);
            Assert.AreEqual(surname, phone_number_test._surname);
            Assert.AreEqual(payment, phone_number_test._payment);
            Assert.AreEqual(credit, phone_number_test._credit);
        }

        [TestMethod]
        public void TestPhoneNumberDisplayMethod()
        {
            string address = "Ленина";
            string surname = "Ленин";
            double payment = 100;
            double credit = 300;

            OOP_7.PhoneNumber phone_number_test = new OOP_7.PhoneNumber();
            phone_number_test.Init(address, surname, payment, credit);

            Assert.IsTrue(phone_number_test.Display());
        }

        [TestMethod]
        public void TestPhoneNumberAddMethod()
        {
            OOP_7.PhoneNumber phone_number1 = new OOP_7.PhoneNumber();
            phone_number1.Init("Ленина", "Ленин", 100, 300);

            OOP_7.PhoneNumber phone_number2 = new OOP_7.PhoneNumber();
            phone_number2.Init("Сталина", "Сталин", 1000, 3000);

            OOP_7.PhoneNumber phone_number3 = new OOP_7.PhoneNumber();
            phone_number3.Init("Ленина", String.Concat(phone_number1._surname, " - ", phone_number2._surname), 1100, 3000);

            OOP_7.PhoneNumber phone_number_test = phone_number1.Add(phone_number1, phone_number2);
            Assert.AreEqual(phone_number3._address, phone_number_test._address);
            Assert.AreEqual(phone_number3._surname, phone_number_test._surname);
            Assert.AreEqual(phone_number3._payment, phone_number_test._payment);
            Assert.AreEqual(phone_number3._credit, phone_number_test._credit);

            phone_number2._credit = 50;
            phone_number3._credit = 300;
            phone_number_test = phone_number1.Add(phone_number1, phone_number2);

            Assert.AreEqual(phone_number3._address, phone_number_test._address);
            Assert.AreEqual(phone_number3._surname, phone_number_test._surname);
            Assert.AreEqual(phone_number3._payment, phone_number_test._payment);
            Assert.AreEqual(phone_number3._credit, phone_number_test._credit);

        }

        [TestMethod]
        public void TestPhoneNumberGet_addressMethod()
        {
            OOP_7.PhoneNumber phone_number1 = new OOP_7.PhoneNumber();
            phone_number1._address = "Ленина";
            string address = phone_number1.Get_address();

            Assert.AreEqual(phone_number1._address, address);
        }

        [TestMethod]
        public void TestPhoneNumberGet_surnameMethod()
        {
            OOP_7.PhoneNumber phone_number1 = new OOP_7.PhoneNumber();
            phone_number1._surname = "Ленин";
            string surname = phone_number1.Get_surname();

            Assert.AreEqual(phone_number1._surname, surname);
        }

        [TestMethod]
        public void TestPhoneNumberGet_paymentMethod()
        {
            OOP_7.PhoneNumber phone_number1 = new OOP_7.PhoneNumber();
            phone_number1._payment = 100;
            double payment = phone_number1.Get_payment();

            Assert.AreEqual(phone_number1._payment, payment);
        }

        [TestMethod]
        public void TestPhoneBookNew_ArrayMethod()
        {
            int size = 3;
            OOP_7.PhoneNumber phone_number = new OOP_7.PhoneNumber();

            OOP_7.PhoneBook phone_book_test = new PhoneBook();
            phone_book_test.New_Array();

            Assert.AreEqual(size, phone_book_test._size);

            for (int i = 0; i < size; i++){
                Assert.AreEqual(phone_number._address, phone_book_test._phone[i]._address);
                Assert.AreEqual(phone_number._surname, phone_book_test._phone[i]._surname);
                Assert.AreEqual(phone_number._payment, phone_book_test._phone[i]._payment);
                Assert.AreEqual(phone_number._credit, phone_book_test._phone[i]._credit);
            }
        }

        [TestMethod]
        public void TestPhoneBookInit_Phone_NumberMethod()
        {
            int size = 3;
            string[] address = { "Ленина", "Сталина", "Гоголя" };
            string[] surname = { "Ленин", "Сталин", "Гоголь" };
            double[] payment = { 100, 200, 300 };
            double[] credit = { 1000, 2000, 3000 };

            double internet_payment = 10000;

            OOP_7.PhoneBook phone_book_test = new PhoneBook();
            phone_book_test.Init_Phone_Number(address[0], surname[0], payment[0], credit[0],
                address[1], surname[1], payment[1], credit[1],
                address[2], surname[2], payment[2], credit[2], internet_payment);

            for (int i = 0; i < size; i++)
            {
                Assert.AreEqual(address[i], phone_book_test._phone[i]._address);
                Assert.AreEqual(surname[i], phone_book_test._phone[i]._surname);
                Assert.AreEqual(payment[i], phone_book_test._phone[i]._payment);
                Assert.AreEqual(credit[i], phone_book_test._phone[i]._credit);
            }

            Assert.AreEqual(size, phone_book_test._size);
            Assert.AreEqual(internet_payment, phone_book_test._internet_payment);
        }

        [TestMethod]
        public void TestPhoneBookDisplay_Phone_NumberMethod()
        {
            OOP_7.PhoneBook phone_book_test = new PhoneBook();
            Assert.IsTrue(phone_book_test.Display_Phone_Number());
        }

        [TestMethod]
        public void TestPhoneBookSumMethod()
        {
            string[] address = { "Ленина", "Сталина", "Гоголя" };
            string[] surname = { "Ленин", "Сталин", "Гоголь" };
            double[] payment = { 100, 200, 300 };
            double[] credit = { 1000, 2000, 3000 };

            double internet_payment = 10000;

            OOP_7.PhoneBook phone_book_test = new PhoneBook();
            phone_book_test.Init_Phone_Number(address[0], surname[0], payment[0], credit[0],
                address[1], surname[1], payment[1], credit[1],
                address[2], surname[2], payment[2], credit[2], internet_payment);

            double sum = 16600;
             
            double sum_test = phone_book_test.Sum();

            Assert.AreEqual(sum, sum_test);
        }


        [TestMethod]
        public void TestPhoneBookMaxCreditMethod()
        {
            string[] address = { "Ленина", "Сталина", "Гоголя" };
            string[] surname = { "Ленин", "Сталин", "Гоголь" };
            double[] payment = { 100, 200, 300 };
            double[] credit = { 1000, 2000, 3000 };

            double internet_payment = 10000;

            OOP_7.PhoneBook phone_book_test = new PhoneBook();
            phone_book_test.Init_Phone_Number(address[0], surname[0], payment[0], credit[0],
                address[1], surname[1], payment[1], credit[1],
                address[2], surname[2], payment[2], credit[2], internet_payment);


            int numP = phone_book_test.MaxCredit();
            Assert.AreEqual(3, numP);

            phone_book_test._phone[1].Credit = 3000;
            phone_book_test._phone[2].Credit = 2000;
            numP = phone_book_test.MaxCredit();
            Assert.AreEqual(2, numP);

            phone_book_test._phone[0].Credit = 3000;
            phone_book_test._phone[1].Credit = 1000;
            numP = phone_book_test.MaxCredit();
            Assert.AreEqual(1, numP);
        }
    }
}
