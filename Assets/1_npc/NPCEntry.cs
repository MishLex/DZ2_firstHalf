using Infrastructure;
using Npc.NPCStates;
using UnityEngine;

namespace Npc
{
    public class NPCEntry : MonoBehaviour
    {
        [SerializeField] private float _jobTime;
        [SerializeField] private float _restTime;

        private IStateMachine _stateMachine;
        private void Awake()
        {
            _stateMachine = new StateMachine();

            _stateMachine.
                RegisterState(new RestState(_stateMachine, _restTime)).
                RegisterState(new VJobState(_stateMachine, _jobTime)).
                RegisterState(new GoFromJobState(_stateMachine)).
                RegisterState(new GoToJobState(_stateMachine));

            _stateMachine.SetState<RestState>();
        }

        private void Update()
        {
            _stateMachine.Update(Time.deltaTime);
        }
    }
}
