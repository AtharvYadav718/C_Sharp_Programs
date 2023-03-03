using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Defined_Exception
{
    class UserDefinedExecption : Exception
    {
        public UserDefinedExecption(String str)
        {
            Console.WriteLine(str);
        }
    }
    class program
    {
        static void Main(string[] args)
        {
            UserDefinedExecption M = new UserDefinedExecption("User Defined Exception");

            try
            {
                throw M;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
        }
    }
}

