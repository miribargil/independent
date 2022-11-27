using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class KupotCholim
    {
        public KupotCholim()
        {
            Users = new HashSet<User>();
        }

        public string IdKupa { get; set; }
        public string NameKupa { get; set; }
        public string LinkKupa { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}
