using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDtest.Models
{
    using System;
    using System.Collections.Generic;
    public partial class Users
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public  Users()
        {
        }
        [Key]
        public int UsersId { get; set; }
       
        public string Username { get; set; }
        public string Password { get; set; }
    }
}