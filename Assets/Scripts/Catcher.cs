using UnityEngine;
using System.Collections;

public class Catcher : MonoBehaviour 
{

	void Start () 
	{
	
	}
	
	void Update () 
	{
	
	}

	void OnTriggerEnter2D(Component other)
	{
		other.gameObject.Recycle();
	}
}
