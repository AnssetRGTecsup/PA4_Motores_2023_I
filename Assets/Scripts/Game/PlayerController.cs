using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    private Animator animator;
    private AudioSource water;
    public GameObject ParticleRotator;
    private bool canMove;
    private Vector3 target;
    public GameObject lineRendererRotator;

    private void Awake()
    {
        if(instance != this && instance != null){
            Destroy(this.gameObject);
        }

        instance = this;
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
        water = GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (canMove)
        {
            if (Vector3.Distance(transform.position, target) < 0.001f) canMove = false;
            else
            {
                float step = 5f * Time.deltaTime;
                transform.localScale = new Vector3(transform.position.x < target.x ? -0.5f : 0.5f, 0.5f, 0.5f);
                transform.position = Vector3.MoveTowards(transform.position, target, step);
                animator.Play("Walking");
            }
        }
        else
        {
            animator.Play("Idle");
        }
    }

    public void SetTarget(Vector3 newTarget)
    {
        target = newTarget;
        canMove = true;
    }

    public void ShootWater(Vector2 pos)
    {
        canMove = true ;
        //calcular angle de jugador a fire

        float ang = Mathf.Atan2(pos.y - transform.position.y, pos.x - transform.position.x) * 180 / Mathf.PI;
        print("xd");
        //setear angulo
        /*ParticleRotator.transform.eulerAngles = new Vector3(0f, 0f, ang);
        ParticleRotator.GetComponentInChildren<ParticleSystem>().Play();
        water.Play();*/

        lineRendererRotator.transform.eulerAngles = new Vector3(0f,0f,ang);
        lineRendererRotator.SetActive(true);
        StartCoroutine(SentenceOut());
    }
    IEnumerator SentenceOut()
    {
        yield return new WaitForSeconds(0.5f);
        lineRendererRotator.SetActive(false);
    }
}
