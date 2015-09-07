using UnityEngine;
using UnityEngine.UI;

public class Statistics : MonoBehaviour 
{
	public static int PlayerLifes;
	public static int Score;
	public static int Level;

	private Text _playerLifes;
	private Text _score;
	private Text _level;


	private void Start()
	{
		gameObject.SetActive(true);
		_playerLifes = transform.FindChild("Lifes").FindChild("Body").GetComponent<Text>();
		_score = transform.FindChild("Scoring").FindChild("Body").GetComponent<Text>();
		_level = transform.FindChild("Level").FindChild("Body").GetComponent<Text>();
	}

	private void Update()
	{
		_playerLifes.text = PlayerLifes.ToString();
		_score.text = Score.ToString();
		_level.text = Level.ToString();
	}

	public static void Reset(int playerLifes)
	{
		PlayerLifes = playerLifes;
		Score = 0;
		Level = 0;
	}

	public void Hide()
	{
		gameObject.SetActive(false);
	}
}