using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_Reading_02
{
    class CreateFile
    {
        public static void Main(string[] args)
        {
            FileStream f = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            for (int i = 1; i <= 20; i++)
            {
                f.WriteByte((byte)i);
            }
            f.Position = 0;
            for (int i = 0; i <= 20; i++)
            {
                Console.Write(f.ReadByte() + " ");
            }
            f.Close();
            Console.ReadKey();
        }
    }
}
