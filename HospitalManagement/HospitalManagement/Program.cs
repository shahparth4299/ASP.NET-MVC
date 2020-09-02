using System;
using System.Collections;
using System.Collections.Generic;
using BusinessLayer;
namespace HospitalManagement
{
    class HospitalManagement
    {
        static void DisplayPatients(List<Patient> lst_patient)
        {
            foreach (Patient p in lst_patient)
            {
                Console.WriteLine("Patient Id:"+p.id);
                Console.WriteLine("Patient Name: "+p.name);
                Console.WriteLine("Mobile Nymber: "+p.phoneNumber);
                Console.WriteLine("Doctor Name:" + p.d.name);
                foreach (Visit v in p.visit)
                {
                    Console.WriteLine("Visit Information: "+v.visitTime);
                    foreach (Problems pr in v.problems)
                    {
                        Console.WriteLine("Problem Name: "+pr.problem_name);
                        foreach (Medication m in pr.medication)
                        {
                            Console.WriteLine("Medication Name" + m.medication_name);
                            Console.WriteLine("Medication Description"+m.description);
                        }
                    }
                }
                foreach(Nurses n in p.nurse)
                {
                    Console.WriteLine("Nurse Name: " +n.name);
                }
                foreach (Wardboy w in p.wardboy)
                {
                    Console.WriteLine("Wardboy Name: " + w.name);
                }
            }
        }
        static Address GetAddressInformation()
        {
            Address adr = new Address();
            Console.Write("Enter Flat Numer: ");
            adr.flat = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter Building: ");
            adr.building = Console.ReadLine();
            Console.Write("Enter Street Name: ");
            adr.street = Console.ReadLine();
            Console.Write("Enter City: ");
            adr.city = Console.ReadLine();
            return adr;
        }
        static Staff GetStaffInformation()
        {
            Staff staff = new Staff();
            Console.Write("Enter Staff ID: ");
            staff.id = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter Staff Name: ");
            staff.name = Console.ReadLine();
            Console.Write("Enter Staff Age: ");
            staff.age = Convert.ToInt16(Console.ReadLine());
            Console.Write("Enter Staff Department: ");
            staff.department = Console.ReadLine();
            Console.Write("Enter Staff Mobile Number: ");
            staff.mobileNumber = Console.ReadLine();
            Console.Write("Enter Staff Date Of Joining: ");
            staff.doj = DateTime.Now;
            return staff;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("----------Welcom To LifeLine Hospital----------");
                List<Patient> lst_patient = new List<Patient>();
                Dictionary<int, Doctor> doctor = new Dictionary<int, Doctor>();
                Dictionary<int, Nurses> nurse = new Dictionary<int, Nurses>();
                Dictionary<int, Wardboy> wardboy = new Dictionary<int, Wardboy>();

                Address nurseAddress1 = new Address(101, "Shanti Jyot", "Station Road", 401010, "Mumbai");
                Address nurseAddress2 = new Address(1010, "Tirupati Jyot", "Balaji Nagar", 401110, "Banglore");
                Address wardboyAddress1 = new Address(1001, "Raj Heights", "Dhanuarwadi", 401101, "Pune");
                Address wardboyAddress2 = new Address(201, "Jat Apartment", "Mahvir Nagar", 400100, "Surat");
                Address doctorAddress1 = new Address(2301, "Haresh Heights", "Modi Patel", 401123, "Baroda");
                Address doctorAddress2 = new Address(2431, "Ram Apartment", "Narayan Nagar", 404500, "Delhi");

                doctor.Add(1, new Doctor("MBBS", doctorAddress1, 1, 29, "Dhairya Savaliya", "9876432134", DateTime.Now));
                doctor.Add(2, new Doctor("BHMS", doctorAddress2, 2, 44, "Rohan Gupta", "8876432134", DateTime.Now));

                nurse.Add(51, new Nurses(nurseAddress1, 51, 49, "Padma Selarka", "9875642134", DateTime.Now));
                nurse.Add(52, new Nurses(nurseAddress2, 52, 24, "Parul Shah", "8876437634", DateTime.Now));

                wardboy.Add(51, new Wardboy(wardboyAddress1, 101, 39, "Rahul Selarka", "8725642134", DateTime.Now));
                wardboy.Add(52, new Wardboy(wardboyAddress2, 102, 44, "Kaustubh Shah", "9896437634", DateTime.Now));

                short condition = 0;
                do
                {
                    Console.WriteLine("1. New Patinet");
                    Console.WriteLine("2. Current Patinet");
                    Console.WriteLine("3. Add New Doctor");
                    Console.WriteLine("4. Add New Nurse");
                    Console.WriteLine("5. Add New Wardboy");
                    Console.WriteLine("6. Display All Patients");
                    Console.WriteLine("7. Exit");
                    condition = Convert.ToInt16(Console.ReadLine());
                    switch (condition)
                    {
                        case 1:
                            //Add New Patient
                            Patient p = new Patient();
                            Console.Write("Enter Patient ID: ");
                            p.id = Convert.ToInt16(Console.ReadLine());
                            Console.Write("\nEnter Patient Name: ");
                            p.name = Console.ReadLine();
                            Console.Write("\nEnter Phone Number: ");
                            p.phoneNumber = Console.ReadLine();

                            //Address of Patient
                            p.adr = new Address();
                            Console.Write("Enter Flat Numer: ");
                            p.adr.flat = Convert.ToInt16(Console.ReadLine());
                            Console.Write("Enter Building: ");
                            p.adr.building = Console.ReadLine();
                            Console.Write("Enter Street Name: ");
                            p.adr.street = Console.ReadLine();
                            Console.Write("Enter City: ");
                            p.adr.city = Console.ReadLine();

                            //Allergy Information of Patient
                            Allergies allergies = new Allergies();
                            Console.Write("Enter Allergy Name: ");
                            allergies.name = Console.ReadLine();
                            Console.Write("Enter Allergy Description: ");
                            allergies.description = Console.ReadLine();
                            Console.Write("Total Years: ");
                            allergies.totalYears = Convert.ToInt16(Console.ReadLine());
                            p.allergy.Add(allergies);

                            //Vist and Problems of Patient
                            p.visit = new List<Visit>();
                            Visit v = new Visit();
                            v.visitTime = DateTime.Now;
                            v.problems = new List<Problems>();
                            Problems problems = new Problems();
                            Console.Write("Enter Problem Name: ");
                            problems.problem_name = Console.ReadLine();
                            Console.Write("Enter Problem Description: ");
                            problems.problem_description = Console.ReadLine();
                            Console.Write("Enter Days: ");
                            problems.totalDays = Convert.ToInt16(Console.ReadLine());
                            problems.medication = new List<Medication>();
                            Medication m = new Medication();
                            Console.Write("Medication Name: ");
                            m.medication_name = Console.ReadLine();
                            Console.Write("Medication Description: ");
                            m.description = Console.ReadLine();
                            problems.medication.Add(m);
                            v.problems.Add(problems);
                            p.visit.Add(v);

                            //Doctor Data
                            foreach (KeyValuePair<int, Doctor> ele1 in doctor)
                            {
                                Console.WriteLine(ele1.Key + " " + ele1.Value.name + " " + ele1.Value.education);
                            }
                            Console.WriteLine("Assign Doctor To Patient By Entering Id");
                            short doctorId = Convert.ToInt16(Console.ReadLine());
                            p.d = doctor[doctorId];

                            //Nurses Data
                            foreach (KeyValuePair<int, Nurses> ele1 in nurse)
                            {
                                Console.WriteLine(ele1.Key + " " + ele1.Value.name);
                            }
                            Console.WriteLine("Assign Nurse To Patient By Entering Id");
                            short nurseId = Convert.ToInt16(Console.ReadLine());
                            p.nurse.Add(nurse[nurseId]);

                            //Wardboy Data
                            foreach (KeyValuePair<int, Wardboy> ele1 in wardboy)
                            {
                                Console.WriteLine(ele1.Key + " " + ele1.Value.name);
                            }
                            Console.WriteLine("Assign Wardboy To Patient By Entering Id");
                            short wardboyId = Convert.ToInt16(Console.ReadLine());
                            p.wardboy.Add(wardboy[wardboyId]);

                            lst_patient.Add(p);
                            break;
                        case 2:
                            Console.Write("Enter Patient Id: ");
                            short pid = Convert.ToInt16(Console.ReadLine());
                            foreach (Patient patient in lst_patient)
                            {
                                if (patient.id == pid)
                                {
                                    short choice = 0;
                                    do
                                    {
                                        Console.WriteLine("1. Add Allergy");
                                        Console.WriteLine("2. Visit Again");
                                        Console.WriteLine("3. Exit");
                                        choice = Convert.ToInt16(Console.ReadLine());
                                        switch (choice)
                                        {
                                            case 1:

                                                Allergies alg = new Allergies();
                                                Console.Write("Enter Allergy Name: ");
                                                alg.name = Console.ReadLine();
                                                Console.Write("Enter Allergy Description: ");
                                                alg.description = Console.ReadLine();
                                                Console.Write("Total Years: ");
                                                alg.totalYears = Convert.ToInt16(Console.ReadLine());
                                                patient.allergy.Add(alg);
                                                break;
                                            case 2:
                                                
                                                Visit v2 = new Visit();
                                                v2.visitTime = DateTime.Now;
                                                v2.problems = new List<Problems>();
                                                Problems problems2 = new Problems();
                                                Console.Write("Enter Problem Name: ");
                                                problems2.problem_name = Console.ReadLine();
                                                Console.Write("Enter Problem Description: ");
                                                problems2.problem_description = Console.ReadLine();
                                                Console.Write("Enter Days: ");
                                                problems2.totalDays = Convert.ToInt16(Console.ReadLine());
                                                problems2.medication = new List<Medication>();
                                                Medication m2 = new Medication();
                                                Console.Write("Medication Name: ");
                                                m2.medication_name = Console.ReadLine();
                                                Console.Write("Medication Description: ");
                                                m2.description = Console.ReadLine();
                                                problems2.medication.Add(m2);
                                                v2.problems.Add(problems2);
                                                patient.visit.Add(v2);
                                                break;
                                        }
                                    } while (choice != 3);
                                }
                            }
                                break;
                        case 3:
                            Staff staff = GetStaffInformation();
                            Address adr = GetAddressInformation();
                            Console.Write("Enter Doctor Education: ");
                            string education = Console.ReadLine();
                            Doctor d = new Doctor(education, adr, staff.id, staff.age, staff.name, staff.mobileNumber, staff.doj);
                            doctor.Add(staff.id, d);
                            break;
                        case 4:
                            staff = GetStaffInformation();
                            adr = GetAddressInformation();
                            Nurses n = new Nurses(adr, staff.id, staff.age, staff.name, staff.mobileNumber, staff.doj);
                            nurse.Add(staff.id, n);
                            break;
                        case 5:
                            staff = GetStaffInformation();
                            adr = GetAddressInformation();
                            Wardboy w = new Wardboy(adr, staff.id, staff.age, staff.name, staff.mobileNumber, staff.doj);
                            wardboy.Add(staff.id, w);
                            break;
                        case 6:
                            DisplayPatients(lst_patient);
                            break;
                    }
                } while (condition != 7);

                
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }

                /*
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
                */
            }
    }
}
