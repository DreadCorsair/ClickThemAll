using UnityEngine;

public class Target : MonoBehaviour 
{
	public int Price;
	public int MaxHealth;

	private int _currentHealth;
	private bool _onMouse;

	void Start() 
	{
		_currentHealth = MaxHealth;
		_onMouse = false;
	}
	
	void Update() 
	{
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

	void OnMouseEnter()
	{
		_onMouse = true;
	}
	
	void OnMouseExit()
	{
		_onMouse = false;
	}

}