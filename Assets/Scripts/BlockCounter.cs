using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BlockCounter : MonoBehaviour
{
    public int counter;
    public GameObject counterTxt;


    void Update()
    {
        counterTxt.GetComponent<Text>().text = "Осталось блоков: " + counter.ToString();
        if(counter == 0)
        {
            SceneManager.LoadScene(3);
        }
    }
}
