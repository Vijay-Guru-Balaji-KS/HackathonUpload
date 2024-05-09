using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Lvl1TimeCopy : MonoBehaviour
{
    public TMPro.TextMeshProUGUI timer;   

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        timer.text = TimerManager.instance.timerText.text;
    }
}
