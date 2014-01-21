using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameScript : MonoBehaviour {
	
	//Variables
	public GameObject PlantOO;
	public GameObject PlantOo;
	public GameObject Plantoo;
	
	protected GameObject[] pSquarePlants = new GameObject[4];

	protected List<GameObject> plants = new List<GameObject>();

	// Use this for initialization
	void Start () {
		Vector3 v = new Vector3(0.72f, 0.48f, 0.1f);
		GameObject go = Instantiate(PlantOO,v,Quaternion.identity) as GameObject;
		go.GetComponent<PlantScript>().isInBasket = true;
		go.GetComponent<PlantScript>().gene1 = true;
		go.GetComponent<PlantScript>().gene2 = true;
		plants.Add(go);

		Vector3 v2 = new Vector3(0.81f, 0.48f, 0.1f);
		GameObject go2 = Instantiate(PlantOo,v2,Quaternion.identity) as GameObject;
		go2.GetComponent<PlantScript>().isInBasket = true;
		go2.GetComponent<PlantScript>().gene1 = true;
		go2.GetComponent<PlantScript>().gene2 = false;
		plants.Add(go2);
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetMouseButtonDown(0))
		{
			GameObject go = null;
			foreach(GameObject g in plants)
			{
				if (g.GetComponent<PlantScript>().hasFocus)
				{
					go = g;
				}
			}

			if(go != null)
			{
				Vector3 areaClicked = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));

				Debug.Log(areaClicked);

				if(areaClicked.x > 3.1f && areaClicked.x < 5.4f && areaClicked.y > 0.1f && areaClicked.y < 2.5f){
					Debug.Log ("before: " + go.transform.position);
					go.GetComponent<PlantScript>().updateFocus(new Vector3(0.685f, 0.616f, 0.1f));
					Debug.Log ("after: " + go.transform.position);
				}
			}
		}
	}


	void updateSquare() {

		GameObject topPlant = null;
		GameObject sidePlant = null;
		
		foreach(GameObject plant in plants) {
			if (plant.GetComponent<PlantScript>().isTopPsquare) topPlant = plant;
			if (plant.GetComponent<PlantScript>().isSidePsquare) sidePlant = plant;
		}
		
		if (topPlant == null || sidePlant == null) {
			for(int i = 0; i < pSquarePlants.Length; i++) {
				pSquarePlants[i] = null;
			}
		}
		else {
			for (int i = 0; i < pSquarePlants.Length; i++) {
				bool firstGene;
				bool secondGene;
				
				if (i % 2 == 0) {
					firstGene = topPlant.GetComponent<PlantScript>().gene1;
				}
				else {
					firstGene = topPlant.GetComponent<PlantScript>().gene2;
				}
				
				if (i < 2) {
					secondGene = sidePlant.GetComponent<PlantScript>().gene1;
				}
				else {
					secondGene = sidePlant.GetComponent<PlantScript>().gene2;
				}
				
				int offset;// = //fill in later;
				Vector3 pos = new Vector3();// = new Vector3(/* Left side of square */ + (i % 2 == 1 ? offset : 0, /* Bottom of square */ + (i < 2 ? offset : 0));
				                          
            	if (firstGene && secondGene) {
					GameObject plant = Instantiate(PlantOO, pos, Quaternion.identity) as GameObject;
					plant.GetComponent<PlantScript>().gene1 = true;
					plant.GetComponent<PlantScript>().gene2 = true;
				}
				else if (firstGene || secondGene) {
					GameObject plant = Instantiate(PlantOo, pos, Quaternion.identity) as GameObject;
					plant.GetComponent<PlantScript>().gene1 = true;
					plant.GetComponent<PlantScript>().gene2 = false;
				}
				else {
					GameObject plant = Instantiate(Plantoo, pos, Quaternion.identity) as GameObject;
					plant.GetComponent<PlantScript>().gene1 = false;
					plant.GetComponent<PlantScript>().gene2 = false;
				}
			}
		}
	}
}
