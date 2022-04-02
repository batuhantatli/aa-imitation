using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    GameObject middleCircle;
    GameObject mainCircle;
    public Animator animator;
    public Text level;
    public Text Object1;
    public Text Object2;
    public Text Object3;
    public int howmuchminicircle;
    bool control = true;

    void Start()
    {
        PlayerPrefs.SetInt("load",int.Parse(SceneManager.GetActiveScene().name)); // for loading  i can call every script key word 'load'
        
        // I am created 2 game object and used script of the same game objects
        middleCircle = GameObject.FindGameObjectWithTag("RotatingCircleTAG"); // for Rotate function
        mainCircle = GameObject.FindGameObjectWithTag("MainCircleTAG"); // for MainCircle function
        level.text = SceneManager.GetActiveScene().name; // which level

        if (howmuchminicircle < 2)
        {
            Object1.text = howmuchminicircle + "";
        }
        else if (howmuchminicircle < 3)
        {
            Object1.text = howmuchminicircle + "";
            Object2.text = (howmuchminicircle - 1) + "";
        }
        else{
            Object1.text = howmuchminicircle + "";
            Object2.text = (howmuchminicircle - 1) + "";
            Object3.text = (howmuchminicircle - 2) + "";
        }

    }

    public  void showerMiinCircleText()
    {
        howmuchminicircle--;
        if (howmuchminicircle < 2)
        {
            Object1.text = howmuchminicircle + "";
            Object2.text = "";
            Object3.text = "";
        }
        else if (howmuchminicircle < 3)
        {
            Object1.text = howmuchminicircle + "";
            Object2.text = (howmuchminicircle - 1) + "";
            Object3.text = "";
        }
        else
        {
            Object1.text = howmuchminicircle + "";
            Object2.text = (howmuchminicircle - 1) + "";
            Object3.text = (howmuchminicircle - 2) + "";
        }
        if (howmuchminicircle == 0)
        {
            StartCoroutine(nextLevel());
        }
    }

    IEnumerator nextLevel()
    {
        middleCircle.GetComponent<Rotate>().enabled = false;
        mainCircle.GetComponent<MainCircle>().enabled = false;
        yield return new WaitForSeconds(0.5f);
        if (control)
        {
            animator.SetTrigger("NextLevel");
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene(int.Parse(SceneManager.GetActiveScene().name) + 1); //int.parse (....) = this parametre translated int , (for int + int)
        }
    }

    public void gameOver() // called IEnumerator function
    {
        StartCoroutine(retardants());
    }
    IEnumerator retardants() // this function allows us to wait
    {
        middleCircle.GetComponent<Rotate>().enabled = false;
        mainCircle.GetComponent<MainCircle>().enabled = false;
        // mainCircle.GetComponent<Deneme1>().enabled = false;  //deneme1
        animator.SetTrigger("GameOver");
        control = false;
        yield return new WaitForSeconds(2); // 2 sec waited
        SceneManager.LoadScene("Main Menu");
    }

}
