using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl1Status : MonoBehaviour
{
    public TMPro.TextMeshProUGUI currentscore;
    public TMPro.TextMeshProUGUI maxscore;
    public bool islvlCompleted = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        setStatus();
        DontDestroyOnLoad(gameObject);
    }

    public void setStatus()
    {
        if(int.Parse(currentscore.text) >= int.Parse(maxscore.text))
        {
            islvlCompleted = true;
        }
    }
}
