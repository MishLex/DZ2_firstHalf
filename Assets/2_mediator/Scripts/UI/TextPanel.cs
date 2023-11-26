using UnityEngine;
using UnityEngine.UI;

namespace Mediator.UI
{
    public class TextPanel : MonoBehaviour
    {
        [SerializeField] private Text _textComponent;

        public void ShowText(string text)
        {
            _textComponent.text = text;
        }
    }
}
