using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragAndDrop : MonoBehaviour
{
    bool moveAllowed;
    Collider2D col;
    

                                                                                                                                                    //public AudioSource source;
                                                                                                                                                 //public GameObject selectionEffect;
                                                                                                                                                //public GameMaster gm;
    // Start is called before the first frame update
    void Start()
    {
                                                                                                                                            //gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
        col = GetComponent<Collider2D>();
                                                                                                                                                        //source = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            if(touch.phase == TouchPhase.Began)
            {
                Collider2D touchedCollider = Physics2D.OverlapPoint(touchPosition);
                if(col == touchedCollider)
                {
                                                                                                                                                                    //source.Play();
                    moveAllowed = true;
                }
            }
            if (touch.phase == TouchPhase.Moved)
            {
                if (moveAllowed)
                {
                    transform.position = new Vector2(touchPosition.x, touchPosition.y);
                }
            }
            if (touch.phase == TouchPhase.Ended)
            {
                moveAllowed = false;
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bird")
        {

                                                                                                                                                                    //gm.GameOver();
        }

    }

}
