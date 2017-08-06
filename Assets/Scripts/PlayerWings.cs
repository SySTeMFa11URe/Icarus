using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWings : MonoBehaviour {
    bool wingsActive = false;
    bool stopDownMotion = false;
    public float flySpeed = 0.1f;
    private Rigidbody rbody;
	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            toggleWings();
        }
        if (wingsActive)
        {
            rbody.useGravity = false;
            if (Input.GetKey(KeyCode.Space))
            {
                //transform.Translate(Vector3.up * flySpeed);
                rbody.AddForce(Vector3.up * 10);
            }
            else if(!(stopDownMotion))
            {
                //transform.Translate(Vector3.down * .05f);
                rbody.AddForce(Vector3.down * 40);
            }
        }
        else
        {
            rbody.useGravity = true;
        }
	}
    private void toggleWings()
    {
        if (wingsActive)
        {
            wingsActive = false;
        }
        else
        {
            wingsActive = true;
        }
    }
    public bool getWingState()
    {
        return wingsActive;
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            rbody.velocity = Vector3.zero;
            rbody.angularVelocity = Vector3.zero;
            stopDownMotion = true;
        }
    }
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.CompareTag("Floor"))
        {
            stopDownMotion = false;
        }
    }
}
