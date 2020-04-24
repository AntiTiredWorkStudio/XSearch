using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XSearching
{
    class Character
    {
        #region 基本属性
        /// <summary>
        /// 身份定位
        /// </summary>
        public Identity identitiy;
        /// <summary>
        /// 社会地位
        /// </summary>
        public SocialLevels socialLevels;
        #endregion

        #region 水平静态属性
        /// <summary>
        /// 警戒度
        /// </summary>
        public BalanceLevel GuardLevel;
        #endregion

        #region 静态属性
        #region 被动

        /// <summary>
        /// 防范意识
        /// </summary>
        public SkillLevel SelfPrevention;

        /// <summary>
        /// 伪装意识
        /// </summary>
        public SkillLevel EmotionalMasking;

        /// <summary>
        /// 精神强度
        /// </summary>
        public SkillLevel Mentalntensity;

        /// <summary>
        /// 计谋运用
        /// </summary>
        public SkillLevel SchemeUse;

        #endregion

        #region 主动
        /// <summary>
        /// 沟通能力
        /// </summary>
        public SkillLevel CommunicateSkill;

        /// <summary>
        /// 读心能力
        /// </summary>
        public SkillLevel MindReadingSkill;

        /// <summary>
        /// 收集线索能力
        /// </summary>
        public SkillLevel SearchSkill;

        /// <summary>
        /// 调查能力
        /// </summary>
        public SkillLevel InvestigationSkill;

        #endregion
        #endregion
    }
}
