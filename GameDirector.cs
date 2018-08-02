using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// UnityEngine.UIを追加しましょう！
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {

	public GameObject moichang;
	public GameObject counter;
	private int cnt = 0;

	void Start () {
		this.moichang = GameObject.Find("moichang");
		this.counter = GameObject.Find("Counter");
	}

	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			cnt ++;
			this.counter.GetComponent<Text>().text =
				"モイちゃんを" + cnt.ToString() + "回なでた！";
		}

	}
}
