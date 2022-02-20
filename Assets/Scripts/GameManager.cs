using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
   [SerializeField] private Text _scoreTxt;
    public int _score;

    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        _scoreTxt.text = "score: " + _score.ToString();
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
