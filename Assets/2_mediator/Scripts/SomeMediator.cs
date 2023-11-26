using Mediator.Domain;
using Mediator.UI;
using System;

namespace Mediator
{
    public class SomeMediator : IDisposable
    {
        private readonly PlayerController _controller;
        private readonly ControllPanel _uiControlPanel;
        private readonly TextPanel _hpTextPanel;
        private readonly TextPanel _lvlTextPanel;
        private readonly RestartPanel _restartPanel;

        public SomeMediator(PlayerController controller, ControllPanel uiControlPanel, TextPanel hpTextPanel, TextPanel lvlTextPanel, RestartPanel restartPanel)
        {
            _controller = controller;
            _uiControlPanel = uiControlPanel;
            _hpTextPanel = hpTextPanel;
            _lvlTextPanel = lvlTextPanel;
            _restartPanel = restartPanel;

            _controller.PlayerDied += PlayerDied;
            _controller.PlayerData.ReadOnlyLevel.OnChanged += PlayerLevelChanged;
            _controller.PlayerData.ReadOnlyHP.OnChanged += PlayerHPChanged;

            _uiControlPanel.OnGrowBtnPressed += GrowBtnPressed;
            _uiControlPanel.OnHitBtnPressed += HitBtnPressed;

            _controller.Init();
        }

        public void Dispose()
        {
            _controller.PlayerDied -= PlayerDied;
            _controller.PlayerData.ReadOnlyLevel.OnChanged -= PlayerLevelChanged;
            _controller.PlayerData.ReadOnlyHP.OnChanged -= PlayerHPChanged;

            _uiControlPanel.OnGrowBtnPressed -= GrowBtnPressed;
            _uiControlPanel.OnHitBtnPressed -= HitBtnPressed;
        }

        private void HitBtnPressed() => _controller.TakeDamage();
        private void GrowBtnPressed() => _controller.GrowUp();
        private void PlayerHPChanged(int hp) => _hpTextPanel.ShowText(hp.ToString());
        private void PlayerLevelChanged(int level) => _lvlTextPanel.ShowText(level.ToString());

        private void PlayerDied()
        {
            _restartPanel.gameObject.SetActive(true);
            _uiControlPanel.gameObject.SetActive(false);
        }      
    }
}

