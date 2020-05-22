using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FacultyTransaction
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public int Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
