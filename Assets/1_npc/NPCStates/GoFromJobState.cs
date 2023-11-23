using Infrastructure;
using UnityEngine;

namespace Npc.NPCStates
{
    public class GoFromJobState : StateBase
    {
        public GoFromJobState(IStateMachine stateMachine) : base(stateMachine)
        {

        }
        public override void Enter()
        {
            base.Enter();
            Debug.LogWarning("Вот и домой пора");
            _stateMachine.SetState<RestState>();
        }

        public override void Exit()
        {
            base.Exit();
            Debug.LogWarning("Вжух! Вот я и дома!");
        }
    }
}
