namespace RmoscosoLabAssigment2
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public Person p1Spouse;
        public Person p2Spouse;
        public string MaritalStatus;
        public static double SumOfAllAges;

        public string GetFullName()
        {
            return this.FirstName + " " + this.LastName;
        }
            public void PrintNameAndAge()
        {
            System.Console.WriteLine(this.FirstName + " " + this.Age);

            {
             
            }
        }
    }
}
