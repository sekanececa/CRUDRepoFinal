
namespace CRUDtest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ManagerComment
    {
        public int ManagerCommentID { get; set; }
        public string Comments { get; set; }
        public Nullable<int> ProjectTaskID { get; set; }
    
        public virtual ProjectTask ProjectTask { get; set; }
    }
}
