using App4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App4.Data
{
    public class SeedingService
    {
        private App4Context _context;

        public SeedingService(App4Context context)
        {
            _context = context;
        }
        public void Seed() 
        {
            if (_context.Pacient.Any() || _context.Disease.Any())
            {
                return;
            }
            else
            {
                Pacient initial = new Pacient(1, "Paulo");
                Disease second = new Disease(1, "preguiça", DateTime.Now);
                _context.Disease.AddRange(second);
                _context.Pacient.AddRange(initial);
                _context.SaveChanges();
            }

        }
        
    }
}
