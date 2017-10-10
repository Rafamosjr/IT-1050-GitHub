namespace RmoscosoLabAssigment2
{
    class Program
    
    {
        static void Main(string[] args)
        {
            #region Person One
            Person p1 = new Person();
            System.Console.Write("Enter Your First Name: ");
            p1.FirstName = System.Console.ReadLine();

            System.Console.Write("Enter Your Last Name: ");
            p1.LastName = System.Console.ReadLine();

            System.Console.Write("Enter Your Age: ");
            p1.Age = int.Parse(System.Console.ReadLine());

            System.Console.Write("What is your marital status?: ");
            p1.MaritalStatus = System.Console.ReadLine();
                                                                            //I cannot seem to figure out why i keep getting System.NullReferenceException with this line.
            System.Console.Write("What is your spouses first name?: ");
            p1.p1Spouse.FirstName = System.Console.ReadLine();

            System.Console.Write("What is your spouses age?: ");
            p1.p1Spouse.Age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine(p1.GetFullName());
            System.Console.WriteLine(p1.p1Spouse.GetFullName());

            p1.PrintNameAndAge();
            p1.p1Spouse.PrintNameAndAge();

            #endregion
            #region Person Two
            Person p2 = new Person();
            System.Console.Write("Enter Your First Name: ");
            p2.FirstName = System.Console.ReadLine();

            System.Console.Write("Enter Your Last Name: ");
            p2.LastName = System.Console.ReadLine();

            System.Console.Write("Enter Your Age: ");
            p2.Age = int.Parse(System.Console.ReadLine());

            System.Console.Write("What is your marital status?: ");
            p2.MaritalStatus = System.Console.ReadLine();

            System.Console.Write("What is your spouses first name?: ");
            p2.p2Spouse.FirstName = System.Console.ReadLine();

            System.Console.Write("What is your spouses age?: ");
            p2.p2Spouse.Age = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine(p2.GetFullName());
            System.Console.WriteLine(p2.p2Spouse.GetFullName());

            p2.PrintNameAndAge();
            p2.p2Spouse.PrintNameAndAge();

            #endregion


            double SumOffAllAges = (p1.Age + p2.Age + p1.p1Spouse.Age + p2.p2Spouse.Age / 4);
            System.Console.WriteLine(SumOffAllAges);


        }
    }
}