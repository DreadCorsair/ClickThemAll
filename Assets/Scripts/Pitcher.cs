using UnityEngine;

public class Pitcher : MonoBehaviour 
{
	public Target CirclePrefab;
	public Target SquarePrefab;

	public int CirclePoolSize;
	public int SquarePoolSize;

	public float CircleInitialThrust;
	public float SquareInitialThrust;
	public float AccelerationPerLevel;

	public static float CircleThrust { get; private set; }
	public static float SquareThrust { get; private set; }

	public float PitchFrequency;
	public float FrequentPerLevel;
	private float _timer;


	private void Start () 
	{
		CircleThrust = CircleInitialThrust;
		SquareThrust = SquareInitialThrust;

		_timer = 0.0f;

		ObjectPool.CreatePool(CirclePrefab, CirclePoolSize);
		ObjectPool.CreatePool(SquarePrefab, SquarePoolSize);
	}
	
	private void Update () 
	{
		if(_timer > PitchFrequency)
		{
			Vector2 circleSpawnPos = CalculateSpawnPosition();
			Vector2 squareSpawnPos = CalculateSpawnPosition();

			CirclePrefab.Spawn(transform, circleSpawnPos);
			SquarePrefab.Spawn(transform, squareSpawnPos);

			_timer = 0.0f;
		}

		_timer += Time.deltaTime;
	}

	public void Accelerate()
	{
		CircleThrust += AccelerationPerLevel;
		SquareThrust += AccelerationPerLevel;
		PitchFrequency -= FrequentPerLevel;
	}

	private Vector2 CalculateSpawnPosition()
	{
		Vector3 spawnMinPos = transform.InverseTransformPoint(collider2D.bounds.max);
		Vector3 spawnMaxPos = transform.InverseTransformPoint(collider2D.bounds.min);

		float randValueY = Random.Range(spawnMinPos.y, spawnMaxPos.y);
		
		return new Vector3(0.0f, randValueY);
	}
}