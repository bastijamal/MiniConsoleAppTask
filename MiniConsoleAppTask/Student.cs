using System;
namespace MiniConsoleAppTask
{
	public class Student
	{
        private static int _id;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }


        public Student()
        {
            Id =++ _id;
           
        }

        public void ShowInfo()
        {
            Console.WriteLine($"id:{Id},name:{Name},surname:{Surname}");
        }


    }
}

