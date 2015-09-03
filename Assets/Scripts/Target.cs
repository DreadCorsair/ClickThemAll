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
		float thrust = Pitcher.Thrust;
		gameObject.rigidbody2D.AddForce(-Vector2.right * thrust);
		if(_onMouse && Input.GetKeyDown(KeyCode.Mouse0))
		{
			_currentHealth--;
		}
		if(_currentHealth <= 0)
		{
			_currentHealth = MaxHealth;
			_onMouse = false;
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