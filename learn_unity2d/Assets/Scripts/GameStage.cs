using UnityEngine;
using System.Collections;

public class GameStage : MonoBehaviour
{
	void Start ()
	{
	}
	
	void Update ()
	{
		//マウスの左ボタンをクリック
		if(Input.GetMouseButtonUp(0)){
			Application.LoadLevel("Result");
		}
	}
	// GUI描画
	void OnGUI() {
		GUI.Label(new Rect(0,0,100,20),"GameStage");
	}
}
