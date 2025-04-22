﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Moon
{
    public class SetTargetableSMB : StateMachineBehaviour
    {
        // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
        override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
        {
            PlayerController controller = animator.GetComponent<PlayerController>();

            if (controller != null)
            {
                controller.RespawnFinished();
            }
        }
    } 
}
