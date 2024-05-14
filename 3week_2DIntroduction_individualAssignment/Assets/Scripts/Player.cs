using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Unity.Jobs;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum PlayerJob
    {
        Knight,
        Monster
    }

    public RuntimeAnimatorController[] animCon;

    Rigidbody2D rigid;
    SpriteRenderer spriter;
    Animator anim;

    //Player -> unitiolize

    void OnEnalbe()
    {
        anim.runtimeAnimatorController = animCon[GameManager.instance.playerId];
    }

}