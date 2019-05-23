using System;

namespace ReposT
{
    public interface IStoreable
    {
        IComparable Id { get; set; }
    }
    
}