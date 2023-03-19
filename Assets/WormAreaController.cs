using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class WormAreaController : MonoBehaviour
{

    public GameObject gm;
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.tag == "Bird")
        {
            gm.GetComponent<GameMaster>().GameOver();
        }
    }
}
