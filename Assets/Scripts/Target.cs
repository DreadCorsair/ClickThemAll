using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour 
{
	public int Price;
	public int Health;
	public float BasicSpeed;

	private int _health;
	private Image _healthBar;
	private bool _onMouse;


	private void OnEnable() 
	{
		_health = Health;
		_healthBar = transform.FindChild("EnemyCanvas").
							   FindChild("HealthBarBg").
				               FindChild("HealthBarFill").
				               GetComponent<Image>();
		_healthBar.fillAmount = 1;
		gameObject.rigidbody2D.velocity = -Vector2.right * BasicSpeed;
		_onMouse = false;
	}

	private void Update() 
	{
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
}