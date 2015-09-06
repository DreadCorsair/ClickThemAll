using UnityEngine;

public class Catcher : MonoBehaviour 
{
	public static event EventController.VoidMethodContainer Catch;

	private void OnTriggerEnter2D(Component other)
	{
		other.gameObject.Recycle();
		Catch();
	}
}