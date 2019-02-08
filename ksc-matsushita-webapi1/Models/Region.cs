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
    /// 都道府県
    /// </summary>
    public class Region
    {
        /// <summary>
        /// 都道府県コード
        /// </summary>
        [Key]
        public int RegionID { get; set; }
        /// <summary>
        /// 都道府県
        /// </summary>
        [Required, StringLength(15)]
        public string RegionName { get; set; }
        /// <summary>
        /// トドウフケン
        /// </summary>
        [StringLength(30)]
        public string RegionNameKana { get; set; }
        /// <summary>
        /// ローマ字
        /// </summary>
        [StringLength(100)]
        public string RegionNameE { get; set; }
        /// <summary>
        /// 地域名
        /// </summary>
        [StringLength(10)]
        public string AreaName { get; set; }
        /// <summary>
        /// 地域名ローマ字
        /// </summary>
        [StringLength(100)]
        public string AreaNameE { get; set; }
    }
}