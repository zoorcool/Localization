using System.Collections.Generic;
using UnityEngine;

public class LocalizationTest : MonoBehaviour
{
    [SerializeField]
    private LocalizedText text;
    [SerializeField]
    private LocalizedDropdown dropdown;

    public void LocalizeText()
    {
        text.Localize("Text2_Key");
    }

    public void LocalizeDropdown()
    {
        var options = new List<string>() { "Blue_Key", "Green_Key", "Black_Key" };
        dropdown.Localize(options);
    }
}
