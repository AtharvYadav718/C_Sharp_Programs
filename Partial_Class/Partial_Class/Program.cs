
using System;
         using System.Collections.Generic;
         using System.Linq;
         using System.Text;
namespace partialclass
{
    public partial class Studentpartial
    {
        private string firstname; private string lastname;

        public string Firstname
        {
            set
            {
                firstname = value;
            }
            get
            {
                return firstname;
            }
        }
        public string Lastname
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }
    }
}






   



    

