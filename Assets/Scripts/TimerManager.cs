using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerManager : MonoBehaviour
{
    public static TimerManager instance; 

    public float maxTime = 60f; 
    private float currentTime; // Current time

    public TMPro.TextMeshProUGUI timerText; // Reference to UI text to display the timer

    void Awake()
    {
        
        // Create a singleton instance
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Ensure the timer persists across scenes
            InitializeTimer();
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate instances
        }
    }

    void InitializeTimer()
    {
        currentTime = PlayerPrefs.GetFloat("CurrentTime", maxTime); // Load the saved time or set it to maxTime
        UpdateTimerDisplay();
    }

    void UpdateTimerDisplay()
    {
        // Convert time to minutes and seconds
        float minutes = Mathf.FloorToInt(currentTime / 60);
        float seconds = Mathf.FloorToInt(currentTime % 60);

        // Update the UI text to display the timer
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void Update()
    {
        // Update the timer if it's running
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;
            UpdateTimerDisplay();
        }
        else
        {
            Debug.Log("No Time to spend");
            // Display message or perform any action when time reaches zero
        }
    }

    // Save the current time when the application is paused or stopped
    void OnApplicationPause(bool pauseStatus)
    {
        if (pauseStatus)
        {
            PlayerPrefs.SetFloat("CurrentTime", currentTime);
            PlayerPrefs.Save();
        }
    }

    void OnApplicationQuit()
    {
        // Save the current time when the application is quit
        PlayerPrefs.SetFloat("CurrentTime", currentTime);
        PlayerPrefs.Save();
    }

    // Function to reset the timer
    public void ResetTimer()
    {
        currentTime = maxTime;
        UpdateTimerDisplay();
    }

    public void overRidingResetTimer(TextMeshProUGUI timer)
    {
        timer.text = maxTime.ToString();
        UpdateTimerDisplay();
    }
}
