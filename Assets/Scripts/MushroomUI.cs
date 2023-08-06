using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MushroomUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _mushroomText;
    private void Start()
    {
        // Subscribe to the event when this script starts
        MushroomPotionManager.Instance.OnPotionsChanged += UpdateMushroomText;
    }
    public void UpdateMushroomText(int amount)
    {
        _mushroomText.text = amount.ToString(); 
    }
}
