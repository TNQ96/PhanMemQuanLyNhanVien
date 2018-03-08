using System;
using System.Collections.Generic;
using System.Linq;
using EmployeeManagement_Service.ModelDBContext;
using EmployeeManagement_Service.Service.Module;

namespace EmployeeManagement_Service.Service.Module
{
    public class FeedBacks
    {
        private readonly EmployeeManagementDBContext _context;

        public FeedBacks(EmployeeManagementDBContext context)
        {
            this._context = context;
        }

        public IEnumerable<PdbFeedBack> EventsAll()
        {
            return _context.PdbFeedBacks;
        }

        public bool Add(PdbFeedBack item)
        {
            _context.PdbFeedBacks.Add(item);
            _context.Entry(item).State = System.Data.Entity.EntityState.Added;
            return _context.SaveChanges() == 1;
        }

        public bool Edit(PdbFeedBack item)
        {
            _context.PdbFeedBacks.Attach(item);
            _context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            return _context.SaveChanges() == 1;
        }

        public bool Delete(Guid id)
        {
            PdbFeedBack item = _context.PdbFeedBacks.SingleOrDefault(itemc => itemc.IDFeedBack == id);
            _context.PdbFeedBacks.DefaultIfEmpty(item);
            _context.Entry(item).State = System.Data.Entity.EntityState.Deleted;
            return _context.SaveChanges() == 1;
        }

        public PdbFeedBack GetEvent(Guid id)
        {
            return _context.PdbFeedBacks.SingleOrDefault(item => item.IDFeedBack == id);
        }
    }
}
