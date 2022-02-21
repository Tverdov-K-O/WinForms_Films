using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms_Films.Data
{
    public class Film 
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Genre> Genres { get; set; }
        public DateTime CreatedAt { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
