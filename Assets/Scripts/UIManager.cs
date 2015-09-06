using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour 
{
	public Text Score;

	private void Start()
	{
		Score.text = Referee.Score.ToString();
	}

	private void Update()
	{
		Score.text = Referee.Score.ToString();
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