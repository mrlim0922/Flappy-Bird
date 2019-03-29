using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float pipeSpeed = 2f;

    void Update()
    {
        if (GameManager.playerDie == false)
        {
            transform.Translate(-pipeSpeed * Time.deltaTime, 0, 0);
        }

        if (transform.position.x <= -3f)
        {
            Destroy(gameObject);
        }
    }
}