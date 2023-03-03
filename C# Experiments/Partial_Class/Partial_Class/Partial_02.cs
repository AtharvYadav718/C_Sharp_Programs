using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace partialclass
{
    public partial class Studentpartial
    {
        public string Getcompletename()
        {
            return Firstname + " " + Lastname;
        }
    }
}
