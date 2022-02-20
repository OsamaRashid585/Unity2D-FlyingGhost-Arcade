using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameManager : MonoBehaviour
{
   [SerializeField] private Text _scoreTxt;
    public int _score;

    void Update()
    {
        _scoreTxt.text = "score: " + _score.ToString();
    }

}
