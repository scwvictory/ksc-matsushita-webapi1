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
    public class OrdersController : ApiController
    {
        private NorthWindJDbContext db = new NorthWindJDbContext();

        // GET: api/Orders
        public IHttpActionResult GetOrders()
        {
            //データを返すDataTableオブジェクトを生成
            var result = new EnterpriseService.DataTable();

            //列情報をColumnsにセット
            result.Columns = new EnterpriseService.DataTableColumn[] {
                new EnterpriseService.DataTableColumn { name = "OrderID", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "CustomerID", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "EmployeeID", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "ShipName", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "ShipPostalCode", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "ShipRegionID", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "ShipAddress1", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "ShipAddress2", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "ShipperID", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "OrderDate", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "RequiredDate", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "ShippedDate", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "ShipVia", @class = "java.lang.String" }
            };

            //データを返すRowsを初期化
            result.Rows = new EnterpriseService.DataTableRows();
            //行位置を示すインデックスを初期化
            int idx = 0;
            //データを取得する変数を初期化
            var rows = new List<EnterpriseService.DataTableRowsRow>();
            //データを取得し、格納
            var data = db.Orders.AsEnumerable<Order>();
            foreach (var d in data)
            {
                EnterpriseService.DataTableRowsRowCell[] cells = {
                    new EnterpriseService.DataTableRowsRowCell { index = "0", Value = d.OrderID.ToString() },
                    new EnterpriseService.DataTableRowsRowCell { index = "1", Value = (d.CustomerID == null ? "" : d.CustomerID.ToString()) },
                    new EnterpriseService.DataTableRowsRowCell { index = "2", Value = (d.EmployeeID == null ? "" : d.EmployeeID.ToString()) },
                    new EnterpriseService.DataTableRowsRowCell { index = "3", Value = d.ShipName },
                    new EnterpriseService.DataTableRowsRowCell { index = "4", Value = d.ShipPostalCode },
                    new EnterpriseService.DataTableRowsRowCell { index = "5", Value = (d.ShipRegionID == null ? "" : d.ShipRegionID.ToString()) },
                    new EnterpriseService.DataTableRowsRowCell { index = "6", Value = d.ShipAddress1 },
                    new EnterpriseService.DataTableRowsRowCell { index = "7", Value = d.ShipAddress2 },
                    new EnterpriseService.DataTableRowsRowCell { index = "8", Value = (d.ShipperID == null ? "" : d.ShipperID.ToString()) },
                    new EnterpriseService.DataTableRowsRowCell { index = "9", Value = (d.OrderDate == null ? "" : d.OrderDate.ToString()) },
                    new EnterpriseService.DataTableRowsRowCell { index = "10", Value = (d.RequiredDate == null ? "" : d.RequiredDate.ToString()) },
                    new EnterpriseService.DataTableRowsRowCell { index = "11", Value = (d.ShippedDate == null ? "" : d.ShippedDate.ToString()) },
                    new EnterpriseService.DataTableRowsRowCell { index = "12", Value = d.ShipVia.ToString() }
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