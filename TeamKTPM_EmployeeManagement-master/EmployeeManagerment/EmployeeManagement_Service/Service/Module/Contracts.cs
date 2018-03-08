using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeManagement_Service.ModelDBContext;
using EmployeeManagement_Service.Service.Module;

namespace EmployeeManagement_Service.Service.Module
{
    public class Contracts
    {
        private readonly EmployeeManagementDBContext _context;

        public Contracts(EmployeeManagementDBContext context)
        {
            this._context = context;
        }

        public List<PdbContract> ContractsAll()
        {
            return _context.PdbContracts.ToList<PdbContract>();
        }

        public bool Add(PdbContract item)
        {
            _context.PdbContracts.Add(item);
            _context.Entry(item).State = System.Data.Entity.EntityState.Added;
            return _context.SaveChanges() == 1;
        }

        public bool Edit(PdbContract item)
        {
            _context.PdbContracts.Attach(item);
            _context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            return _context.SaveChanges() == 1;
        }

        public bool Delete(Guid id)
        {
            PdbContract item = _context.PdbContracts.SingleOrDefault(itemc => itemc.IDContract == id);
            _context.PdbContracts.DefaultIfEmpty(item);
            _context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
            return _context.SaveChanges() == 1;
        }

        public PdbContract GetContract(Guid id)
        {
            return _context.PdbContracts.SingleOrDefault(item => item.IDContract == id);
        }
    }
}
