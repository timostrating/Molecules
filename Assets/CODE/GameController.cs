using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	[SerializeField] GameObject prefab;
	[SerializeField] float startVelocity = 3;
	

	void Start () {
		for (int x = 0; x < 4; x++) {
			for (int y = 0; y < 8; y++) {
				Instantiate(prefab, new Vector3(x-4,y-4,0), Quaternion.identity).GetComponent<Rigidbody2D>().velocity = new Vector3(
					Random.Range(-startVelocity, startVelocity),
					Random.Range(-startVelocity, startVelocity),
					0);
			}
		}
	}
}
