using Infrastructure;
using UnityEngine;

namespace Npc.NPCStates
{
    public class RestState : StateBase
    {
        private readonly float _restTime;
        private float _counter;
        public RestState(IStateMachine stateMachine, float restTime) : base(stateMachine)
        {
            _restTime = restTime;
        }

        public override void Enter()
        {
            base.Enter();
            Debug.LogWarning("Ох и устал я! Надо бы отдохнуть!\n А то сижу на попе перед компом уже 40 часоффф! Прохрамирую игоры!" );
            _counter = _restTime;
        }

        public override void Update(float timeDelta)
        {
            _counter -= timeDelta;

            Debug.Log("Отдыхать осталося " + _counter + " секунд");

            if(_counter <= 0f)
            {
                _stateMachine.SetState<GoToJobState>();
            }
        }

        public override void Exit()
        {
            base.Exit();
            Debug.LogWarning("Ох и отдохнул я! Надо бы еще отдохнуть!\n Но пойду посижу на попе перед компом хоть 40 часоффф! Ихоры поделаю!");
        }
    }
}
