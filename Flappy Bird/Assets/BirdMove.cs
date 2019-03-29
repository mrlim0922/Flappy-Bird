using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMove : MonoBehaviour
{
    public float birdJump = 1f;
    public GameObject EndPanel;

    void Update()
    {
        if (GameManager.playerDie == false)
        {
            if (Input.GetMouseButton(0))
            {
                GetComponent<Rigidbody2D>().velocity = new Vector3(0, birdJump, 0);
                transform.rotation = Quaternion.Euler(0, 0, 30f);
            }
            transform.Rotate(0, 0, -1f);
        }


    }

    //충돌처리.
    void OnCollisionEnter2D(Collision2D other) //충돌판정.
    {

        if (other.gameObject.tag.CompareTo("Pipe") == 0) //파이프 판단.
        {
            GameManager.playerDie = true;
            EndPanel.SetActive(true);
        }



    }

}