using UnityEngine;

public class Referee : MonoBehaviour 
{
	public int ScoreToLevelUp;
	public int MaxLifes;

	public static int Lifes { get; set; }
	public static int Score { get; set; }
	public static int Level { get; private set; }

	private int _scoreToLevelUp;
	private int _missesToGameOver;


	private void Start()
	{
		_scoreToLevelUp = ScoreToLevelUp;
		Level = 1;
		Lifes = MaxLifes;
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
		if(Lifes <= 0)
		{

		}
	}
}