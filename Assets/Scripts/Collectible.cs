using System;
using UnityEngine;
using TMPro;

public class Collectible : MonoBehaviour
{
    [SerializeField] private GameObject interactionButton;
    private bool _isInRange = false;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && _isInRange)
        {
            Collect();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        if (player)
        {
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
        MushroomPotionManager.Instance.NumberOfPotions++;
        Destroy(gameObject);

    }
}
