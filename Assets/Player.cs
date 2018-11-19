using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

  float downSpeed; //落下速度
  Rigidbody2D rb;  //物理演算コンポーネント
	// Use this for initialization
	void Start () { // 初期化処理
		  rb = GetComponent<Rigidbody2D>();
      downSpeed = 0;
	}

	// Update is called once per frame
	void Update () {
    RaycastHit2D hit;
    hit = Physics2D.Raycast(transform.position + new Vector3(-0.32f, -0.32f), Vector2.right, 0.64f);
    if (hit.transform != null) {
      if (Input.GetButtonDown("Jump")) {
        downSpeed = 6.5f;
      }
    }

		downSpeed += -0.3f;
    Vector2 nowpos = rb.position;
    nowpos += new Vector2(0, downSpeed) * Time.deltaTime;
    rb.MovePosition(nowpos);
	}
}
