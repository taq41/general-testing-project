using System;
using System.Collections.Generic;
using UnityEngine;

namespace AccessingWithNegativeIndex
{
    [Serializable]
    public class ElementListAccessor
    {
        [SerializeField]
        private List<ListWrapper<PrimaryElement>> elements;

        // Direct access, no error checking
        public PrimaryElement this[int index1, int index2]
        {
            get
            {
                return elements[index1][index2];
            }
            set
            {
                elements[index1][index2] = value;
            }
        }

        public void DoSomething()
        {
            elements = new() // this
            {
                new ListWrapper<PrimaryElement>() // 0
                {
                    Values = new()
                    {
                        new PrimaryElement(layer: 0), // 0
                        new PrimaryElement(layer: 0)  // 1
                    }
                }
            };

            Debug.Log(this[0, 1].Layer);
        }
    }
}