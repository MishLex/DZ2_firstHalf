using Mediator.Data;
using Mediator.Domain;
using Mediator.UI;
using UnityEngine;

namespace Mediator
{
    public class SomeEntry : MonoBehaviour
    {
        [SerializeField] private SomeConfig _someConfig;
        [SerializeField] private ControllPanel _controlPanel;
        [SerializeField] private TextPanel _lvlTextPanel;
        [SerializeField] private TextPanel _hpTextPanel;
        [SerializeField] private RestartPanel _restartPanel;

        private SomeMediator _mediator;

        private void Awake()
        {
            var playerController = new PlayerController(new PlayerData(), _someConfig);

            _restartPanel.gameObject.SetActive(false);
            _mediator = new(playerController, _controlPanel, _hpTextPanel, _lvlTextPanel, _restartPanel);
        }

        private void OnDestroy()
        {
            _mediator.Dispose();
        }
    }
}
