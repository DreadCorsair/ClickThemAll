using UnityEngine;

public class InputAggregator : MonoBehaviour 
{
	public static event EventController.VoidMethodContainer EscKeyDown;

	private void Update() 
	{
		if(Input.GetKeyDown(KeyCode.Escape)) EscKeyDown();
	}
}
