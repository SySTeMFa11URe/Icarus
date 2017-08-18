using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeHideOnLaunch : MonoBehaviour {
    public GameObject treeTop1;
    public GameObject treeTop2;
    public GameObject treeTop3;
    public GameObject treeTrunk;
	// Use this for initialization
	void Start () {
        treeTop1.GetComponent<MeshRenderer>().enabled = false;
        treeTop2.GetComponent<MeshRenderer>().enabled = false;
        treeTop3.GetComponent<MeshRenderer>().enabled = false;
        treeTrunk.GetComponent<MeshRenderer>().enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		if(treeTrunk.activeSelf == false)
        {
            treeTop1.SetActive(false);
            treeTop2.SetActive(false);
            treeTop3.SetActive(false);
        }
    }
}
