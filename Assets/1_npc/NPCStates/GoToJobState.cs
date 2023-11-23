using Infrastructure;
using UnityEngine;

namespace Npc.NPCStates
{
    public class GoToJobState : StateBase
    {
        
        public GoToJobState(IStateMachine stateMachine) : base(stateMachine)
        {
        }

        public override void Enter()
        {
            base.Enter();
            Debug.LogWarning("Ох посижу поиграю в маршруточке пока еду");
            _stateMachine.SetState<VJobState>();
        }

        public override void Exit()
        {
            base.Exit();
            Debug.LogWarning("Вжух! Ну, еще один ходик!!1");
        }
    }
}
