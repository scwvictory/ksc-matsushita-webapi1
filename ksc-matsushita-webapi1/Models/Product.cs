using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace ksc_matsushita_webapi1.Models
{
    /// <summary>
    /// 商品クラス
    /// </summary>
    public class Product
    {
        /// <summary>
        /// 商品コード
        /// </summary>
        [Key]
        public int ProductID { get; set; }
        /// <summary>
        /// フリガナ
        /// </summary>
        [StringLength(80)]
        public string ProductNameKana { get; set; }
        /// <summary>
        /// 商品名
        /// </summary>
        [Required, StringLength(40)]
        public string ProductName { get; set; }
        /// <summary>
        /// 仕入先コード
        /// </summary>
        public int? SupplierID { get; set; }
        /// <summary>
        /// 商品区分コード
        /// </summary>
        public int? ProductCategoryID { get; set; }
        /// <summary>
        /// 梱包単位
        /// </summary>
        [StringLength(20)]
        public string QuantityPerUnit { get; set; }
        /// <summary>
        /// 単価
        /// </summary>
        [DataType(DataType.Currency)]
        public int UnitPrice { get; set; }
        /// <summary>
        /// 在庫
        /// </summary>
        public int UnitsInStock { get; set; }
        /// <summary>
        /// 発注済
        /// </summary>
        public int UnitsOnOrder { get; set; }
        /// <summary>
        /// 発注点
        /// </summary>
        public int ReorderLevel { get; set; }
        /// <summary>
        /// 生産中止
        /// </summary>
        [Required]
        public bool Discontinued { get; set; }

        ///// <summary>
        ///// 仕入先(外部キー)
        ///// </summary>
        //[ForeignKey("SupplierID"), JsonIgnore, XmlIgnore]
        //public virtual Supplier Supplier { get; set; }
        ///// <summary>
        ///// 商品区分(外部キー)
        ///// </summary>
        //[ForeignKey("ProductCategoryID"), JsonIgnore, XmlIgnore]
        //public virtual ProductCategory ProductCategory { get; set; }
    }
}