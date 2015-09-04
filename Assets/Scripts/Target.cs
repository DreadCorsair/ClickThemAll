using UnityEngine;

public class Target : MonoBehaviour 
{
	public int Price;
	public int MaxHealth;

	private int _currentHealth;
	private bool _onMouse;


	private void OnEnable() 
	{
		_currentHealth = MaxHealth;
		_onMouse = false;
	}
	
	private void Update() 
	{
		gameObject.rigidbody2D.AddForce(-Vector2.right * Pitcher.Thrust);
		if(_onMouse && Input.GetKeyDown(KeyCode.Mouse0))
		{
			_currentHealth--;
		}
		if(_currentHealth <= 0)
		{
			gameObject.Recycle();
			Referee.Score += Price;
		}
	}

	private void OnMouseEnter()
	{
		_onMouse = true;
	}
	
	private void OnMouseExit()
	{
		_onMouse = false;
	}
}