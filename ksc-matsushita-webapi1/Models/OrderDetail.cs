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
    /// 受注明細
    /// </summary>
    public class OrderDetail
    {
        /// <summary>
        /// 受注コード
        /// </summary>
        [Key, Column(Order = 1)]
        public int OrderID { get; set; }
        /// <summary>
        /// 明細番号
        /// </summary>
        [Key, Column(Order = 2)]
        public int DetailNo { get; set; }
        /// <summary>
        /// 商品コード
        /// </summary>
        [Required]
        public int ProductID { get; set; }
        /// <summary>
        /// 単価
        /// </summary>
        [Required, DataType(DataType.Currency)]
        public int UnitPrice { get; set; }
        /// <summary>
        /// 数量
        /// </summary>
        [Required]
        public int Quantity { get; set; }
        /// <summary>
        /// 割引
        /// </summary>
        [Required, Range(0,1)]
        public float Discount { get; set; }

        ///// <summary>
        ///// 受注(外部キー)
        ///// </summary>
        //[ForeignKey("OrderID"), JsonIgnore, XmlIgnore]
        //public virtual Order Order { get; set; }
        ///// <summary>
        ///// 商品(外部キー)
        ///// </summary>
        //[ForeignKey("ProductID"), JsonIgnore, XmlIgnore]
        //public virtual Product Product { get; set; }
    }
}