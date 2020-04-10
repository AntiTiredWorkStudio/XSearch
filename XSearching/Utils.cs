using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XSearching
{
    /// <summary>
    /// 身份定义 解锁进程
    /// </summary>
    public enum Identity
    {
        XMen,//关键人
        Informant,//线人
        Outsider//外围人
    }
    /// <summary>
    /// 阶级 解锁难易度
    /// </summary>
    public enum SocialLevels
    {
        Underclass,//低级
        Middleclass,//中级
        Eliteclass//高级
    }
}
