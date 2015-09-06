using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour 
{
	public Text Lifes;
	public Text Score;
	public Text Level;


	private void Update()
	{
		if(Statistics.PlayerLifes >= 0)
			Lifes.text = Statistics.PlayerLifes.ToString();
		Score.text = Statistics.Score.ToString();
		Level.text = Statistics.Level.ToString();
	}

	public void StartGame()
	{
		Application.LoadLevel("Game");
	}

	public void QuitGame()
	{
		Application.Quit();
	}
}