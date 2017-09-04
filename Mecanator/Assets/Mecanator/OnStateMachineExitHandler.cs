﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStateMachineExitHandler : StateMachineBehaviour
{
	public StateMachineAction[] Actions;

	public override void OnStateMachineExit (Animator animator, int stateMachinePathHash)
	{
		base.OnStateMachineExit (animator, stateMachinePathHash);

		var smao = new StateMachineActionObject () { Animator = animator, PathHash = stateMachinePathHash };
		foreach (var action in Actions)
		{
			action.Execute (smao);
		}
	}
}
