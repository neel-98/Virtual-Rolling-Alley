using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject[] balls;
    public float ballSpeed = 2.0f;

    float timer = 10.0f;  // time between each spawn
    // private variables
    float timeRemaining;    // to reset timer


    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = timer;      // initializing the timer for countdown
    }

    // Update is called once per frame
    void Update()
    {
        // it will stay in if condition if timer is not yet finished.
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        // it will go in else part if timer is finished
        else
        {
            // generating random index
            int selectedIndex = Random.Range(0, balls.Length);

            // Instantiating Block at index selected randomly
            GameObject ball = Instantiate(balls[selectedIndex], transform);

            // throwing ball with the speed of "ballSpeed"
            ball.GetComponent<Rigidbody>().velocity = -(transform.forward).normalized * ballSpeed;

            // putting block under spawner so that all the blocks can be found under spawner
            ball.transform.parent = gameObject.transform;

            // reseting the timer
            timeRemaining = timer;
            
        }
    }

}