using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PanelController : MonoBehaviour
{
    public GameObject gameController;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        gameController.GetComponent<AudioSource>().Play();
    }
}
