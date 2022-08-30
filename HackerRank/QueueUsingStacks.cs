using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerRank
{
    class StackQueue{
        
        private Stack<int> _enqueueStack;
        private Stack<int> _dequeueStack;
        
        public StackQueue()
        {
            _enqueueStack = new Stack<int>();
            _dequeueStack = new Stack<int>();
            
        }
        
        // Enqueue a element
        public void Enqueue(int n){
            _enqueueStack.Push(n);           
        }
        
        public int Dequeue(){
            // Get from the bottom of the 'stack'
            return 0;
        }
    }

    public class QueueUsingStacks
    {
        
    }
}