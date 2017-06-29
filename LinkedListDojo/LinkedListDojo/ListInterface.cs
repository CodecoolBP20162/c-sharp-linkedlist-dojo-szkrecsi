using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDojo
{
    public interface LinkedListInterface
    {
        void Add(Object value);

        void Remove(Object value);

        void Insert(int index, Object value);

        void Reverse();
    }
}
