using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenceClickManager : MonoBehaviour
{
    public int nextScence;
    float time = 0;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            time += Time.deltaTime;
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            if(time >= 2)
            {
                Application.Quit();
            }
            else
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}
