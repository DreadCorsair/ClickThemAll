using UnityEngine;

public class InputAggregator : MonoBehaviour 
{
	public static event EventController.MethodContainer EscKeyDown;

	private void Update() 
	{
		if(Input.GetKeyDown(KeyCode.Escape) && !EscMenu.IsLocked) EscKeyDown();
	}
}