namespace MiniConsoleAppTask
{
    public class Classroom
    {

        //Id oz - oz luyunde artacaq
        //Name
        //Student arrayi olsun
        //Sinifin Type olsun - Enum olacaq(Backend ve Student)
        //Type = Backend olsa sinifin limiti 20
        //Type = FrontEnd olsa sinifin limiti 15 olsun

        //Methods:

        //StudentAdd methoduvuz olsun.
        //FindId - methodunuz id qebul edecek ve hemin id uygun telebeni qaytaracaq
        //Delete - methodunuz id qebul edib ve hemin id uygun telebeni arrayden silecek

        private static int _id;
        public int Id { get; set; }

        public string Name { get; set; }

        public Student[] students;

        public Type type { get; set; }

        //private Type backend;
        //private Type frontend;

        public Classroom()
        {
            Id = ++_id;


            if (type == Type.Backend)
            {
                students = new Student[20];
            }

            else if (type == Type.Frontend)
            {
                students = new Student[15];
            }

            else
            {
                
                Console.WriteLine("duzgun deyer daxil edinn");
            }
        }


        //public Classroom(Type frontend,Type backend)
        //{
        //    this.frontend = frontend;
        //    this.backend = backend;
        //}




        public void ShowAllStudent()
        {
            foreach (Student student in students)
            {
                Console.WriteLine($"id:{student.Id},name:{student.Name},surname:{student.Surname}");
            }

        }


        public void StudentAdd(Student student)
        {

            if (students.Length < 20)
            {
                Array.Resize(ref students, students.Length + 1);
                students[^1] = student;

                //veya
                //students[students.Length - 1] = student;
            }

            else
            {
                Console.WriteLine("SINFDE ELAVE EDILMEYE YER YOXDYUR");
            }
        }

        //FindId ele hemishe yazdigimiz Filterdi

        public Student[] FindById(int id)
        {
            Student[] filteredStudents = new Student[students.Length];
            int count = 0;

            foreach (var student in students)
            {
                if (student != null && student.Id == id)
                {
                    filteredStudents[count] = student;
                    count++;
                }
            }

            Array.Resize(ref filteredStudents, count);
            return filteredStudents;
        }

        //DeleteMethodu

        public void DeleteStudent(int id)
        {
            Student[] filteredstudents = new Student[students.Length - 1];
            int index = 0;

            foreach (var pr in students)
            {
                if (pr.Id != _id)
                {
                    filteredstudents[index] = pr;
                    index++;
                }

            }

            students = filteredstudents;

        }

        //GetMethodu
        public  Student GetStudent(int id)
        {
            foreach (var pr in students)
            {
                if (pr.Id==id)
                {
                    return pr;
                }

            }

            return null;

        }





    }
}

