using System.Collections;
using TMPro;
using UnityEngine;

public class HP : MonoBehaviour
{
    [SerializeField] private TMP_Text _score;
    [SerializeField] private Player _player;

    private void Update()
    {
        _score.text = _player.Health.ToString();
    }
}
