using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Day2.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        public string Brief { get; set; }

        public virtual List<News> News { get; set; } = new List<News>();

        public override string ToString() 
        {
            return $"Id: {Id}\n Name: {Name}\n JoinDate: {JoinDate}\n Username: {Username}\n Password: {Password}\n Brief: {Brief}\n";
        }
    }
}
