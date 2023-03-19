using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomPatrol : MonoBehaviour
{
    //&& movToWorm==false // if
    //movToWorm = false; // Start

   // movToWorm = true; //ots2d
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    Vector2 targetPosition;

    public float minSpeed;
    public float maxSpeed;

    public GameObject gameController;
    float speed;

    public float secToMaxDiff;

    bool movToWorm;


    // Start is called before the first frame update
    void Start()
    {
        targetPosition = getRandomPos();
        
    }

    // Update is called once per frame
    void Update()
    {
            if ((Vector2)transform.position != targetPosition )
            {
                speed = Mathf.Lerp(minSpeed, maxSpeed, getDifficultyPercent());
                if (transform.position.x < targetPosition.x)
                {
                    transform.localScale = new Vector2(-1, 1);
                }
                else
                {
                    transform.localScale = new Vector2(1, 1);
                }

                transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            }
            else
            {
                targetPosition = getRandomPos();
            }
           
    }
  
    Vector2 getRandomPos()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        return new Vector2(randomX, randomY);
    }
   
    float getDifficultyPercent()
    {
        return Mathf.Clamp01(Time.timeSinceLevelLoad / secToMaxDiff);
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Worm")
        {
            transform.position = Vector2.MoveTowards(transform.position, collision.transform.position, 2 * Time.deltaTime);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        movToWorm = false;
        targetPosition = getRandomPos();
    }
}
