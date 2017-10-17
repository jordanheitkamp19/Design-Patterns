using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorDemo
{
    public enum IteratorType { TotalIterator, SquaresIterator, PrimeIterator}

    public abstract class Aggregate: List<string>
    {
    }

    public class ConcreteAggregate : Aggregate
    {
        public Iterator CreateIterator(IteratorType it)
        {
            Iterator retVal;
            switch(it)
            {
                case IteratorType.TotalIterator:
                    retVal = CreateTotalIterator(this);
                    break;
                case IteratorType.SquaresIterator:
                    retVal = CreateEvenIterator(this);
                    break;
                case IteratorType.PrimeIterator:
                    retVal = CreateOddIterator(this);
                    break;
                default:
                    retVal = CreateTotalIterator(this);
                    break;
            }
            return retVal;
        }
        private Iterator CreateOddIterator(Aggregate agg)
        {
            return new PrimeIterator(agg);
        }
        private Iterator CreateEvenIterator(Aggregate agg)
        {
            return new SquaresIterator(agg);
        }
        private Iterator CreateTotalIterator(Aggregate agg)
        {
            return new TotalIterator(agg);
        }
    }
}
