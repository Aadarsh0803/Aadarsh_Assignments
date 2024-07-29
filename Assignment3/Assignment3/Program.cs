namespace Assignment3
{
    internal class Program
    {
        public class person
        {
            public string FirstName;
            public string LastName; 
            public string Email;
            public DateTime DOB;
            
            public void constr(string FirstName, string LastName, string Email, DateTime DOB)
            {
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.Email = Email;
                this.DOB = DOB;
            } 
            public person(string FirstName, string LastName, string Email, DateTime DOB)
            {
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.Email = Email;
                this.DOB = DOB;

            }
            public person(string FirstName, string LastName, string Email)
            {
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.Email = Email;
            }
            public person(string FirstName, string LastName, DateTime DOB)
            {
                this.FirstName = FirstName;
                this.LastName = LastName;
            
                 this.DOB = DOB;
            }
            public void Display()
            {
                Console.WriteLine("First Name : " + FirstName);
                Console.WriteLine("Last Name: " +LastName);
                Console.WriteLine("Email: "+Email);
                Console.WriteLine("Date of Birth : " + DOB);
            }
        }
        static void Main(string[] args)
        {
            person p1 = new person("Adarsh","Navathe","adarsh@gmail.com",new DateTime(2003,8,6));
            p1.Display();
            person p2 = new person("Adarsh", "Navathe", "adarsh@gmail.com");
            p2.Display();
            person p3 = new person("Adarsh", "Navathe",  new DateTime(2003, 8, 6));
            p3.Display();
        }
    }
}
