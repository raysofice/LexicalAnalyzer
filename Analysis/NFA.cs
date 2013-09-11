using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysis
{
    public class NFA
    {
        public int Start { get; set; }
        public Dictionary<int,Status> StatusMap { get; set; }
        public int End { get; set; }
        public HashSet<char> Vt { get; set; }

        public NFA(){}

        public NFA(RegularGrammer rg)
        {
            StatusMap = new Dictionary<int, Status>();            
            Dictionary<char, int> Vn_dic = new Dictionary<char,int >();
            Vt=new HashSet<char>();
            char empty=System.Configuration.ConfigurationManager.AppSettings["Empty"][0];
            for (int i = 0; i < rg.Vt.Count; ++i)
            {
                char ch = rg.Vt.ElementAt(i);
                Vt.Add(ch);
            }

            for (int i = 0; i < rg.Vn.Count; ++i)
            {
                char ch = rg.Vn.ElementAt(i);
                Vn_dic.Add(ch, i);
                StatusMap.Add(i, new Status(i, 0));
            }
            this.Start = Vn_dic[rg.Start];
            this.End = rg.Vn.Count;
            StatusMap.Add(rg.Vn.Count, new Status(rg.Vn.Count, 1));
            foreach (Production pro in rg.Productions)
            {
                int st = Vn_dic[pro.Left];
                int next;                
                if (pro.Right[0] == empty || pro.Right.Length == 1)
                {
                    next = End;
                }
                else
                {
                    next=Vn_dic[pro.Right[1]];
                }
                if (!StatusMap[st].Next.ContainsKey(pro.Right[0]))
                    StatusMap[st].Next.Add(pro.Right[0], new HashSet<int>());
                StatusMap[st].Next[pro.Right[0]].Add(next);
            }
        }

        public HashSet<int> GONext(int id,char ch)
        {
            HashSet<int> result = new HashSet<int>();
            if (StatusMap[id].Next.ContainsKey(ch))
            {
                result = StatusMap[id].Next[ch];
            }
            return result;
        }

        public HashSet<int> Closure(HashSet<int> set)
        {
            HashSet<int> result =new HashSet<int>();
            foreach (int id in set)
            {
                result.Add(id);
            }
            bool changed = false;
            char empty=System.Configuration.ConfigurationManager.AppSettings["Empty"][0];
            do
            {
                changed = false;
                //foreach (int i in result)
                for(int i=0;i<result.Count;++i)
                {
                    int d = result.ElementAt(i);
                    if (StatusMap[d].Next.ContainsKey(empty))
                    {
                        foreach (int k in StatusMap[d].Next[empty])
                        {
                            changed |= result.Add(k);
                        }
                    }
                }
            } while (changed);
            return result;
        }

        public bool IsEnd(HashSet<int> set)
        {
            foreach (int i in set)
            {
                if (StatusMap[i].IsEnd == 1)
                    return true;
            }
            return false;
        }
    }
}
