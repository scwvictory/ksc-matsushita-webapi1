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
    public class ShippersController : ApiController
    {
        private NorthWindJDbContext db = new NorthWindJDbContext();

        // GET: api/Shippers
        public IHttpActionResult GetShippers()
        {
            //データを返すDataTableオブジェクトを生成
            var result = new EnterpriseService.DataTable();

            //列情報をColumnsにセット
            result.Columns = new EnterpriseService.DataTableColumn[] {
                new EnterpriseService.DataTableColumn { name = "ShipperID", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "CompanyName", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "Phone", @class = "java.lang.String" }
            };

            //データを返すRowsを初期化
            result.Rows = new EnterpriseService.DataTableRows();
            //行位置を示すインデックスを初期化
            int idx = 0;
            //データを取得する変数を初期化
            var rows = new List<EnterpriseService.DataTableRowsRow>();
            //データを取得し、格納
            var data = db.Shippers.AsEnumerable<Shipper>();
            foreach (var d in data)
            {
                EnterpriseService.DataTableRowsRowCell[] cells = {
                    new EnterpriseService.DataTableRowsRowCell { index = "0", Value = d.ShipperID.ToString() },
                    new EnterpriseService.DataTableRowsRowCell { index = "1", Value = d.CompanyName },
                    new EnterpriseService.DataTableRowsRowCell { index = "2", Value = d.Phone }
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