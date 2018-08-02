using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickerController : MonoBehaviour {

  private float rotSpeed = 0;
  private int cnt = 0;

  // オーディオ
  private AudioSource soundMokyu;
  private AudioSource soundMoi;

  void Start () {
    // AudioSourceコンポーネントを取得し、変数に格納
    AudioSource[] audioSources = GetComponents<AudioSource>();
    this.soundMokyu = audioSources[0];
    this.soundMoi = audioSources[1];
  }

  void Update(){

      if (Input.GetMouseButtonDown(0)){
          this.rotSpeed += 50;
          this.cnt++;
          // 効果音の再生
          if (cnt%5 == 0) {
            soundMoi.PlayOneShot(soundMoi.clip);
          } else {
            soundMokyu.PlayOneShot(soundMokyu.clip);
          }
      }

      // 回転速度分、モイちゃんを回転させる
      transform.Rotate(0, this.rotSpeed, 0);

      // ルーレットを減速
      this.rotSpeed *= 0.96f;
  }
}
