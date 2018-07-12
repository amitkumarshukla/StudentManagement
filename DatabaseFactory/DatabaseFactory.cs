using DatabaseInterface;
using SQLInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTextFileDatabase;

namespace DatabaseFactory
{
    enum AvailableDbType
    {
        SQLDB,
        TestTextFile
    }
    public class DatabaseFactory
    {
        // This is the hard coding done for the interface to choose
        // this should actually come from a xml file. We will read xml and see what is hardcoded and 
        // get this info
        private AvailableDbType _currentDbTochoose = AvailableDbType.TestTextFile;

        static readonly DatabaseFactory _instance = new DatabaseFactory();
        public static DatabaseFactory Instance
        {
            get
            {
                return _instance;
            }
        }
        public DatabaseFactory()
        {

        }
        public IDBOperationInterface GetDBInterface()
        {
            IDBOperationInterface dbInterface = null;
            switch (_currentDbTochoose)
            {
                case AvailableDbType.SQLDB:
                    dbInterface =  new SQLDBOperation();
                    break;
                case AvailableDbType.TestTextFile:
                    dbInterface = new TestTextfileDBOperation();
                    break;
                default:
                    break;
            }
            return dbInterface;
        }
    }
}
