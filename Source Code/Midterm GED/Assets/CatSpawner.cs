using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatSpawner : MonoBehaviour
{
    private static CatSpawner _instance;
    float frequency = 0;
    public Transform catPrefab, player;
    float mileageLimit = 10;
    Vector3 position;
    public SubjectObserver _SubjectInstance;
    

    private void Awake()
    {
        _instance = this;
    }



    //this ensures there is always one copy of the singleton instance
    public static CatSpawner _Instance { 
        get { 
            if (_Instance == null)
            {
                Debug.LogError("There is no instance of the spawner!");
                return null;
            }
            return _instance;
        } 
    }

    void Update()
    {
        if (!(mileageLimit <= 0))
        {
            frequency += Time.deltaTime;
            mileageLimit -= Time.deltaTime;
        }


        if (frequency >= mileageLimit)
        {
            position = new Vector3(Random.Range(-10.0f, 10.0f), 0f, Random.Range(-10.0f, 10.0f));
            Quaternion rotation = Quaternion.Euler(0, 0, 0);
            Instantiate(catPrefab, position, rotation);
            frequency -= mileageLimit;

        }
        if (mileageLimit <= 0)
        {
            _SubjectInstance.Notify();

        }
        
        //after mileagelimit hits 0 kill the player
        //time increases exponentially, because why not
        
    }

}
