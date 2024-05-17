using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float speed = 5.0f; 

    public float[] whenparticleisOffX;
    public float[] whenparticleisOnX;

    public GameObject[] fx;
   
   void Start()
   {
        fx[0].SetActive(true);
        fx[1].SetActive(false);
        fx[2].SetActive(false);

        whenparticleisOffX[0] =-0.8f;
        whenparticleisOffX[1] = -5f;

        whenparticleisOnX[0] =-1f;
        whenparticleisOnX[1] = -7.5f;
   }

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
        OffParticle();
        OnParticle();
    }

    public void OffParticle()
    {
        float playerX = transform.position.x;
        
        if (playerX <= whenparticleisOffX[0])
        {
            fx[0].SetActive(false);
        }

        if (playerX <= whenparticleisOffX[1])
        {
            fx[1].SetActive(false);
        }
    }

    public void OnParticle()
    {
        float playerX2 = transform.position.x;

        if (playerX2 <= whenparticleisOnX[0])
        {
            fx[1].SetActive(true);
        }

        if(playerX2 <= whenparticleisOnX[1])
        {
            fx[2].SetActive(true);
        }
    }
}
