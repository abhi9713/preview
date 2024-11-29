using System.ComponentModel.DataAnnotations;

namespace Abhishek_Lodhi.Models
{
    public class DynamicFormField
    {
        [Key]
        public int Id { get; set; } // Primary key
        public string? Label { get; set; } // Field label
        public string? Value { get; set; } // Field label
        public string? FieldType { get; set; } // Type of the field (text, dropdown, etc.)

        public List<string> Options { get; set; } = new List<string>(); // Options for dropdown, checkbox, or radio

        //public List<string>? Options { get; set; } // Options for dropdown, checkbox, etc.
        public string? SelectedOption { get; set; }
    }
}
