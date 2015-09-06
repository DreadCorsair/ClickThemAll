using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EventController : MonoBehaviour 
{
	public EscMenu EscMenu;

	public delegate void MethodContainer();

	private void Awake()
	{
		InputAggregator.OnEscapeDownEvent += EscMenu.SwitchDisplay;
	}
}
