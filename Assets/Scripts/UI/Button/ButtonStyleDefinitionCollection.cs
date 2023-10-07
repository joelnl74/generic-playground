using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Core.UI
{
    [CreateAssetMenu(menuName = "UI/Button/StyleCollection")]
    public class ButtonStyleDefinitionCollection : ScriptableObject
    , IButtonStyleDefintionCollection
    {
        [SerializeField] private List<ButtonStyleDefinition> _buttonStyleList;

        /// <summary>
        /// Get button style from the collection.
        /// </summary>
        /// <param name="style">The style you wish to retrieve.</param>
        /// <returns>Return the style definition.</returns>
        public ButtonStyleDefinition Get(ButtonStyle style)
            => _buttonStyleList.FirstOrDefault(x => x.style == style);
    }
}
