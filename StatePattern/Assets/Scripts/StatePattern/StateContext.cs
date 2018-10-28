using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
	public class StateContext
	{
		public IState CurrentState { get; private set; }

		public void ChangeState(IState targetState)
		{
			if (targetState == null) {
				return;
			}

			CurrentState?.OnExit();
			CurrentState = targetState;
			targetState?.OnEnter();
		}

		public void OnUpdate()
		{
			CurrentState.OnExecute();
		}
	}
}
