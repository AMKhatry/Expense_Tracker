using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Title { get; set; }

        public string Icon { get; set; } = string.Empty;

        public string Type { get; set; } = "Expense";
    }
}
