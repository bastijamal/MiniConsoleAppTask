using System;
using System.Drawing;
using System.Runtime.ConstrainedExecution;
using static MiniConsoleAppTask.Extencions;

namespace MiniConsoleAppTask;

class Program
{
    static void Main(string[] args)
    {

        #region Task


        // Console app yaradirsiz Menu:
        //1.Classroom yarat
        //2.Student yarat
        //3.Butun Telebeleri ekrana cixart
        //4.Secilmis sinifdeki telebeleri ekrana cixart
        //5.Telebe sil(Verilmis id olan telbeni taparaq silecek)
        //eger telebe tapilmasa StudentNotFoundException(Ozunuz yaradirsiz) qaytaracaq
        //ps:sinif yoxdusa telbe yaradila bilmesin(ClasroomNotFoundException)

        //Classroom classinda olacaqlar
        //Id oz - oz luyunde artacaq
        //Name
        //Student arrayi olsun
        //Sinifin Type olsun - Enum olacaq(Backend ve Frontend)
        //Type = Backend olsa sinifin limiti 20
        //Type = FrontEnd olsa sinifin limiti 15 olsun

        //StudentAdd methoduvuz olsun.
        //FindId - methodunuz id qebul edecek ve hemin id uygun telebeni qaytaracaq
        //Delete - methodunuz id qebul edib ve hemin id uygun telebeni arrayden silecek


        //Student classinda olacaqlar
        //Id oz - oz luyunde artacaq
        //Name,
        //SurName

        //Bir Helper classiviz olsun
        //Name, Surname check etsin adlar boyuk herfle baslamali-extensions seklinde)
        //Name 1 den cox soz olmamali ve en azi uzunlugu 3 olmali
        //bu dediklerim Surname-de aiddir
        //Classroom - un adi 2 boyuk herf 3 reqemden ibaret olmalidi
        //verilen her hansi serti odemese yeniden girilmeyi teleb etsin ve obyect yaranmasin

        #endregion


        Classroom classroom = new Classroom();

      
        Student student1 = new Student { Name = "Basti", Surname = "Jamal" };

        classroom.StudentAdd(student1);

        Console.WriteLine("-----------------------------------------------");

        ///



            bool exit = false;
            do
            {
                Console.WriteLine("Xosh gelmisooozzz");
                Console.WriteLine("1. classroom yaratmaq");
                Console.WriteLine("2. student yaratmaq");
                Console.WriteLine("3. butun studentleri gosdermek");
                Console.WriteLine("4. student axtarmaq");
                Console.WriteLine("5. student silmek");
                Console.WriteLine("0.CHIXISH");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.WriteLine("classroom yaratmaq");
                        Classroom classroom1 = Createclassroom();
                        Console.WriteLine(" classroom yaradildi");

                     static Classroom Createclassroom()
                    {
                        Classroom classroom = new Classroom();
                        Console.WriteLine("Classroom adi daxil edin: ");
                        classroom.Name = Console.ReadLine();
                        Console.WriteLine("Typini daxil edin-(Front/Back): ");
                        string choose = Console.ReadLine();


                        switch (choose)
                        {

                            case "1":
                                classroom.type = Type.Backend;
                                break;
                            case "2":
                                classroom.type = Type.Frontend;
                                break;
                            default:
                                Console.WriteLine("Classromm Errorrrr");
                                break;

                        }


                        return classroom;
                    }
                    break;

                    case "2":
                        try
                        {
                            Console.WriteLine("student yaratmaq ");
                            Student student = Createstudent();
                            Console.WriteLine("student yaradildi");
                            classroom.StudentAdd(student);
                            Console.WriteLine("student elave edildi");


                         static Student Createstudent()
                        {
                            Classroom students = null;
                            if (students == null)
                            {
                                throw new Newexception("clasroom yaradila bilmirr");
                            }
                            else
                            {
                                Student student = new Student();
                                Console.WriteLine(" Student adi daxil edin: ");
                                student.Name = Console.ReadLine();
                                Console.WriteLine(" Student soyadi daxil edin: ");
                                student.Surname = Console.ReadLine();

                                return student;
                            }
                        }
                        break;

                        }
                        catch (Newexception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case "3":
                        classroom.ShowAllStudent();

                        Console.WriteLine("Butun studentleri gore bilersiniz");
                        break;

                    case "4":
                        try
                        {
                            Console.WriteLine(" student id si daxil edin: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            var student = classroom.FindById(id);
                            Console.WriteLine(student);
                        }
                        catch (Studentdontfoundexception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case "5":
                        try
                        {
                            Console.WriteLine("Hansin silmek isteyirsiz(id):  ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            classroom.DeleteStudent(id);
                        }
                        catch (Studentdontfoundexception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                    
                    case "0":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine();
                        break;
                }
            } while (exit != true);
        }

       


       


    }





