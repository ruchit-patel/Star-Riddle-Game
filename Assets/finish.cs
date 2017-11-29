using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour {
	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name == "star") {
			Destroy (col.gameObject);
		}
	}

}
