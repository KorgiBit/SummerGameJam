using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    [SerializeField] private GameObject _interactionButton;
    [SerializeField] private GameObject _collectiblePrefab;
    [SerializeField] private Animator _chestAnimation;

    private bool _isInRange = false;
    


    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && _isInRange)
        {
            
            Open();
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
        _interactionButton.SetActive(true);
    }
    private void HideInteractionButton()
    {
        _interactionButton.SetActive(false);
    }

    private void Open()
    {
        _chestAnimation.SetBool("IsTouched", true);
    }
}
