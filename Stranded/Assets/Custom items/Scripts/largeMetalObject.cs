using UnityEngine;
using System.Collections;

public class largeMetalObject : MonoBehaviour
{

    public GameController Counter;

//	public GameObject gameController;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("score");
        Destroy(gameObject);
        Counter.metalScore = Counter.metalScore + 10;
    }
}
