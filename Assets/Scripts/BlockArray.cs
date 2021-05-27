using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockArray : MonoBehaviour
{
    public GameObject[] array;
    public GameObject nextBlock; 

    public void SpawnBlock()
    {
        
        int numberBlock = Random.Range(0, array.Length);
        array[numberBlock].GetComponent<Block>().strength = Random.Range(array[numberBlock].GetComponent<Block>().minStrength, array[numberBlock].GetComponent<Block>().maxStrength);
        if(array[numberBlock].GetComponent<Block>().strength == -1)
        {
            GameObject.Find("ClickManager").GetComponent<ClickManager>().flag = true;
            array[numberBlock].GetComponent<Block>().strength = Random.Range(10, 20);
        }
        nextBlock = Instantiate(array[numberBlock]); 
        
    }

    public void Start()
    {
        SpawnBlock();
    }
}
