using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Binary_Search_Tree_Generics
{
    public class BST<T> : IBinaryTree<T> where T : IComparable<T>
    {
        private BinaryTreeNode<T> _root = null;


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
            else
            {
                BinaryTreeNode<T> nextNode = _root;
                BinaryTreeNode<T> prev = null;
                bool exiter = false;

                while (!exiter)
                {
                    prev = nextNode;
                    if (value.CompareTo(nextNode.Data) < 0)
                    {
                        nextNode = nextNode.Left;
                        if (nextNode == null)
                        {
                            prev.Left = temp;
                            exiter = true;
                        }
                    }
                    else
                    {
                        nextNode = nextNode.Right;
                        if (nextNode == null)
                        {
                            prev.Right = temp;
                            exiter = true;
                        }

                    }

                }
            }

        }

        public void Delete(T value)
        {

            BinaryTreeNode<T> node = _root;
            BinaryTreeNode<T> previous = null;

            while (node != null) 
            {
                
                if (node.Data.CompareTo(value) > 0)
                {
                    previous = node;
                    node = node.Left;
                }
                else if (node.Data.CompareTo(value) < 0) 
                {
                    previous = node;
                    node = node.Right;
                }
                else 
                {
                    if (node.Left != null && node.Right != null) 
                    {
                        BinaryTreeNode<T> nodeNext = node.Left;
                        BinaryTreeNode<T> nodePrev = node;

                        while (nodeNext.Right != null) 
                        {
                            nodePrev = nodeNext;
                            nodeNext = nodeNext.Right;

                        }
                        nodePrev.Right = null;
                        node.Data = nodeNext.Data;
                        return;

                    }
                    else if (node.Left != null || node.Right != null)
                    {
                     

                        if (node.Left != null)
                        {
                            node = node.Left;
                            previous.Left = node;
                            node = null;
                            return;


                        }
                        else
                        {
                            
                            node = node.Right;
                            previous.Right = node;
                            node = null;
                            return;
                        }

                    }
                    else
                    {
                        if (previous.Data.CompareTo(node.Data) > 0)
                        {
                            previous.Left = null;
                            node = null;
                            return;
                        }
                        else 
                        {
                            previous.Right = null;
                            node = null;
                            return;

                        }
                        

                       
                    }

                }
                

            }

        }
        


        public bool Contains(T value)
        {
            BinaryTreeNode<T> current = _root;
            while (current != null)
            {
                if (value.CompareTo(current.Data) < 0)
                {
                    current = current.Left;
                }
                else if (value.CompareTo(current.Data) == 0)
                {
                    return true;
                }
                else
                {
                    current = current.Right;
                }
            }
            return false;
        }

        public BinaryTreeNode<T> Search(T value)
        {
            BinaryTreeNode<T> newNode = _root;
            while (newNode != null)
            {
                if (value.CompareTo(newNode.Data) < 0)
                {
                    newNode = newNode.Left;
                }
                else if (value.CompareTo(newNode.Data) == 0)
                {
                    return newNode;
                }
                else
                {
                    newNode = newNode.Right;
                }
            }
            return null;

        }

        public void PrintInorder()
        {
            throw new NotImplementedException();
        }
    }
}
    

