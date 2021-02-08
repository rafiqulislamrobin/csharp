using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    public class Node<N, M> : NodeBase<N, M> where N : class,new ()where M: INode<N,M>
    {
       protected override string Email { get => base.Email;
            set => base.Email = "rafiqu@email.com"; }
        public override void GetCount()
        {
           
        }
        public Node()
        {

        }
        public Node(int size)
        {

        }
        public void Add(int[] size)
        {
            
        }
        public void remove(int[] size)
        {
            
        }
    }

}
