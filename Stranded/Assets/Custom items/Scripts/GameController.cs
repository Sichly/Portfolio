using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour 
{
    // Some variables forthe different parts to pick up
    public int metalScore = 0;
    public int fuelScore = 0;

    public Text MetalParts;
    public Text Fuel;

	// Use this for initialization
	void Start () 
    {
        //Get a reference to our text LevelText's text component by finding it by name and calling GetComponent.
        MetalParts = GameObject.Find("MetalParts").GetComponent<Text>();
        Fuel = GameObject.Find("Fuel").GetComponent<Text>();

	}
	
    public void Update()
    {
            // this part of the code updates the amount of fuel and parts collected during every update
            MetalParts.text = "Metal Parts: " + metalScore + "/100";
            Fuel.text = "Fuel: " + fuelScore + "/50";
    }
}
