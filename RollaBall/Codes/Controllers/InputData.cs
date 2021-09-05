using UnityEngine;

namespace SkipinGame
{
    [CreateAssetMenu(menuName = "Data/Input", fileName = nameof(InputData))]
    public sealed class InputData : ScriptableObject
    {
        public KeyCode SavePlayer = KeyCode.C;
        public KeyCode LoadPlayer = KeyCode.V;
    }
}
