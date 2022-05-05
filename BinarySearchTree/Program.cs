using BinarySearchTree;
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(" Welcome to Binary Search Tree");
        MyBinaryTree<int> binarysearch = new MyBinaryTree<int>(56);
        binarysearch.Insert(30);
        binarysearch.Insert(70);
        binarysearch.Display();

    }
}
