using System;
using System.Collections.Generic;

#nullable disable

namespace DAL.Models
{
    public partial class User
    {
        public string NumMom { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Id { get; set; }
        public string IdKupa { get; set; }
        public string PhNum { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual KupotCholim IdKupaNavigation { get; set; }
    }
}
