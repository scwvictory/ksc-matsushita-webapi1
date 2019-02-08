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
    /// 社員クラス
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// 社員コード
        /// </summary>
        [Key]
        public int EmployeeID { get; set; }
        /// <summary>
        /// フリガナ
        /// </summary>
        [StringLength(80)]
        public string EmployeeNameKana { get; set; }
        /// <summary>
        /// 氏名
        /// </summary>
        [Required, StringLength(40)]
        public string EmployeeName { get; set; }
        /// <summary>
        /// 在籍支社
        /// </summary>
        [StringLength(20)]
        public string BranchName { get; set; }
        /// <summary>
        /// 部署名
        /// </summary>
        [StringLength(30)]
        public string DepartmentName { get; set; }
        /// <summary>
        /// 誕生日
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime? BirthDate { get; set; }
        /// <summary>
        /// 入社日
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime? HireDate { get; set; }
        /// <summary>
        /// 自宅郵便番号
        /// </summary>
        [StringLength(10), DataType(DataType.PostalCode)]
        public string PostalCode { get; set; }
        /// <summary>
        /// 自宅都道府県
        /// </summary>
        public int? RegionID { get; set; }
        /// <summary>
        /// 自宅住所1
        /// </summary>
        [StringLength(60)]
        public string Address1 { get; set; }
        /// <summary>
        /// 自宅住所2
        /// </summary>
        [StringLength(60)]
        public string Address2 { get; set; }
        /// <summary>
        /// 自宅電話番号
        /// </summary>
        [StringLength(24), DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        /// <summary>
        /// 内線
        /// </summary>
        [StringLength(4)]
        public string Extension { get; set; }
        /// <summary>
        /// 写真
        /// </summary>
        [StringLength(255)]
        public string PhotoPath { get; set; }
        /// <summary>
        /// プロフィール
        /// </summary>
        public string Profile { get; set; }

        ///// <summary>
        ///// 都道府県(外部キー)
        ///// </summary>
        //[ForeignKey("RegionID"), JsonIgnore, XmlIgnore]
        //public virtual Region Region { get; set; }
    }
}