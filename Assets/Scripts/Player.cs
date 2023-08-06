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
<<<<<<< Updated upstream
 
=======
    
   
>>>>>>> Stashed changes
    void Start()
    {
        _hp = maxHp;
        _sanity = maxSanity;
        _power = startPower;
<<<<<<< Updated upstream
    }

    void Update()
    {
        
=======
>>>>>>> Stashed changes
    }
}
