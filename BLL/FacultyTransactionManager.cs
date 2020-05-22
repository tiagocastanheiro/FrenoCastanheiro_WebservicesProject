using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FacultyTransactionManager : IFacultyTransactionManager
    {
        private FacultyTransactionDB FacultyTransactionDB { get; }

        public FacultyTransactionManager(FacultyTransactionDB facultyTransactionDB)
        {
            FacultyTransactionDB = facultyTransactionDB;
        }

        public FacultyTransaction AddTransaction(FacultyTransaction facultiesTransaction)
        {
            return FacultyTransactionDB.AddTransaction(facultiesTransaction);
        }
    }
}
