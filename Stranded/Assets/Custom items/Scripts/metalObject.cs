using UnityEngine;
using System.Collections;

public class metalObject : MonoBehaviour 
{
    public GameController Counter;

    void OnTriggerEnter(Collider other)
    {
            Debug.Log("score");
            Destroy(gameObject);
            Counter.metalScore = Counter.metalScore + 5;
    }
}
