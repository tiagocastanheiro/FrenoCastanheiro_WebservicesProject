using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SAPHRManager : ISAPHRManager
    {
        private ISAPHRDB SAPHRDB { get; }

        public SAPHRManager(ISAPHRDB SAPHRDB)
        {
            this.SAPHRDB = SAPHRDB;
        }

        public string GetUsernameByUID(int UID)
        {
            return SAPHRDB.GetStudentByUID(UID).Username;
        }

        public int GetUIDbyCardID(int CardUID)
        {
            throw new NotImplementedException();
        }
    }
}
