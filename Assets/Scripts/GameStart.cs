using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System.Security.AccessControl;

public class GameStart : MonoBehaviour
{
    public Text GameName, TopScore;
    public GameObject StartButton, Sphere, SpawnBlocks, ButtonGameOver;
    public GameObject ControlButtons, BorderDown;
    
    private bool _flag;
    private int _score;
    private bool _i;

    private void Start()
    {
        TopScore.text = "Best Score :" + PlayerPrefs.GetInt("a1").ToString();
    }
    private void OnMouseDown()
    {
        if (!_flag)
        {
            _flag = true;
            GetComponent<Text>().text = "";
            StartButton.GetComponent<ScrollButtons>().Speed = -1f;
            StartButton.GetComponent<ScrollButtons>().CheckPos = -160f;
            Sphere.GetComponent<Animation>().Play("StartGame");
            StartCoroutine(RespawnFigure());
            StartCoroutine(SphereAddRigidbody());
            InvokeRepeating("ScoreIncrement", 0, 1f);

        }
        IEnumerator RespawnFigure()
        {
            yield return new WaitForSeconds(1f);
            SpawnBlocks.GetComponent<SpawnBlocks>().enabled = true;
        }

        IEnumerator SphereAddRigidbody()
        {
            yield return new WaitForSeconds(Sphere.GetComponent<Animation>().clip.length + 1f);
            Sphere.AddComponent<Rigidbody>();
            Sphere.GetComponent<Rigidbody>().drag = 6f;
            ControlButtons.SetActive(true); //Делаем активными кнопки управления
            Sphere.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionZ; //Добавляем Rigidbody здесь чтобы отыграла анимация подъема
            Sphere.GetComponent<SphereMove>().enabled = true; //включаем управление чтобы не ругался на отсутствие Rigidbody
        }
    }

    private void ScoreIncrement()
    {
        _score +=1;
       GameName.text = "Score " + _score;
    }
    void Update()
    {
        _i = BorderDown.GetComponent<OverGame>().temp;

        if (PlayerPrefs.GetInt("a1") < _score)
        {
            PlayerPrefs.SetInt("a1", _score);
            TopScore.text = "Best Score :" + PlayerPrefs.GetInt("a1").ToString();
        }

        if (_i)
        {
            Destroy(Sphere);
            CancelInvoke("ScoreIncrement");
            ControlButtons.SetActive(false);
            ButtonGameOver.SetActive(true);
            StartButton.GetComponent<ScrollButtons>().Speed = -1f;
            ButtonGameOver.GetComponent<ScrollButtons>().CheckPos = 200f;
            GameName.enabled = false;
            TopScore.enabled = true;
        }

  
    }
}
