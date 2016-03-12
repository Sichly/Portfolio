using UnityEngine;
using System.Collections;

public class fuelObject : MonoBehaviour 
{
    public GameController Counter;

    void OnTriggerEnter(Collider other)
    {
            Debug.Log("score");
            Destroy(gameObject);
            Counter.fuelScore = Counter.fuelScore + 10;
    }
}
