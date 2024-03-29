﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
namespace Langben.DAL
{
    [MetadataType(typeof(ShenQingMetadata))]//使用ShenQingMetadata对ShenQing进行数据验证
    public partial class ShenQing 
    {
      
        #region 自定义属性，即由数据实体扩展的实体
        
        [Display(Name = "会员")]
        public string HuiYuanIdOld { get; set; }
        
        #endregion

    }
    public partial class ShenQingMetadata
    {
			[ScaffoldColumn(false)]
			[Display(Name = "主键", Order = 1)]
			public object Id { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "学校", Order = 2)]
			[StringLength(200, ErrorMessage = "长度不可超过200")]
			public object XueXiao { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "报修人", Order = 3)]
			[StringLength(200, ErrorMessage = "长度不可超过200")]
			public object BaoXiuRen { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "联系电话", Order = 4)]
			[StringLength(200, ErrorMessage = "长度不可超过200")]
			public object LianXiDianHua { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "描述", Order = 5)]
			[StringLength(4000, ErrorMessage = "长度不可超过4000")]
			public object MiaoShu { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "图片", Order = 6)]
			[StringLength(200, ErrorMessage = "长度不可超过200")]
			public object TuPian { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "打分", Order = 7)]
			[Range(0,2147483646, ErrorMessage="数值超出范围")]
			public int? DaFen { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "评论", Order = 8)]
			[StringLength(4000, ErrorMessage = "长度不可超过4000")]
			public object PingLun { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "备注", Order = 9)]
			[StringLength(4000, ErrorMessage = "长度不可超过4000")]
			public object Remark { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "状态", Order = 10)]
			[StringLength(200, ErrorMessage = "长度不可超过200")]
			public object State { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "会员", Order = 11)]
			[StringLength(36, ErrorMessage = "长度不可超过36")]
			public object HuiYuanId { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "创建时间", Order = 12)]
			[DataType(System.ComponentModel.DataAnnotations.DataType.DateTime,ErrorMessage="时间格式不正确")]
			public DateTime? CreateTime { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "创建人", Order = 13)]
			[StringLength(200, ErrorMessage = "长度不可超过200")]
			public object CreatePerson { get; set; }

			[ScaffoldColumn(true)]
			[Display(Name = "标识", Order = 14)]
			[StringLength(200, ErrorMessage = "长度不可超过200")]
			public object BiaoShi { get; set; }


    }
}
 

