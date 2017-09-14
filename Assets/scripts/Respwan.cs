using UnityEngine;
using System.Collections;
using UnityEngine.UI;

 
public class Respwan : MonoBehaviour {

    public GameObject apel;
    public GameObject anggur;
    public GameObject buku;
    public GameObject kucing;
    public GameObject wortel;
    public GameObject anjing;
    public GameObject rumah;
    public GameObject hapus;
    public GameObject bunga;
    public GameObject brok;
    public GameObject rumput;
    public GameObject pepa;
    public GameObject pensil;
    public GameObject pulpen;
    public GameObject gunt;
    public GameObject jamur;
    public GameObject sema;
    public GameObject nanas;
    public GameObject jeruk;
    public GameObject kertas;
    public GameObject pir;
    public GameObject kenta;
    public GameObject batu;
    public GameObject pohon;
    public GameObject tomat;
    public GameObject misibar;
    public GameObject huruf;
    public GameObject misitiga;
    public AudioSource tabrak;
    public int mission;
    public int n;

    private void Update()
    {
        PlayerPrefs.SetInt("playermission", mission);
        PlayerPrefs.SetInt("misiN", n);
    }
    public void OnTriggerEnter(Collider col)
    {
        //LEVEL 1

        if (col.tag == "apple")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            apel.SetActive(true);
            mission = 1;
        }

        else if (col.tag == "grape")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            anggur.SetActive(true);
            mission = 2;
        }
        else if (col.tag == "book")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            buku.SetActive(true);
            mission = 3;
        }
        else if (col.tag == "house")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            rumah.SetActive(true);
            mission = 4;
        }
        else if (col.tag == "eraser")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            hapus.SetActive(true);
            mission = 5;
        }
        else if (col.tag == "cat")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            kucing.SetActive(true);
            mission = 6;
        }
        else if (col.tag == "carrot")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            wortel.SetActive(true);
            mission = 7;
        }
        else if (col.tag == "dog")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            anjing.SetActive(true);
            mission = 8;
        }
        else if (col.tag == "flower")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            bunga.SetActive(true);
            mission = 9;
        }

        //LEVEL 2

        else if (col.tag == "broccoli")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            brok.SetActive(true);
            mission = 10;
            n = 3;
        }
        else if (col.tag == "grass")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            rumput.SetActive(true);
            n = 3;
            mission = 11;
        }
        else if (col.tag == "papaya")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            pepa.SetActive(true);
            mission = 12;
            n = 3;

        }
        else if (col.tag == "pencil")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            pensil.SetActive(true);
            n = 3;
            mission = 13;
        }
        else if (col.tag == "scissor")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            gunt.SetActive(true);
            mission = 14;
            n = 3;

        }
        else if (col.tag == "mushroom")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            jamur.SetActive(true);
            n = 3;
            mission = 15;
        }
        else if (col.tag == "watermelon")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            sema.SetActive(true);
            n = 3;
            mission = 16;
        }
        else if (col.tag == "pineapple")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            nanas.SetActive(true);
            n = 3;
            mission = 17;
        }

        //LEVEL 3

        else if (col.tag == "orange")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            jeruk.SetActive(true);
            mission = 18;
            n = 6;
        }
        else if (col.tag == "paper")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            kertas.SetActive(true);
            mission = 19;
            n = 5;
        }
        else if (col.tag == "pear")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            pir.SetActive(true);
            mission = 20;
            n = 4;
        }
        else if (col.tag == "pen")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            pulpen.SetActive(true);
            mission = 21;
            n = 3;
        }
        else if (col.tag == "potato")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            kenta.SetActive(true);
            mission = 22;
            n = 6;
        }
        else if (col.tag == "stone")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            batu.SetActive(true);
            mission = 23;
            n = 5;
        }
        else if (col.tag == "tomato")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            tomat.SetActive(true);
            mission = 24;
            n = 6;
        }
        else if (col.tag == "tree")
        {
            tabrak.PlayOneShot(tabrak.clip);
            Destroy(col.gameObject);
            pohon.SetActive(true);
            mission = 24;
            n = 4;
        }
        else
            mission = 0;
    }
}
