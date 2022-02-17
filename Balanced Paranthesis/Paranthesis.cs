using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balanced_Paranthesis
{
    public  class Paranthesis
    {
        Stack stack=new Stack();
        public bool Check(string Expression)
        {
            for(int i = 0; i < Expression.Length; i++)
            {
                if (Expression[i] == '(' || Expression[i] == '[') stack.Push(Expression[i]);
                if(Expression[i] == ')' || Expression[i] == ']')
                {
                    char top = stack.Top();
                    if (Expression[i] == ')' && top == '(') stack.Pop();
                    else if (Expression[i] == ']' && top == '[') stack.Pop();
                    else
                        return false;
                    

                }
                
            }
            if (stack.Top()=='0') return true;
            else
                return false;

        }
    }
}
