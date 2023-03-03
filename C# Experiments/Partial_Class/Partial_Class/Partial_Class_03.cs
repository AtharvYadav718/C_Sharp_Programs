using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace partialclass
{
    class program1
    {
        static public void Main(string[] args)
        {
            Studentpartial obj = new Studentpartial(); obj.Firstname = "ATHARV"; obj.Lastname = "YADAV";
            Console.WriteLine("YOUR COMPLETE NAME IS : " + obj.Getcompletename());
            Console.ReadKey();
        }
    }
}