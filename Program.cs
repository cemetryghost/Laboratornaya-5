namespace ConsoleApp4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StudentNamespace.Student[] students = {
                new StudentNamespace.Student("Байкин Н.Д.", 2789, 18),
                new StudentNamespace.Student("Иванов Д.A.", 2710, 18),
                new StudentNamespace.Student("Марусик М.Д.", 1437, 19)
            };

            ReaderNamespace.Reader[] readers = {
                new ReaderNamespace.Reader("Байкин Н.Д.", 138900, "Программирование и информационные системы", new DateTime(2004, 11, 11), "89875678978"),
                new ReaderNamespace.Reader("Иванов Д.A.", 456789, "Программирование и информационные системы", new DateTime(2004, 06, 27), "89271765423"),
                new ReaderNamespace.Reader("Марусик М.Д.", 283891, "Программирование и информационные системы", new DateTime(2004, 02, 03), "89003459971")
            };
            foreach (var student in students)
            {
                student.PrintDisplay();
            }

            foreach (var reader in readers)
            {
                reader.PrintDisplay();
            }

            readers[0].takeBook(2);
            readers[1].takeBook("1984", "Метро");
            readers[0].returnBook(2);
            readers[1].returnBook("1984", "Метро");
            readers[2].takeBook(4);
            readers[2].takeBook("Мгла", "Сияние", "Мизери", "Под куполом");
            readers[2].returnBook(4);
            readers[2].returnBook("Мгла", "Сияние", "Мизери", "Под куполом");

        }
    }
}
