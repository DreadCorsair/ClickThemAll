using UnityEngine;

public class Referee : MonoBehaviour 
{
	public int ScoreToLevelUp;
	public int MissesToGameOver;

	public static int Score { get; set; }
	public static int Misses { get; set; }
	public static int Level { get; private set; }

	private int _scoreToLevelUp;
	private int _missesToGameOver;


	private void Start()
	{
		_scoreToLevelUp = ScoreToLevelUp;
		_missesToGameOver = MissesToGameOver;
		Level = 1;
	}

	private void Update() 
	{
		if(Score >= _scoreToLevelUp)
		{
			Pitcher.Instance.Accelerate();
			_scoreToLevelUp = Score + ScoreToLevelUp;
			Level++;
			Debug.Log("LEVEL: " + Level);
		}
		if(Misses >= _missesToGameOver)
		{
//			Debug.Log("GAME OVER");
		}
//		Debug.Log("Score: " + Score);
//		Debug.Log("Misses: " + Misses);
	}
}