using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
	public GameObject PinSpawner;
	public GameObject setOfPinsPrefab;
	public int firstCountPoints;
	public int secondCountPoints;
	bool firstCountDone = false;
	public int finalPoints;

	int totalRounds = 5;
	int round = 1;

	public int totalPoints = 0;

	TMP_Text log;


    // Start is called before the first frame update
    void Start()
    {
        log = GameObject.FindWithTag("Log").GetComponent<TMP_Text>();
        resetPins();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CountPoints()
    {
    	// log.text += "Round" + round.ToString() + "\n";
    	if(round<=totalRounds)
    	{
    		if(!firstCountDone)
	    	{
	    		firstCountPoints = 10 - PinSpawner.transform.GetChild(0).childCount;
	    		// log.text += "first" + firstCountPoints.ToString() + "\n";
	    		firstCountDone = true;
	    	}
	    	else
	    	{
	    		finalPoints = 10 - PinSpawner.transform.GetChild(0).childCount;
	    		secondCountPoints = finalPoints - firstCountPoints;
	    		totalPoints += finalPoints;
	    		round++;
	    		firstCountDone = false;
	    		// log.text += "second" + secondCountPoints.ToString() + "\n";
	    		// log.text += "Total" + totalPoints.ToString() + "\n";
	    		resetPins();
	    	}
    	}
    }

    void resetPins()
    {
    	Destroy(PinSpawner.transform.GetChild(0).gameObject);
    	GameObject g = Instantiate(setOfPinsPrefab, PinSpawner.transform);
    	g.transform.parent = PinSpawner.transform;
    }
}
