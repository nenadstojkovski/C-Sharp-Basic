using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_4
{
    class Program
    {
        static string GetLongestName(Student[] array )
        {
           
            int length = 0;
            string name = "";
            foreach (Student input in array)
            {
                if (input.Name.Length == length)
                {
                    name = $"{name} {input.Name}";
                }
               else if (input.Name.Length > length)
                {
                    length = input.Name.Length;
                    name = input.Name;
                }
                
            }

            return $"The longest name is {name}";
        }

       static string GetShortestName (Student [] array)
        {

            int length = 100;
            string name = "";
            foreach (Student input in array)
            {
                if (input.Name.Length == length)
                {
                    name = $"{name} {input.Name}";
                }
                else if (input.Name.Length < length)
                {
                    length = input.Name.Length;
                    name = input.Name;
                }

            }

            return $"The shortest name is {name}";
        }

        static string GetAverageName(Student [] array)
        { 
           
            double Averagelength = 0;
            foreach (Student input in array)
            {
                Averagelength += input.Name.Length;
            }
            return $"Average length is {Averagelength/5}";
        }

        static void FindStudent(Student[] students, string name)
        {
            bool studentFound = false;
            while (studentFound == false)
            {
                foreach (var student in students)
                {
                    if (name.ToLower() == student.Name.ToLower())
                    {
                        Console.WriteLine($"Student found: \n Name: {student.Name} \n Age: {student.Age} \n Group: {student.Group} \n Academy: {student.Academy}");
                        studentFound = true;
                    }
                }
                if (studentFound == false)
                {
                    Console.WriteLine("There is no such student, please try again");
                    name = Console.ReadLine();
                }
            }
   
        }


        static void Main(string[] args)
        {
            Student student1, student2, student3, student4, student5 = new Student();
            while (true)
            {
                string firstInput, secondInput, thirdInput, forthInput, fifthInput;

                while (true)
                {
                    Console.WriteLine("Enter first student name: ");
                    firstInput = Console.ReadLine();
                    bool result = int.TryParse(firstInput, out int first);
                    if (!result)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter valid name.");
                        continue;
                    }
                }

                while (true)
                {
                    Console.WriteLine("Enter first student age");
                    var AgeInput = Console.ReadLine();
                    if (!int.TryParse(AgeInput, out int firstAge))
                    {
                        Console.WriteLine("Not-a-number");
                        continue;
                    }
                    else
                    {
                        student1 = new Student(firstInput, firstAge,"Seavus Web Developer","G3");
                        break;
                    }
                }

                while (true)
                {
                    Console.WriteLine("Enter second student: ");
                    secondInput = Console.ReadLine();
                    bool result = int.TryParse(secondInput, out int second);
                    if (!result)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter valid name.");
                        continue;
                    }
                }

                while (true)
                {
                    Console.WriteLine("Enter second student age");
                    var AgeInput = Console.ReadLine();
                    if (!int.TryParse(AgeInput, out int secondAge))
                    {
                        Console.WriteLine("Not-a-number");
                        continue;
                    }
                    else
                    {
                        student2 = new Student(secondInput, secondAge,"Seavus Web Developer", "G4");
                        break;
                    }
                }

                while (true)
                {
                    Console.WriteLine("Enter third student: ");
                    thirdInput = Console.ReadLine();
                    bool result = int.TryParse(thirdInput, out int third);
                    if (!result)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter valid name.");
                        continue;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Enter third student age");
                    var AgeInput = Console.ReadLine();
                    if (!int.TryParse(AgeInput, out int thirdAge))
                    {
                        Console.WriteLine("Not-a-number");
                        continue;
                    }
                    else
                    {
                        student3 = new Student(thirdInput, thirdAge,"Seavus Web Developer", "G5");
                        break;
                    }
                }

                while (true)
                {
                    Console.WriteLine("Enter forth student: ");
                    forthInput = Console.ReadLine();
                    bool result = int.TryParse(forthInput, out int forth);
                    if (!result)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter valid name.");
                        continue;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Enter fourth student age");
                    var AgeInput = Console.ReadLine();
                    if (!int.TryParse(AgeInput, out int fourthAge))
                    {
                        Console.WriteLine("Not-a-number");
                        continue;
                    }
                    else
                    {
                        student4 = new Student(forthInput, fourthAge, "Seavus Web Developer", "G6");
                        break;
                    }
                }

                while (true)
                {
                    Console.WriteLine("Enter fifth student: ");
                    fifthInput = Console.ReadLine();
                    bool result = int.TryParse(fifthInput, out int fifth);
                    if (!result)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Please enter valid name.");
                        continue;
                    }
                }
                while (true)
                {
                    Console.WriteLine("Enter fifth student age");
                    var AgeInput = Console.ReadLine();
                    if (!int.TryParse(AgeInput, out int fifthAge))
                    {
                        Console.WriteLine("Not-a-number");
                        continue;
                    }
                    else
                    {
                        student5 = new Student(fifthInput, fifthAge, "Seavus Web Developer", "G1");
                        break;
                    }
                }

                Student[] array = { student1, student2, student3, student4, student5 };

           
                Console.WriteLine(GetLongestName(array));
                Console.WriteLine(GetShortestName(array));
                Console.WriteLine(GetAverageName(array));

                Console.WriteLine("Enter student name");
                var findInput = Console.ReadLine();
                FindStudent(array,findInput);


                Console.ReadLine();
                
            }
        }
    }
}

