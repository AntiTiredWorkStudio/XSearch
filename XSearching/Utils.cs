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

    /// <summary>
    /// 通用技能等级定义
    /// </summary>
    public enum SkillLevel
    {
        Level0,//一窍不通
        Level1,//略知一二
        Level2,//掌握
        Level3,//熟练
        Level4,//精通
        Level5//烂熟于心
    }

    /// <summary>
    /// 平衡值
    /// </summary>
    public enum BalanceLevel
    {
        Worst,//最低
        Worse,//较低
        Average,//平均
        Better,//较高
        Best//最高
    }
}
