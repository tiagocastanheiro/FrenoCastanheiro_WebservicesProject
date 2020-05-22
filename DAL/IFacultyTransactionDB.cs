using DTO;
using System;

namespace DAL
{
    public interface IFacultyTransactionDB
    {
        FacultyTransaction AddTransaction(FacultyTransaction facultiesTransaction);

    }
}