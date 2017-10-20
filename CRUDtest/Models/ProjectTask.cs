
namespace CRUDtest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProjectTask
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProjectTask()
        {
            this.ManagerComments = new HashSet<ManagerComment>();
        }
    
        public int ProjectTaskID { get; set; }
        public Nullable<int> AssignedTo { get; set; }
        public Nullable<System.DateTime> TaskStartDate { get; set; }
        public Nullable<System.DateTime> TaskEndDate { get; set; }
        public Nullable<int> TaskCompletion { get; set; }
        public Nullable<int> UserStoryID { get; set; }
    
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ManagerComment> ManagerComments { get; set; }
        public virtual UserStory UserStory { get; set; }
    }
}
