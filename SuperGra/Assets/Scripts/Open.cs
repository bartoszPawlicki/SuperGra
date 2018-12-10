using UnityEngine;
using System.Collections;
using UnityEditor.Build;
using UnityEngine.Networking;

public class Open : MonoBehaviour
{
	public Vector3 startPos;
	public int dir;
	public float floatDistance;
	void Start()
	{
		startPos = transform.position;
		dir = 1;
	}

	void Update()
	{
		if (EnemyHealth.remainingEnemies == 0){
//zjazd w dół
/*			if (transform.position.y >= startPos.y + floatDistance)
			{
				dir = -1;
				floatDistance = 0;
			}*/
			//góra
			if (transform.position.y < startPos.y - floatDistance)
			{
				dir = 1;
				floatDistance = 3;
			}

		if (transform.position.y < 3)
		{
			transform.position = new Vector3(transform.position.x, transform.position.y + Time.deltaTime * dir,
				transform.position.z);
		}
	}

}	
}

