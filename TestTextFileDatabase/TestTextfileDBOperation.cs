using DatabaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PeopleInformation;

namespace TestTextFileDatabase
{
    public class TestTextfileDBOperation : IDBOperationInterface
    {
        public List<FacultyEntity> GetFacultyInfoByName(string name)
        {
            // Open the text file with hardcoded faculty information
            // read the text file
            // search the file
            // and return the info back
            throw new NotImplementedException();
        }

        public List<StudentEntity> GetStudentInfoByName(string name)
        {
            // Open the text file with hardcoded student information
            // read the text file
            // search the file
            // and return the info back
            throw new NotImplementedException();
        }

        public List<StudentEntity> GetStudentInfoByRollNumber(int rollNumber)
        {
            // Open the text file with hardcoded student information
            // read the text file
            // search the file
            // and return the info back
            throw new NotImplementedException();
        }
    }
}
