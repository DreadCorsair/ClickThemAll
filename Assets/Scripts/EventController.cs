using UnityEngine;

public class EventController : MonoBehaviour 
{
	public Referee Referee;
	public EscMenu EscMenu;
	public GameOverMenu GameOverMenu;

	public delegate void MethodContainer();


	private void Awake()
	{
		InputAggregator.EscKeyDown += EscMenu.SwitchDisplay;
		Referee.GameOver += GameOverMenu.Display;
	}
}
