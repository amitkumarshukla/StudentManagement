using DatabaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleInformation;

namespace SQLInterface
{
    public class SQLDBOperation : IDBOperationInterface
    {
        public List<FacultyEntity> GetFacultyInfoByName(string name)
        {
            // Create connection to DB of use existing stored connect
            // Run the query in the data base
            throw new NotImplementedException();
        }

        public List<StudentEntity> GetStudentInfoByName(string name)
        {
            // Create connection to DB of use existing stored connect
            // Run the query in the data base
            throw new NotImplementedException();
        }

        public List<StudentEntity> GetStudentInfoByRollNumber(int rollNumber)
        {
            // Create connection to DB of use existing stored connect
            // Run the query in the data base
            throw new NotImplementedException();
        }
    }
}
