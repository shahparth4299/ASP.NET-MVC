using System;
using BusinessLayer;
namespace HospitalManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Address nurse_address1 = new Address(101,"Shanti Jyot","Station Road",401010);
            Address nurse_address2 = new Address(1010, "Tirupati Jyot", "Balaji Nagar", 401110);
            Address wardboy_address1 = new Address(1001, "Raj Heights", "Dhanuarwadi", 401101);
            Address wardboy_address2 = new Address(201, "Jat Apartment", "Mahvir Nagar", 400100);
            Address doctor_address1 = new Address(2301, "Haresh Heights", "Modi Patel", 401123);
            Address doctor_address2 = new Address(2431, "Ram Apartment", "Narayan Nagar", 404500);

            Salary n1 = new Salary(12000);
            Salary n2 = new Salary(12000);
            Salary w1 = new Salary(15000);
            Salary w2 = new Salary(15000);
            Salary d1 = new Salary(10000);
            Salary d2 = new Salary(10000);


            Nurses nurse1 = new Nurses(n1,nurse_address1, 101, 21, "Rachita", "9082121123");
            Nurses nurse2 = new Nurses(n2,nurse_address2, 102, 26, "Shivani", "9082564323");

            Wardboy wardboy1 = new Wardboy(w1,wardboy_address1, 601, 28, "Smith", "8976121123");
            Wardboy wardboy2 = new Wardboy(w2,wardboy_address2, 801, 48, "Aloknath", "8976342133");

            Doctor doctor1 = new Doctor(d1,"Heart Specialist", doctor_address1, 601, 29, "Yash Gill", "8565432423");
            Doctor doctor2 = new Doctor(d2, "Neurologist",doctor_address2, 801, 32, "Raj Parekh", "1234542133");

            //nurse1.DisplayNurses();
            //nurse2.DisplayNurses();
            //doctor1.DisplayDoctor();
            //doctor2.DisplayDoctor();
            //wardboy1.DisplayWardboy();
            //wardboy2.DisplayWardboy();

            int flag = 0;
            string a;
            do
            {
                Console.WriteLine("Select Below Option");
                Console.WriteLine("1. Display Doctors Information");
                Console.WriteLine("2. Display Nurses Information");
                Console.WriteLine("3. Display Warboys Information");
                Console.WriteLine("4. Exit");
                a = Console.ReadLine();
                flag = Convert.ToInt16(a);
                switch(flag)
                {
                    case 1:
                        doctor1.DisplayDoctor();
                        //passing the patinets statically
                        Console.WriteLine("Salary: "+doctor1.DoctorSalary(5) + "\n");
                        doctor2.DisplayDoctor();
                        Console.WriteLine("Salary: " + doctor2.DoctorSalary(11) + "\n");
                        break;
                    case 2:
                        nurse1.DisplayNurses();
                        Console.WriteLine("Salary: "+nurse1.NurseSalary() + "\n");
                        nurse2.DisplayNurses();
                        Console.WriteLine("Salary: " + nurse2.NurseSalary() + "\n");
                        break;
                    case 3:
                        wardboy1.DisplayWardboy();
                        Console.WriteLine("Salary: " + wardboy1.WardboySalary()+"\n");
                        wardboy2.DisplayWardboy();
                        Console.WriteLine("Salary: " + wardboy2.WardboySalary() + "\n");
                        break;
                    default:
                        Console.WriteLine("Please Select Correct Option");
                        break;
                }
            } while (flag != 4);
        }
    }
}
