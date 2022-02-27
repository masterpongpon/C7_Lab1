using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimator : MonoBehaviour
{
    public void getAnimatorStand(){
        this.GetComponent<Animator>().Play("Standing Torch Idle 03");
    }
    public void getAnimatorWalk(){
        this.GetComponent<Animator>().Play("Walking");
    }
}
