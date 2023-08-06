using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float maxHp;
    [SerializeField] private float maxSanity;
    [SerializeField] private float startPower;

    public int Stage = 0;
    private float _hp;
    private float _sanity;
    private float _power;
    private int _numberOfPotions { get; set ; }
    public int NumberOfPotions
    {
        get { return _numberOfPotions; }
        set { _numberOfPotions = value; }
    }

    void Start()
    {
        _hp = maxHp;
        _sanity = maxSanity;
        _power = startPower;
        _numberOfPotions = 0;
    }

    void Update()
    {
        
    }
    
}
