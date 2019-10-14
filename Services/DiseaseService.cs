using App4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App4.Services
{
    
    public class DiseaseService
    {
        private readonly App4Context _context;

        public DiseaseService(App4Context context)
        {
            _context = context;
        }



        public List<Disease> List()
        {
            return _context.Disease.ToList();
        }
        public void Insert(Disease disease)
        {
            _context.Disease.Add(disease);
            _context.SaveChanges();
        }
        public void Update(Disease disease)
        {
            if (!_context.Disease.Any(x => x.Id == disease.Id))
            {
                //ao criar erro personalizado adicionar aqui
            }
            try
            {
                _context.Update(disease);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                //ao criar erro personalizado adicionar aqui
            }
        }
        public void remove(int id)
        {
            try
            {
                var obj = _context.Disease.Find(id);
                _context.Disease.Remove(obj);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                //ao criar erro personalizado adicionar aqui
            }
        }
    }
}
