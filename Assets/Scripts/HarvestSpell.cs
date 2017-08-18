using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HarvestSpell : MonoBehaviour {
    public Resources resource;
    public Text timeRemaining;
    public GameObject sapling;
    private bool touchingTree = false;
    private bool touchingSand = false;
    private bool touchingIron = false;
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
        if (touchingSand && Input.GetMouseButtonDown(0) && currentTime >= 3f && resource.getSelected() == 1 && resource.getMagic() >= 10f)
        {
            resource.addSand(1);
            currentTime = 0f;
            resource.drainMagic(10f);
        }
        if (touchingIron && Input.GetMouseButtonDown(0) && currentTime >= 3f && resource.getSelected() == 1 && resource.getMagic() >= 10f)
        {
            resource.addIron(1);
            currentTime = 0f;
            resource.drainMagic(10f);
        }
        if (currentTime <= 3f)
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
        if (other.gameObject.CompareTag("MaterialSand"))
        {
            touchingSand = true;
        }
        if (other.gameObject.CompareTag("MaterialIron"))
        {
            touchingIron = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("TreeTrunk"))
        {
            touchingTree = false;
        }
        if (other.gameObject.CompareTag("MaterialSand"))
        {
            touchingSand = false;
        }
        if (other.gameObject.CompareTag("MaterialIron"))
        {
            touchingIron = false;
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("MaterialSand") && currentTime >= 3f && resource.getSelected() == 1 && resource.getMagic() >= 20f && Input.GetMouseButtonDown(0))
        {
            other.gameObject.SetActive(false);
        }
        if (other.gameObject.CompareTag("MaterialIron") && currentTime >= 3f && resource.getSelected() == 1 && resource.getMagic() >= 20f && Input.GetMouseButtonDown(0))
        {
            other.gameObject.SetActive(false);
        }
    }
}
