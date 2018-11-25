using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Open : MonoBehaviour
{
	private Vector3 startPos;
	private int dir;
	private float floatDistance;
	void Start()
	{
		startPos = transform.position;
		dir = 1;	
	}

	void Update()
	{

	if (transform.position.y >= startPos.y + floatDistance)
		{
			dir = -1;
			floatDistance = 0;
		}
		if (transform.position.y < startPos.y - floatDistance)
		{
			dir = 1;
			floatDistance = 3;
		}

		transform.position = new Vector3(transform.position.x,transform.position.y+Time.deltaTime*dir, transform.position.z);
	}
}
