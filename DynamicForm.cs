using System.ComponentModel.DataAnnotations;

namespace Abhishek_Lodhi.Models
{
    public class DynamicForm
    {
        [Key]
        public int Id { get; set; } // Form ID
        public string Name { get; set; } // Form name
        public List<DynamicFormField> Fields { get; set; } = new List<DynamicFormField>();
        // public List<DynamicFormField> Fields { get; set; } = new(); // List of form fields
    }
}
