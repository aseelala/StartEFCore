using System;
using System.Collections.Generic;
using System.Text;
using Model.Entities;
using Model.Repositories;
using System.Linq;

namespace Model.Services
{
    public class DocentService
    {
        readonly private EFOpleidingenContext context;
        // Constructor
        public DocentService(EFOpleidingenContext context)
        {
            this.context = context;
        }
        public IEnumerable<Docent> GetDocentenVoorCampus(int campus)
        {
            return context.Docenten.Where(x => x.CampusId == campus).ToList();
        }
        public Docent GetDocent(int id)
        {
            if (id == 0)
            { throw new ArgumentException(nameof(id)); }
            return context.Docenten.FirstOrDefault(x => x.DocentId == id);
        }
        public void ToevoegenDocent(Docent docent)
        {
            if (String.IsNullOrEmpty(docent.LandCode)) 
            { 
                docent.LandCode = "BE";
            }
            context.Docenten.Add(docent);
        }
    }
}
