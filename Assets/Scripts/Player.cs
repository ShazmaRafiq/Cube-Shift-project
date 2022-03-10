using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 5.0f;
    int score;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        if (transform.position.z > 40)
        {
            Destroy(gameObject);
            Time.timeScale = 0;
        }

    }
  
   public void OnTriggerEnter(Collider col)
    {
        Debug.Log("collider");
        if (col.gameObject.tag == "first")
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        if (col.gameObject.tag == "sec")
        {
            transform.localScale = new Vector3(3, 1, 1);
        }
       
    }
    void AddScore()
    {
        score++;
        Debug.Log(score);
    }
    


}
