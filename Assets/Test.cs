using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss {
	private	int hp = 100;
	private	int power = 25;
	private int mp = 53; //発展課題 MP
	private int magicCost = 5;


	//	攻撃用の関数
	public void Attack(){
		Debug.Log( this.power + "のダメージを与えた");
	}

	//  防御用の関数
	public void Defence(int damage) {
		Debug.Log ( damage+"のダメージを受けた" );
		// 残りhpを減らす
		this.hp -= damage;
	}

	//  発展課題 魔法を使う
	public void Magic () {
		this.mp -= this.magicCost;
		if (this.mp > 0) {
			Debug.Log ("魔法攻撃をした。残りMPは" + this.mp);
		} else {
			Debug.Log ("MPが足りない");
			this.mp += this.magicCost; //使用してないので戻す
		}
	}


}
	
public class Test : MonoBehaviour {

	void Start () {
		//////////
		//課題 配列に関して 
		//////////

		// 配列を初期化
		int[] tmpArray = {5, 55, 555, 5555, 55555 };

		// 順に表示
		for (int i = 0; i < tmpArray.Length; i++) {
			Debug.Log(tmpArray[i]);
		}
		//逆順に表示
//		var arrayLength = tmpArray.Length;
		for (int i = 0; i < tmpArray.Length; i++) {
//			var tmpIndex = ;
			Debug.Log(tmpArray[tmpArray.Length - i -1]);
		}

		Boss lastboss = new Boss();

		//発展課題魔法攻撃用の関数を呼び出す
		lastboss.Magic();

		//魔法関数を10回使用する
		for (int j = 0; j < 10; j++) {
			lastboss.Magic ();
		}
//		// 攻撃用の関数を呼び出す
//		lastboss.Attack();
//		// 防御用の関数を呼び出す
//		lastboss.Defence(3);
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
