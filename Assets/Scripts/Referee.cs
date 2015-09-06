using UnityEngine;

public class Referee : MonoBehaviour 
{
	public int MaxPlayerLifes;
	public float TimePerLevel;
	private float _timer;

	private int _scoreToLevelUp;


	private void Start()
	{
		Statistics.Reset(MaxPlayerLifes);
	}

	private void Update() 
	{
		if(_timer >= TimePerLevel * Statistics.Level)
		{
			Statistics.Level++;
		}
		if(Statistics.PlayerLifes <= 0)
		{

		}
	}

	public void FixDamage()
	{
		Statistics.PlayerLifes--;
	}
}