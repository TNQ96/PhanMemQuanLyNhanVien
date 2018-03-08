using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeManagement_Service.ModelDBContext;
using EmployeeManagement_Service.Service.Module;

namespace EmployeeManagement_Service.Service.Module
{
    public class Events
    {
        private readonly EmployeeManagementDBContext _context;

        public Events(EmployeeManagementDBContext context)
        {
            this._context = context;
        }

        public List<PdbEvent> EventsAll()
        {
            return _context.PdbEvents.ToList<PdbEvent>();
        }

        public bool Add(PdbEvent item)
        {
            _context.PdbEvents.Add(item);
            _context.Entry(item).State = System.Data.Entity.EntityState.Added;
            return _context.SaveChanges() == 1;
        }

        public bool Edit(PdbEvent item)
        {
            _context.PdbEvents.Attach(item);
            _context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            return _context.SaveChanges() == 1;
        }

        public bool Delete(Guid id)
        {
            PdbEvent item = _context.PdbEvents.SingleOrDefault(itemc => itemc.ID_Event == id);
            _context.PdbEvents.DefaultIfEmpty(item);
            _context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
            return _context.SaveChanges() == 1;
        }

        public PdbEvent GetEvent(Guid id)
        {
            return _context.PdbEvents.SingleOrDefault(item => item.ID_Event == id);
        }
    }
}
