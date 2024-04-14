using System;
namespace MiniConsoleAppTask
{
	public class Extencions
	{
        internal class Newexception : Exception
        {
            public Newexception(string message="problem varr ashkoo") : base(message)
            {

            }
        }

        internal class Studentdontfoundexception : Exception
        {
            public Studentdontfoundexception(string message="studentimizde probb") : base(message)
            {

            }
        }
    }
}

