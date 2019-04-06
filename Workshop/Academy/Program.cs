using System;
using System.Collections.Generic;
using System.Linq;
using Entities;

namespace Academy
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Subject cSharp = new Subject("C#");
            Subject cSharpAdvanced = new Subject("C# Advanced");
            Subject javaScript = new Subject("JavaScript");
            Subject javaScriptAdvanced = new Subject("JavaScript Advanced");
            Subject html = new Subject("HTML");
            Subject css = new Subject("CSS");

            List<Subject> subjects = new List<Subject>() { cSharp, cSharpAdvanced, javaScript, javaScriptAdvanced, html, css };


            Admin admin1 = new Admin("Pero", "Perovski", "peroKamikaza", "1234");
            Admin admin2 = new Admin("Risto", "Ristovski", "riki", "1123");
            Student student1 = new Student("Miki", "Perovski", "miki", "3342");
            student1.Grades = new Dictionary<Subject, int>()
            {
                {cSharp,5 },
                {cSharpAdvanced,7},
                {javaScript,9},
                {javaScriptAdvanced,7 },
                {html,8 },
                {css,4 }
            };
            Student student2 = new Student("Majk", "Nikolovski", "majki", "6654");
            student2.Grades = new Dictionary<Subject, int>()
            {
                {cSharp,7 },
                {cSharpAdvanced,8},
                {javaScript,7 },
                {javaScriptAdvanced,5 },
                {html,3 },
                {css,2 }
            };
            Student student3 = new Student("Koki", "Perevski", "koki1", "7786");
            student3.Grades = new Dictionary<Subject, int>()
            {
                {cSharp,9 },
                {cSharpAdvanced,9},
                {javaScript,4 },
                {javaScriptAdvanced,6 },
                {html,8},
                {css,8}
            };
            Student student4 = new Student("Goce", "Delchev", "goceKomita", "1903");
            student4.Grades = new Dictionary<Subject, int>()
            {
                {cSharp,4 },
                {cSharpAdvanced,4},
                {javaScript,9 },
                {javaScriptAdvanced,9 },
                {html,8},
                {css,9 }
            };
            Trainer trainer1 = new Trainer("Mitko", "Mitkovski", "mite", "23356");
            Trainer trainer2 = new Trainer("Dejan", "Lovren", "deki", "5577");
            List<User> users = new List<User>() { admin1, admin2, student1, student2, student3, student4, trainer1, trainer2 };

            try
            {
                Console.WriteLine("Enter Role:");
                Console.WriteLine("1. Admin");
                Console.WriteLine("2. Trainer");
                Console.WriteLine("3. Student");

                int roleInput = int.Parse(Console.ReadLine());

                if (roleInput == 1)
                {
                    Admin adminUser = null;
                    LogInAdmin(users, ref adminUser);
                    Console.WriteLine("Choose Action");
                    Console.WriteLine("1. Add User");
                    Console.WriteLine("2. Remove User");
                    int input = int.Parse(Console.ReadLine());
                    if (input == 1)
                    {
                        AddUser(users, adminUser);
                    }
                    else if (input == 2)
                    {
                        RemoveUser(users, adminUser);
                    }
                    else
                    {
                        throw new Exception("Please enter 1 or 2!");
                    }
                }
                else if (roleInput == 2)
                {
                    Trainer trainerUser = null;
                    LogInTrainer(users, ref trainerUser);
                    Console.WriteLine("Choose action:");
                    Console.WriteLine("1. Show all students");
                    Console.WriteLine("2. Show all subjects");
                    int input = int.Parse(Console.ReadLine());

                    if (input == 1)
                    {
                        foreach (User user in users)
                        {
                            if (user.Role == Role.Student)
                            {
                                user.PrintInfo();
                            }
                            else
                            {
                                continue;
                            }
                        }

                        Console.WriteLine("Enter First Name:");
                        string fNameInput = Console.ReadLine();
                        Console.WriteLine("Enter Last Name:");
                        string lNameInput = Console.ReadLine();

                        foreach (Student user in users.Where(x => x.Role == Role.Student))
                        {
                            if (user.FirstName == fNameInput)
                            {
                                if (user.LastName == lNameInput)
                                {
                                    Console.WriteLine($"Grades of Student: {user.FirstName} {user.LastName}");
                                    foreach (var item in user.Grades)
                                    {
                                        Console.WriteLine($"{item.Key.SubjectName} : {item.Value}");
                                    }
                                }
                            }
                        }
                    }
                    else if (input == 2)
                    {
                        foreach (var subject in subjects)
                        {
                            Console.WriteLine($"Subject: \"{subject.SubjectName}\" Attending Students: ({subject.Listeners})");
                        }
                    }
                    else
                    {
                        throw new Exception("Please enter 1 or 2!");
                    }
                }
                else if (roleInput == 3)
                {
                    Student studentUser = null;
                    LogInStudent(users, ref studentUser);
                    Console.WriteLine("Choose Action:");
                    Console.WriteLine("1. Enrol to a Subject");
                    Console.WriteLine("2. Show Grades");
                    int actionInput = int.Parse(Console.ReadLine());

                    if (actionInput == 1)
                    {
                        foreach (Subject subject in subjects)
                        {
                            subject.PrintInfo();
                        }
                        Console.WriteLine("Enter name of the Subject");
                        string input = Console.ReadLine();
                        EnrolToSubject(ref studentUser, input, subjects);
                        foreach (Subject subject in subjects)
                        {
                            Console.WriteLine($"Subject: \"{subject.SubjectName}\" Attending Students: ({subject.Listeners})");
                        }
                        Console.WriteLine($"{studentUser.FirstName} {studentUser.LastName} current subject is: \"{studentUser.CurrentSubject.SubjectName}\"");
                    }
                    else if (actionInput == 2)
                    {
                        ShowGrades(ref studentUser);
                    }
                    else
                    {
                        throw new Exception("Please enter 1 or 2.");
                    }
                }
                else
                {
                    throw new Exception("Please enter 1,2 or 3!");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("You did not enter a correct format and you broke it!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
        