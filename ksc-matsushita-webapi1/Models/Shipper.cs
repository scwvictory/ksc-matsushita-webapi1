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
    /// 運送会社クラス
    /// </summary>
    public class Shipper
    {
        /// <summary>
        /// 運送会社コード
        /// </summary>
        [Key]
        public int ShipperID { get; set; }
        /// <summary>
        /// 運送会社
        /// </summary>
        [Required, StringLength(40)]
        public string CompanyName { get; set; }
        /// <summary>
        /// 電話番号
        /// </summary>
        [Required, StringLength(24), DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
    }
}