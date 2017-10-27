

//namespace CRUDtest.Models
//{
//    using System;
//    using System.Collections.Generic;
//    using System.ComponentModel.DataAnnotations;
//    //pokusaj realizacije tutorijla za login
//    //https://www.youtube.com/watch?v=Uq0y8oxnx-8
//    public partial class User
//    {
//        [Key]
        
//        public int UserID { get; set; }


//        [Required(ErrorMessage ="Frst Name is required.")]
//        public string FirstName { get; set; }


//        [Required(ErrorMessage ="Last Name is required.")]
//        public string LastName { get; set; }

//        [Required(ErrorMessage ="Email is required.")]
//        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
//         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
//         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage ="Please enter valid email.")]
//        public string Email { get; set; }

//        [Required(ErrorMessage ="User name is required.")]
//        public string UserName { get; set; }

//        [Required(ErrorMessage ="Password is required.")]
//        [DataType(DataType.Password)]
//        public string Password { get; set; }

//        [Compare("Password",ErrorMessage ="Please confirm your password.")]
//        [DataType(DataType.Password)]
//        public string ConfigPassword { get; set; }
//    }
//}