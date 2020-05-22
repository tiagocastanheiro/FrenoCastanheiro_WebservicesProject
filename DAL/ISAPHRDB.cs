using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ISAPHRDB
    {
        Student GetStudentByUID(int UID);
        Student GetStudentByCardID(int CardID);
    }
}
