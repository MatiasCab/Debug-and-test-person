using System;

namespace UnitTestAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John Doe", "5.260.108-6");
            Person jane = new Person("", "8.765.432-1");
            john.IntroduceYourself();
            jane.IntroduceYourself();
        }
    }
}
