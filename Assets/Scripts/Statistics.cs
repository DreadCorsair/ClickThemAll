using UnityEngine;

public class Statistics : MonoBehaviour 
{
	public static int PlayerLifes { get; private set; }
	public static int Score { get; private set; }
	public static int Level { get; private set; }


	public static void Reset(int playerLifes)
	{
		PlayerLifes = playerLifes;
		Score = 0;
		Level = 0;
	}
}
