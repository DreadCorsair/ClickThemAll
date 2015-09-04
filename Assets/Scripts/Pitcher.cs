using UnityEngine;

public class Pitcher : MonoBehaviour 
{
	public Target CirclePrefab;
	public Target SquarePrefab;

	public int CirclePoolSize;
	public int SquarePoolSize;

	public float InitialThrust;
	public static float Thrust { get; private set; }

	public float PitchFrequency;
	private float _timer;


	private void Start () 
	{
		_timer = 0.0f;
		Thrust = InitialThrust;

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

	private Vector2 CalculateSpawnPosition()
	{
		Vector3 spawnMinPos = transform.InverseTransformPoint(collider2D.bounds.max);
		Vector3 spawnMaxPos = transform.InverseTransformPoint(collider2D.bounds.min);

		float randValueY = Random.Range(spawnMinPos.y, spawnMaxPos.y);
		
		return new Vector3(0.0f, randValueY);
	}
}