using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLibrary.Models;
using DataLibrary.DataAccessLayer;



namespace DataLibrary.BusinessLogic
{
    public static class EmployeeLogicDataProcess
    {
        public static int CreateEmployee(int employeeid, string firstname, string lastname, string emailaddress)
        {
            EmployeeModel data = new EmployeeModel 
            {
            
                EmployeeId = employeeid,
               FirstName = firstname,
               LastName = lastname,
               EmailAddress = emailaddress
            };
            string sql = @"insert into  dbo.Employee(EmployeeId , FirstName,LastName,EmailAddress )
            Values (@EmployeeId,@FirstName,@LastName,@EmailAddress); ";

            return SqlDataAcsess.SaveData(sql, data);
        }
       
        public static List<EmployeeModel> LoadEmployess()
            {
            string sql = @"select Id,EmployeeId,FirstName,LastName,EmailAddress from dbo.Employee;";

            return SqlDataAcsess.LoadData<EmployeeModel>(sql);
        }

    }
        
}

