using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour {

	public GameObject carPrefab;
	public GameObject coinPrefab;
	public GameObject conePrefab;
	private int startPos = -205;
	private int goalPos = 75;
	private float posRange = 3.4f;

	private GameObject unityChan;
	private float sparnRange;
	private float sparnCount = 0;

	// Use this for initialization
	void Start () {
		unityChan = GameObject.Find("unitychan");


	}
	
	// Update is called once per frame
	void Update () {
		sparnRange = unityChan.transform.position.z + 45;
		sparnCount += Time.deltaTime;
		if (sparnRange > startPos && sparnRange < goalPos && sparnCount > 1) {
			//int num = Random.Range (1, 2);
			SparnItem ();
			sparnCount = 0;
		}

		Debug.Log (sparnCount);
		//unity -160 以上 120以下
		//sparn Range unityちゃん+45
		//ツアmり startPos -205 goalPos 75

	}

	void SparnItem(){
			//どのアイテムを出すのかをランダムに設定
			int num = Random.Range (0, 10);
			if (num <= 1) {
				//コーンをx軸方向に一直線に生成
				for (float j = -1; j <= 1; j += 0.4f) {
					GameObject cone = Instantiate (conePrefab) as GameObject;
				cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, sparnRange);
				}
			} else {

				//レーンごとにアイテムを生成
				for (int j = -1; j < 2; j++) {
					//アイテムの種類を決める
					int item = Random.Range (1, 11);
					//アイテムを置くZ座標のオフセットをランダムに設定
					int offsetZ = Random.Range (-5, 6);
					//60%コイン配置:30%車配置:10%何もなし
					if (1 <= item && item <= 6) {
						//コインを生成
						GameObject coin = Instantiate (coinPrefab) as GameObject;
					coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, sparnRange + offsetZ);
					} else if (7 <= item && item <= 9) {
						//車を生成
						GameObject car = Instantiate (carPrefab) as GameObject;
					car.transform.position = new Vector3 (posRange * j, car.transform.position.y, sparnRange + offsetZ);
					}
				}
			}
	}
}
