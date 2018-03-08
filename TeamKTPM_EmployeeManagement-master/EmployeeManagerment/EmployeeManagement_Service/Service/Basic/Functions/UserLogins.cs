using EmployeeManagement_Service.Service.Basic.Notification;
using EmployeeManagement_Service.ModelDBContext;
using EmployeeManagement_Service.Service.Module;

namespace EmployeeManagement_Service.Service.Basic.Functions
{
    public class UserLogins
    {
        ErrorNotification Error;
        SuccessfulNotification Successful;
        Accounts AccountService;

        public UserLogins()
        {
            Error = new ErrorNotification();
            Successful = new SuccessfulNotification();
            EmployeeManagementDBContext context = new EmployeeManagementDBContext();
            AccountService = new Accounts(context);
        }

        public PdbAccount CheckLogin(string username, string password, string department)
        {
            if (username == "" || password == "" || department == "")
            {
                if (username == "")
                {
                    Error.UsernameRequired();
                    return null;
                }
                else if (password == "")
                {
                    Error.PasswordRequired();
                    return null;
                }
                else
                {
                    Error.DepartmentRequired();
                    return null;
                }
            }
            else
            {
                try
                {
                    PdbAccount ac = new PdbAccount();
                    ac = AccountService.GetAccountwithUPD(username, password, department);
                    bool checkauthentication = ac.isActive;
                    if (checkauthentication)
                    {
                        Successful.LoginSuccessful();
                        return ac;
                    }
                    else
                    {
                        Error.LockedAccount();
                        return null;
                    }
                }
                catch
                {
                    return null;
                }                
            }
        }
    }
}
