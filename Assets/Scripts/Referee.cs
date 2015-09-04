using UnityEngine;
using System.Collections;

public class Referee : MonoBehaviour 
{
	public static int Score {get; set;}
	public static int Misses {get; set;}

	void Start () 
	{

	}
	
	void Update () 
	{
		Debug.Log("Score: " + Score);
		Debug.Log("Misses: " + Misses);
	}
}
