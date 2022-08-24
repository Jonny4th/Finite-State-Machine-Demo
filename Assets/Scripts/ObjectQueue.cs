using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectQueue<T> : MonoBehaviour
{
    [SerializeField] public Queue<T> items = new Queue<T>();
    public void Enqueue(T t)
    {
        if(!items.Contains(t)) items.Enqueue(t);
    }
}
