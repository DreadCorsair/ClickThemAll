using UnityEngine;

public class GameOverMenu : MonoBehaviour 
{
	private void Start() 
	{
		gameObject.SetActive(false);
	}

	public void Display()
	{
		gameObject.SetActive(true);
	}
}
