using UnityEngine;

public class Target : MonoBehaviour 
{
	public int Price;
	public int MaxHealth;

	private int _currentHealth;
	private bool _onMouse;
	private float _thrust;

	private void OnEnable() 
	{
		_currentHealth = MaxHealth;
		_onMouse = false;
		_thrust = 0.0f;
	}
	
	private void Update() 
	{
		if(gameObject.tag == "circle")
			_thrust = Pitcher.CircleThrust;
		else if(gameObject.tag == "square")
			_thrust = Pitcher.SquareThrust;

		//move
		gameObject.rigidbody2D.AddForce(-Vector2.right * _thrust);

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