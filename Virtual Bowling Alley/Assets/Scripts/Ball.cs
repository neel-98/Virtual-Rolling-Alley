using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ball : MonoBehaviour
{
	TMP_Text log;
	float timeToDestroy = 10.0f;
	bool audioPlayed = false;
	GameManager gamemanager;
	bool collisionwithFloor = false;

    // Start is called before the first frame update
    void Start()
    {
    	gamemanager = GameObject.FindWithTag("Manager").GetComponent<GameManager>();
    	log = GameObject.FindWithTag("Log").GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
    	if(!collisionwithFloor)
    	{
    		if(collision.gameObject.tag == "Environment")
	        {
	        	destroyObject();
	        	collisionwithFloor = true;
	        }
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
    	gamemanager.Invoke("CountPoints", timeToDestroy);
    	Destroy(gameObject, timeToDestroy);
    }

}
