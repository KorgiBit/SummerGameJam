using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float maxHp;
    [SerializeField] private float maxSanity;
    [SerializeField] private float startPower;
    
    private float _hp;
    private float _sanity;
    private float _power;
 
    void Start()
    {
        _hp = maxHp;
        _sanity = maxSanity;
        _power = startPower;
    }

    void Update()
    {
        
    }
}
