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
    /// 商品区分
    /// </summary>
    public class ProductCategory
    {
        /// <summary>
        /// 区分コード
        /// </summary>
        [Key]
        public int ProductCategoryID { get; set; }
        /// <summary>
        /// 区分名
        /// </summary>
        [Required,StringLength(30)]
        public string ProductCategoryName { get; set; }
        /// <summary>
        /// 説明
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 画像
        /// </summary>
        [DataType(DataType.Upload)]
        public byte[] Picture { get; set; }
    }
}