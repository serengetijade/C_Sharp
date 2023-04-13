namespace CodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Students!");

            using (var ctx = new StudentContext())
            {
                GradeLevel GL = new GradeLevel();   //In order for all of the class properties to pass through, must create an instance of the class.
                Console.WriteLine("Please enter your first name...");
                string FN = Console.ReadLine();     
                Console.WriteLine("Please enter your last name...");
                string LN = Console.ReadLine();
                //Console.WriteLine("And what grade are you in? Please enter a number 1-12...");
                //GL.GradeID = Convert.ToInt32(Console.ReadLine()); //Change the GradeID property value of this instance.
                var newStudent = new Student() { FirstName = FN, LastName = LN};
                ctx.Students.Add(newStudent);
                ctx.SaveChanges();
                Console.WriteLine("Super Duper.");
                Console.ReadKey();
            }
        }
    }
}