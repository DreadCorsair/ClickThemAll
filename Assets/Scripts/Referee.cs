using UnityEngine;

public class Referee : MonoBehaviour 
{
	public int MaxPlayerLifes;
	public float TimeToLevelUp;
	private float _timer;

	public static event EventController.MethodContainer GameOver;
	public static event EventController.MethodContainer LevelUp;

	private void Start()
	{
		Statistics.Reset(MaxPlayerLifes);
	}

	private void Update() 
	{
		if(_timer >= TimeToLevelUp * Statistics.Level)
		{
			Statistics.Level++;
			LevelUp();
		}
		_timer += Time.deltaTime;

		if(Statistics.PlayerLifes <= 0)
		{
			GameOver();
		}
	}
}