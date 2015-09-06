using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour 
{
	public Text Score;
	public Text Level;

	private void Start()
	{
		Score.text = Referee.Score.ToString();
		Level.text = Referee.Level.ToString();
	}

	private void Update()
	{
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