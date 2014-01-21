using UnityEngine;
using System.Collections;

public class PlantScript : MonoBehaviour {

	//Variables
	public bool gene1 = false;
	public bool gene2 = false;
	
	public bool isInBasket = false;
	public bool isTopPsquare = false;
	public bool isSidePsquare = false;

	public bool hasFocus = false;	
	float jitter = 0.002f;
	float currentjitterX = 0.0f;
	float currentjitterY = 0.0f;
	bool jitterX = false;
	bool jitterY = false;
	public Vector3 HoldPosition;
	//public 


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(jitterX) {
			if(currentjitterX < jitter * 2){
				currentjitterX += 0.0005f;
			}
			else {
				jitterX = false;
			}
		}
		else {
			if (currentjitterX > -(jitter * 2)) {
				currentjitterX -= 0.0005f;
			}
			else {
				jitterX = true;
			}
		}


		if(jitterY) {
			if(currentjitterY < jitter){
				currentjitterY += 0.005f;
			}
			else {
				jitterY = false;
			}
		}
		else {
			if (currentjitterY > -jitter) {
				currentjitterY -= 0.005f;
			}
			else {
				jitterY = true;
			}
		}

		if(hasFocus){
			gameObject.transform.position = HoldPosition + new Vector3(currentjitterX, currentjitterY);
		}
	}

	public void updateFocus(Vector3 v)
	{
		HoldPosition = v;
		gameObject.transform.position = v;
		hasFocus = false;
	}

	void OnMouseDown()
	{		
		if(!hasFocus)
		{
			hasFocus = true;
			HoldPosition = gameObject.transform.position;
		}
		else
		{
			hasFocus = false;
			gameObject.transform.position = HoldPosition;
		}

	}


}
