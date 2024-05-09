using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class L1GGameWon : MonoBehaviour
{
    public TMPro.TextMeshProUGUI currentscore;
    public TMPro.TextMeshProUGUI maxscore;
    public GameObject GameWonPanel;


    public UnityEvent unityEvents;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (int.Parse(currentscore.text) >= int.Parse(maxscore.text))
        {
            unityEvents.Invoke();
        }
    }

    public void ViewWonPage()
    {
        GameWonPanel.SetActive(true);
    }
}
