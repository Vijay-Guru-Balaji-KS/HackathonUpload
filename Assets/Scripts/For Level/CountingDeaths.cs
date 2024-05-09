using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using TMPro;

public class CountingDeaths : MonoBehaviour
{
    public TextMeshProUGUI currentKillStatus;
    public TextMeshProUGUI objectiveKillCount;

    public bool StageCompleted = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        continouslyCheck();
    }

    public void continouslyCheck()
    {
        if(int.Parse(currentKillStatus.text)==int.Parse(objectiveKillCount.text))
        {
            StageCompleted = true;
        }
    }
}
