using System;
using System.Collections.Generic;
using EmployeeManagement_Service.ModelDBContext;
using System.Linq;

namespace EmployeeManagement_Service.Service.Module
{
    public class Staffs
    {
        private readonly EmployeeManagementDBContext _context;

        public Staffs(EmployeeManagementDBContext context)
        {
            this._context = context;
        }

        public bool Create(PdbStaff staff)
        {
            this._context.PdbStaffs.Add(staff);
            this._context.Entry(staff).State = System.Data.Entity.EntityState.Added;
            return _context.SaveChanges() == 1;
        }

        public bool Update(PdbStaff staff)
        {
            _context.PdbStaffs.Attach(staff);
            _context.Entry(staff).State = System.Data.Entity.EntityState.Modified;
            return _context.SaveChanges() == 1;
        }

        public bool Delete(Guid id)
        {
            PdbStaff staff = _context.PdbStaffs.SingleOrDefault(admin => admin.ID_Staff == id);
            _context.PdbStaffs.DefaultIfEmpty(staff);
            _context.Entry(staff).State = System.Data.Entity.EntityState.Deleted;
            return _context.SaveChanges() == 1;
        }

        public List<PdbStaff> GetAllStaff()
        {
            return this._context.PdbStaffs.ToList<PdbStaff>();
        }

        public PdbStaff GetStaff(Guid id)
        {
            return _context.PdbStaffs.SingleOrDefault(ad => ad.ID_Staff == id);
        }

        public List<PdbStaff> GetStaffwithDepPos(string department, string position)
        {
            List<PdbStaff> listdepartment = this._context.PdbStaffs.Where(item => item.Department == department).ToList<PdbStaff>();
            List<PdbStaff> listposition = listdepartment.Where(item => item.Position == position).ToList<PdbStaff>();
            return listposition;
        }

        public List<PdbStaff> GetStaffwithPosition(string posi, string depar)
        {
            List<PdbStaff> list = GetAllStaff();
            List<PdbStaff> listresult = list.Where(item => item.Department == depar).Where(item => item.Position == posi).ToList<PdbStaff>();

            return listresult;
        }

    }
}
