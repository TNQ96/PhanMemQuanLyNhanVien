using System;
using System.Collections.Generic;
using EmployeeManagement_Service.ModelDBContext;
using System.Linq;

namespace EmployeeManagement_Service.Service.Module
{
    public class Supplies
    {
        private readonly EmployeeManagementDBContext _context;

        public Supplies(EmployeeManagementDBContext context)
        {
            this._context = context;
        }

        public IEnumerable<PdbSupply> SupplyAll()
        {
            return _context.PdbSupplies;
        }

        public bool Add(PdbSupply item)
        {
            _context.PdbSupplies.Add(item);
            _context.Entry(item).State = System.Data.Entity.EntityState.Added;
            return _context.SaveChanges() == 1;
        }

        public bool Edit(PdbSupply item)
        {
            _context.PdbSupplies.Attach(item);
            _context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            return _context.SaveChanges() == 1;
        }

        public bool Delete(Guid id)
        {
            PdbSupply item = _context.PdbSupplies.SingleOrDefault(itemc => itemc.IDSupplies == id);
            _context.PdbSupplies.DefaultIfEmpty(item);
            _context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
            return _context.SaveChanges() == 1;
        }

        public PdbSupply GetEvent(Guid id)
        {
            return _context.PdbSupplies.SingleOrDefault(item => item.IDSupplies == id);
        }
    }
}
