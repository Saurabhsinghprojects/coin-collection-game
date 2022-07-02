using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public static int CoinCount = 0;
    //A static variable is declared with the help of static keyword. When a variable is declared as static, then a single copy of the variable is created and shared among all objects at the class level. Static variables are accessed with the name of the class, they do not require any object for access.

    void Start()
    {
        CoinCount++;

    }
    void OnTriggerEnter(Collider Col)
    {
        //if player collided then destroy the coin see current object is coin so hm destroy(gameobject) likh skte hain bcz no need to specify the coin as it is game object itself 
         if (Col.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

    }

    void OnDestroy()
    {
        CoinCount--;
        if (CoinCount <= 0)
        {
            //We won 
            GameObject Timer = GameObject.Find("LevelTimer");
            Destroy(Timer);
            GameObject[] Fireworks = GameObject.FindGameObjectsWithTag("Fireworks");
            foreach(GameObject Go in Fireworks)
            {
                Go.GetComponent<ParticleSystem>().Play(); // notice that playonAwake = enabled work nhi kr raha hai
            }

        
        }

    } 
    void Update()
    {
       
    }
}
