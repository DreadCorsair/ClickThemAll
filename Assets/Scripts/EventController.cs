using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EventController : MonoBehaviour 
{
	public EscMenu EscMenu;
	public Referee Referee;

	public delegate void MethodContainer();

	private void Awake()
	{
		InputAggregator.OnEscapeDownEvent += EscMenu.SwitchDisplay;
		Target.OnDie += Referee.ScoreAdd;
	}
}
