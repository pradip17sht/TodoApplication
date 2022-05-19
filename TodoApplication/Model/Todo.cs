using System;
using System.ComponentModel.DataAnnotations;

namespace TodoApplication.Model
{
    public class Todo
    {
        public Guid Id { get; set; }
        [StringLength(10)]
        public string Title { get; set; }
        [StringLength(50)]
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDone { get; set; }
        public DateTime CompletedDate { get; set; }
        public Guid? CreatorId { get; set; }
    }
}
