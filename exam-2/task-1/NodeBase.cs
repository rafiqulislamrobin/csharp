using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    public abstract class NodeBase<N, INode> : INode<N, INode> where N : class
    {
        protected virtual string Email { get; set; }
    public void Add(N item)
        {
          
        }

        public void Remove(N item)
        {
            
        }
        public abstract void GetCount();
    }
}
