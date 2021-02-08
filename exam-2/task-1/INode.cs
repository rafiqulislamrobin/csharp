using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    public interface INode<N, M> where N : class,new ()where M:INode<N,M>
    {
        public void Add(N item);
        public void Remove(N item);
    }
}
