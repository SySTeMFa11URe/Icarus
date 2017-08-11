using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HarvestSpell : MonoBehaviour {
    public Resources resource;
    public Text timeRemaining;
    private bool touchingTree = false;
    private float currentTime = 0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(touchingTree && Input.GetMouseButtonDown(0) && currentTime >= 3f && resource.getSelected() == 1 && resource.getMagic() >= 20f)
        {
            resource.addWood(1);
            currentTime = 0f;
            resource.drainMagic(20f);
        }
        if(touchingTree && currentTime <= 3f)
        {
            timeRemaining.enabled = true;
            timeRemaining.text = System.Math.Round(3 - currentTime, 2) + "s";
        }
        else
        {
            timeRemaining.enabled = false;
        }
        currentTime += Time.deltaTime;
	}
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("TreeTrunk"))
        {
            touchingTree = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("TreeTrunk"))
        {
            touchingTree = false;
        }
    }
}
