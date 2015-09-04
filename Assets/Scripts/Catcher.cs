using UnityEngine;
using System.Collections;

public class Catcher : MonoBehaviour 
{
	void OnTriggerEnter2D(Component other)
	{
		other.gameObject.Recycle();
		Referee.Misses++;
	}
}
