using UnityEngine;

public class EventController : MonoBehaviour 
{
	public EscMenu EscMenu;
	public Referee Referee;

	public delegate void VoidMethodContainer();

	private void Awake()
	{
		InputAggregator.EscKeyDown += EscMenu.SwitchDisplay;
	}
}
