using UnityEngine;

namespace Core.UI
{
    [CreateAssetMenu(menuName = "UI/Button/Style")]
    public class ButtonStyleDefinition : ScriptableObject
    {
        public ButtonStyle style;
        public Sprite sprite;
    }
}
