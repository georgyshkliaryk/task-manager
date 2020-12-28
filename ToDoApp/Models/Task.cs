using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoApp.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Text { get; set; }

        [Column(TypeName = "varchar(20)")]
        public string Color { get; set; }
    }
}
