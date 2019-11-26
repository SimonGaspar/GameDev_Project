using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadManager : MonoBehaviour
{
    [SerializeField]
    private string Scene1;
    [SerializeField]
    private string Scene2;
    [SerializeField]
    private string Scene3;

    private static LoadManager _instance;

    public static LoadManager Instance { get { return _instance; } }


    private void Awake()
    {

        DontDestroyOnLoad(this.gameObject);
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }


    //// Start is called before the first frame update
    //void Awake()
    //{
    //    //SceneManager.LoadScene(Scene1, LoadSceneMode.Additive);
    //}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.F1) && !string.IsNullOrWhiteSpace(Scene1))
        {
            SceneManager.LoadScene(Scene1, LoadSceneMode.Single);
        }
        if (Input.GetKey(KeyCode.F2) && !string.IsNullOrWhiteSpace(Scene2))
        {
            SceneManager.LoadScene(Scene2, LoadSceneMode.Single);
        }
        if (Input.GetKey(KeyCode.F3) && !string.IsNullOrWhiteSpace(Scene3))
        {
            SceneManager.LoadScene(Scene3, LoadSceneMode.Single);
        }
    }
}
