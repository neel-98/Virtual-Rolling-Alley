using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exit : MonoBehaviour
{
	TMP_Text log;
    // Start is called before the first frame update
    void Start()
    {
        log = GameObject.FindWithTag("Log").GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
        	log.text = "Exit";
        }
    }
}
