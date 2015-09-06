using UnityEngine;
using UnityEngine.UI;

public class GameOverMenu : MonoBehaviour 
{
	private void Start() 
	{
		gameObject.SetActive(false);
	}

	public void Display()
	{
		transform.FindChild("Score").GetComponent<Text>().text = Statistics.Score.ToString();
		gameObject.SetActive(true);
	}
}
