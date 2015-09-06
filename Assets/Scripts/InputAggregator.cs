using UnityEngine;
using System.Collections;

public class InputAggregator : MonoBehaviour 
{
	public static event EventController.MethodContainer OnEscapeDownEvent;

	private void Update() 
	{
		if(Input.GetKeyDown(KeyCode.Escape)) OnEscapeDownEvent();
	}
}
