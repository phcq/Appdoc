﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App4.Models
{
    public class Disease
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateDiagnosis { get;set; }

        public Disease(int id, string name, DateTime dateDiagnosis)
        {
            Id = id;
            Name = name;
            DateDiagnosis = dateDiagnosis;
        }
    }
}
