using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject top,spawn_point;
    public Text score;
    public static int x;
    public Button level_Button;
    void Start()
    {
        GameManager.x = 0;
        level_Button.gameObject.SetActive(false);
        for (int i = 0; i < 15; i++)
        {
            Instantiate(top, new Vector3(spawn_point.transform.position.x, spawn_point.transform.position.y, spawn_point.transform.position.z), Quaternion.identity);
        }
    }
    private void Update()
    {
        score.text = "SKORE : " + GameManager.x;

        if (GameManager.x > 0)
        {
            StartCoroutine(final_Fonk());
        }
    }
    // Update is called once per frame
    IEnumerator final_Fonk()
    {
        yield return new WaitForSeconds(3f);
        level_Button.gameObject.SetActive(true);
    }
}
