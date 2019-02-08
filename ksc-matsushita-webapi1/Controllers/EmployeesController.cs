using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ksc_matsushita_webapi1.Models;

namespace ksc_matsushita_webapi1.Controllers
{
    public class EmployeesController : ApiController
    {
        private NorthWindJDbContext db = new NorthWindJDbContext();

        // GET: api/Employees
        public IHttpActionResult GetEmployees()
        {
            //データを返すDataTableオブジェクトを生成
            var result = new EnterpriseService.DataTable();

            //列情報をColumnsにセット
            result.Columns = new EnterpriseService.DataTableColumn[] {
                new EnterpriseService.DataTableColumn { name = "EmployeeID", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "EmployeeNameKana", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "EmployeeName", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "BranchName", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "DepartmentName", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "BirthDate", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "HireDate", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "PostalCode", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "RegionID", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "Address1", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "Address2", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "Phone", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "Extension", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "PhotoPath", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "Profile", @class = "java.lang.String" }
            };

            //データを返すRowsを初期化
            result.Rows = new EnterpriseService.DataTableRows();
            //行位置を示すインデックスを初期化
            int idx = 0;
            //データを取得する変数を初期化
            var rows = new List<EnterpriseService.DataTableRowsRow>();
            //データを取得し、格納
            var data = db.Employees.AsEnumerable<Employee>();
            foreach (var d in data)
            {
                EnterpriseService.DataTableRowsRowCell[] cells = {
                    new EnterpriseService.DataTableRowsRowCell { index = "0", Value = d.EmployeeID.ToString() },
                    new EnterpriseService.DataTableRowsRowCell { index = "1", Value = d.EmployeeNameKana },
                    new EnterpriseService.DataTableRowsRowCell { index = "2", Value = d.EmployeeName },
                    new EnterpriseService.DataTableRowsRowCell { index = "3", Value = d.BranchName },
                    new EnterpriseService.DataTableRowsRowCell { index = "4", Value = d.DepartmentName },
                    new EnterpriseService.DataTableRowsRowCell { index = "5", Value = (d.BirthDate == null ? "" : d.BirthDate.ToString()) },
                    new EnterpriseService.DataTableRowsRowCell { index = "6", Value = (d.HireDate == null ? "" : d.HireDate.ToString()) },
                    new EnterpriseService.DataTableRowsRowCell { index = "7", Value = d.PostalCode },
                    new EnterpriseService.DataTableRowsRowCell { index = "8", Value = (d.RegionID == null ? "" : d.RegionID.ToString()) },
                    new EnterpriseService.DataTableRowsRowCell { index = "9", Value = d.Address1 },
                    new EnterpriseService.DataTableRowsRowCell { index = "10", Value = d.Address2 },
                    new EnterpriseService.DataTableRowsRowCell { index = "11", Value = d.Phone },
                    new EnterpriseService.DataTableRowsRowCell { index = "12", Value = d.Extension },
                    new EnterpriseService.DataTableRowsRowCell { index = "13", Value = d.PhotoPath },
                    new EnterpriseService.DataTableRowsRowCell { index = "14", Value = d.Profile }
                    };

                rows.Add(new EnterpriseService.DataTableRowsRow { index = idx.ToString(), Cell = cells });
                idx++;
            }
            result.Rows.Row = rows.ToArray<EnterpriseService.DataTableRowsRow>();
            //データ件数
            result.Rows.count = result.Rows.Row.Length.ToString();

            return Ok(result);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}