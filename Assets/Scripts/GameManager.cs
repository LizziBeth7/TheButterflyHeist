using System;
using System.Runtime.CompilerServices;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {get; private set;}
    public Boolean Key = false;
    public Boolean Decoder = false;
    public Boolean Date = false;
    public Boolean Map = false;
    public Boolean Hack = false;

    public Boolean LedgersChanged = false;
    public Boolean CAKE = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Collect(string Object)
    {
        if (Object == "Key"){
            Key = true;
        }
        else if (Object == "Decoder")
        {
            Decoder = true;
        }
        else if (Object == "Date")
        {
            Date = true;
        }
        else if (Object == "Map")
        {
            Map = true;
        }
        else if (Object == "Hack")
        {
            Hack = true;
        }

    }

    public Boolean Check(string Object)
    {
        if (Object == "Key" && Key == true){
            return true;
        }
        else if (Object == "Decoder" && Decoder == true)
        {
            return true;
        }
        else if (Object == "Date" && Date == true)
        {
            return true;
        }
        else if (Object == "Map" && Map == true)
        {
            return true;
        }
        else if (Object == "Hack" && Hack == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private void Awake()
    {
        if (Instance != null && Instance != this) 
        {
            Destroy(gameObject); 
        } 
        else 
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
