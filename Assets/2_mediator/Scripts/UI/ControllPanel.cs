using System;
using UnityEngine;
using UnityEngine.UI;

namespace Mediator.UI
{
    public class ControllPanel : MonoBehaviour
    {
        [SerializeField] private Button _growBtn;
        [SerializeField] private Button _hitBtn;

        public event Action OnGrowBtnPressed;
        public event Action OnHitBtnPressed;

        private void OnEnable()
        {
            _growBtn.onClick.AddListener(GrowBtnPressed);
            _hitBtn.onClick.AddListener(HitBtnPressed);
        }

        private void OnDisable()
        {
            _growBtn.onClick.RemoveListener(GrowBtnPressed);
            _hitBtn.onClick.RemoveListener(HitBtnPressed);
        }

        private void GrowBtnPressed() => OnGrowBtnPressed?.Invoke();
        private void HitBtnPressed() => OnHitBtnPressed?.Invoke();
    }
}
