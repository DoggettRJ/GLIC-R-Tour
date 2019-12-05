using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMaterial : MonoBehaviour
{
    
    public Material chrome;
    public Material plastic;
    public Material rubber;
    public Material steel;
    public Material carbon;

    // Update is called once per frame

    void start() {
        chrome = GetComponent<Renderer>().material;   
    }

    private void Awake()
    {
        assignStandard();
    }

    public void assignStandard()
    {
            chrome.color = Color.white;
            chrome.SetFloat("_Metallic", 0f);
            chrome.SetFloat("_Glossiness", 0f);
            
    }

    public void assignChrome()
    {
        if (gameObject.activeInHierarchy == true)
        {
            chrome.color = Color.white;
            chrome.SetFloat("_Metallic", 1.0f);
            chrome.SetFloat("_Glossiness", 1.0f);
        }
    }

     public void assignPlastic()
      {
        if (gameObject.activeInHierarchy == true)
        {
            plastic.color = Color.blue;
            plastic.SetFloat("_Metallic", 0f);
            plastic.SetFloat("_Glossiness", 0.8f);
        }
    }
      public void assignRubber()
      {
        if (gameObject.activeInHierarchy == true)
        {
            rubber.color = Color.black;
            rubber.SetFloat("_Metallic", 0f);
            rubber.SetFloat("_Glossiness", 0.1f);
        }
    }
      public void assignSteel()
      {
        if (gameObject.activeInHierarchy == true)
        {
            steel.color = Color.black;
            steel.SetFloat("_Metallic", 1.0f);
            steel.SetFloat("_Glossiness", 1.0f);
        }
    }
      public void assignCarbon()
      {
        if (gameObject.activeInHierarchy == true)
        {
            carbon.color = Color.red;
            carbon.SetFloat("_Metallic", 1.0f);
            carbon.SetFloat("_Glossiness", 1.0f);
        }
    }
}
