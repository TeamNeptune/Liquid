﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveWaterAction : StateMachineBehaviour
{
    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        var root = animator.gameObject.transform.root.GetComponent<PlayerController>();

        root.RemoveWater();
    }
}
