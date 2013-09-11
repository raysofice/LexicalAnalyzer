using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Analysis
{
    public class Analyse
    {
        public Dictionary<WordType, DFA> DFAs { get; set; }
        public string[] input { get; set; }
        public List<Token> Token { get; set; }

        public Analyse()
        {
            DFAs = new Dictionary<WordType, DFA>();
            Token = new List<Token>();
        }

        public void AddDFA(string[] input, WordType type)
        {
            RegularGrammer rg = new RegularGrammer(input);
            NFA nfa = new NFA(rg);
            DFA dfa = new DFA(nfa);
            if (!DFAs.ContainsKey(type))
            {
                DFAs.Add(type, dfa);
            }
            else
            {
                DFAs[type] = dfa;
            }
        }

        public void Work(string[] input)
        {
            Token.Clear();
            int id=0;
            for (int i = 0; i < input.Length; ++i)
            {
                for (int k = 0; k < input[i].Length; )
                {
                    if (input[i][k] == ' ' || input[i][k] == '\n')
                    {
                        ++k;
                        continue;
                    }
                    ResultPair ans = new ResultPair(0, WordType.Error);
                    for (int ii = 0; ii < DFAs.Count; ++ii)
                    {
                        ResultPair res = DFAs.ElementAt(ii).Value.identify(input[i].Substring(k), DFAs.ElementAt(ii).Key);
                        if (res.type != WordType.Error && ans.type == WordType.Error)
                        {
                            ans = res;
                        }
                        else if (res.type != WordType.Error && ans.type != WordType.Error)
                        {
                            if (res.length > ans.length || (res.length == ans.length && res.type == WordType.KeyWord))
                            {
                                ans = res;
                            }
                        }
                    }
                    if (ans.length == 0)
                    {
                        ans.length = 1;
                    }
                    Token.Add(new Token(++id, ans.type, input[i].Substring(k, ans.length), i, k));
                    k += ans.length;
                }
            }
        }
    }
}
