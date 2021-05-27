using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickManager : MonoBehaviour
{

    public bool flag = false;
    float greenTime = 0;
    public AudioSource clickSound;

    void Update()
    {
        if (!flag)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                clickSound.Play();
                if (GameObject.Find("BlockArrayManager").GetComponent<BlockArray>().nextBlock.GetComponent<Block>().strength != -5 && !flag)
                {
                    GameObject.Find("BlockArrayManager").GetComponent<BlockArray>().nextBlock.GetComponent<Block>().strength -= 1;
                }
                else if (GameObject.Find("BlockArrayManager").GetComponent<BlockArray>().nextBlock.GetComponent<Block>().strength == -5)
                {
                    SceneManager.LoadScene(2);
                }
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.Mouse0))
            {
                Debug.Log(greenTime);
                greenTime += Time.deltaTime;
                if(greenTime >= 0.15f)
                {
                    greenTime = 0;
                    GameObject.Find("BlockArrayManager").GetComponent<BlockArray>().nextBlock.GetComponent<Block>().strength -= 1;
                }
            }
            else
            {
                greenTime = 0;
            }
        }
    }
}
