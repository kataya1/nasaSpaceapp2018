using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	public Text timerText;
	private float startTime;
	[SerializeField] private Image customImage;
	[SerializeField] private Image customImage1;
	[SerializeField] private Image customImage2;
	[SerializeField] private Image customImage3;
	[SerializeField] private Image customImage4;


	// Use this for initialization
	void Start () {
		startTime = Time.time;
		
	}
	
	// Update is called once per frame
	void Update () {
		float t = Time.time - startTime;

		string minutes = ((int)t / 60).ToString ();
		string seconds = (t % 60).ToString ("f0");

		timerText.text = minutes + ":" + seconds;

		if (((int)t % 60) == 10) {
			customImage.enabled = true;
		}
		if (((int)t % 60) == 15) {
			customImage.enabled = false;
		}
		if (((int)t % 60) == 20) {
			customImage1.enabled = true;
		}
		if (((int)t % 60)== 25) {
			customImage1.enabled = false;
		}
		if (((int)t % 60) == 30) {
			customImage2.enabled = true;
		}
		if (((int)t % 60) == 35) {
			customImage2.enabled = false;
		}
		if (((int)t % 60)== 40) {
			customImage3.enabled = true;
		}
		if (((int)t % 60) == 45) {
			customImage3.enabled = false;
		}
		if (((int)t % 60)== 50) {
			customImage4.enabled = true;
		}
		if (((int)t % 60) == 55) {
			customImage4.enabled = false;
		}


	}
}
