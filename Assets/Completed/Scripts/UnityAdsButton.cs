using UnityEngine;
using System.Collections;

using UnityEngine.Advertisements;

public class UnityAdsButton : MonoBehaviour
{
	void Start() {
		if (Application.platform == RuntimePlatform.Android) {
			Advertisement.Initialize("1076548");
			Debug.Log("Android !!!");
		} else if (Application.platform == RuntimePlatform.IPhonePlayer) {
			Advertisement.Initialize("1076547");
			Debug.Log("iOS !!!");
		} else {
			Advertisement.Initialize("1076548");
			Debug.Log("Others !!!");
		}
		Debug.Log("start!!!");
	}

	public void OnClick()
	{
		Debug.Log("ready? : " + Advertisement.IsReady());
		if (Advertisement.IsReady())
		{
			Advertisement.Show();
			Debug.Log("Show!");
		}
		Debug.Log("on click End");
	}
}