namespace OOP_1
{
    internal class Program
    {
        public enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public enum Season
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        [Flags]
        public enum Permissions
        {
            None = 0,       // No permissions
            Read = 1 << 0,  // 1 (0001)
            Write = 1 << 1, // 2 (0010)
            Delete = 1 << 2,// 4 (0100)
            Execute = 1 << 3// 8 (1000)
        }

        public enum Colors
        {
            Red,    
            Green,  
            Blue    
        }

        public struct Point
        {
            public double X { get; set; } 
            public double Y { get; set; } 

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }

            public static double CalculateDistance(Point p1, Point p2)
            {
                return Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            }
        }


        static void Main(string[] args)
        {
            #region Enum weekDays q1
            //Console.WriteLine("Days of the week");
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day);
            //}
            #endregion
            #region Create an enum called "Season"  q2
            //Console.WriteLine("Enter a season name (Spring, Summer, Autumn, Winter)");
            //string input = Console.ReadLine();

            //if (Enum.TryParse(input, true, out Season season))
            //{
            //    switch (season)
            //    {
            //        case Season.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Season.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Season.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Season.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid season name.");
            //}

            #endregion
            #region permissions q3
            //Permissions userPermissions = Permissions.None;
            //userPermissions |= Permissions.Read;
            //userPermissions |= Permissions.Write;
            //userPermissions |= Permissions.Delete;  
            //userPermissions |= Permissions.Execute; 

            //Console.WriteLine($"Current permissions: {userPermissions}");

            //if (userPermissions.HasFlag(Permissions.Read))
            //{
            //    Console.WriteLine("Read permission exists");
            //}

            //if (userPermissions.HasFlag(Permissions.Execute))
            //{
            //    Console.WriteLine("Execute permission exists");
            //}
            //else
            //{
            //    Console.WriteLine("Execute permission does not exist");
            //}


            //userPermissions &= ~Permissions.Read;
            //Console.WriteLine($"Permissions after removing Read: {userPermissions}");

            //if (userPermissions.HasFlag(Permissions.Read))
            //{
            //    Console.WriteLine("Read permission exists");
            //}
            //else
            //{
            //    Console.WriteLine("Read permission does not exist");
            //}
            //if (userPermissions.HasFlag(Permissions.Delete))
            //{
            //    Console.WriteLine("Delete permission exists.");
            //}

            //userPermissions &= ~Permissions.Delete;
            //Console.WriteLine($"Permissions after removing Delete: {userPermissions}");


            //if (userPermissions.HasFlag(Permissions.Execute))
            //{
            //    Console.WriteLine("Execute permission exists.");
            //}
            //else
            //{
            //    Console.WriteLine("Execute permission does not exist.");
            //}
            //userPermissions &= ~Permissions.Execute;
            //Console.WriteLine($"Permissions after removing Execute {userPermissions}");


            #endregion
            #region Create an enum called "Colors"  q4
            //Console.WriteLine("Enter a color name ");
            //string input = Console.ReadLine();
            //if (Enum.TryParse(input, true, out Colors color))
            //{

            //    if (Enum.IsDefined(typeof(Colors), color))
            //    {
            //        Console.WriteLine($"{color} is a primary color");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("is not a primary color");
            //}
            #endregion
            #region Struct x,y q5
            //double x1, y1, x2, y2;
            //Console.WriteLine("Enter the coordinates for the first point");
            //Console.Write("X1 ");
            //while (!double.TryParse(Console.ReadLine(), out x1))
            //{
            //    Console.WriteLine("Invalid input for X1. Please enter a valid number.");
            //    Console.Write("X1 ");
            //}

            //Console.Write("Y1 ");
            //while (!double.TryParse(Console.ReadLine(), out y1))
            //{
            //    Console.WriteLine("Invalid input for Y1. Please enter a valid number.");
            //    Console.Write("Y1 ");
            //}
            //Console.WriteLine("Enter the coordinates for the second point:");

            //Console.Write("X2 ");
            //while (!double.TryParse(Console.ReadLine(), out x2))
            //{
            //    Console.WriteLine("Invalid input for X2. Please enter a valid number.");
            //    Console.Write("X2 ");
            //}

            //Console.Write("Y2 ");
            //while (!double.TryParse(Console.ReadLine(), out y2))
            //{
            //    Console.WriteLine("Invalid input for Y2. Please enter a valid number.");
            //    Console.Write("Y2 ");
            //}

            //Point point1 = new Point(x1, y1);
            //Point point2 = new Point(x2, y2);

            //double distance = Point.CalculateDistance(point1, point2);
            //Console.WriteLine($"The distance between the points is {distance}");
            #endregion

            /*
             * Demo
             */

            #region Exception Handling
            //try
            //{
            //    DoSomeProtectiveCode();
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //Console.WriteLine("Ay 7aga");
            #endregion

            #region Enum
            // Grades Grade = Grades.A;
            //Grades Grade =(Grades)1;//RunTime => Explicit Casting
            //Console.WriteLine(Grade);
            //if(Grade == Grades.A)
            //    Console.WriteLine(":)");
            //else
            //    Console.WriteLine(":(");
            //Employee employee = new Employee();
            //employee.id = 1;
            //employee.name = "Ahmed";
            //employee.gender = Gender.Male;//1

            //Branches branches = (Branches)3;
            #endregion

            #region Access Modifires ->C# keywords => 6 
            //Private 
            //Private Protected
            //Protected
            //Internal 
            //Internal Protected
            //Public 
            //TypeA typeA = new TypeA();  
            //typeA.x
            //typeA.x
            #endregion

            #region Struct 
            //ValueType 
            //Struct 
            //Class
            //-->Attributes => Variables
            //-->Methods [Constructor  - Getter/Setter -User Defined]
            //--->Property [Full Prop -Autamatic Prop - Indexer]
            //Point P1;//CLR Generated Object at Stack
            //P1 = new Point(3,5);//Built In
            ////Console.WriteLine(P1.z);

            //Console.WriteLine(P1.ToString());//P1
            #endregion

           



        }
    }
}
