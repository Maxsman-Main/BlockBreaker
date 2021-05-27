using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Block : MonoBehaviour
{
    public int minStrength;
    public int maxStrength;
    public GameObject txt;
    private float timeCounter = 0;
    public int strength;
    public AudioSource destroySound;

    private void Update()
    {
        txt.GetComponent<Text>().text = strength.ToString();
        if (strength != -5)
        {
            
            if (strength == 0)
            {
                destroySound.Play();
                Destroy(gameObject);
                GameObject.Find("ClickManager").GetComponent<ClickManager>().flag = false;
                GameObject.Find("BlockArrayManager").GetComponent<BlockArray>().SpawnBlock();
                GameObject.Find("BlockCountManager").GetComponent<BlockCounter>().counter -= 1;
            }
        }
        else
        {
            timeCounter += Time.deltaTime;
            if (timeCounter >= 1f)
            {
                timeCounter = 0;
                destroySound.Play();
                Destroy(gameObject);
                GameObject.Find("BlockArrayManager").GetComponent<BlockArray>().SpawnBlock();
                GameObject.Find("BlockCountManager").GetComponent<BlockCounter>().counter -= 1;
            }
        }
        
    }
}
