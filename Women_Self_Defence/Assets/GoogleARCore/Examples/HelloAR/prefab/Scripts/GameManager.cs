using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject Master;
   [SerializeField] private GameObject Childs;
    [SerializeField] private GameObject Punchs;
    [SerializeField] private GameObject Kills;
    [SerializeField] private GameObject Blocks;
    [SerializeField] private GameObject Idles;
   // private GameObject[] child;
    private bool Found;
    private bool DoneOnce;


    private void Update()
    {
        if (!Found || Master==null)
        {

            Master = GameObject.FindGameObjectWithTag("Master");
            Childs = GameObject.FindGameObjectWithTag("Child");
            Punchs = GameObject.FindGameObjectWithTag("Punch");
            Kills = GameObject.FindGameObjectWithTag("Kill");
            Blocks = GameObject.FindGameObjectWithTag("Block");
            Idles = GameObject.FindGameObjectWithTag("Idle");
           
            if (Master != null )
            {
                clearAll();

               
                Found = true;
            }
        }

        if (Found &&!DoneOnce)
        {
            Idles.SetActive(true);
            DoneOnce = true;
        }

     
        
        
            
        

    }


    public void Kick()
    {
        if (Master != null)
        {
            clearAll();
            Childs.SetActive(true);

        }
        
    }

    public void Idle()
    {
        if (Master != null)
        {
            clearAll();
            Idles.SetActive(true);

        }
    }

    public void Punch()
    {
        if (Master != null)
        {
            clearAll();
            Punchs.SetActive(true);

        }

    }
    public void Block()
    {
        if (Master != null)
        {
            clearAll();
            Blocks.SetActive(true);

        }

    }
    public void Kill()
    {
        if (Master != null)
        {
            clearAll();
            Kills.SetActive(true);

        }

    }

    public void clearAll()
    {
        Childs.SetActive(false);
        Punchs.SetActive(false);
        Kills.SetActive(false);
        Blocks.SetActive(false);
        Idles.SetActive(false);


    }
}
