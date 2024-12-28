namespace Assignment_Session01
{
    #region Example_1 Enum
    enum WeekDays
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    #endregion

    #region Example_2 Enum
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }
    #endregion

    #region Example_3 Enum
    enum Permission
    {
        None = 0,
        Read = 1,
        Write = 2,
        Execute = 4,
        Delete = 8
    }
    #endregion

    #region Example_4 Enum
    enum Colors
    {
        Red,
        Green,
        Blue,
        Yellow,
        Black,
        White
    }
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this Enum.
            //Console.Write("Enter The Day Number: ");
            //bool isParsed = int.TryParse(Console.ReadLine(), out int dayNum);
            //if (isParsed && (dayNum >= 1 && dayNum <= 7))
            //{
            //    WeekDays urDay = (WeekDays)dayNum;
            //    Console.WriteLine($"The Day U Wanna it is: {urDay}");
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid Number, Pls Enter Number Between 1 : 7");
            //}
            #endregion

            #region 2.Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
            //Console.Write("Enter a season [Spring, Summer, Autumn, Winter]: ");
            //string userInput = Console.ReadLine();
            //bool isParsed = Enum.TryParse(typeof(Season), userInput, true, out object inputSeason);

            //if (isParsed && inputSeason != null)
            //{
            //    Season selectedSeason = (Season)inputSeason;

            //    switch (selectedSeason)
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
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid input. Please restart the program and enter a valid season (Spring, Summer, Autumn, Winter).");
            //}
            #endregion

            #region 3.Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum, Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission existed inside variable. 
            //// Step 1: Create a variable from Permission Enum
            //Permission userPermissions = Permission.None;
            //Console.WriteLine($"Initial Permissions: {userPermissions}");

            //// Step 2: Add Permissions (Read and Write)
            //userPermissions |= Permission.Read;
            //Console.WriteLine($"After Adding Read: {userPermissions}");

            //userPermissions |= Permission.Write;
            //Console.WriteLine($"After Adding Write: {userPermissions}");

            //// Step 3: Remove a Permission (Read)
            //userPermissions &= ~Permission.Read;
            //Console.WriteLine($"After Removing Read: {userPermissions}");

            //// Step 4: Check if a specific Permission exists (Write)
            //if ((userPermissions & Permission.Write) == Permission.Write)
            //{
            //    Console.WriteLine("Write Permission Exists.");
            //}
            //else
            //{
            //    Console.WriteLine("Write Permission Does NOT Exist.");
            //}

            //// Step 5: Check if a specific Permission exists (Execute)
            //if ((userPermissions & Permission.Execute) == Permission.Execute)
            //{
            //    Console.WriteLine("Execute Permission Exists.");
            //}
            //else
            //{
            //    Console.WriteLine("Execute Permission Does NOT Exist.");
            //}
            #endregion

            #region 4.Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
            //Console.Write("Enter a Color Name: ");
            //string userInput = Console.ReadLine();
            //bool isParsed = Enum.TryParse(typeof(Colors), userInput, true, out object inputColor);

            //if (isParsed && inputColor != null)
            //{
            //    Colors selectedColor = (Colors)inputColor;
            //    if (selectedColor == Colors.Green || selectedColor == Colors.Blue || selectedColor == Colors.Red)
            //    {
            //        Console.WriteLine($"{inputColor} is a primary color");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{inputColor} is not a primary color");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Error: Invalid input.");
            //}
            #endregion
        }
    }
}
