using UnityEngine;

public class EventController : MonoBehaviour 
{
	public Referee Referee;
	public Statistics Statistics;
	public EscMenu EscMenu;
	public GameOverMenu GameOverMenu;

	public delegate void MethodContainer();


	private void Awake()
	{
		InputAggregator.EscKeyDown += EscMenu.SwitchDisplay;
		Referee.GameOver += GameOverMenu.Display;
		Referee.GameOver += Statistics.Hide;
		Referee.GameOver += ObjectPool.RecycleAll;
		Referee.GameOver += EscMenu.Lock;
	}

	private void OnDestroy()
	{
		InputAggregator.EscKeyDown -= EscMenu.SwitchDisplay;
		Referee.GameOver -= GameOverMenu.Display;
		Referee.GameOver -= Statistics.Hide;
		Referee.GameOver -= ObjectPool.RecycleAll;
		Referee.GameOver -= EscMenu.Lock;
	}
}
