using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartGenerator : MonoBehaviour {

	public GameObject heartPrefab;
	private int cnt = 0;

	void Start () {
	}

	void Update () {

		if (Input.GetMouseButtonDown(0)){
				this.cnt++;
				// ハートの生成
				if (cnt%5 == 0) {
					Instantiate (heartPrefab, new Vector3 (-2.0f, 1.0f, 0.0f), Quaternion.identity);
					transform.Translate(0, 0.2f, 0);
				}
		}
	}

}
