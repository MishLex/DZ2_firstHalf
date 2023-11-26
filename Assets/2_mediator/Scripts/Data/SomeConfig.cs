using UnityEngine;

namespace Mediator.Data
{
    [CreateAssetMenu(fileName = "New SomeConfig", menuName = "Mediator/SomeConfig")]
    public class SomeConfig : ScriptableObject
    {
        [field: SerializeField] public int DamageValue { get; private set; } = 5;
        [field: SerializeField] public int StartHPValue { get; private set; } = 100;
    }
}