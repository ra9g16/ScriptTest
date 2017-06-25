using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private int mp = 53;	// MP

	// Magic関数
	public void Magic() {
		this.mp -= 5;
		if (mp < 0) {
			Debug.Log ("MPが足りないため魔法が使えない");
		} else {
			Debug.Log ("魔法攻撃した。残りMPは"+mp);
		}
			
	}
}

public class Test : MonoBehaviour {

	void Start () {
		int[] points = {4, 6, 1, 2, 7};		//配列の宣言及び初期化
		for (int i = 0; i < 5; i++) {		//配列の各要素を順に表示
			Debug.Log (points [i]);
		}
		for (int i = 4; i >= 0; i--) {		//配列の各要素を逆順に表示
			Debug.Log (points [i]);
		}

		// Bossクラスの変数を宣言してインスタンスを代入
		Boss lastboss = new Boss ();
		// Magic関数を11回呼び出す
		lastboss.Magic ();
		lastboss.Magic ();
		lastboss.Magic ();
		lastboss.Magic ();
		lastboss.Magic ();
		lastboss.Magic ();
		lastboss.Magic ();
		lastboss.Magic ();
		lastboss.Magic ();
		lastboss.Magic ();
		lastboss.Magic ();
	}

	void Update () {

	}
}
