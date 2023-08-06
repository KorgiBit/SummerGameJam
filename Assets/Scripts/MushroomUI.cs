using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MushroomUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _mushroomText;
    
    public void UpdateMushroomText(int amount)
    {
        _mushroomText.text = amount.ToString(); 
    }
}
