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
    public class RegionsController : ApiController
    {
        private NorthWindJDbContext db = new NorthWindJDbContext();

        public IHttpActionResult GetRegions()
        {
            //データを返すDataTableオブジェクトを生成
            var result = new EnterpriseService.DataTable();

            //列情報をColumnsにセット
            result.Columns = new EnterpriseService.DataTableColumn[] {
                new EnterpriseService.DataTableColumn { name = "RegionID", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "RegionName", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "RegionNameKana", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "RegionNameE", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "AreaName", @class = "java.lang.String" },
                new EnterpriseService.DataTableColumn { name = "AreaNameE", @class = "java.lang.String" }
            };

            //データを返すRowsを初期化
            result.Rows = new EnterpriseService.DataTableRows();
            //行位置を示すインデックスを初期化
            int idx = 0;
            //データを取得する変数を初期化
            var rows = new List<EnterpriseService.DataTableRowsRow>();
            //データを取得し、格納
            var data = db.Regions.AsEnumerable<Region>();
            foreach(var d in data)
            {
                EnterpriseService.DataTableRowsRowCell[] cells = {
                    new EnterpriseService.DataTableRowsRowCell { index = "0", Value = d.RegionID.ToString() },
                    new EnterpriseService.DataTableRowsRowCell { index = "1", Value = d.RegionName },
                    new EnterpriseService.DataTableRowsRowCell { index = "2", Value = d.RegionNameKana },
                    new EnterpriseService.DataTableRowsRowCell { index = "3", Value = d.RegionNameE },
                    new EnterpriseService.DataTableRowsRowCell { index = "4", Value = d.AreaName },
                    new EnterpriseService.DataTableRowsRowCell { index = "5", Value = d.AreaNameE }
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