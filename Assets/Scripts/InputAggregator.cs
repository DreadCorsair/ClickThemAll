using UnityEngine;

public class InputAggregator : MonoBehaviour 
{
	public static event EventController.MethodContainer EscKeyDown;

	private void Update() 
	{
		if(Input.GetKeyDown(KeyCode.Escape) && !EscMenu.IsLocked) EscKeyDown();

		int nbTouches = Input.touchCount;
		
		if (nbTouches > 0) 
		{
			for(int i = 0; i < nbTouches; i++)
			{
				Touch touch = Input.GetTouch(i);
				
				if(touch.phase == TouchPhase.Began)
				{
					RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(touch.position), Vector2.zero);
					if(hit.collider != null)
					{
						hit.collider.gameObject.GetComponent<Target>().Hit();
					}
				}
			}
		}
	}
}