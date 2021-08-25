using System;

namespace LogReader.SearchAlgorithm
{
    public interface ISearchAlgorithm
    {
        delegate bool Checker(string line);
        
    }
}