using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour 
{
	public Text Lifes;
	public Text Score;
	public Text Level;


	private void Update()
	{
		if(Referee.PlayerLifes >= 0)
			Lifes.text = Referee.PlayerLifes.ToString();
		Score.text = Referee.Score.ToString();
		Level.text = Referee.Level.ToString();
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