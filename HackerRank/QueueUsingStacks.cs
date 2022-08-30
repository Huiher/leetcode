using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HackerRank
{
    public class StackQueue{
        
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

            // Build dequeue stack
            _dequeueStack.Clear();
            int poppedValue;

            var stackValue = new List<int>();
            while(_enqueueStack.TryPop(out poppedValue))
            {
                stackValue.Add(poppedValue);
                _dequeueStack.Push(poppedValue);
            }          

            // re-create the stack
            stackValue.Reverse();
            _enqueueStack = new Stack<int>(stackValue);
        }
        
        public int? Dequeue(){

            // get the current dequeu value;    
            int poppedValue;         
            var result = _dequeueStack.TryPop(out poppedValue);

            if (result)
            {
                int peek;
                var stackValues = new List<int>();

                // Rebuild the enqueue stack
                _enqueueStack.Clear();
                while(_dequeueStack.TryPop(out peek))
                {
                    stackValues.Add(peek);
                    _enqueueStack.Push(peek);
                }

                stackValues.Reverse();
                _dequeueStack = new Stack<int>(stackValues);

                // return the dequeued value
                return poppedValue;
            }

            return null;
            
        }
    }
}