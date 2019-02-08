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
    public class ProductCategoriesController : ApiController
    {
        private NorthWindJDbContext db = new NorthWindJDbContext();

        // GET: api/ProductCategories
        public IHttpActionResult GetProductCategories()
        {
            //データを返すDataTableオブジェクトを生成
            var result = new EnterpriseService.DataTable();

            //列情報をColumnsにセット
            result.Columns = new EnterpriseService.DataTableColumn[] {
                new EnterpriseService.DataTableColumn { name = "ProductCategoryID", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "ProductCategoryName", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "Description", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "Picture", @class = "java.lang.String" }
            };

            //データを返すRowsを初期化
            result.Rows = new EnterpriseService.DataTableRows();
            //行位置を示すインデックスを初期化
            int idx = 0;
            //データを取得する変数を初期化
            var rows = new List<EnterpriseService.DataTableRowsRow>();
            //データを取得し、格納
            var data = db.ProductCategories.AsEnumerable<ProductCategory>();
            foreach (var d in data)
            {
                EnterpriseService.DataTableRowsRowCell[] cells = {
                    new EnterpriseService.DataTableRowsRowCell { index = "0", Value = d.ProductCategoryID.ToString() },
                    new EnterpriseService.DataTableRowsRowCell { index = "1", Value = d.ProductCategoryName },
                    new EnterpriseService.DataTableRowsRowCell { index = "2", Value = d.Description },
                    new EnterpriseService.DataTableRowsRowCell { index = "3", Value = (d.Picture == null ? "" :  d.Picture.ToString()) }
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