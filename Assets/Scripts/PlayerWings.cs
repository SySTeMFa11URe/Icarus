using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerWings : MonoBehaviour {
    bool wingsActive = false;
    bool stopDownMotion = false;
    public float flySpeed = 0.1f;
    public RawImage wingIcon;
    private Rigidbody rbody;
    public Resources resource;
	// Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        if(transform.position.y <= -100)
        {
            SceneManager.LoadScene("main");
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Toggled");
            toggleWings();
        }
        if (resource.getMagic() <= 0)
        {
            wingsActive = false;
        }
        if (wingsActive)
        {
            wingIcon.enabled = true;
            rbody.useGravity = false;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                //transform.Translate(Vector3.up * flySpeed);
                rbody.velocity = Vector3.zero;
                rbody.angularVelocity = Vector3.zero;
            }
            if (Input.GetKey(KeyCode.Space))
            {
                //transform.Translate(Vector3.up * flySpeed);
                rbody.AddForce(Vector3.up * 13);
                resource.drainMagic(.1f);
            }
            else if(!(stopDownMotion))
            {
                //transform.Translate(Vector3.down * .05f);
                rbody.AddForce(Vector3.down * 40);
                resource.drainMagic(.02f);
            }
        }
        else
        {
            wingIcon.enabled = false;
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
