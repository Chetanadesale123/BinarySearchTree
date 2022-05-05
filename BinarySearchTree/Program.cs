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
        binarysearch.Insert(22);
        binarysearch.Insert(40);
        binarysearch.Insert(60);
        binarysearch.Insert(95);
        binarysearch.Insert(11);
        binarysearch.Insert(65);
        binarysearch.Insert(3);
        binarysearch.Insert(16);
        binarysearch.Insert(63);
        binarysearch.Insert(67);
        binarysearch.Display();
        binarysearch.GetSize();
        bool result = binarysearch.IfExists(67, binarysearch);
        Console.WriteLine(result);

    }
}
