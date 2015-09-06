using UnityEngine;

public class EventController : MonoBehaviour 
{
	public EscMenu EscMenu;
	public Referee Referee;

	public delegate void VoidMethodContainer();

	private void Awake()
	{
		InputAggregator.EscKeyDown += EscMenu.SwitchDisplay;
		Target.Die += Referee.ScoreAdd;
		Catcher.Catch += Referee.SubtractLife;
		Referee.LevelUp += Referee.ScoreAdd; //!!
	}
}
