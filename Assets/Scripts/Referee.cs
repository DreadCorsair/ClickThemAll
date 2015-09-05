using UnityEngine;

public class Referee : MonoBehaviour 
{
	public int ScoreToLevelUp;
	public int MissesToGameOver;

	public static int Score { get; set; }
	public static int Misses { get; set; }

	private int _scoreToLevelUp;
	private int _missesToGameOver;

	private int _currentLevel;


	private void Start()
	{
		_scoreToLevelUp = ScoreToLevelUp;
		_missesToGameOver = MissesToGameOver;
		_currentLevel = 1;
	}

	private void Update() 
	{
		if(Score >= _scoreToLevelUp)
		{
			Pitcher.Instance.Accelerate();
			_scoreToLevelUp = Score + ScoreToLevelUp;
			_currentLevel++;
			Debug.Log("LEVEL: " + _currentLevel);
		}
		if(Misses >= _missesToGameOver)
		{
//			Debug.Log("GAME OVER");
		}
//		Debug.Log("Score: " + Score);
//		Debug.Log("Misses: " + Misses);
	}
}