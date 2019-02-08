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
    /// 受注クラス
    /// </summary>
    public class Order
    {
        /// <summary>
        /// 受注コード
        /// </summary>
        [Key]
        public int OrderID { get; set; }
        /// <summary>
        /// 得意先コード
        /// </summary>
        public int? CustomerID { get; set; }
        /// <summary>
        /// 社員コード
        /// </summary>
        public int? EmployeeID { get; set; }
        /// <summary>
        /// 出荷先名
        /// </summary>
        [StringLength(40)]
        public string ShipName { get; set; }
        /// <summary>
        /// 出荷先郵便番号
        /// </summary>
        [StringLength(10), DataType(DataType.PostalCode)]
        public string ShipPostalCode { get; set; }
        /// <summary>
        /// 出荷先都道府県コード
        /// </summary>
        public int? ShipRegionID { get; set; }
        /// <summary>
        /// 出荷先住所1
        /// </summary>
        [StringLength(60)]
        public string ShipAddress1 { get; set; }
        /// <summary>
        /// 出荷先住所2
        /// </summary>
        [StringLength(60)]
        public string ShipAddress2 { get; set; }
		/// <summary>
		/// 運送区分
		/// </summary>
		public int? ShipperID { get; set; }
        /// <summary>
        /// 受注日
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime? OrderDate { get; set; }
        /// <summary>
        /// 締切日
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime? RequiredDate { get; set; }
        /// <summary>
        /// 出荷日
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime? ShippedDate { get; set; }
        /// <summary>
        /// 運送料
        /// </summary>
        [DataType(DataType.Currency)]
        public int ShipVia { get; set; }

        /// <summary>
        /// 得意先(外部キー)
        /// </summary>
        [ForeignKey("CustomerID"), JsonIgnore, XmlIgnore]
        public virtual Customer Customer { get; set; }
        /// <summary>
        /// 社員(外部キー)
        /// </summary>
        [ForeignKey("EmployeeID"), JsonIgnore, XmlIgnore]
        public virtual Employee Employee { get; set; }
        /// <summary>
        /// 運送会社(外部キー)
        /// </summary>
        [ForeignKey("ShipperID"), JsonIgnore, XmlIgnore]
        public virtual Shipper Shipper { get; set; }
        /// <summary>
        /// 出荷先都道府県(外部キー)
        /// </summary>
        [ForeignKey("ShipRegionID"), JsonIgnore, XmlIgnore]
        public virtual Region Region { get; set; }
        /// <summary>
        /// 受注日(外部キー)
        /// </summary>
        [ForeignKey("OrderDate"), JsonIgnore, XmlIgnore]
        public virtual Calendar OrderDateCalendar { get; set; }
        /// <summary>
        /// 締切日(外部キー)
        /// </summary>
        [ForeignKey("RequiredDate"), JsonIgnore, XmlIgnore]
        public virtual Calendar RequiredDateCalendar { get; set; }
        /// <summary>
        /// 出荷日(外部キー)
        /// </summary>
        [ForeignKey("ShippedDate"), JsonIgnore, XmlIgnore]
        public virtual Calendar ShippedDateCalendar { get; set; }

        ///// <summary>
        ///// 受注明細
        ///// </summary>
        //[JsonIgnore, XmlIgnore]
        //public virtual ICollection<OrderDetail> OrderDetails { get; set; }
    }
}