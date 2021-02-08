using System;
using System.Collections.Generic;
using System.Text;

namespace task_1
{
    public class Node<N, INode> : NodeBase<N, INode> where N : class
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
        public int Add(int size)
        {
            return size;
        }
        public int remove(int size)
        {
            return size;
        }
    }

}
