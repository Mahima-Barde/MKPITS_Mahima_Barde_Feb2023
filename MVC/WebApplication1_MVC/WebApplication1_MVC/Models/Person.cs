namespace WebApplication1_MVC.Models
{
    public class Person
    {
        //buid a constructor
        string Name;
        int Age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string name
        {
            get
            {
                return Name;
            }
        }
        public int age
        {
            get
            { 
                return Age;
            }
        }

    }
}
