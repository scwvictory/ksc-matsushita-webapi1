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
    /// 仕入先クラス
    /// </summary>
    public class Supplier
    {   
        /// <summary>
        /// 仕入先コード
        /// </summary>
        [Key]
        public int SupplierID { get; set; }
        /// <summary>
        /// フリガナ
        /// </summary>
        [StringLength(80)]
        public string CompanyNameKana { get; set; }
        /// <summary>
        /// 仕入先名
        /// </summary>
        [Required, StringLength(40)]
        public string CompanyName { get; set; }
        /// <summary>
        /// 担当者名
        /// </summary>
        [StringLength(30)]
        public string ContactName { get; set; }
        /// <summary>
        /// 部署
        /// </summary>
        [StringLength(30)]
        public string ContactDepartment { get; set; }
        /// <summary>
        /// 郵便番号
        /// </summary>
        [StringLength(10), DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }
        /// <summary>
        /// 都道府県コード
        /// </summary>
        public int? RegionID { get; set; }
        /// <summary>
        /// 住所1
        /// </summary>
        [StringLength(60)]
        public string Address1 { get; set; }
        /// <summary>
        /// 住所2
        /// </summary>
        [StringLength(60)]
        public string Address2 { get; set; }
        /// <summary>
        /// 電話番号
        /// </summary>
        [StringLength(24), DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        /// <summary>
        /// FAX番号
        /// </summary>
        [StringLength(24), DataType(DataType.PhoneNumber)]
        public string Fax { get; set; }
        /// <summary>
        /// ホームページ
        /// </summary>
        [StringLength(200), DataType(DataType.Url)]
        public string HomePage { get; set; }

        ///// <summary>
        ///// 都道府県(外部キー)
        ///// </summary>
        //[ForeignKey("RegionID"), JsonIgnore, XmlIgnore]
        //public virtual Region Region { get; set; }
    }
}