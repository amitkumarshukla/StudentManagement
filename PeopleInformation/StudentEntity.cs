using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleInformation
{
    public class StudentEntity : People
    {
        public int studentClass { get; set; }
        public int studentmarks { get; set; }

        // more student related info
    }
}
