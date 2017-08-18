using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaplingGrow : MonoBehaviour {
    public GameObject tree;
    float originX;
    float originY;
    float originZ;
	// Use this for initialization
	void Start () {
        originX = transform.position.x;
        originY = transform.position.y;
        originZ = transform.position.z;
    }
	
	// Update is called once per frame
	void Update () {
        gameObject.transform.localScale = new Vector3(transform.localScale.x + .006f, transform.localScale.y + .006f, transform.localScale.z + .006f);
        if(transform.localScale.x >= 1f)
        {
            gameObject.SetActive(false);
            Instantiate(tree, new Vector3(originX, originY + 2, originZ), Quaternion.identity);
        }
	}
}
