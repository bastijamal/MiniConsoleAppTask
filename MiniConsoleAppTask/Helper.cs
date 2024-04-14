using System;
using System.Xml.Linq;

namespace MiniConsoleAppTask
{
    public static class Helper
    {
        //Bir Helper classiviz olsun
        //Name, Surname check etsin adlar boyuk herfle baslamali-extensions seklinde)
        //Name 1 den cox soz olmamali ve en azi uzunlugu 3 olmali
        //bu dediklerim Surname-de aiddir
        //Classroom - un adi 2 boyuk herf 3 reqemden ibaret olmalidi
        //verilen her hansi serti odemese yeniden girilmeyi teleb etsin ve obyect yaranmasin


       
            public static bool Checkname(this string name)
            {
                bool uppercharackter = false;
                if (!string.IsNullOrEmpty(name))
                {
                    return true;
                }

                if (name.Length < 3)
                {
                    return false;
                }
                foreach (char c in name)
                {
                    if (char.IsUpper(name[0]))
                    {
                        uppercharackter = true;
                        break;
                    }
                }
                return uppercharackter;
            }
            public static bool Checksurname(this string surname)
            {
                bool uppercharackter = false;
                if (!string.IsNullOrEmpty(surname))
                {
                    return true;
                }
                if (surname.Length < 3)
                {
                    return false;
                }
                foreach (char c in surname)
                {
                    if (char.IsUpper(surname[0]))
                    {
                        uppercharackter = true;
                        break;
                    }
                }
                return uppercharackter;
            }
            public static bool checkclassroom(this string name)
            {
                bool uppercharacter1 = false;
                bool uppercharacter2 = false;
                bool number1 = false;
                bool number2 = false;
                bool number3 = false;
                if (name.Length < 5)
                {
                    return false;
                }
                foreach (char c in name)
                {
                    if (char.IsUpper(name[0]))
                    {
                        uppercharacter1 = true;
                        continue;
                    }
                    if (char.IsUpper(name[1]))
                    {
                        uppercharacter2 = true;
                        continue;
                    }
                    if (char.IsDigit(name[2]))
                    {
                        number1 = true;
                        continue;
                    }
                    if (char.IsDigit(name[3]))
                    {
                        number2 = true;
                        continue;
                    }
                    if (char.IsDigit(name[4]))
                    {
                        number3 = true;
                        break;
                    }
                }
                return uppercharacter1 && uppercharacter2 && number1 && number2 && number3;
            }


        }


    }













