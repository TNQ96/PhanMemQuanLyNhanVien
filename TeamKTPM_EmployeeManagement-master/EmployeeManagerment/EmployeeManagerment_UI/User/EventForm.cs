using System;
using EmployeeManagement_Service.ModelDBContext;
using EmployeeManagement_Service.Service.Basic;
using EmployeeManagement_Service.Service.Module;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

namespace EmployeeManagerment_UI.User
{
    public partial class EventForm : Form
    {
        int index;
        EmployeeManagementDBContext _context;
        Guid _id;

        public EventForm(EmployeeManagementDBContext context)
        {
            this._context = context;

        }

        public EventForm()
        {
            InitializeComponent();
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            _context = new EmployeeManagementDBContext();
            try
            {
                GetAllData();
            }
            catch
            {
                new EmployeeManagement_Service.Service.Basic.Notification.ErrorNotification() { }.ErrorWhileRefreshData();
            }
        }

        private void GetAllData()
        {
            try
            {
                grid_listevent.DataSource = new EmployeeManagement_Service.Service.Module.Events(new EmployeeManagementDBContext()) { }.EventsAll();
            }
            catch
            {
                new EmployeeManagement_Service.Service.Basic.Notification.ErrorNotification() { }.ErrorWhileRefreshData();
            }
        }

        private void btn_backevent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addevent_Click(object sender, EventArgs e)
        {
            AddEvent();
        }

        private void AddEvent()
        {
            PdbEvent eve = new PdbEvent();
            try
            {
                eve = GetInfomation();
                new EmployeeManagement_Service.Service.Module.Events(new EmployeeManagementDBContext()) { }.Add(eve);
                new EmployeeManagement_Service.Service.Basic.Notification.SuccessfulNotification() { }.InsertSuccessful();
            }
            catch
            {
                new EmployeeManagement_Service.Service.Basic.Notification.ErrorNotification() { }.ErrorWhileInsert();
            }
            finally
            {
                GetAllData();
            }
        }

        private void EditEvent()
        {
            PdbEvent eve = new Events(_context) { }.GetEvent(_id);
            eve = GetInfomationforEdit(eve);
            try
            {
                new Events(_context) { }.Edit(eve);
                new EmployeeManagement_Service.Service.Basic.Notification.SuccessfulNotification() { }.UpdateSuccessful();
            }
            catch
            {
                new EmployeeManagement_Service.Service.Basic.Notification.ErrorNotification() { }.ErrorWhileEdit();
                //throw new Exception();
            }
            finally
            {
                GetAllData();
            }
        }
        private PdbEvent GetInfomationforEdit(PdbEvent eve)
        {
            eve.EventName = txt_eventname.Text;
            eve.CostsAwarded = Convert.ToDecimal(txt_costawarded.Text);
            eve.ExpectedCost = Convert.ToDecimal(txt_expectedcost.Text);
            eve.ActualCosts = Convert.ToDecimal(txt_actualcost.Text);
            eve.Scale = txt_scale.Text;
            eve.Location = txt_location.Text;
            eve.DateStart = dtp_datestart.Value;
            eve.DateEnd = dtp_dateend.Value;
            eve.TravelBy = txt_travelby.Text;
            eve.EventContent = rtxt_eventcontent.Text;
            eve.Money_Staff_Pay = Convert.ToDecimal(txt_moneystaffpay.Text);
            return eve;
        }

        private PdbEvent GetInfomation()
        {
            PdbEvent eve = new PdbEvent();
            eve.ID_Event = Guid.NewGuid();
            eve.EventName = txt_eventname.Text;
            eve.CostsAwarded = Convert.ToDecimal(txt_costawarded.Text);
            eve.ExpectedCost = Convert.ToDecimal(txt_expectedcost.Text);
            eve.ActualCosts = Convert.ToDecimal(txt_actualcost.Text);
            eve.Scale = txt_scale.Text;
            eve.Location = txt_location.Text;
            eve.DateStart = dtp_datestart.Value;
            eve.DateEnd = dtp_dateend.Value;
            eve.TravelBy = txt_travelby.Text;
            eve.EventContent = rtxt_eventcontent.Text;
            eve.Money_Staff_Pay = Convert.ToDecimal(txt_moneystaffpay.Text);
            return eve;
        }

        private void btn_reloadevent_Click(object sender, EventArgs e)
        {
            GetAllData();
        }

        private void btn_deleteevent_Click(object sender, EventArgs e)
        {
            DeleteEvent();
        }

        private void DeleteEvent()
        {
            try
            {
                new EmployeeManagement_Service.Service.Module.Events(new EmployeeManagementDBContext()) { }.Delete(_id);
                new EmployeeManagement_Service.Service.Basic.Notification.SuccessfulNotification() { }.DeleteSuccessful();
            }
            catch
            {
                new EmployeeManagement_Service.Service.Basic.Notification.ErrorNotification() { }.ErrorWhileDelete();
            }
            finally
            {
                GetAllData();
            }
        }

        private void grid_listevent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = grid_listevent.CurrentCell.RowIndex;
            _id = (Guid)grid_listevent.Rows[index].Cells[0].Value;
            txt_eventname.Text = grid_listevent.Rows[index].Cells[1].Value.ToString().Trim();
            txt_expectedcost.Text = grid_listevent.Rows[index].Cells[2].Value.ToString().Trim();
            txt_costawarded.Text = grid_listevent.Rows[index].Cells[3].Value.ToString().Trim();
            txt_actualcost.Text = grid_listevent.Rows[index].Cells[4].Value.ToString().Trim();
            dtp_datestart.Value = (DateTime)grid_listevent.Rows[index].Cells[5].Value;
            dtp_dateend.Value = (DateTime)grid_listevent.Rows[index].Cells[6].Value;
            txt_location.Text = grid_listevent.Rows[index].Cells[7].Value.ToString().Trim();
            txt_scale.Text = grid_listevent.Rows[index].Cells[8].Value.ToString().Trim();
            rtxt_eventcontent.Text = grid_listevent.Rows[index].Cells[9].Value.ToString().Trim();
            txt_travelby.Text = grid_listevent.Rows[index].Cells[10].Value.ToString().Trim();
            try
            {
                txt_moneystaffpay.Text = grid_listevent.Rows[index].Cells[11].Value.ToString().Trim();
            }
            catch 
            {

            }
            
        }

        private void btn_editevent_Click(object sender, EventArgs e)
        {
            EditEvent();
        }
    }
}
