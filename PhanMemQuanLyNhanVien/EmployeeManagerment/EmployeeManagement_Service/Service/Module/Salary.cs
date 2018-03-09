using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeManagement_Service.ModelDBContext;
using EmployeeManagement_Service.Service.Module;

namespace EmployeeManagement_Service.Service.Module
{
    public class Salary
    {
        private readonly EmployeeManagementDBContext _context;

        public Salary(EmployeeManagementDBContext context)
        {
            this._context = context;
        }

        public IEnumerable<PdbBonusSalary> EventsAll()
        {
            return _context.PdbBonusSalaries;
        }

        public bool Add(PdbBonusSalary item)
        {
            _context.PdbBonusSalaries.Add(item);
            _context.Entry(item).State = System.Data.Entity.EntityState.Added;
            return _context.SaveChanges() == 1;
        }

        public bool Edit(PdbBonusSalary item)
        {
            _context.PdbBonusSalaries.Attach(item);
            _context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            return _context.SaveChanges() == 1;
        }

        public bool Delete(Guid id)
        {
            PdbBonusSalary item = _context.PdbBonusSalaries.SingleOrDefault(itemc => itemc.IDBS == id);
            _context.PdbBonusSalaries.DefaultIfEmpty(item);
            _context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
            return _context.SaveChanges() == 1;
        }

        public PdbBonusSalary GetSalary(Guid id)
        {
            return _context.PdbBonusSalaries.SingleOrDefault(item => item.IDBS == id);
        }
    }
}
