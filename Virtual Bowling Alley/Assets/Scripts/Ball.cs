using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
	float timeToDestroy = 20.0f;
	bool audioPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Environment")
        {
        	destroyObject();
        }

        if((collision.gameObject.tag == "Pin") && (!audioPlayed))
        {
        	//play the audio
        	gameObject.GetComponent<AudioSource>().Play();
        	audioPlayed = true;
        }
    }

    void destroyObject()
    {
    	Destroy(gameObject, timeToDestroy);
    }

}
