using System;
using System.Collections.Generic;

[Serializable]
public class ListWrapper<T>
{
    public List<T> Values;

    public T this[int index]
    {
        get
        {
            return Values[index];
        }
        set
        {
            Values[index] = value;
        }
    }
}