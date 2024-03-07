using Casting___OperatorOverloading___Indexer.Helpers.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting___OperatorOverloading___Indexer.Services.Interfaces
{
    public interface IEmployeeServices
    {

        Employee[] GetAll();
        EmployeeResponse GetById(Employee[] employees, int? id);

        EmployeeResponse[]  Search(Employee[] employees, string str);
    }
}
