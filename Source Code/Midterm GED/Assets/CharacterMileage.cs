using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMileage : MonoBehaviour,ISubscriber
{
    public SubjectObserver subject;

    void Awake()
    {
        subject.AddObserver(this);
    }
    public void Notified() {
        Destroy(transform.gameObject);
        Application.Quit();
    }



}
