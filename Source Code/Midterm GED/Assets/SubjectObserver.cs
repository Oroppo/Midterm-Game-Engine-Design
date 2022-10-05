using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubjectObserver : MonoBehaviour
{
        List<ISubscriber> Observers = new List<ISubscriber>();

        public void Notify()
        {
            for (int i = 0; i < Observers.Count; i++)
            {
                Observers[i].Notified();
            }
        }
        public void AddObserver(ISubscriber subscriber)
        {
            Observers.Add(subscriber);
        }
        public void DeleteObserver(ISubscriber subscriber)
        {
            Observers.Remove(subscriber);
        }
}
