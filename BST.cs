using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree_Generics
{
    public  class BST<T>: IBinaryTree<T> where T:IComparable<T>
    {
        private BinaryTreeNode<T> _root;
        
       
        void IBinaryTree<T>.Clear()
        {
            _root = null;
        }

        public void Insert(T value)
        {
            BinaryTreeNode<T> temp = new BinaryTreeNode<T>(value);

            if (_root == null)
            {
                _root = temp;
            }
            if (temp.Data.CompareTo(_root.Data) > 0)
            {
                _root.Right = temp;
                while (_root.Right != null)
                {
                    InsertNew(temp);
                }
            }
            else if (temp.Data.CompareTo(_root.Data) < 0) 
            {
                _root.Left = temp;
               while (_root.Left != null) 
               {
                    InsertNew(temp);
                
               }
            
            }
            

        }
        void InsertNew(BinaryTreeNode<T> temp) 
        {
          
            if (temp.Data.CompareTo(_root.Data) > 0)
            {
                _root.Right = temp;
            }
            else if (temp.Data.CompareTo(_root.Data) < 0)
            {               
                _root.Left = temp;

            }
        }
        void IBinaryTree<T>.Delete(T value)
        {
            BinaryTreeNode<T> temp = new BinaryTreeNode<T>(value);
        }

        public bool Contains(T value)
        {
            throw new NotImplementedException();
        }

        BinaryTreeNode<T> IBinaryTree<T>.Search(T value)
        {
            throw new NotImplementedException();
        }

        void IBinaryTree<T>.PrintInorder()
        {
            throw new NotImplementedException();
        }
    }
}
