using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CountdownCountroller : MonoBehaviour
{
    public int countdownTime;
    public Text countdownDisplay;
    public Canvas canvasObject;
    bool GameStarted = false;
    public Button StartButton;
    CharacterController cc;
    Vector3 direction;
    [SerializeField] private float forwardSpeed;




    public void startGame()
    {

        if (!GameStarted)
        {
            StartCoroutine(CountdownToStart());
        }
    }

    private void Start()
    {
        StartButton.onClick.AddListener(startGame);
        //Time.timeScale = 0;

        cc = GetComponent<CharacterController>();
        //StartCoroutine(CountdownToStart());
        
   

    }
    
    private void Update()
    {
        if (GameStarted) return;
        direction.z = forwardSpeed;
        if (cc.enabled == true)
        {
            cc.Move(direction * Time.deltaTime);
        }

    }

    IEnumerator CountdownToStart()
    {

     
        while (countdownTime > 0)
        {
           
            countdownDisplay.text = countdownTime.ToString();

            yield return new WaitForSecondsRealtime(1f);
            countdownTime--;
        }
        countdownDisplay.text = "GOOO!";
      
        yield return new WaitForSeconds(1f);
        cc.enabled = true;

    



        //yield return new WaitForSecondsRealtime(1f);

        //CharController.instance.Reset();
        //yield return new WaitForSeconds(1f);

        canvasObject.gameObject.SetActive(false);
       
    }

}
