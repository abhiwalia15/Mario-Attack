using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class countdownTimer : MonoBehaviour
{
	public float Timer = 10f;
	public Text timerSeconds;
	bool timerActive = true;
    // Start is called before the first frame update
    void Start()
    {
    	timerSeconds = GetComponent<Text>();
        
    }
  
    // Update is called once per frame
    void Update()
    {
    	if(timerActive == true){
Timer -= Time.deltaTime;

if(Timer <= 0){
        	timerActive = false;
        	Timer = 0f;
        	Debug.Log("Timer finished");
        }
    	}

        timerSeconds.text = Timer.ToString("f2");

        if (GameObject.FindGameObjectsWithTag("Player").Length == 0){

      GameObject enemy = Instantiate(Resources.Load("enemy", typeof(GameObject))) as GameObject;
      GameObject enemy1 = Instantiate(Resources.Load("enemy1", typeof(GameObject))) as GameObject;
      GameObject enemy2 = Instantiate(Resources.Load("enemy2", typeof(GameObject))) as GameObject;
      GameObject enemy3 = Instantiate(Resources.Load("enemy3", typeof(GameObject))) as GameObject;
       GameObject enemy4 = Instantiate(Resources.Load("enemy4", typeof(GameObject))) as GameObject;
        GameObject enemy5 = Instantiate(Resources.Load("enemy5", typeof(GameObject))) as GameObject;

    }
        
    }
}
