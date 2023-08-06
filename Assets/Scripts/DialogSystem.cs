using UnityEngine;
using TMPro;
using System.Collections.Generic;
using System;

public class DialogSystem : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private SkullMovement skullMovement;

    private Dictionary<int, string> _dialogs = new Dictionary<int, string>()
    {
        { 0, "Найди сундук, в нем подбери грибы и перейди через речку" },
        { 1, "Диалог 2"},
        { 2, "Диалог 3"}
    };
    

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.gameObject.GetComponent<Player>();
        var stage = player.Stage;
        skullMovement.canMove = true;

        if (player != null)
        {
            _gameObject.SetActive(true);

            _text.text = ShuffleLettersInWords(_dialogs[stage]);
        }
    }

    public string ShuffleLettersInWords(string input)
    {
        string[] words = input.Split(' ');

        for (int i = 0; i < words.Length; i++)
            words[i] = ShuffleWordLetters(words[i]);

        string result = string.Join(" ", words);
        return result;
    }

    public string ShuffleWordLetters(string word)
    {
        var letters = word.ToCharArray();
        var random = new System.Random();

        for (int i = letters.Length - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);

            char temp = letters[i];
            letters[i] = letters[j];
            letters[j] = temp;
        }

        return new string(letters);
    }

    private void OnTriggerExit(Collider other)
    {
        _gameObject.SetActive(false);
    }
}
