using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountDown : MonoBehaviour

{
    public float endTime;
    public float currentTime;
    public Text timer;
    public bool isGameStarted;
    // Start is called before the first frame update

    void Start()
    {
        currentTime = 0f;
        isGameStarted = true;
    }

    // Update is called once per frame
    void Update()
    {
      
        if (isGameStarted && currentTime <= endTime)
        {
            currentTime += Time.deltaTime; // Increment time
            timer.text = ((int)currentTime).ToString(); // Update the text
        }
       
    }

  
}
