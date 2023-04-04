using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pin : MonoBehaviour
{
	TMP_Text log;
	bool marked = false;
	float timeToDestroy = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        log = GameObject.FindWithTag("Log").GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
    	// if(!marked)
    	// {
    	// 	if((gameObject.transform.rotation.x < -0.71) || (gameObject.transform.rotation.x > -0.69))
	    //     {
	    //     	Debug.Log(gameObject.transform.rotation.x);
	    //     	marked = true;
	    //     	Destroy(gameObject, 5);
	    //     }
    	// }
        
    }

    void OnCollisionEnter(Collision collision)
    {
    	if(!marked)
    	{
    		if((collision.collider.tag == "Pin") || (collision.collider.tag == "Ball"))
	        {
	        	marked = true;
	        	Destroy(gameObject, timeToDestroy);
	        }
    	}
        
    }

}
