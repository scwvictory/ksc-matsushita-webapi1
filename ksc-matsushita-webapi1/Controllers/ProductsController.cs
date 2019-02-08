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
    public class ProductsController : ApiController
    {
        private NorthWindJDbContext db = new NorthWindJDbContext();

        // GET: api/Products
        public IHttpActionResult GetProducts()
        {
            //データを返すDataTableオブジェクトを生成
            var result = new EnterpriseService.DataTable();

            //列情報をColumnsにセット
            result.Columns = new EnterpriseService.DataTableColumn[] {
                new EnterpriseService.DataTableColumn { name = "ProductID", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "ProductNameKana", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "ProductName", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "SupplierID", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "ProductCategoryID", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "QuantityPerUnit", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "UnitPrice", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "UnitsInStock", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "UnitsOnOrder", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "ReorderLevel", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "Discontinued", @class = "java.lang.String" }
            };

            //データを返すRowsを初期化
            result.Rows = new EnterpriseService.DataTableRows();
            //行位置を示すインデックスを初期化
            int idx = 0;
            //データを取得する変数を初期化
            var rows = new List<EnterpriseService.DataTableRowsRow>();
            //データを取得し、格納
            var data = db.Products.AsEnumerable<Product>();
            foreach (var d in data)
            {
                EnterpriseService.DataTableRowsRowCell[] cells = {
                    new EnterpriseService.DataTableRowsRowCell { index = "0", Value = d.ProductID.ToString() },
                    new EnterpriseService.DataTableRowsRowCell { index = "1", Value = d.ProductNameKana },
                    new EnterpriseService.DataTableRowsRowCell { index = "2", Value = d.ProductName },
                    new EnterpriseService.DataTableRowsRowCell { index = "3", Value = (d.SupplierID == null ? "" : d.SupplierID.ToString()) },
                    new EnterpriseService.DataTableRowsRowCell { index = "4", Value = (d.ProductCategoryID == null ? "" : d.ProductCategoryID.ToString()) },
                    new EnterpriseService.DataTableRowsRowCell { index = "5", Value = d.QuantityPerUnit },
                    new EnterpriseService.DataTableRowsRowCell { index = "6", Value = d.UnitPrice.ToString() },
                    new EnterpriseService.DataTableRowsRowCell { index = "7", Value = d.UnitsInStock.ToString() },
                    new EnterpriseService.DataTableRowsRowCell { index = "8", Value = d.UnitsOnOrder.ToString() },
                    new EnterpriseService.DataTableRowsRowCell { index = "9", Value = d.ReorderLevel.ToString() },
                    new EnterpriseService.DataTableRowsRowCell { index = "10", Value = d.Discontinued.ToString() }
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