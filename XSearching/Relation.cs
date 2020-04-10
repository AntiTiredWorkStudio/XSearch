using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace XSearching
{
    public class RelationManager
    {
        static Dictionary<Character, List<Relation>> Relations;
        public static Relation BuildReleation(Character self,Character other,float knowledge)
        {
            if (Relations == null)
            {
                Relations = new Dictionary<Character, List<Relation>>();
            }
            if (!Relations.ContainsKey(self))
            {
                Relations.Add(self, new List<Relation>());
            }
            Relation tRelation = new Relation();
            tRelation.knowledge = knowledge;
            tRelation.target = other;
            Relations[self].Add(tRelation);
            return tRelation;
        }
    }
    class Relation
    {
        /// <summary>
        /// 目标
        /// </summary>
        public Character target;
        /// <summary>
        /// 了解程度
        /// </summary>
        public float knowledge;
    }
}
