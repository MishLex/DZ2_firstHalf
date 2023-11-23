using Infrastructure;
using UnityEngine;

namespace Npc.NPCStates
{
    public class VJobState : StateBase
    {
        private readonly float _jobTime;
        private float _counter;
        public VJobState(IStateMachine stateMachine, float jobTime) : base(stateMachine)
        {
            _jobTime = jobTime;
        }

        public override void Enter()
        {
            base.Enter();
            Debug.LogWarning("Ох и устал я! Пока шёл! Надо бы отдохнуть!\n Но посижу - попрохромирую!");
            _counter = _jobTime;
        }

        public override void Update(float timeDelta)
        {
            _counter -= timeDelta;

            Debug.Log("Вджобывать осталось " + _counter + " миллионов лет");

            if (_counter <= 0f)
            {
                _stateMachine.SetState<GoFromJobState>();
            }
        }

        public override void Exit()
        {
            base.Exit();
            Debug.LogWarning("Ох и устал я! Надо бы отдохнуть!\n А то сижу на попе 40 часоффф! Фаркрай делаю!");
        }
    }
}
