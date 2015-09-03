﻿using UnityEngine;
using System.Collections;

public class Pitcher : MonoBehaviour 
{
	public Target CirclePrefab;
	public Target SquarePrefab;

	public float PitchFrequency;
	private float _timer;

	public float InitialThrust;
	public static float Thrust {get; private set;}


	private void Start () 
	{
		_timer = 0.0f;
		Thrust = InitialThrust;
	}
	
	private void Update () 
	{
		if(_timer > PitchFrequency)
		{
			Vector2 spawnPos = CalculateSpawnPosition();
			CirclePrefab.Spawn(transform, spawnPos);
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
