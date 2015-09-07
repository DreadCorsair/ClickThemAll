using UnityEngine;

public class EscMenu : MonoBehaviour 
{
	public static bool IsLocked { get; private set; }

	private void Start() 
	{
		IsLocked = false;
		gameObject.SetActive(false);
	}

	private void OnDestroy()
	{
		IsLocked = false;
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

	public void Lock()
	{
		gameObject.SetActive(false);
		IsLocked = true;
	}
}