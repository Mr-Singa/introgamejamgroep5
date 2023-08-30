using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dieren : MonoBehaviour
{
    public float dierSPEED;

    public GameObject dier;

    public GameObject pijl;
    public float pijlTimer;

    public Transform noord;
    public Transform oost;
    public Transform zuid;
    public Transform west;

    public Transform xOffset;
    public Transform zOffset;

    void Start()
    {
        SpawnNoord();
        SpawnOost();
        SpawnWest();
        SpawnZuid();
    }

    void Update()
    {
        
    }

    public void SpawnNoord()
    {
        GameObject thispijl = Instantiate(pijl, noord);
        Destroy(thispijl, pijlTimer);

        GameObject thisDier = Instantiate(dier, noord);

        thisDier.transform.position = Vector3.MoveTowards(thisDier.transform.position, zuid.position, dierSPEED * Time.deltaTime);
    }
    public void SpawnOost()
    {
        GameObject thispijl = Instantiate(pijl, oost);
        Destroy(thispijl, pijlTimer);

        GameObject thisDier = Instantiate(dier, oost);

        thisDier.transform.position = Vector3.MoveTowards(thisDier.transform.position, zuid.position, dierSPEED * Time.deltaTime);
    }
    public void SpawnZuid()
    {
        GameObject thispijl = Instantiate(pijl, zuid);
        Destroy(thispijl, pijlTimer);

        GameObject thisDier = Instantiate(dier, zuid);

        thisDier.transform.position = Vector3.MoveTowards(thisDier.transform.position, zuid.position, dierSPEED * Time.deltaTime);
    }
    public void SpawnWest()
    {
        GameObject thispijl = Instantiate(pijl, west);
        Destroy(thispijl, pijlTimer);

        GameObject thisDier = Instantiate(dier, west);

        thisDier.transform.position = Vector3.MoveTowards(thisDier.transform.position, zuid.position, dierSPEED * Time.deltaTime);
    }
}
