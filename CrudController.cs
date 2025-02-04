using CRUD_API.Models;
using CRUD_API.Models.BL;
using CRUD_API.Models.PL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRUD_API.Controllers
{
    public class CrudController : ApiController
    {
        
        BusinessLogic objbl = new BusinessLogic();
        SqlCon sql;
        Student st = new Student();

        [HttpGet]
        public DataTable GetData1()
        
        {
            DataTable dt = new DataTable();
            dt = objbl.GetData();
            return dt;
        }

        [HttpPost]
         public DataTable insertdata(Student st)
        {
            DataTable dt = new DataTable();
            dt = objbl.InsertData(st);
            return dt;

        }

        [HttpGet]
        public DataTable GetById(int StudentId)
        {
            DataTable dt = new DataTable();
            dt = objbl.GetId(StudentId);
            return dt;

        }

        [HttpPost]
        //[Route("api/UpdateStudent")]
        public DataTable UpdateStudent(Student st)
        {
            DataTable dt = new DataTable();
            dt = objbl.UpdateData(st) ;
            return dt;
        }

        [HttpGet]
        public DataTable delete(int StudentId)
        {
            DataTable dt = new DataTable();
            dt = objbl.DeleteData(StudentId);
            return dt;
        }

    }
}

