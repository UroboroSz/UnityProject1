using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject GameOvertext;
    public GameObject Selection;
    public static GameObject GameOverStatic;
    public static GameObject GameOverSelect;

    // Start is called before the first frame update
    void Start()
    {
        GameOver.GameOverStatic = GameOvertext;
        GameOver.GameOverSelect = Selection;
        GameOver.GameOverStatic.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void show()
    {
        GameOver.GameOverStatic.SetActive(true);
        Instantiate(GameOver.GameOverSelect, new Vector3(0, 0, 0), GameOver.GameOverSelect.transform.rotation);

    }
}
