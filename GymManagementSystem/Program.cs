using System.Numerics;
using System.Xml.Linq;

namespace GymManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Member m1 = new();
            bool isparsed;
            Console.WriteLine("Enter Mmber ID : ");
            do
            {
             isparsed = int.TryParse(Console.ReadLine() , out m1.ID);
                if (isparsed && m1.ID > 0)
                    break;
                else
                    Console.WriteLine("please enter valid id");
            }while (true);

            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("Enter Mmber name : ");
            do
            {
                m1?.Name = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(m1?.Name))
                    break;
                else
                    Console.WriteLine("please enter valid Name");
            } while (true);
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("Enter Mmber age : ");
            do
            {
                isparsed = int.TryParse(Console.ReadLine(), out m1.Age);
                if (isparsed && m1.Age >= 16 && m1.Age <= 50)
                    break;
                else
                    Console.WriteLine("please enter valid Age");
            }while(true);
            Console.WriteLine("------------------------------------------------------");
            
            Console.WriteLine("Enter Mmber gender : ");
            Console.WriteLine("1. Male");
            Console.WriteLine("2. Female");
            Console.Write("Choice: ");
            do
            {
                isparsed = Enum.TryParse(Console.ReadLine(), out m1.gender);
                if (isparsed && Enum.IsDefined<Gender>(m1.gender)) 
                break;
                else
                    Console.WriteLine("pleas enter valid gender");

            } while (true);
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine("Enter Mmber type : ");
            Console.WriteLine("1. Standard");
            Console.WriteLine("2. Premium");
            Console.Write("Choice: ");
            do
            {
                isparsed = Enum.TryParse(Console.ReadLine(), out m1.membershipType);
                if (isparsed && Enum.IsDefined(m1.membershipType))
                    break;
                else
                    Console.WriteLine("pleas enter valid type");
            } while (true);

            Console.WriteLine
                (
                $"========= Member Data =========\n" +
                $"ID : {m1.ID}\n" +
                $"Name : {m1.Name}\n" +
                $"Age : {m1.Age}\n" +
                $"Gender : {m1.gender}\n" +
                $"MemberShip : {m1.membershipType}\n" +
                $"MemberShip Price : {m1.MembershipPrice}"
                );
            
        }
    }
}
