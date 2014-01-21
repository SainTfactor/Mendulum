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
	float jitter = 0.1f;
	float currentjitterX = 0.0f;
	float currentjitterY = 0.0f;
	bool jitterX = false;
	bool jitterY = false;
	Vector3 HoldPosition;
	//public 


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(jitterX) {
			if(currentjitterX < jitter * 2){
				currentjitterX += 0.005f;
			}
			else {
				jitterX = false;
			}
		}
		else {
			if (currentjitterX > -(jitter * 2)) {
				currentjitterX -= 0.005f;
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
			gameObject.transform.position += new Vector3(currentjitterX, currentjitterY);
		}
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
		}
	}


}
