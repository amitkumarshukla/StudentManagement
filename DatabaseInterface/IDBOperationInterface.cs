using PeopleInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseInterface
{
    public interface IDBOperationInterface
    {
        
        List<StudentEntity> GetStudentInfoByName(string name);
        List<StudentEntity> GetStudentInfoByRollNumber(int rollNumber);

        List<FacultyEntity> GetFacultyInfoByName(string name);

        // put more function as it came in the requirement

    }
}
