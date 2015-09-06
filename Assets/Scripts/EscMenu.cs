using UnityEngine;

public class EscMenu : MonoBehaviour 
{
	private void Start() 
	{
		gameObject.SetActive(false);
	}

	public void SwitchDisplay()
	{
		if(gameObject.activeSelf)
		{
			gameObject.SetActive(false);
		}
		else
		{
			gameObject.SetActive(true);
		}
	}
}