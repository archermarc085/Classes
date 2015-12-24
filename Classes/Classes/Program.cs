using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1
            Address addressdefault = new Address();
            Address address = new Address() { Apartment = 110 , City = "Kiev", Country = "Ukraine", House = 50 , Index = 58000, Street = "Hreshatik"};
            Address addressChangedIndex = new Address(10000);
            
            addressdefault.DisplayAddress();
            address.DisplayAddress();
            Console.WriteLine(addressChangedIndex.ToString());
           //Task 2
            string str = "";
            double number1 = 0;
            double number2 = 0;

            number1 = str.CheckDoubleDigits();
            number2 = str.CheckDoubleDigits();
          
            Rectangle rectangle = new Rectangle(number1, number2);
            Console.WriteLine(rectangle.ToString());

            //Task 3
            Book book = new Book("Programming","Troelsen","C#");
            book.Show();

            //Task 4
            Point []  p = new Point[3];
            p[0] = new Point(1,4);
            p[1] = new Point(6,3);
            p[2] = new Point(3,1);
            
            Figure figure = new Figure(p);
            figure.Display();
            

            //Task 5
            User user = new User(login:"link", password: "3532jgjfd", name: "Jack", sername:"...");
            user.Output();

            //Task 6
            Converter conv = new Converter(24.6081, 25.99,0.3274);
            conv.Sum = 10.11;
            conv.ChooseCurrency();
            conv.ExchangeCurrency();

            //Task 7

            Employee employee = new Employee("User", "Relly");
            employee.Display();

            //Task 8

            Invoice invoice = new Invoice(10000, "Customer" ,"Provider");
            invoice.Article = "PC";
            invoice.Quantity = 2;
            invoice.Display();

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
