
namespace CRUDtest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserStory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserStory()
        {
            this.ProjectTasks = new HashSet<ProjectTask>();
        }
    
        public int UserStoryID { get; set; }
        public string Story { get; set; }
        public Nullable<int> ProjectID { get; set; }
    
        public virtual Project Project { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectTask> ProjectTasks { get; set; }
    }
}
