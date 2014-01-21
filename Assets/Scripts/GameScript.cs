using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameScript : MonoBehaviour {
	
	//Variables
	public GameObject PlantOO;
	public GameObject PlantOo;
	public GameObject Plantoo;

	protected GameObject[] plants = new GameObject[12];

	// Use this for initialization
	void Start () {
		Vector3 v = new Vector3(0.685f, 0.616f, 0.1f);
		GameObject go = Instantiate(PlantOO,v,Quaternion.identity) as GameObject;
		go.GetComponent<PlantScript>().gene1 = true;
		go.GetComponent<PlantScript>().gene2 = true;
		go.GetComponent<PlantScript>().currentPosition = 2;
		plants[2] = go;

		Vector3 v2 = new Vector3(0.8f, 0.616f, 0.1f);
		GameObject go2 = Instantiate(PlantOo,v2,Quaternion.identity) as GameObject;
		go2.GetComponent<PlantScript>().gene1 = true;
		go2.GetComponent<PlantScript>().gene2 = false;
		go2.GetComponent<PlantScript>().currentPosition = 3;
		plants[3] = go2;
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0))
		{
			GameObject go = null;
			foreach(GameObject g in plants)
			{
				if(g != null) {
					if (g.GetComponent<PlantScript>().hasFocus)
					{
						go = g;
					}
				}
			}

			if(go != null)
			{
				Vector3 areaClicked = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
				
				if(areaClicked.x > -2.6f && areaClicked.x < -0.4f && areaClicked.y > 0.4f && areaClicked.y < 2.7f && plants[0] == null){
					go.GetComponent<PlantScript>().updateFocus(new Vector3(0.418f, 0.635f, 0.1f));
					plants[0] = go;
					plants[go.GetComponent<PlantScript>().currentPosition] = null;
					go.GetComponent<PlantScript>().currentPosition = 0;
					go.GetComponent<PlantScript>().isTopPsquare = true;
					go.GetComponent<PlantScript>().isSidePsquare = false;
					clearSquare();
					updateSquare();
					if (checkWin()) {
						Application.LoadLevel(1);
					}
				}
				if(areaClicked.x > -5.0f && areaClicked.x < -2.8f && areaClicked.y > -2.1f && areaClicked.y < 0.2f && plants[1] == null){
					go.GetComponent<PlantScript>().updateFocus(new Vector3(0.295f, 0.39f, 0.1f));
					plants[1] = go;
					plants[go.GetComponent<PlantScript>().currentPosition] = null;
					go.GetComponent<PlantScript>().currentPosition = 1;
					go.GetComponent<PlantScript>().isTopPsquare = false;
					go.GetComponent<PlantScript>().isSidePsquare = true;
					clearSquare();
					updateSquare();
					if (checkWin()) {
						Application.LoadLevel(1);
					}
				}
				if(areaClicked.x > 2.5f && areaClicked.x < 4.5f && areaClicked.y > 0.1f && areaClicked.y < 2.5f && plants[2] == null){
					go.GetComponent<PlantScript>().updateFocus(new Vector3(0.685f, 0.616f, 0.1f));
					plants[2] = go;
					plants[go.GetComponent<PlantScript>().currentPosition] = null;
					go.GetComponent<PlantScript>().currentPosition = 2;
					go.GetComponent<PlantScript>().isTopPsquare = false;
					go.GetComponent<PlantScript>().isSidePsquare = false;
					clearSquare();
					updateSquare();
					if (checkWin()) {
						Application.LoadLevel(1);
					}
				}
				if(areaClicked.x > 4.7f && areaClicked.x < 6.7f && areaClicked.y > 0.1f && areaClicked.y < 2.5f && plants[3] == null){
					go.GetComponent<PlantScript>().updateFocus(new Vector3(0.8f, 0.616f, 0.1f));
					plants[3] = go;
					plants[go.GetComponent<PlantScript>().currentPosition] = null;
					go.GetComponent<PlantScript>().currentPosition = 3;
					go.GetComponent<PlantScript>().isTopPsquare = false;
					go.GetComponent<PlantScript>().isSidePsquare = false;
					clearSquare();
					updateSquare();
					if (checkWin()) {
						Application.LoadLevel(1);
					}
				}
				if(areaClicked.x > 6.9f && areaClicked.x < 8.9f && areaClicked.y > 0.1f && areaClicked.y < 2.5f && plants[4] == null){
					go.GetComponent<PlantScript>().updateFocus(new Vector3(0.915f, 0.616f, 0.1f));
					plants[4] = go;
					plants[go.GetComponent<PlantScript>().currentPosition] = null;
					go.GetComponent<PlantScript>().currentPosition = 4;
					go.GetComponent<PlantScript>().isTopPsquare = false;
					go.GetComponent<PlantScript>().isSidePsquare = false;
					clearSquare();
					updateSquare();
					if (checkWin()) {
						Application.LoadLevel(1);
					}
				}
				if(areaClicked.x > 2.5f && areaClicked.x < 4.5f && areaClicked.y > -2.6f && areaClicked.y < -0.1f && plants[5] == null){
					go.GetComponent<PlantScript>().updateFocus(new Vector3(0.685f, 0.355f, 0.1f));
					plants[5] = go;
					plants[go.GetComponent<PlantScript>().currentPosition] = null;
					go.GetComponent<PlantScript>().currentPosition = 5;
					go.GetComponent<PlantScript>().isTopPsquare = false;
					go.GetComponent<PlantScript>().isSidePsquare = false;
					clearSquare();
					updateSquare();
					if (checkWin()) {
						Application.LoadLevel(1);
					}
				}
				if(areaClicked.x > 4.7f && areaClicked.x < 6.7f && areaClicked.y > -2.6f && areaClicked.y < -0.1f && plants[6] == null){
					go.GetComponent<PlantScript>().updateFocus(new Vector3(0.8f, 0.355f, 0.1f));
					plants[6] = go;
					plants[go.GetComponent<PlantScript>().currentPosition] = null;
					go.GetComponent<PlantScript>().currentPosition = 6;
					go.GetComponent<PlantScript>().isTopPsquare = false;
					go.GetComponent<PlantScript>().isSidePsquare = false;
					clearSquare();
					updateSquare();
					if (checkWin()) {
						Application.LoadLevel(1);
					}
				}
				if(areaClicked.x > 6.9f && areaClicked.x < 8.9f && areaClicked.y > -2.6f && areaClicked.y < -0.1f && plants[7] == null){
					go.GetComponent<PlantScript>().updateFocus(new Vector3(0.915f, 0.355f, 0.1f));
					plants[7] = go;
					plants[go.GetComponent<PlantScript>().currentPosition] = null;
					go.GetComponent<PlantScript>().currentPosition = 7;
					go.GetComponent<PlantScript>().isTopPsquare = false;
					go.GetComponent<PlantScript>().isSidePsquare = false;
					clearSquare();
					updateSquare();
					if (checkWin()) {
						Application.LoadLevel(1);
					}
				}
			}
		}
	}

	void clearSquare() {
		for(int i = 8; i < plants.Length; i++) {
			Destroy(plants[i]);
		}
	}

	void updateSquare() {

		GameObject topPlant = null;
		GameObject sidePlant = null;
		
		foreach(GameObject plant in plants) {
			if (plant != null) {
				if (plant.GetComponent<PlantScript>().isTopPsquare) topPlant = plant;
				if (plant.GetComponent<PlantScript>().isSidePsquare) sidePlant = plant;
			}
		}
		if (topPlant != null && sidePlant != null) {
			for (int i = 8; i < plants.Length; i++) {
				bool firstGene;
				bool secondGene;
				
				if (i % 2 == 0) {
					firstGene = topPlant.GetComponent<PlantScript>().gene1;
				}
				else {
					firstGene = topPlant.GetComponent<PlantScript>().gene2;
				}
				
				if (i < 10) {
					secondGene = sidePlant.GetComponent<PlantScript>().gene1;
				}
				else {
					secondGene = sidePlant.GetComponent<PlantScript>().gene2;
				}
				
				float offsetx = .123f;
				float offsety = .245f;
				Vector3 pos = new Vector3(.418f + (i % 2 == 1 ? offsetx : 0f), .39f - (i >= 10 ? offsety : 0f), 0.1f);
				                          
            	if (firstGene && secondGene) {
					GameObject plant = Instantiate(PlantOO, pos, Quaternion.identity) as GameObject;
					plant.GetComponent<PlantScript>().gene1 = true;
					plant.GetComponent<PlantScript>().gene2 = true;
					plant.GetComponent<PlantScript>().currentPosition = i;
					plants[i] = plant;
				}
				else if (firstGene || secondGene) {
					GameObject plant = Instantiate(PlantOo, pos, Quaternion.identity) as GameObject;
					plant.GetComponent<PlantScript>().gene1 = true;
					plant.GetComponent<PlantScript>().gene2 = false;
					plant.GetComponent<PlantScript>().currentPosition = i;
					plants[i] = plant;
				}
				else {
					GameObject plant = Instantiate(Plantoo, pos, Quaternion.identity) as GameObject;
					plant.GetComponent<PlantScript>().gene1 = false;
					plant.GetComponent<PlantScript>().gene2 = false;
					plant.GetComponent<PlantScript>().currentPosition = i;
					plants[i] = plant;
				}
			}
		}
	}

	bool checkWin() {
		bool hasDominant = false;
		bool hasMixed = false;
		bool hasRecessive = false;
		for (int i = 0; i < plants.Length - 4; i++) {
			if (plants[i] != null) {
				if (plants[i].GetComponent<PlantScript>().gene1) {
					if (plants[i].GetComponent<PlantScript>().gene2) hasDominant = true;
					else hasMixed = true;
				}
				else {
					if (plants[i].GetComponent<PlantScript>().gene2) hasMixed = true;
					else hasRecessive = true;
				}
			}
		}
		
		if (hasDominant && hasMixed && hasRecessive) {
			return true;
		}
		return false;
	}
}
