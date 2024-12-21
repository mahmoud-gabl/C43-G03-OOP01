namespace assignment_5
{
    internal class Program
    {
        #region enum_1
        //enum WeekDays
        //{
        //    Saturday, Sunday, Monday, Tuesday, Wednesday, Thursday, Friday
        //}
        #endregion
        #region enum2
        //enum Season
        //{
        //    Spring, Summer, Autumn, Winter
        //}
        #endregion
        #region enum3
        //enum Permissions
        //{
        //    Read = 1,
        //    Write = 2,
        //    Delete = 4,
        //    Execute = 8
        //}
        #region enum4
        enum Colors
        {
            Red,
            Green,
            Blue
        }
        #endregion
        #endregion
        public class PermissionManager
        {
            static void Main(string[] args)
            {
                #region enum_1
                //WeekDays[] daysOfWeek = (WeekDays[])Enum.GetValues(typeof(WeekDays));
                //foreach (WeekDays dayOfWeek in daysOfWeek)
                //    Console.WriteLine(dayOfWeek);
                #endregion
                #region struct_1
                //person[] persons = new person[3];
                //persons[0].name = "mahmoud";
                //persons[0].Age = 30;
                //persons[1].name = "ali";
                //persons[1].Age = 20;
                //persons[2].name = "mohamed";
                //persons[2].Age = 20;

                //foreach (var person in persons)
                //{
                //    Console.WriteLine($"nema:{person.name}/n age:{person.Age}");
                //}


                #endregion
                #region enum2
                //Console.WriteLine("please enter season:");
                //string input =Console.ReadLine();
                //if(input = Season.Spring)
                //{
                //    Console.WriteLine(" spring march to may ");
                //}
                //else if(input= Season.Winter)
                //{
                //    Console.WriteLine("summer june to august");
                //}
                //else if (input = Season.Autumn)
                //{
                //    Console.WriteLine("autumn September to Novembe");
                //}
                //else if (input = Season.Summer)
                //{
                //    Console.WriteLine("winter December to February");
                //}
                #endregion
                #region enum3
                //Permissions userPermissions = Permissions.Read | Permissions.Write;

                //Console.WriteLine(userPermissions.HasFlag(Permissions.Read));

                //userPermissions |= Permissions.Execute;

                //userPermissions &= ~Permissions.Write;

                //Console.WriteLine(userPermissions.HasFlag(Permissions.Write));
                #endregion
                #region enum4
                //Console.WriteLine("Enter a color (Red, Green, Blue):");
                //string inputColor = Console.ReadLine();

                //Colors color;

                //if (Enum.TryParse(inputColor, true, out color))
                //{
                //    Console.WriteLine($"{inputColor} is a primary color.");
                //}
                //else
                //{
                //    Console.WriteLine($"{inputColor} is not a primary color.");
                //}

                //Console.ReadLine();
                #endregion
                #region struct3
            //    Person[] persons = new Person[3];

            //    for (int i = 0; i < 3; i++)
            //    {
            //        Console.WriteLine($"Enter details for Person {i + 1}:");
            //        Console.Write("Name: ");
            //        persons[i].Name = Console.ReadLine();
            //        Console.Write("Age: ");
            //        persons[i].Age = int.Parse(Console.ReadLine());
            //    }

            //    Person oldestPerson = FindOldestPerson(persons);

            //    Console.WriteLine($"\nThe oldest person is: {oldestPerson.Name} (Age: {oldestPerson.Age})");

            //    Console.ReadLine();
            //}
            //private static Person FindOldestPerson(Person[] persons)
            //{
            //    Person oldest = persons[0];

            //    for (int i = 1; i < persons.Length; i++)
            //    {
            //        if (persons[i].Age > oldest.Age)
            //        {
            //            oldest = persons[i];
            //        }
            //    }

            //    return oldest;
                #endregion

            }
        }
    }
}
