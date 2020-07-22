using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;

namespace WebApplication1.Controllers
{
    public class CRUDController : ApiController
    {
        private static CRUDEntities crud = new CRUDEntities();

        /// <summary>
        /// Get All Employee Details
        /// </summary>
        /// <returns></returns>
        [ResponseType(typeof(IEnumerable<Employee>))]
        [System.Web.Http.Route("api/GetEmployees")]
        [System.Web.Http.HttpGet]
        public HttpResponseMessage GetEmployees()
        {
            var result = crud.Employees.ToList();
            return GetResultResponse(result);
        }

        /// <summary>
        /// Get Employee Details
        /// </summary>
        /// <remarks>
        /// Get Employee Details based on empid
        /// </remarks>
        /// <param name="employeeid"></param>
        /// <returns></returns>
        [ResponseType(typeof(IEnumerable<Employee>))]
        [System.Web.Http.Route("api/GetEmployee")]
        [System.Web.Http.HttpGet]
        public HttpResponseMessage GetEmployee(int employeeid)
        {
            var result = crud.Employees.Where(a => a.ID == employeeid).ToList();
            return GetResultResponse(result);
        }
        /// <summary>
        /// Add new employee
        /// </summary>
        /// <remarks>
        /// Create new employee and return inserted employee details
        /// </remarks>
        /// <param name="employee"></param>
        /// <returns></returns>
        [ResponseType(typeof(IEnumerable<Employee>))]
        [System.Web.Http.Route("api/AddEmployee")]
        [System.Web.Http.HttpPost]
        public HttpResponseMessage AddEmployee(Employee employee)
        {
            var result = crud.Employees.Add(employee);
            crud.SaveChanges();
            return GetResultResponse(result);
        }
        /// <summary>
        /// Update Employee Details
        /// </summary>
        /// <remarks>
        /// Update Employee Details Based on empid
        /// </remarks>
        /// <param name="employee"></param>
        /// <returns></returns>
        [ResponseType(typeof(IEnumerable<Employee>))]
        [System.Web.Http.Route("api/UpdateEmployee")]
        [System.Web.Http.HttpPut]
        public HttpResponseMessage UpdateEmployee(Employee employee)
        {
            Employee result = crud.Employees.Where(a => a.ID == employee.ID).FirstOrDefault();
            if (result != null)
            {
                result.FullName = employee.FullName;
                result.Designation = employee.Designation;
                result.Phone = employee.Phone;
                result.Designation = employee.Designation;
                result.Email = employee.Email;
                crud.Entry(result).State = EntityState.Modified;
                crud.SaveChanges();
            }
            return GetResultResponse(result);
        }
        /// <summary>
        /// Delete Employee
        /// </summary>
        /// <remarks>
        /// Delete Employee record based on empid
        /// </remarks>
        /// <param name="employee"></param>
        /// <returns></returns>
        [ResponseType(typeof(IEnumerable<Employee>))]
        [System.Web.Http.Route("api/DeleteEmployee")]
        [System.Web.Http.HttpDelete]
        public void DeleteEmployee(Employee employee)
        {
            Employee result = crud.Employees.Where(a => a.ID == employee.ID).FirstOrDefault();
            if (result != null)
            {
                crud.Entry(result).State = EntityState.Deleted;
                crud.SaveChanges();
            }

        }


        /// <summary>
        /// Get Response for Each result
        /// </summary>
        /// <param name="Result"></param>
        /// <returns></returns>
        public HttpResponseMessage GetResultResponse(object Result)
        {
            HttpResponseMessage response = null;
            try
            {
                response = Request.CreateResponse(HttpStatusCode.OK, Result);

            }
            catch (Exception ex)
            {
                response = Request.CreateResponse(HttpStatusCode.BadRequest, Result);
            }
            return response;
        }
    }
}