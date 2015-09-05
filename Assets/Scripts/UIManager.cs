using UnityEngine;

public class UIManager : MonoBehaviour 
{
	public void StartGame()
	{
		Application.LoadLevel("Game");
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}