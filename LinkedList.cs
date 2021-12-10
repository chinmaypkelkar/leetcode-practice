using System;

namespace LeetcodePractice
{
    public class LinkedList
    {
        private ListNode Head { get; set; }

       public LinkedList()
       {
           Head = null;
       }

       public void Insert(int data)
       {
           var newNode = new ListNode(data);
           if (Head is null)
           {
               Head = newNode;
           }
           else
           {
               var runner = Head;
               while (runner.next is not null)
               {
                   runner = runner.next;
               }

               runner.next = newNode;
           }
       }

       public bool Contains(int data)
       {
           var runner = Head;
           var isAlreadyExists = false;
           while (runner != null)
           {
               if(runner.val == data)
               {
                   isAlreadyExists = true;
                   break;
               }
               runner = runner.next;
           }

           return isAlreadyExists;
       }
       
       public void Remove(int data)
       {
           
           var runner1 = Head;
           var runner2 = Head.next;
           if (runner1.val == data)
           {
               Head = runner1.next;
               runner1.next = null;
           }
           else
           {
               while (runner2 != null && runner2.val != data )
               {
                   runner2 = runner2.next;
                   runner1 = runner1.next;
               }

               runner1.next = runner2?.next;
           }
           
       }

       public void Traverse()
       {
           var runner = Head;
           while (runner != null)
           {
               Console.Write($"{runner.val}->");
               runner = runner.next;
           }
       } 
    }
}