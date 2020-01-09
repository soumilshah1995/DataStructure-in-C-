using System;
using System.Collections.Generic;

namespace mystack
{
    class Stacks<T>
    {
        
        // STL Template 
        public List<T> Data;

        public Stacks(){
            this.Data = new List<T>();
        }

        public void Add(T elem){
            this.Data.Add(elem);
        
        }

        public int Size(){
            return this.Data.Count;
        }

        public bool isEmpty(){
            if(this.Size() == 0){
                return true;
            }else{
                return false;
            }
        }



    }
}
