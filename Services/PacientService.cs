using App4.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App4.Services
{
    public class PacientService
    {
        private readonly App4Context _context;

        public PacientService(App4Context context)
        {
            _context = context;
        }

        public Pacient FindById(int id)
        {
            return _context.Pacient.Include(obj => obj.Disease).FirstOrDefault(obj => obj.Id == id);
        }
        public void Insert(Pacient pacient)
        {
            _context.Pacient.Add(pacient);
            _context.SaveChanges();
        }
        public void Update(Pacient pacient)
        {
            if (!_context.Pacient.Any(x => x.Id == pacient.Id))
            {
                //ao criar erro personalizado adicionar aqui
            }
            try
            {
                _context.Update(pacient);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                //ao criar erro personalizado adicionar aqui
            }
        }
        public void Remove(int id)
        {
            try
            {
                var obj = _context.Pacient.Find(id);
                _context.Pacient.Remove(obj);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                //ao criar erro personalizado adicionar aqui
            }
        }

    }
}

