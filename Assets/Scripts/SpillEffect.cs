using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpillEffect : MonoBehaviour
{
    // Start is called before the first frame update
    public float angle =90f;
    public ParticleSystem particula;
    private Quaternion rotationAux;
    private bool apertado;
    void Start()
    {
        apertado = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Angle(Vector2.down, transform.up) <= angle)
        {
           
            if(!particula.isPlaying)
            particula.Play();
           
        }
        else
        {
            if (particula.isPlaying)
                particula.Stop();
        }

        if (apertado)
        {
            rotationAux = this.transform.rotation;
            rotationAux.z = rotationAux.z + 1;
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, rotationAux, Time.deltaTime);
        }
        if ( apertado==false && this.transform.localEulerAngles.z > 1)
        {
            rotationAux = this.transform.rotation;
            rotationAux.z = rotationAux.z - 1;
            this.transform.rotation = Quaternion.Lerp(this.transform.rotation, rotationAux, Time.deltaTime);
        }

        


    }

    public void BotaoApertado()
    {   rotationAux = this.transform.rotation;
        rotationAux.z = rotationAux.z + 10;
        this.transform.rotation = Quaternion.Lerp(this.transform.rotation, rotationAux,Time.deltaTime);
    }

    public void Apertado()
    {
        apertado = true;
    }
    public void Solto()
    {
        apertado = false;
    }
}
