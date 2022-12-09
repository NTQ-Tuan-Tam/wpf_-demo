using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMVVM.Models
{
    public class EmployeeSevice
    {
        private static List<Employee> ObjEmployeesList;
        public EmployeeSevice()
        {
            ObjEmployeesList = new List<Employee>()
            {
                new Employee{ Id = 1, Name = "tuantam", Age = 12}
            };

        }
        public List<Employee> GetALL()
        {
            return ObjEmployeesList;
        }
        public bool Add(Employee objNewEmployee)
        {
            // 12<Age<58
            if (objNewEmployee.Age < 21 || objNewEmployee.Age > 58)
                throw new ArgumentException("Invalid age limid for Employee");
           
            ObjEmployeesList.Add(objNewEmployee);
            return true;
        }


        //---Update
        public bool Update(Employee objEmployeeToUpdate)
        {
            bool IsUpdate = false;
            for(int index = 0; index < ObjEmployeesList.Count; index ++)
            {
                if (ObjEmployeesList[index].Id == objEmployeeToUpdate.Id)
                {
                    ObjEmployeesList[index].Name = objEmployeeToUpdate.Name;
                    ObjEmployeesList[index].Age = objEmployeeToUpdate.Age;
                    IsUpdate = true;
                    break;
                }
            }
            return IsUpdate;
        }
        //delete
        public bool Delete(int id)
        {
            bool IsDeleted = false;
            for(int index = 0 ; index<ObjEmployeesList.Count; index++)
            {
                if (ObjEmployeesList[index].Id == id)
                {
                    ObjEmployeesList.RemoveAt(index);
                    IsDeleted = true;
                    break;
                }
            }
            return IsDeleted;
        }

        //search
        public Employee Search(int id)
        {
            return ObjEmployeesList.FirstOrDefault(e => e.Id == id);
        }
    }
}
