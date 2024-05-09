using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public static GameManager Instance 
    {
        get 
        {
            return instance; 
        } 
    }

    public List<GameObject> doors;
    private int correctDoorIndex;

    private void Awake()
    {
        //PlayerPrefs.DeleteKey("CorrectDoorIndex");
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        if (doors.Count == 0)
        {
            // Add your doors to the list only if it's empty
            GameObject[] doorObjects = GameObject.FindGameObjectsWithTag("Door");
            foreach (GameObject door in doorObjects)
            {
                doors.Add(door);
            }
        }



        // Check if the correct door index is already stored, if not, set a random one
        if (!PlayerPrefs.HasKey("CorrectDoorIndex"))
        {
            correctDoorIndex = Random.Range(0, doors.Count);
            PlayerPrefs.SetInt("CorrectDoorIndex", correctDoorIndex);
        }
        else
        {
            correctDoorIndex = PlayerPrefs.GetInt("CorrectDoorIndex");
        }

        string correctidxName = doors[correctDoorIndex].name;

        // Destroy all doors except the correct one
        for (int i = 0; i < doors.Count; i++)
        {
            if (i != correctDoorIndex && doors[i].name != correctidxName)
            {
                Destroy(doors[i]);
                break;
            }
        }
    }

    public void ChangeScene(string sceneName)
    {
        // Load the next scene
        SceneManager.LoadScene(sceneName);
    }

}
