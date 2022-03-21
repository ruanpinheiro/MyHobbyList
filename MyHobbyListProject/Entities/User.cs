using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHobbyListProject.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; private set; }
        public string lastName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDay { get; private set; }
        
    }
}
