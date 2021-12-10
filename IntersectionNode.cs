using System;

namespace LeetcodePractice
{
   class InterSectionNode
   {
      public ListNode GetIntersectionNode(ListNode headA, ListNode headB) {
         var runner1 = headA;
         var runner2 = headB;
         var lengthA = 0;
         var lengthB = 0;
         while(runner1 != null){
            lengthA++;
            runner1 = runner1.next;
         }
         while(runner2 != null){
            lengthB++;
            runner2 = runner2.next;
         }
        
         var difference = Math.Abs(lengthA - lengthB);
         runner1 = headA;
         runner2 = headB;
         if(lengthA > lengthB){
            while(difference > 0){
               runner1 = runner1.next;
               difference--;
            }
         }
         if(lengthA < lengthB){
            while(difference > 0){
               runner2 = runner2.next;
               difference--;
            }
         }
        
         while(runner1 != null && runner2 != null){
            if(runner1 == runner2 && runner1.val == runner2.val){
               return runner1;
            }
            runner1 = runner1.next;
            runner2 = runner2.next;
         }
        
         return null;
        
        
      }
   }
}