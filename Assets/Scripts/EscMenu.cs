using UnityEngine;

public class EscMenu : MonoBehaviour 
{
	public GameObject Panel;
	public static bool IsEnable { get; private set; }
	private enum State { Disable, Enable };
	private State _state;

	private void Start() 
	{
		IsEnable = false;
		_state = State.Disable;
		Panel.SetActive(false);
		Time.timeScale = 1;
	}
	
	private void Update() 
	{
		if(Input.GetKeyDown(KeyCode.Escape))
		{
			if(_state == State.Disable)
			{
				IsEnable = true;
				_state = State.Enable;
				Panel.SetActive(true);
				Time.timeScale = 0;
			}
			else if(_state == State.Enable)
			{
				IsEnable = false;
				_state = State.Disable;
				Panel.SetActive(false);
				Time.timeScale = 1;
			}
		}
	}
}
