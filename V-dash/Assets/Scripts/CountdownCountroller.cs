using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountdownCountroller : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;

    private void Start()
    {
        StartCoroutine(CountdownToStart());
    }
    IEnumerator CountdownToStart()
    {

        Time.timeScale = 0;
        while (countdownTime > 0)
        {

            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSecondsRealtime(1f);
            countdownTime--;
        }
        Time.timeScale = 1;
        countdownDisplay.text = "GOOO!";
        

       
        //yield return new WaitForSecondsRealtime(1f);
        
        //CharController.instance.Reset();
        //yield return new WaitForSeconds(1f);

        //countdownDisplay.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
