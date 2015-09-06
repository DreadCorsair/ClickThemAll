using UnityEngine;

public class Statistics : MonoBehaviour 
{
	public static int PlayerLifes;
	public static int Score;
	public static int Level;


	public static void Reset(int playerLifes)
	{
		PlayerLifes = playerLifes;
		Score = 0;
		Level = 0;
	}
}
