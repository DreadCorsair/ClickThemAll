using UnityEngine;

public class Referee : MonoBehaviour 
{
	public int MaxPlayerLifes;
	public float TimeToLevelUp;
	private float _timer;

	public static event EventController.MethodContainer GameOver;

	private void Start()
	{
		Statistics.Reset(MaxPlayerLifes);
	}

	private void Update() 
	{
		if(_timer >= TimeToLevelUp * Statistics.Level)
		{
			Statistics.Level++;
		}
		_timer += Time.deltaTime;

		if(Statistics.PlayerLifes <= 0)
		{
			GameOver();
		}
	}
}