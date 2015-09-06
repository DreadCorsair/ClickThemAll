using UnityEngine;

public class Catcher : MonoBehaviour 
{
	private void OnTriggerEnter2D(Component other)
	{
		other.gameObject.Recycle();
		Statistics.PlayerLifes--;
	}
}