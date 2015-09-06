using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour 
{
	public int Price;
	public int MaxHealth;

	private int _currentHealth;
	private Image _healthBar;
	private bool _onMouse;
	private float _thrust;

	public static event EventController.VoidMethodContainer Die;

	private void OnEnable() 
	{
		_currentHealth = MaxHealth;
		_healthBar = transform.FindChild("EnemyCanvas").
							   FindChild("HealthBarBg").
				               FindChild("HealthBarFill").
				               GetComponent<Image>();
		_healthBar.fillAmount = 1;
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
			_healthBar.fillAmount = (float)_currentHealth / (float)MaxHealth;
		}
		if(_currentHealth <= 0)
		{
			gameObject.Recycle();
			Die();
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