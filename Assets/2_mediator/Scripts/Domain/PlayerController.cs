using Mediator.Data;
using System;
using UnityEngine;

namespace Mediator.Domain
{
    public class PlayerController
    {
        public IReadOnlyPlayerData PlayerData => _playerData;
        public event Action PlayerDied;

        private readonly PlayerData _playerData;
        private readonly SomeConfig _config;

        public PlayerController(PlayerData playerData, SomeConfig config)
        {
            _playerData = playerData;
            _config = config;
        }

        public void Init()
        {
            _playerData.HP.Value = _config.StartHPValue;
            _playerData.Level.Value = 0;
        }

        public void TakeDamage()
        {
            var result = _playerData.HP.Value - _config.DamageValue;
            result = Mathf.Clamp(result, 0, _playerData.HP.Value);

            _playerData.HP.Value = result;

            if(_playerData.HP.Value == 0)
            {
                PlayerDied?.Invoke();
            }
        }

        public void GrowUp()
        {
            _playerData.Level.Value += 1;
            HealthGrow();
        }

        private void HealthGrow()
        {
            _playerData.HP.Value += (_playerData.HP.Value * 10 / 100);
        }
    }
}
