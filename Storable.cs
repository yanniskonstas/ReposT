using System;

namespace ReposT
{
    class Storable : IStoreable
    {
        public IComparable Id { get; set; }
    }
}
