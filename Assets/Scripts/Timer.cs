using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float timeRemaining = 60f;
    public GameObject timeTxt;

    private void Start()
    {
        timeTxt.GetComponent<Text>().text = "Время: " + timeRemaining;
    }

    private void Update()
    {
        if (timeRemaining <= 0)
        {
            SceneManager.LoadScene(2);
        }
        timeRemaining -= Time.deltaTime;
        timeTxt.GetComponent<Text>().text = "Время: " + timeRemaining;
    }
}
