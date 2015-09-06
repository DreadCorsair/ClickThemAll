using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour 
{
	public int Price;
	public int Health;
	public float BasicSpeed;
	public float MaxSpeed;

	private float _speed;
	private int _health;
	private Image _healthBar;
	private bool _onMouse;


	private void Start()
	{
		_speed = BasicSpeed;
		Referee.LevelUp += SpeedUp;
	}

	private void OnEnable() 
	{
		_health = Health;
		_healthBar = transform.FindChild("EnemyCanvas").
							   FindChild("HealthBarBg").
				               FindChild("HealthBarFill").
				               GetComponent<Image>();
		_healthBar.fillAmount = 1;

		_onMouse = false;
	}

	private void Update()
	{
		gameObject.rigidbody2D.velocity = -Vector2.right * _speed;

		if(_onMouse && Input.GetKeyDown(KeyCode.Mouse0))
		{
			_health--;
			_healthBar.fillAmount = (float)_health / (float)Health;
		}
		if(_health <= 0)
		{
			gameObject.Recycle();
			Statistics.Score += Price;
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

	public void SpeedUp()
	{
		float newSpeed = _speed + 0.01f * BasicSpeed * Statistics.Level;
		if(newSpeed < MaxSpeed)
			_speed = newSpeed;
	}
}