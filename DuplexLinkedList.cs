using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace проба4.Model
{
    class DuplexLinkedList<T> : IEnumerable<T>
    {
        public DuplexItem<T> Head { get; set; }
        public DuplexItem<T> Tail { get; set; }
        public int Count { get; set; }

        public DuplexLinkedList() { }
        public DuplexLinkedList(T data)
        {
            var item = new DuplexItem<T>(data);
            Head = item;
            Tail = item;
            Count = 1;
        }
        public void Add(T data)
        {
            var item = new DuplexItem<T>(data);
            if (Count == 0)
            {
                Head = item;
                Tail = item;
                Count = 1;
                return;

            }
            Tail.Next = item;
            item.Previous = Tail;
            Tail = item;
            Count++;
        }
        public void Delete(T data)
        {
              var current = Head;
            while(current != null)
            {
                if(current.Data.Equals(data))
                {
                    current.Previous.Next = current.Next;
                    current.Next.Previous = current.Previous;
                    Count--;
                    return;
                }
                current = current.Next;
            }
           
        }
        public void InsertAfter(T target, T data)
        {
            var current = Head;
           
            while (current != null )
            {
                if (current.Data.Equals(target))
                {
                    var item = new DuplexItem<T>(data);
                    current.Next = item.Next;
                    item.Next = Tail;
                    Tail.Previous = item.Previous;
                    
                    current.Next = item;
                    Count++;

                    Count++;
                    return;
                }
                else
                { current = current.Next; }
            }
        }
        public IEnumerator GetEnumerator()
        {
            var current = Head;
            while (current != null)
            {
                yield return current;
                current = current.Next;
            }
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)GetEnumerator();
        }


    }

}
