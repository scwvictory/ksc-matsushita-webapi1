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
    public class CustomersController : ApiController
    {
        private NorthWindJDbContext db = new NorthWindJDbContext();

        // GET: api/Customers
        public IHttpActionResult GetCustomers()
        {
            //データを返すDataTableオブジェクトを生成
            var result = new EnterpriseService.DataTable();

            //列情報をColumnsにセット
            result.Columns = new EnterpriseService.DataTableColumn[] {
                new EnterpriseService.DataTableColumn { name = "CustomerID", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "CompanyNameKana", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "CompanyName", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "ContactName", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "ContactDepartment", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "PostalCode", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "RegionId", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "Address1", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "Address2", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "Phone", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "Fax", @class = "java.lang.String" }
            };

            //データを返すRowsを初期化
            result.Rows = new EnterpriseService.DataTableRows();
            //行位置を示すインデックスを初期化
            int idx = 0;
            //データを取得する変数を初期化
            var rows = new List<EnterpriseService.DataTableRowsRow>();
            //データを取得し、格納
            var data = db.Customers.AsEnumerable<Customer>();
            foreach (var d in data)
            {
                EnterpriseService.DataTableRowsRowCell[] cells = {
                    new EnterpriseService.DataTableRowsRowCell { index = "0", Value = d.CustomerID.ToString() },
                    new EnterpriseService.DataTableRowsRowCell { index = "1", Value = d.CompanyNameKana },
                    new EnterpriseService.DataTableRowsRowCell { index = "2", Value = d.CompanyName },
                    new EnterpriseService.DataTableRowsRowCell { index = "3", Value = d.ContactName },
                    new EnterpriseService.DataTableRowsRowCell { index = "4", Value = d.ContactDepartment },
                    new EnterpriseService.DataTableRowsRowCell { index = "5", Value = d.PostalCode },
                    new EnterpriseService.DataTableRowsRowCell { index = "6", Value = (d.RegionId == null ? "" : d.RegionId.ToString()) },
                    new EnterpriseService.DataTableRowsRowCell { index = "7", Value = d.Address1 },
                    new EnterpriseService.DataTableRowsRowCell { index = "8", Value = d.Address2 },
                    new EnterpriseService.DataTableRowsRowCell { index = "9", Value = d.Phone },
                    new EnterpriseService.DataTableRowsRowCell { index = "10", Value = d.Fax }
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