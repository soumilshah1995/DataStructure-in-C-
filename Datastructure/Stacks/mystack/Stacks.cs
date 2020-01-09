using System;
using System.Collections.Generic;

namespace mystack
{
    public class Stacks<T>
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

        public T Pop(){
            /*
                Pop the Last item in Stack 
            */

            int index = this.Data.Count - 1;
            if (index < 0)
            {
                throw new InvalidOperationException("The stack is empty and there are no items to remove");
            }else{

                T item = this.Data[index];
                this.Data.RemoveAt(index);
                return item;
            }    
        }
        public T Peek(){
            /*
                Peek allows to get the last elements in stacks 
            */

            int index = this.Data.Count - 1;
            if (this.Data.Count == 0)
            {
                throw new InvalidOperationException("The stack is empty !  ");

            }else{
                T tem = this.Data[index];
                return tem;
            }
        }

        public void print(){

            foreach(var x in this.Data){
                System.Console.WriteLine(x);
                System.Console.WriteLine("\n");
            }

        }


    }
}
