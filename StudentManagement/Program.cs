using DatabaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            DatabaseFactory.DatabaseFactory Instance = DatabaseFactory.DatabaseFactory.Instance;
            IDBOperationInterface dbInterface = Instance.GetDBInterface();
            dbInterface.GetStudentInfoByName("sumit");
        }
    }
}
