using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour 
{
	public int Price;
	public int Health;

	public float BasicSpeed;
	public float MaxSpeed;

	private int _health;
	private float _speed;
	private Image _healthBar;
	private bool _onMouse;

	private Transform _spriteTrans;
	private int _randomDirection;

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

		_spriteTrans = transform.FindChild ("sprite").transform;
		System.Random rand = new System.Random ();
		_randomDirection = rand.Next (-2, 2);

		_onMouse = false;
	}

	private void Update()
	{
		gameObject.GetComponent<Rigidbody2D>().velocity = -Vector2.right * _speed;
		_spriteTrans.Rotate (new Vector3(0f, 0f, _randomDirection != 0 ? _randomDirection : 1) * _speed);

		if(_health <= 0)
		{
			gameObject.Recycle();
			Statistics.Score += Price;
		}
	}

	public void Hit()
	{
		_health--;
		_healthBar.fillAmount = (float)_health / (float)Health;
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
		float newSpeed = _speed + 0.05f * BasicSpeed * Statistics.Level;
		if(newSpeed < MaxSpeed)
			_speed = newSpeed;
	}
}