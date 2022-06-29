// See https://aka.ms/new-console-template for more information

using System;

namespace AddressBook_ADO
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AddressBookRepo getMethod = new AddressBookRepo();
            Console.WriteLine("Enter 1 to Add Data\n2 to Read Data\n3.UpdateTable\n4.DeleteData\n5.multithreading\n");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch (userInput)
            {
                case 1:
                    {
                        AddressBook_ADO.AddressBook_Model model = new AddressBook_ADO.AddressBook_Model();
                        Console.WriteLine("Enter First Name");
                        model.FIRST_NAME = Console.ReadLine();
                        Console.WriteLine("Enter Last Name");
                        model.LAST_NAME = Console.ReadLine();
                        Console.WriteLine("Enter Address ");
                        model.ADDRESS = Console.ReadLine();
                        Console.WriteLine("Enter City ");
                        model.CITY = Console.ReadLine();
                        Console.WriteLine("Enter State ");
                        model.STATE = Console.ReadLine();
                        Console.WriteLine("Enter Zip Code ");
                        model.ZIP = Console.ReadLine();
                        Console.WriteLine("Enter Phone ");
                        model.PhoneNO = Console.ReadLine();
                        Console.WriteLine("Enter Email ");
                        model.EMAIL = Console.ReadLine();
                        Console.WriteLine("Enter Type ");
                        model.Type = Console.ReadLine();
                        getMethod.AddData(model);
                        break;
                    }
                case 2:
                    {
                        getMethod.ReadData();
                        break;
                    }

                case 3:
                    {
                        getMethod.UpdateTable();
                        break;
                    }

                case 4:
                    {
                        getMethod.DeleteData();
                        break;

                    }

                case 5:
                    {
                        List<AddressBook_Model> list = new List<AddressBook_Model>();
                        Console.WriteLine("Enter number of contacts to Add");
                        int number = Convert.ToInt32(Console.ReadLine());
                        int i = 0;
                        while (i < number)
                        {
                            AddressBook_Model model = new AddressBook_Model();
                            Console.WriteLine("Enter First Name");
                            model.FIRST_NAME = Console.ReadLine();
                            Console.WriteLine("Enter Last Name");
                            model.LAST_NAME = Console.ReadLine();
                            Console.WriteLine("Enter Address ");
                            model.ADDRESS = Console.ReadLine();
                            Console.WriteLine("Enter City ");
                            model.CITY = Console.ReadLine();
                            Console.WriteLine("Enter State ");
                            model.STATE = Console.ReadLine();
                            Console.WriteLine("Enter Zip Code ");
                            model.ZIP = Console.ReadLine();
                            Console.WriteLine("Enter Phone ");
                            model.PhoneNO = Console.ReadLine();
                            Console.WriteLine("Enter Email ");
                            model.EMAIL = Console.ReadLine();
                            Console.WriteLine("Enter Type ");
                            model.Type = Console.ReadLine();
                            list.Add(model);
                            i++;
                        }
                        getMethod.AddMultipleContacts(list);
                        break;

                    }

                default:
                    {
                        Console.WriteLine("Enter a valid Number");
                        break;
                    }
            }
        }
    }
}