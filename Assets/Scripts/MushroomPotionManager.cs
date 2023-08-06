using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomPotionManager : MonoBehaviour
{   
    public static MushroomPotionManager Instance;

    public delegate void PotionsChangedDelegate(int newPotionCount);
    public event PotionsChangedDelegate OnPotionsChanged;

    private void Awake()
    {
        Instance = this;
    }
    private int _numberOfPotions { get; set; }
    public int NumberOfPotions
    {
        get { return _numberOfPotions; }
        set { 
            _numberOfPotions = value;
            OnPotionsChanged?.Invoke(_numberOfPotions);
        }

    }


}
