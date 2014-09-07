using UnityEngine;
using System.Collections;

public class Title : MonoBehaviour
{
	void Start ()
	{
	}
	
	void Update ()
	{
		//マウスの左ボタンをクリック
		if(Input.GetMouseButtonUp(0)){
			Application.LoadLevel("GameStage");
		}
	}
	// GUI描画
	void OnGUI() {
		GUI.Label(new Rect(0,0,100,20),"タイトル");
	}
}
