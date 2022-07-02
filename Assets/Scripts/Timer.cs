using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //for using sceneManager
public class Timer : MonoBehaviour
{
    public float MaxTime = 60f;
    [SerializeField]
    private float CountDown = 0f;

    void Start()
    {
        CountDown = MaxTime;       
    }

   
    void Update()
    {
        CountDown -= Time.deltaTime;
        //here we have used time.deltaTime in update bcz suppose your game has 2fps then your deltaTime will be o.5 hence in 1sec update will invoke 2 times as 2fps so total time substracted from countdown is 2*0.5 =1sec

        if (CountDown<= 0f)
        {
            Coin.CoinCount = 0;
            SceneManager.LoadScene(0);// this is the new way of loading scene application.Loadlevel is Obsolete now
        }

    }
}
