using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReaderNamespace
{
    class Reader
    {
        private string fullName;
        public int ticket;
        public string faculty;
        private DateTime birthday;
        public string phoneNumber;
        public Reader(string fullName, int ticket, string faculty, DateTime birthday, string phoneNumber)
        {
            this.fullName = fullName;
            this.ticket = ticket;
            this.faculty = faculty;
            this.birthday = birthday;
            this.phoneNumber = phoneNumber;
        }
        public void PrintDisplay() => Console.WriteLine($"{fullName}, номер билета: {ticket}, факультет: {faculty}, дата рождения: {birthday.ToShortDateString()}, номер телефона: {phoneNumber}");

        public void takeBook(int countBook) => Console.WriteLine($"{fullName} взял {countBook} книги");

        public void takeBook(params string[] books) => Console.WriteLine($"{fullName} взял книги: {string.Join(", ", books)}");

        public void returnBook(int countBook) => Console.WriteLine($"{fullName} вернул {countBook} книги");

        public void returnBook(params string[] books) => Console.WriteLine($"{fullName} вернул книги: {string.Join(", ", books)}");
    }
}
