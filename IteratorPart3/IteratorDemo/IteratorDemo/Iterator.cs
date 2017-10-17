using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDemo
{
    //abstract Iterator class
    public abstract class Iterator
    {
        protected Aggregate aggregate;

        public abstract void First();
        public abstract void Next();
        public abstract bool IsDone();
        public abstract string CurrentItem();
    }

    public class ConcreteIterator : Iterator
    {
        int currIndex;
        public ConcreteIterator(Aggregate agg)
        {
            aggregate = agg;
        }
        public override string CurrentItem()
        {
            if (!IsDone())
                return aggregate[currIndex];
            else throw new Exception();
        }
        public override void First()
        {
            currIndex = 0;
        }
        public override bool IsDone()
        {
            return (currIndex >= aggregate.Count);
        }
        public override void Next()
        {
            currIndex++;
        }
    }

    public class TotalIterator : Iterator
    {
        int currIndex;
        public TotalIterator(Aggregate agg)
        {
            aggregate = agg;
        }
        public override string CurrentItem()
        {
            if (!IsDone())
                return aggregate[currIndex];
            else throw new Exception();
        }
        public override void First()
        {
            currIndex = 0;
        }
        public override bool IsDone()
        {
            return (currIndex >= aggregate.Count);
        }
        public override void Next()
        {
            currIndex++;
        }
    }

    public class SquaresIterator : Iterator
    {
        int currIndex;
        public SquaresIterator(Aggregate agg)
        {
            aggregate = agg;
        }
        public override string CurrentItem()
        {
            if (!IsDone())
                return aggregate[currIndex];
            else throw new Exception();
        }
        public override void First()
        {
            currIndex = 1;
        }
        public override bool IsDone()
        {
            return (currIndex >= aggregate.Count);
        }
        public override void Next()
        {
            double temp;
            temp = Math.Sqrt((double)currIndex);
            temp++;
            currIndex = (int)temp * (int)temp;
        }
    }

    public class PrimeIterator : Iterator
    {
        int currIndex;
        public PrimeIterator(Aggregate agg)
        {
            aggregate = agg;
        }
        public override string CurrentItem()
        {
            if (!IsDone())
                return aggregate[currIndex];
            else throw new Exception();
        }
        public override void First()
        {
            currIndex = 2;
        }
        public override bool IsDone()
        {
            return (currIndex >= aggregate.Count);
        }
        public override void Next()
        {
            do
            {
                currIndex++;
            } while (!IsPrime(currIndex));
        }
        public bool IsPrime(int num)
        {
            for(int i = num - 1; i > 1; i--)
            {
                if (num == 0)
                    return false;
                if (num == 1)
                    return false;
                if (num % i == 0)
                    return false;
                else
                    continue;
            }
            return true;
        }
    }
}

