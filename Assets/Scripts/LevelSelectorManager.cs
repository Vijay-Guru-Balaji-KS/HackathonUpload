using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelectorManager : MonoBehaviour
{
    /*public GameObject questpanel;
    private bool isopened = false;

    public Image img;
    public GameObject headAche;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        closePanel();
        findallQuests();
        closeallQuests();
    }

    public void findallQuests()
    {
        img.gameObject.SetActive(true);

        if (Input.GetKeyDown(KeyCode.Q) && !isopened)
        {
            questpanel.SetActive(true);
            //questpanel.activeInHierarchy = true;
            isopened = true;
            headAche.SetActive(true);
        }
        
    }

    public void closeallQuests()
    {
        img?.gameObject.SetActive(false);

        if(Input.GetKeyDown(KeyCode.Q) && isopened)
        {
            questpanel.SetActive(false);
            isopened = false;
            headAche.SetActive(false);
        }
    }



    public void openQuestPage()
    {
        //scrollpanel.active = true;
        Debug.Log("Button is clicked");
        questpanel.SetActive(true);
    }

    public void closePanel()
    {
        questpanel.SetActive(false);
        //scrollpanel.active = false;
    }

    */

    public void loadLevel1()
    {
        Debug.Log("Button clicked");
        SceneManager.LoadScene("Trying");
    }

    public void loadLevel2()
    {
        Debug.Log("Entereing into level 2");
        SceneManager.LoadScene("MindGame");
    }
}
