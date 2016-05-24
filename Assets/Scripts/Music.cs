using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;
using System.Collections;

public class Music : MonoBehaviour
{
    private static Music _play;

    public void OnLevelWasLoaded(int level)
    {
        if (level >= 3)
        {
            GameObject.FindObjectOfType<Music>();
            Destroy(_play.gameObject);
        }
    }

    public static Music play
    {
        get
        {
            if (_play == null)
            {
                _play = GameObject.FindObjectOfType<Music>();
                DontDestroyOnLoad(_play.gameObject);
            }
            return _play;
        }
    }

    void Awake()
    {
        if (_play == null)
        {
            _play = this;
            DontDestroyOnLoad(this);
        }
    }

}
