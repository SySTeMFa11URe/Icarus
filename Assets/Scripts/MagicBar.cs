using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MagicBar : MonoBehaviour {
    public Resources resource;
    public Slider magicBar;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
        magicBar.value = resource.getMagic() / 100;
	}
}
