using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBook_Demo
{
    public class AddressBookSystem
    {
        public static SqlConnection con = new SqlConnection("data source= (localdb)\\MSSQLLocalDB; initial catalog=AddressBook; integrated security=true");
        private static Dictionary<string, string> addressBookDictionary = new Dictionary<string, string>();



        public static void CreateAddressBook()
        {
            Console.Write("Enter the name of the Address Book: ");
            string addressBookName = Console.ReadLine();


            // Check if the address book name is already in the dictionary
            if (addressBookDictionary.ContainsKey(addressBookName))
            {
                Console.WriteLine($"Address Book '{addressBookName}' already exists.");
                return;
            }

            // Create a new table for the address book in the database
            string createTableQuery = $"CREATE TABLE {addressBookName} (FirstName VARCHAR(200), LastName VARCHAR(200), City VARCHAR(200), State varchar(200), Phone VARCHAR(200),Email VARCHAR(200))";

            using (con)
            {
                con.Open();

                using (SqlCommand command = new SqlCommand(createTableQuery, con))
                {
                    command.ExecuteNonQuery();
                }
            }

            // Add the address book to the dictionary
            addressBookDictionary.Add(addressBookName, addressBookName);

            Console.WriteLine($"Address Book '{addressBookName}' created successfully.");
            con.Close();
        }


        public static void AddContactToAddressBook()
        {
            Console.Write("Enter the name of the Address Book: ");
            string addressBookName = Console.ReadLine();

           /* if (!addressBookDictionary.ContainsKey(addressBookName))
            {
                Console.WriteLine($"Address Book '{addressBookName}' does not exist.");
                return;
            }*/

            Console.Write("Enter First Name: ");
            string name = Console.ReadLine();

            // Create a new Person object with the provided details
            Person newPerson = new Person
            {
                FirstName = name,
                LastName = ReadValue("Enter Last Name"),
                
                City = ReadValue("Enter City: "),
                State = ReadValue("Enter State: "),
                Phone = ReadValue("Enter Phone: "),
                Email = ReadValue("Enter Email: ")
            };

            // Check for duplicates based on Person first name
            List<Person> contacts = new List<Person>();
            if (addressBookDictionary.TryGetValue(addressBookName, out string tableName))
            {
                string selectQuery = $"SELECT FirstName FROM {tableName} where FirstName = @FirstName";

                using(con)
                {
                    con.Open() ;

                    using (SqlCommand command = new SqlCommand(selectQuery, con))
                    {
                        command.Parameters.AddWithValue("@FirstName", newPerson.FirstName);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                Console.WriteLine("Duplicate entry found. This person already exists in the Address Book.");
                                return;
                            }
                        }
                    }
                   
                }
            }
            else
            {
                Console.WriteLine($"Address Book '{addressBookName}' does not exist.");
                return;
            }

            // Insert the contact into the specified address book table
            string insertQuery = $"INSERT INTO {tableName}(FirstName,LastName,City,,StatePhone, Email)  VALUES (@FirstName,@LastName ,@City,@State,@Phone, @Email)";

            using (con)
            {
                con.Open();

                using (SqlCommand command = new SqlCommand(insertQuery, con))
                {
                    command.Parameters.AddWithValue("@FirstName", newPerson.FirstName);
                    command.Parameters.AddWithValue("@LastName", newPerson.LastName);
                    command.Parameters.AddWithValue("@City", newPerson.City);
                    command.Parameters.AddWithValue("@State", newPerson.State);
                    command.Parameters.AddWithValue("@Phone", newPerson.Phone);
                    command.Parameters.AddWithValue("@Email", newPerson.Email);

                    command.ExecuteNonQuery();
                }
            }
          

            Console.WriteLine("Contact added successfully.");
        }

        private static string ReadValue(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }



        public static void SearchPersonsByCityOrState()
        {
            Console.Write("Enter city or state to search: ");
            string searchTerm = Console.ReadLine().Trim();

            List<Person> matchingPersons = new List<Person>();

            foreach (var tableName in addressBookDictionary.Values)
            {
                string searchQuery = $"SELECT * FROM {tableName} WHERE City LIKE @SearchTerm OR State LIKE @SearchTerm";

                using (con)
                {
                    con.Open();

                    using (SqlCommand command = new SqlCommand(searchQuery, con))
                    {
                        command.Parameters.AddWithValue("@SearchTerm", $"%{searchTerm}%");

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Person person = new Person
                                {
                                    FirstName = reader["FirstName"].ToString(),
                                    LastName = reader["LastName"].ToString(),
                                    City = reader["City"].ToString(),
                                    State = reader["State"].ToString(),
                                    Phone = reader["Phone"].ToString(),
                                    Email = reader["Email"].ToString()
                                };

                                matchingPersons.Add(person);
                            }
                        }
                    }
                }
            }

            if (matchingPersons.Count == 0)
            {
                Console.WriteLine("No matching persons found.");
            }
            else
            {
                Console.WriteLine("Matching persons:");
                foreach (var person in matchingPersons)
                {
                    Console.WriteLine($"FirstName: {person.FirstName},LastName:{person.LastName}, City: {person.City}, State: {person.State},Phone: {person.Phone}, Email: {person.Email}");
                }
            }
        }



    }

}


       
           
    
