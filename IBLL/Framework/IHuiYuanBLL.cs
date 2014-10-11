﻿using System;
using System.Collections.Generic;
using System.Linq;

using Common;
using Langben.DAL;
using System.ServiceModel;

namespace Langben.IBLL
{
    /// <summary>
    /// 会员 接口
    /// </summary>
    public partial interface IHuiYuanBLL
    {
    /// <summary>
    /// 审核会员
    /// </summary>
    /// <param name="ids">id组合</param>
    /// <param name="state">状态值</param>
    /// <returns></returns>
     [OperationContract]
     int ShenHe(string ids,string State);
    }
}
