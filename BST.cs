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
                BinaryTreeNode<T> breach = null;
                bool exiter = false;

                while (!exiter)
                {
                    breach = nextNode;
                    if (value.CompareTo(nextNode.Data) < 0)
                    {
                        nextNode = nextNode.Left;
                        if (nextNode == null)
                        {
                            breach.Left = temp;
                            exiter = true;
                        }
                    }
                    else
                    {
                        nextNode = nextNode.Right;
                        if (nextNode == null)
                        {
                            breach.Right = temp;
                            exiter = true;
                        }



                    }
                }
            }

        }

        public void Delete(T value)
        {
            List<T> elements = new List<T>();
            InOrderCollect(_root, elements, value);
            _root = null;
            foreach (T element in elements)
            {
                Insert(element);
            }
        }
        private void InOrderCollect(BinaryTreeNode<T> node, List<T> elements, T value)
        {
            if (node == null) return;
            InOrderCollect(node.Left, elements, value);
            if (!node.Data.Equals(value))
            {
                elements.Add(node.Data);
            }
            InOrderCollect(node.Right, elements, value);
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
            if (_root == null) ;
            else
            {
                BinaryTreeNode<T> prevoius;
                BinaryTreeNode<T> node = _root;

                while (node != null)
                {
                    if (node.Left == null)
                    {
                        Console.WriteLine(node.Data);
                        node = node.Right;
                    }
                    else
                    {
                        prevoius = node.Left;
                        while (prevoius.Right != null && prevoius.Right != node)
                        {
                            prevoius = prevoius.Right;


                        }
                        if (prevoius.Right == null)
                        {
                            prevoius.Right = node;
                            node = node.Left;
                        }
                        else
                        {
                            prevoius.Right = null;
                            Console.WriteLine(node.Data);
                            node = node.Right;

                        }

                    }
                }
            }
        }
    }
}
    

