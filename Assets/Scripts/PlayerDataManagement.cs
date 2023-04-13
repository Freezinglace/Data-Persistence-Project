using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDataManagement : MonoBehaviour
{

    public static PlayerDataManagement Instance;

    public string PlayerName;
    public int Score;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Awake()
    {
        // Singleton used, but not required - done for good practices.
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
