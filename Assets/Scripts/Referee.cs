using UnityEngine;

public class Referee : MonoBehaviour 
{
	public static int Score { get; set; }
	public static int Misses { get; set; }


	private void Update () 
	{
		Debug.Log("Score: " + Score);
		Debug.Log("Misses: " + Misses);
	}
}