using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App4.Models
{
    public class Pacient
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Disease> Disease { get; set; } = new List<Disease>();
        public int DiseaseId { get; set; } = 1;

        public Pacient(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void AddDisiease(Disease ds) 
        {
            Disease.Add(ds);
        }
        public void RmvDisiease(Disease ds)
        {
            Disease.Remove(ds);
        }
    }
}
