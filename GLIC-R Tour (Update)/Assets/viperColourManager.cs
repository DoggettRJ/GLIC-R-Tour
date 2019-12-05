using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class viperColourManager : MonoBehaviour
{
    public GameObject dummyProShield;
    public GameObject dummyMach3;

    public GameObject ProShield;
    public GameObject Mach3;

    public GameObject m3Rubber;
    public GameObject m3Plastic;
    public GameObject m3Handle;

    public GameObject m3PreviewRubber;
    public GameObject m3PreviewPlastic;
    public GameObject m3PreviewHandle;

    public Material m3FrontRubberMaterial;
    public Material m3BackRubberMaterial;
    public Material m3PlasticMaterial;
    public Material m3HandleMaterial;

    public Material m3BackLogoMaterial;
    public Material m3FrontLogoMaterial;

    // Proshield////////////////////////////////////////
    public GameObject rubber;
    public GameObject plastic;
    public GameObject handle;

    public GameObject previewRubber;
    public GameObject previewPlastic;
    public GameObject previewHandle;

    public Material rubberMaterial;
    public Material plasticMaterial;
    public Material handleMaterial;

    
    public Texture proglideLogoTexture;
    public Texture blackAndWhiteTexture;
    public Texture chillTexture;
    public Texture proshieldTexture;

    public Renderer Pod;

    public GameObject doorDummy;

    public GameObject thankYou;

    public Material TestMaterial;

    //-------------------------------------------------------------------------

    public GameObject printObjects;
    public Animator printAnimation;
    public GameObject lightSource;
    public int startDelay;

    public GameObject door;
    public Animator doorAnim;

    //-----------------------------------------------------------------------------

   

    // Start is called before the first frame update
    public void Start()
    {
        

        rubberGrey();
        plasticGrey();
        handleGrey();
        assignProglideLogo();

        m3RubberGrey();
        m3PlasticGrey();
        m3HandleGrey();
       // m3HandleLogoStandard();

       // rubberMaterial = GetComponent<Renderer>().material;
        //plasticMaterial = GetComponent<Renderer>().material;
        //handleMaterial = GetComponent<Renderer>().material;

        //m3HandleMaterial = GetComponent<Renderer>().material;

        printAnimation = printObjects.GetComponent<Animator>();
    }

   // Proshield Colour////////////////////////////////////////////////

    public void rubberGreen()
    {
        rubber.GetComponent<Image>().color = Color.green;
        previewRubber.GetComponent<Image>().color = Color.green;
        rubberMaterial.color = Color.green;
    }
    public void rubberRed()
    {
        rubber.GetComponent<Image>().color = Color.red;
        previewRubber.GetComponent<Image>().color = Color.red;
        rubberMaterial.color = Color.red;
    }
    public void rubberBlue()
    {
        rubber.GetComponent<Image>().color = Color.blue;
        previewRubber.GetComponent<Image>().color = Color.blue;
        rubberMaterial.color = Color.blue;
    }
    public void rubberGrey()
    {
        rubber.GetComponent<Image>().color = Color.grey;
        previewRubber.GetComponent<Image>().color = Color.grey;
        rubberMaterial.color = Color.grey;
    }



    public void plasticGreen()
    {
        plastic.GetComponent<Image>().color = Color.green;
        previewPlastic.GetComponent<Image>().color = Color.green;
        plasticMaterial.color = Color.green;
    }
    public void plasticRed()
    {
        plastic.GetComponent<Image>().color = Color.red;
        previewPlastic.GetComponent<Image>().color = Color.red;
        plasticMaterial.color = Color.red;
    }
    public void plasticBlue()
    {
        plastic.GetComponent<Image>().color = Color.blue;
        previewPlastic.GetComponent<Image>().color = Color.blue;
        plasticMaterial.color = Color.blue;
    }
    public void plasticGrey()
    {
        plastic.GetComponent<Image>().color = Color.grey;
        previewPlastic.GetComponent<Image>().color = Color.grey;
        plasticMaterial.color = Color.grey;
    }



    public void handleGreen()
    {
        handle.GetComponent<Image>().color = Color.green;
        previewHandle.GetComponent<Image>().color = Color.green;

        handleMaterial.color = Color.green;
    }
    public void handleRed()
    {
        handle.GetComponent<Image>().color = Color.red;
        previewHandle.GetComponent<Image>().color = Color.red;
 
        handleMaterial.color = Color.red;
    }
    public void handleBlue()
    {
        handle.GetComponent<Image>().color = Color.blue;
        previewHandle.GetComponent<Image>().color = Color.blue;

        handleMaterial.color = Color.blue;
    }
    public void handleGrey()
    {
        handle.GetComponent<Image>().color = Color.grey;
        previewHandle.GetComponent<Image>().color = Color.grey;
    
        handleMaterial.color = Color.grey;   
    }


    // Logo Select

    public void assignProglideLogo()
    {
        Pod.material.SetTexture("_MainTex", proglideLogoTexture);
    }

    public void assignProShieldLogo()
    {
        Pod.material.SetTexture("_MainTex", proshieldTexture);
    }

    public void assignBWLogo()
    {
        Pod.material.SetTexture("_MainTex", blackAndWhiteTexture);
    }

    public void assignChillLogo()
    {
        Pod.material.SetTexture("_MainTex", chillTexture);
    }

    // Proshield Print //////////////////

    public void printProshield()
    {
        if (doorDummy.activeInHierarchy)
        {
            if (dummyProShield.activeInHierarchy)
            {
                ProShield.SetActive(true);
                StartCoroutine(waitForPrint());
                printAnimation.Play("PrintPart");
                lightSource.SetActive(true);
            }

            else if (dummyMach3.activeInHierarchy)
            {
                Mach3.SetActive(true);
                StartCoroutine(waitForPrint());
                printAnimation.Play("PrintPart");
                lightSource.SetActive(true);
            }
        }

        else
        {
            Debug.Log("Shut the door !");
        }
    }

    IEnumerator waitForPrint()
    {
        if (dummyProShield.activeInHierarchy)
        {
        yield return new WaitForSeconds(10);

            //ProShield.SetActive(true);
            //Mach3.SetActive(false);

            yield return new WaitForSeconds(10);

            doorAnim.Play("doorSwingOpen");
            doorDummy.SetActive(false);

            yield return new WaitForSeconds(10);

            thankYou.SetActive(true);
        }

        else 
        {
            yield return new WaitForSeconds(10);

            ProShield.SetActive(false);
            Mach3.SetActive(true);

            yield return new WaitForSeconds(10);

            doorAnim.Play("doorSwingOpen");
            doorDummy.SetActive(false);

            yield return new WaitForSeconds(10);

            thankYou.SetActive(true);
        }

    }

    // Mach 3 Colour//////

    public void m3RubberGreen()
    {
        m3Rubber.GetComponent<Image>().color = Color.green;
        m3PreviewRubber.GetComponent<Image>().color = Color.green;
        m3FrontRubberMaterial.color = Color.green;
        m3BackRubberMaterial.color = Color.green;
    }
    public void m3RubberRed()
    {
        m3Rubber.GetComponent<Image>().color = Color.red;
        m3PreviewRubber.GetComponent<Image>().color = Color.red;
        m3FrontRubberMaterial.color = Color.red;
        m3BackRubberMaterial.color = Color.red;
    }
    public void m3RubberBlue()
    {
        m3Rubber.GetComponent<Image>().color = Color.blue;
        m3PreviewRubber.GetComponent<Image>().color = Color.blue;
        m3FrontRubberMaterial.color = Color.blue;
        m3BackRubberMaterial.color = Color.blue;
    }
    public void m3RubberGrey()
    {
        m3Rubber.GetComponent<Image>().color = Color.grey;
        m3PreviewRubber.GetComponent<Image>().color = Color.grey;
        m3FrontRubberMaterial.color = Color.grey;
        m3BackRubberMaterial.color = Color.grey;
    }


    //Plastic//

    public void m3PlasticGrey()
    {
        m3Plastic.GetComponent<Image>().color = Color.grey;
        m3PreviewPlastic.GetComponent<Image>().color = Color.grey;
        m3PlasticMaterial.color = Color.grey;
    }

    public void m3PlasticRed()
    {
        m3Plastic.GetComponent<Image>().color = Color.red;
        m3PreviewPlastic.GetComponent<Image>().color = Color.red;
        m3PlasticMaterial.color = Color.red;
    }

    public void m3PlasticGreen()
    {
        m3Plastic.GetComponent<Image>().color = Color.green;
        m3PreviewPlastic.GetComponent<Image>().color = Color.green;
        m3PlasticMaterial.color = Color.green;
    }

    public void m3PlasticBlue()
    {
        m3Plastic.GetComponent<Image>().color = Color.blue;
        m3PreviewPlastic.GetComponent<Image>().color = Color.blue;
        m3PlasticMaterial.color = Color.blue;
        
    }
    //Handle//

    public void m3HandleGrey()
    {
        m3Handle.GetComponent<Image>().color = Color.grey;
        m3PreviewHandle.GetComponent<Image>().color = Color.grey;
        m3HandleMaterial.color = Color.grey;
    }

    public void m3HandleGreen()
    {
        m3Handle.GetComponent<Image>().color = Color.green;
        m3PreviewHandle.GetComponent<Image>().color = Color.green;
        m3HandleMaterial.color = Color.green;
    }

    public void m3HandleBlue()
    {
        m3Handle.GetComponent<Image>().color = Color.blue;
        m3PreviewHandle.GetComponent<Image>().color = Color.blue;
        m3HandleMaterial.color = Color.blue;
    }

    public void m3HandleRed()
    {
        m3Handle.GetComponent<Image>().color = Color.red;
        m3PreviewHandle.GetComponent<Image>().color = Color.red;
        m3HandleMaterial.color = Color.red;
    }

    public void m3HandleLogoStandard()
    {
        m3BackLogoMaterial.color = Color.white;
        m3FrontLogoMaterial.color = Color.white;
        TestMaterial.color = Color.white;
    }

    public void m3HandleLogoRed()
    {
        m3BackLogoMaterial.color = Color.red;
        m3FrontLogoMaterial.color = Color.red;
        TestMaterial.color = Color.red;
    }

    public void m3HandleLogoBlue()
    {
        m3BackLogoMaterial.color = Color.blue;
        m3FrontLogoMaterial.color = Color.blue;
        TestMaterial.color = Color.blue;
    }

    public void m3HandleLogoGreen()
    {
        m3BackLogoMaterial.color = Color.green;
        m3FrontLogoMaterial.color = Color.green;
        TestMaterial.color = Color.green;
    }
}
