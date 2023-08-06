using System;
using UnityEngine;
using TMPro;

public class Collectible : MonoBehaviour
{
    [SerializeField] private GameObject interactionButton;
    private bool _isInRange = false;

    private Player _player;
    private MushroomUI _mushroomText;
    private void Awake()
    {
        _player = GameObject.Find("Player").GetComponent<Player>();
        _mushroomText = GameObject.Find("Mushroom Count").GetComponent<MushroomUI>();
    }
    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && _isInRange)
        {
            Debug.Log("Collected");
            Collect();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if (player) 
        {
            Debug.Log("entered"+ _isInRange);

            ShowInteractionButton();
            _isInRange = true;
        }
        
    }
    private void OnTriggerExit(Collider other)
    {
        HideInteractionButton();
        _isInRange = false;
    }

    private void ShowInteractionButton()
    {
        interactionButton.SetActive(true); 
    }
    private void HideInteractionButton()
    {
        interactionButton.SetActive(false);
    }

    private void Collect()
    {
        _player.NumberOfPotions += 1;
        _mushroomText.UpdateMushroomText(_player.NumberOfPotions);
       Destroy(gameObject);

    }
}
