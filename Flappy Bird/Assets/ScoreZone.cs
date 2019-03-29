using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreZone : MonoBehaviour
{

    //충돌처리.
    void OnTriggerExit2D(Collider2D other) //충돌판정 통화후에 점수.
    {
        if (GameManager.playerDie == false)
        {
            if (other.gameObject.tag.CompareTo("Player") == 0) //새 판단.
            {
                GameManager.score += 1;
            }
        }



    }

}