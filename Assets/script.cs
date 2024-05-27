using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    // cuando el usuario presione el boton aceptar
    // debe escribir el mensaje en la consola
    // si el texto coincide con inputppassword coincide
    //con una contraeña predifinida por ustedes
    // escribir acess grantes sino escribir acces denied 
    public string contraseña = "lola";
    public InputField password;
 
        
        void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BotonAceptar()
    {
        if (password.text == contraseña)
            Debug.Log("Acess Granted");

        else
            Debug.Log("Acess Denied");

    }
  

    
}
