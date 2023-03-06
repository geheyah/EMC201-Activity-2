using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalObjective : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D collision)
	{
		switch (collision.gameObject.tag)
		{
			case "Player":
				Debug.Log("Congratulations you've won");
				break;

			default:
				break;
		}
	}
}
