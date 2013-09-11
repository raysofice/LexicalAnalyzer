using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysis
{
    public class DFA
    {
        public int Start { get; set; }
        public Dictionary<int, DFAStatus> StatusMap { get; set; }
        public Dictionary<int, HashSet<int>> Map { get; set; }
        public Dictionary<HashSet<int>,int> _Map{get;set;}

        public DFA()
        {
            Start = new int();
            StatusMap = new Dictionary<int, DFAStatus>();
            Map = new Dictionary<int, HashSet<int>>();
            _Map = new Dictionary<HashSet<int>, int>();
        }

        public DFA(NFA nfa)
        {
            StatusMap = new Dictionary<int, DFAStatus>();
            Map = new Dictionary<int, HashSet<int>>();
            _Map = new Dictionary<HashSet<int>, int>();
            HashSet<int> tmp = new HashSet<int>();
            tmp.Add(nfa.Start);
            HashSet<int> set = nfa.Closure(tmp);
            if (nfa.IsEnd(set))
            {
                StatusMap.Add(0, new DFAStatus(0, 1));
            }
            else
            {
                StatusMap.Add(0, new DFAStatus(0, 0));
            }
            Map.Add(0, set);
            _Map.Add(set, 0);
            for (int i = 0; i < Map.Count; ++i)
            {
                HashSet<int> t = Map.ElementAt(i).Value;
                int nowId = MapKey(t);
                HashSet<int> result = new HashSet<int>();
                //HashSet<int> newnext = new HashSet<int>();
                foreach (char ch in nfa.Vt)
                {
                    HashSet<int> newnext = new HashSet<int>();
                    if(ch==System.Configuration.ConfigurationManager.AppSettings["Empty"][0])
                    {
                        continue;
                    }
                    foreach (int nfaId in t)
                    {
                        if(nfa.StatusMap[nfaId].Next.ContainsKey(ch))
                        {
                            foreach (int ii in nfa.StatusMap[nfaId].Next[ch])
                            {
                                newnext.Add(ii);
                            }
                        }
                    }
                    if (newnext.Count == 0)
                    {
                        continue;
                    }
                    HashSet<int> closenew = nfa.Closure(newnext);
                    if (closenew.Count > 0 && !InMap(closenew))
                    {
                        int newId = Map.Count,endf=0;
                        Map.Add(newId, closenew);
                        _Map.Add(closenew, newId);
                        if(nfa.IsEnd(closenew))
                        {
                            endf=1;
                        }
                        DFAStatus dfastate = new DFAStatus(newId,endf);
                        StatusMap.Add(newId,dfastate);
                    }
                    if (closenew.Count > 0)
                    {
                        if (!StatusMap[nowId].Next.ContainsKey(ch))
                        {
                            StatusMap[nowId].Next.Add(ch, MapKey(closenew));
                        }
                    }
                }                
            }
        }

        public bool InMap(HashSet<int> set)
        {            
            for(int i=0;i<Map.Count;++i)
            {
                HashSet<int> temp = Map.ElementAt(i).Value;
                if(set.Count==temp.Count)
                {
                    bool flag = true;
                    foreach (int k in set)
                    {
                        if (!temp.Contains(k))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == false)
                        continue;
                    return true;
                }
            }
            return false;
        }

        public int MapKey(HashSet<int> set)
        {
            for(int i=0;i<Map.Count;++i)
            {
                HashSet<int> temp = Map.ElementAt(i).Value;
                if(set.Count==temp.Count)
                {
                    bool flag = true;
                    foreach (int k in set)
                    {
                        if (!temp.Contains(k))
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (flag == false)
                        continue;
                    return Map.ElementAt(i).Key;
                }
            }
            return -1;
        }

        public int GONext(int id, char ch)
        {
            if (StatusMap[id].Next.ContainsKey(ch))
            {
                return StatusMap[id].Next[ch];
            }
            return -1;
        }

        public ResultPair identify(string str,WordType type)
        {
            int nowstate = Start,i;
            for (i=0; i < str.Length; ++i)
            {
                if (StatusMap[nowstate].Next.ContainsKey(str[i]))
                {
                    nowstate = StatusMap[nowstate].Next[str[i]];
                }
                else
                {
                    if (StatusMap[nowstate].IsEnd == 1)
                    {
                        return new ResultPair(i, type);
                    }
                    else
                    {
                        return new ResultPair(i,WordType.Error);
                    }
                }
            }
            if (StatusMap[nowstate].IsEnd == 1)
            {
                return new ResultPair(i, type);
            }
            else
            {
                return new ResultPair(i, WordType.Error);
            }
            return new ResultPair(0, WordType.Error);
        }

    }
}
