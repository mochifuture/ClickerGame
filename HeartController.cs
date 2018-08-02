using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartController : MonoBehaviour {

	void Start () {
	}

	void Update () {
			// フレームごとに等速で移動
			transform.Translate(0, 0.05f, 0);

			// 消滅
			if (transform.position.y > 3.0f) {
				Destroy(gameObject);
			}
	}
}
