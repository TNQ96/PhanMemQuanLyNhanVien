using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeManagement_Service.ModelDBContext;
using EmployeeManagement_Service.Service.Module;

namespace EmployeeManagement_Service.Service.Module
{
    public class EducationLevels
    {
        private readonly EmployeeManagementDBContext _context;

        public EducationLevels(EmployeeManagementDBContext context)
        {
            this._context = context;
        }

        public IEnumerable<PdbEducationLevel> EducationLevelsAll()
        {
            return _context.PdbEducationLevels;
        }

        public bool Add(PdbEducationLevel item)
        {
            _context.PdbEducationLevels.Add(item);
            _context.Entry(item).State = System.Data.Entity.EntityState.Added;
            return _context.SaveChanges() == 1;
        }

        public bool Edit(PdbEducationLevel item)
        {
            _context.PdbEducationLevels.Attach(item);
            _context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            return _context.SaveChanges() == 1;
        }

        public bool Delete(Guid id)
        {
            PdbEducationLevel item = _context.PdbEducationLevels.SingleOrDefault(itemc => itemc.ID_EL == id);
            _context.PdbEducationLevels.DefaultIfEmpty(item);
            _context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
            return _context.SaveChanges() == 1;
        }

        public PdbEducationLevel GetEducationLevel(Guid id)
        {
            return _context.PdbEducationLevels.SingleOrDefault(item => item.ID_EL == id);
        }
    }
}
