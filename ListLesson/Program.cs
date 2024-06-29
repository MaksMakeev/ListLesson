using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace ListLesson
{
    internal class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            List<double> testList = new List<double>();
            ArrayList testArrayList = new ArrayList();
            LinkedList<double> testLinkedList = new LinkedList<double>();

            Stopwatch stopWatch = new Stopwatch();

            int maxLengthOfList = 1000000;
            int requiredElement = 496753;
            var remainder = 777;

            //List 

            stopWatch.Start();
            for (int i = 0; i < maxLengthOfList; i++)
            {
                testList.Add(random.Next(100, 1000));
            }
            stopWatch.Stop();
            Console.WriteLine("RunTime of List filling is " + stopWatch.Elapsed);

            stopWatch.Start();
            for (int i = 0; i < maxLengthOfList; i++)
            {
                if (testList[i] % remainder == 0)
                {
                    Console.WriteLine(testList[i]);
                }
            }
            stopWatch.Stop();
            Console.WriteLine("RunTime of division remaindres searching is " + stopWatch.Elapsed);

            /*
            Console.WriteLine('\n');
            for (int i = 0; i < maxLengthOfList; i++)
            {
                Console.WriteLine(testList[i]);
            }
            
            Console.WriteLine(testList.Count);
            */

            stopWatch.Start();
            var listElement = testList[requiredElement - 1];
            stopWatch.Stop();
            Console.WriteLine($"The {requiredElement}-th elemet of the testList is {listElement} and searching took {stopWatch.Elapsed}\n");

            //ArrayList

            stopWatch.Start();
            for (int i = 0; i < maxLengthOfList; i++)
            {
                testArrayList.Add(Math.Round((random.NextDouble() * 1000), 0));
            }
            stopWatch.Stop();
            Console.WriteLine("RunTime of ArrayList filling is " + stopWatch.Elapsed);


            stopWatch.Start();
            for (int i = 0; i < maxLengthOfList; i++)
            {
                if ((double) testArrayList[i] % remainder == 0)
                {
                    Console.WriteLine(testArrayList[i]);
                }
            }
            stopWatch.Stop();
            Console.WriteLine("RunTime of division remaindres searching is " + stopWatch.Elapsed);

            /*
            Console.WriteLine('\n');
            for (int i = 0; i < maxLengthOfList; i++)
            {
                Console.WriteLine(testArrayList[i]);
            }
            Console.WriteLine(testArrayList.Count);
            */

            stopWatch.Start();
            var arrayListElement = testArrayList[requiredElement - 1];
            stopWatch.Stop();
            Console.WriteLine($"The {requiredElement}-th elemet of the testArrayList is {arrayListElement} and searching took {stopWatch.Elapsed}\n");

            //LinkedList

            stopWatch.Start();
            for (int i = 0; i < maxLengthOfList; i++)
            {
                testLinkedList.AddLast(random.Next(100, 1000));
            }
            stopWatch.Stop();
            Console.WriteLine("RunTime of LinkedList filling is " + stopWatch.Elapsed);

            stopWatch.Start();
            var linkedListElementDiv = testLinkedList.First;
            for (int i = 0; i < maxLengthOfList; i++)
            {
                if (linkedListElementDiv.Value % remainder == 0)
                {
                    Console.WriteLine(linkedListElementDiv.Value);
                }
                linkedListElementDiv = linkedListElementDiv.Next;
            }
            stopWatch.Stop();
            Console.WriteLine("RunTime of division remaindres searching is " + stopWatch.Elapsed);

            /*
            Console.WriteLine('\n');
            var currentNode = testLinkedList.First;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
            Console.WriteLine(testLinkedList.Count);
            */

            stopWatch.Start();
            var linkedListElement = testLinkedList.First;
            for (int i = 0; i < (requiredElement - 1); i++)
            {
                linkedListElement = linkedListElement.Next;
            }
            stopWatch.Stop();
            Console.WriteLine($"The {requiredElement}-th elemet of the testLinkedList is {linkedListElement.Value} and searching took {stopWatch.Elapsed}\n");
        }
    }
}