using System;
using UnityEngine;

namespace AccessingWithNegativeIndex
{
    [Serializable]
    public class PrimaryElement
    {
        [SerializeField]
        int? m_layer = null;
        public int? Layer { get { return m_layer;} }

        public PrimaryElement(int layer)
        {
            m_layer = layer;
        }
    }
}