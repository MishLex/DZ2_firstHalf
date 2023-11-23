using System;

namespace Infrastructure
{
    public interface IState
    {
        public void Enter();
        public void Update(float timeDelta);
        public void Exit();       
    }
}
