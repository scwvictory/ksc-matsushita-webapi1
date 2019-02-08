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
    /// カレンダ日付クラス
    /// </summary>
    [Serializable]
    public class Calendar
    {
        /// <summary>
        /// 日付
        /// </summary>
        [Key, DataType(DataType.Date)]
        public DateTime Date { get; set; }
        /// <summary>
        /// 年度
        /// </summary>
        [StringLength(4)]
        public string Year { get; set; }
        /// <summary>
        /// 四半期
        /// </summary>
        [StringLength(2)]
        public string Quarter { get; set; }
        /// <summary>
        /// 月度
        /// </summary>
        [StringLength(2)]
        public string Month { get; set; }
    }
}