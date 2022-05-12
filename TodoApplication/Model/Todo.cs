using System;

namespace TodoApplication.Model
{
    public class Todo
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDone { get; set; }
        public DateTime CompletedDate { get; set; }
    }
}
