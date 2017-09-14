using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RespwanOnMission : MonoBehaviour {
    public GameObject menang;
    public GameObject menang2;
    public GameObject menang3;
    public GameObject kalah;
    public GameObject kalahlevel;
    public GameObject winmisi1;
    public GameObject winmisi2;
    public GameObject winmisi3;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public GameObject O1;
    public GameObject O2;
    public GameObject O3;
    public GameObject O4;
    public GameObject O5;
    public GameObject O6;
    public GameObject R1;
    public GameObject R2;
    public GameObject R3;
    public GameObject R4;
    public GameObject A1;
    public GameObject A2;
    public GameObject A3;
    public GameObject A4;
    public GameObject A5;
    public GameObject N1;
    public GameObject N2;
    public GameObject G;
    public GameObject E1;
    public GameObject E2;
    public GameObject E3;
    public GameObject E4;
    public GameObject E5;
    public GameObject E6;
    public GameObject P1;
    public GameObject P2;
    public GameObject P3;
    public GameObject P4;
    public GameObject T1;
    public GameObject T2;
    public GameObject T3;
    public GameObject T4;
    public GameObject T5;
    public GameObject T6;
    public GameObject S;
    public GameObject M;
    public AudioSource tabrak;
    public AudioSource salah;
    public Text misi;
    public int skor;
    public int mission;
    public int life;
    public int n;
    public int starsatu;
    public int stardua;
    public int startiga;
    // Use this for initialization
    void Start () {
        mission = PlayerPrefs.GetInt("playermission");
        n = PlayerPrefs.GetInt("misiN");
        skor = PlayerPrefs.GetInt("playerpoints",0);
        life = PlayerPrefs.GetInt("playerlifes",5);
        if (mission == 1)
            misi.text = "AP_LE";
        else if (mission == 2)
            misi.text = "_RAPE";
        else if (mission == 3)
            misi.text = "BO_K";
        else if (mission == 5)
            misi.text = "ERAS_R";
        else if (mission == 6)
            misi.text = "CA_";
        else if (mission == 7)
            misi.text = "_ARROT";
        else if (mission == 8)
            misi.text = "DO_";
        else if (mission == 9)
            misi.text = "FL_WER";
        else if (mission == 10)
            misi.text = "_R_CCOL_";
        else if (mission == 11)
            misi.text = "_R_S_";
        else if (mission == 12)
            misi.text = "__PA_A";
        else if (mission == 13)
            misi.text = "__N_IL";
        else if (mission == 14)
            misi.text = "__ISS_R";
        else if (mission == 15)
            misi.text = "_U__ROOM";
        else if (mission == 16)
            misi.text = "WA___MELON";
        else if (mission == 17)
            misi.text = "P___APPLE";
        else if (mission == 18)
            misi.text = "_ _ _ _ _ _";
        else if (mission == 19)
            misi.text = "_ _ _ _ _";
        else if (mission == 20)
            misi.text = "_ _ _ _";
        else if (mission == 21)
            misi.text = "_ _ _";
        else if (mission == 22)
            misi.text = "_ _ _ _ _ _";
        else if (mission == 23)
            misi.text = "_ _ _ _ _";
        else if (mission == 24)
            misi.text = "_ _ _ _ _ _";
        else if (mission == 25)
            misi.text = "_ _ _ _";
    }

    public void OnTriggerEnter(Collider col)
    {
        if (mission == 1) { 
            if (col.tag == "P")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                MenangLevelSatu();
            }
            else
            {
                salah.PlayOneShot(salah.clip);
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 2)
        {
            if (col.tag == "G")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                MenangLevelSatu();
            }
            else
            {
                salah.PlayOneShot(salah.clip);
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 3)
        {
            if (col.tag == "O")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                MenangLevelSatu();
            }
            else
            {
                salah.PlayOneShot(salah.clip);
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 5)
        {
            if (col.tag == "E")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                MenangLevelSatu();
            }
            else
            {
                salah.PlayOneShot(salah.clip);
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 6)
        {
            if (col.tag == "T")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                MenangLevelSatu();
            }
            else
            {
                salah.PlayOneShot(salah.clip);
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 7)
        {
            
            if (col.tag == "C")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                MenangLevelSatu();
            }
            else
            {
                salah.PlayOneShot(salah.clip);
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 8)
        {
            
            if (col.tag == "G")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                MenangLevelSatu();
            }
            else
            {
                salah.PlayOneShot(salah.clip);
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 9)
        {
            if (col.tag == "O")
            {

                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                MenangLevelSatu();
            }
            else
            {
                salah.PlayOneShot(salah.clip);
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 10)
        {
            if (col.tag == "B")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "_R_CCOL_")
                    misi.text = "BR_CCOL_";
                else if (misi.text == "_ROCCOL_")
                    misi.text = "BROCCOL_";
                else if (misi.text == "_R_CCOLI")
                    misi.text = "BR_CCOLI";
                n = n - 1;
                if (n==0)
                    MenangLevelDua();
            }
            else if (col.tag == "O")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "_R_CCOL_")
                    misi.text = "_ROCCOL_";
                else if (misi.text == "BR_CCOL_")
                    misi.text = "BROCCOL_";
                else if (misi.text == "_R_CCOLI")
                    misi.text = "_ROCCOLI";
                    n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else if (col.tag == "I")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "_R_CCOL_")
                    misi.text = "_R_CCOLI";
                else if (misi.text == "BR_CCOL_")
                    misi.text = "BR_CCOLI";
                else if (misi.text == "_ROCCOL_")
                    misi.text = "_ROCCOLI";
                n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else
            {
                salah.PlayOneShot(salah.clip);
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 11)
        {
            if (col.tag == "G")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "_R_S_")
                    misi.text = "GR_S_";
                else if (misi.text == "_RAS_")
                    misi.text = "GRAS_";
                else if (misi.text == "_R_SS")
                    misi.text = "GR_SS";
                n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else if (col.tag == "A")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "_R_S_")
                    misi.text = "_RAS_";
                else if (misi.text == "GR_S_")
                    misi.text = "GRAS_";
                else if (misi.text == "_R_SS")
                    misi.text = "_RASS";
                n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else if (col.tag == "S")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "_R_S_")
                    misi.text = "_R_SS";
                else if (misi.text == "GR_S_")
                    misi.text = "GRAS_";
                else if (misi.text == "_RAS_")
                    misi.text = "_RASS";
                n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else
            {
                salah.PlayOneShot(salah.clip);
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 12)
        {
            if (col.tag == "P")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "__PA_A")
                    misi.text = "P_PA_A";
                else if (misi.text == "_APA_A")
                    misi.text = "PAPA_A";
                else if (misi.text == "__PAYA")
                    misi.text = "P_PAYA";
                n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else if (col.tag == "A")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "__PA_A")
                    misi.text = "_APA_A";
                else if (misi.text == "P_PA_A")
                    misi.text = "PAPA_A";
                else if (misi.text == "__PAYA")
                    misi.text = "_APAYA";
                n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else if (col.tag == "Y")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "__PA_A")
                    misi.text = "__PAYA";
                else if (misi.text == "P_PA_A")
                    misi.text = "P_PAYA";
                else if (misi.text == "_APA_A")
                    misi.text = "_APAYA";
                n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else
            {
                salah.PlayOneShot(salah.clip);

                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 13)
        {
            if (col.tag == "P")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "__N_IL")
                    misi.text = "P_N_IL";
                else if (misi.text == "__NCIL")
                    misi.text = "P_NCIL";
                else if (misi.text == "_EN_IL")
                    misi.text = "PEN_IL";
                n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else if (col.tag == "E")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "__N_IL")
                    misi.text = "_EN_IL";
                else if (misi.text == "P_N_IL")
                    misi.text = "PEN_IL";
                else if (misi.text == "__NCIL")
                    misi.text = "_ENCIL";
                n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else if (col.tag == "C")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "__N_IL")
                    misi.text = "__NCIL";
                else if (misi.text == "P_N_IL")
                    misi.text = "P_NCIL";
                else if (misi.text == "_EN_IL")
                    misi.text = "_ENCIL";
                n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else
            {
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 14)
        {
            if (col.tag == "S")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "__ISS_R")
                    misi.text = "S_ISS_R";
                else if (misi.text == "_CISS_R")
                    misi.text = "SCISS_R";
                else if (misi.text == "__ISSOR")
                    misi.text = "S_ISSOR";
                n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else if (col.tag == "C")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "__ISS_R")
                    misi.text = "_CISS_R";
                else if (misi.text == "S_ISS_R")
                    misi.text = "SCISS_R";
                else if (misi.text == "__ISSOR")
                    misi.text = "_CISSOR";
                n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else if (col.tag == "O")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "__ISS_R")
                    misi.text = "__ISSOR";
                else if (misi.text == "S_ISS_R")
                    misi.text = "S_ISSOR";
                else if (misi.text == "_CISS_R")
                    misi.text = "_CISSOR";
                n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else
            {
                salah.PlayOneShot(salah.clip);
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 15)
        {
            if (col.tag == "M")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "_U__ROOM")
                    misi.text = "MU__ROOM";
                else if (misi.text == "_US_ROOM")
                    misi.text = "MUS_ROOM";
                else if (misi.text == "_U_HROOM")
                    misi.text = "MU_HROOM";
                n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else if (col.tag == "S")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "_U__ROOM")
                    misi.text = "_US_ROOM";
                else if (misi.text == "MU__ROOM")
                    misi.text = "MUS_ROOM";
                else if (misi.text == "_U_HROOM")
                    misi.text = "_USHROOM";
                n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else if (col.tag == "H")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "_U__ROOM")
                    misi.text = "_U_HROOM";
                else if (misi.text == "MU__ROOM")
                    misi.text = "MU_HROOM";
                else if (misi.text == "_US_ROOM")
                    misi.text = "_USHROOM";
                n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else
            {
                salah.PlayOneShot(salah.clip);
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 16)
        {
            if (col.tag == "T")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "WA___MELON")
                    misi.text = "WAT__MELON";
                else if (misi.text == "WA__RMELON")
                    misi.text = "WAT_RMELON";
                else if (misi.text == "WA_E_MELON")
                    misi.text = "WATE_MELON";
                n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else if (col.tag == "E")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "WA___MELON")
                    misi.text = "WA_E_MELON";
                else if (misi.text == "WAT__MELON")
                    misi.text = "WATE_MELON";
                else if (misi.text == "WA__RMELON")
                    misi.text = "WA_ERMELON";
                n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else if (col.tag == "R")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "WA___MELON")
                    misi.text = "WA_RMELON";
                else if (misi.text == "WAT__MELON")
                    misi.text = "WAT_RMELON";
                else if (misi.text == "WA_E_MELON")
                    misi.text = "WA_ERMELON";
                n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else
            {
                salah.PlayOneShot(salah.clip);
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 17)
        {
            if (col.tag == "I")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "P___APPLE")
                    misi.text = "PI__APPLE";
                else if (misi.text == "P_N_APPLE")
                    misi.text = "PIN_APPLE";
                else if (misi.text == "P__EAPPLE")
                    misi.text = "PI_EAPPLE";
                n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else if (col.tag == "N")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "P___APPLE")
                    misi.text = "P_N_APPLE";
                else if (misi.text == "PI__APPLE")
                    misi.text = "PIN_APPLE";
                else if (misi.text == "P__EAPPLE")
                    misi.text = "P_NEAPPLE";
                n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else if (col.tag == "E")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "P___APLLE")
                    misi.text = "P__EAPPLE";
                else if (misi.text == "PI__APPLE")
                    misi.text = "PI_EAPPLE";
                else if (misi.text == "P_N_APPLE")
                    misi.text = "P_NEAPPLE";
                n = n - 1;
                if (n == 0)
                    MenangLevelDua();
            }
            else
            {
                salah.PlayOneShot(salah.clip);
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 18)
        {
            if (col.tag == "O")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                O1.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "R")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                R1.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "A")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                A1.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "N")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                N1.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "G")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                G.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "E")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                E1.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else
            {
                salah.PlayOneShot(salah.clip);
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 19)
        {
            if (col.tag == "P")
            {
                tabrak.PlayOneShot(tabrak.clip);
                skor = skor + 4;
                PlayerPrefs.SetInt("playerpoints", skor);
                P1.SetActive(true);
                P2.SetActive(true);
                n = n - 2;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "A")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                A2.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "E")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                E2.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "R")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                R2.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else
            {
                salah.PlayOneShot(salah.clip);
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 20)
        {
            if (col.tag == "P")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                P3.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "E")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                E3.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "A")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                A3.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "R")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                R3.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else
            {
                salah.PlayOneShot(salah.clip);
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 21)
        {
            if (col.tag == "P")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "___")
                    misi.text = "P__";
                else if (misi.text == "_E_")
                    misi.text = "PE_";
                else if (misi.text == "__N")
                    misi.text = "P_N";
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "E")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "___")
                    misi.text = "_E_";
                else if (misi.text == "P__")
                    misi.text = "PE_";
                else if (misi.text == "__N")
                    misi.text = "_EN";
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "N")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                if (misi.text == "___")
                    misi.text = "__N";
                else if (misi.text == "P__")
                    misi.text = "P_N";
                else if (misi.text == "_E_")
                    misi.text = "_EN";
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else
            {
                salah.PlayOneShot(salah.clip);
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 22)
        {
            if (col.tag == "P")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                P4.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "O")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 4;
                PlayerPrefs.SetInt("playerpoints", skor);
                O2.SetActive(true);
                O3.SetActive(true);
                n = n - 2;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "T")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 4;
                PlayerPrefs.SetInt("playerpoints", skor);
                T1.SetActive(true);
                T2.SetActive(true);
                n = n - 2;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "A")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                A4.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else
            {
                salah.PlayOneShot(salah.clip);
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 23)
        {
            if (col.tag == "S")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                S.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "T")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                T3.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "O")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                O4.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "N")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                N2.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "E")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                E4.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else
            {
                salah.PlayOneShot(salah.clip);
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 24)
        {
            if (col.tag == "T")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 4;
                PlayerPrefs.SetInt("playerpoints", skor);
                T4.SetActive(true);
                T5.SetActive(true);
                n = n - 2;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "O")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 4;
                PlayerPrefs.SetInt("playerpoints", skor);
                O5.SetActive(true);
                O6.SetActive(true);
                n = n - 2;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "M")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                M.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "A")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                A5.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else
            {
                salah.PlayOneShot(salah.clip);
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }
        else if (mission == 25)
        {
            if (col.tag == "T")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                T6.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "R")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                R4.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else if (col.tag == "E")
            {
                tabrak.PlayOneShot(tabrak.clip);
                Destroy(col.gameObject);
                skor = skor + 2;
                PlayerPrefs.SetInt("playerpoints", skor);
                E5.SetActive(true);
                E6.SetActive(true);
                n = n - 1;
                if (n == 0)
                    MenangLevelTiga();
            }
            else
            {
                salah.PlayOneShot(salah.clip);
                life = life - 1;
                PlayerPrefs.SetInt("playerlifes", life);
                NewMethod();
            }
        }

    }

    private void NewMethod()
    {
        if (life == 0)
        {
            kalahlevel.SetActive(true);
            life = 5;
            PlayerPrefs.SetInt("playerlifes", life);
        }
        else
            kalah.SetActive(true);
    }

    private void MenangLevelSatu()
    {
        if (skor == 16)
        {
            winmisi1.SetActive(true);
            life = life + 1;
            PlayerPrefs.SetInt("playerlifes", life);
            if (life < 4)
            {
                star1.SetActive(true);
                starsatu = 1;
            }
            else if (life < 6)
            {
                star2.SetActive(true);
                starsatu = 2;
            }
            else
            {
                star3.SetActive(true);
                starsatu = 3;
            }
            PlayerPrefs.SetInt("levelReached", 1);
            PlayerPrefs.SetInt("levelsatu", life);
            PlayerPrefs.SetInt("starsatu", starsatu);
        }
        else
            menang.SetActive(true);
            
    }

    private void MenangLevelDua()
    {
        if (skor == 64)
        {
            winmisi2.SetActive(true);
            life = life + 1;
            PlayerPrefs.SetInt("playerlifes", life);
            if (life < 4)
            {
                star1.SetActive(true);
                stardua = 1;
            }
            else if (life < 6)
            {
                star2.SetActive(true);
                stardua = 2;
            }
            else
            {
                star3.SetActive(true);
                stardua = 3;
            }
            PlayerPrefs.SetInt("levelReached", 2);
            PlayerPrefs.SetInt("leveldua", life);
            PlayerPrefs.SetInt("stardua", stardua);
        }
        else
            menang2.SetActive(true);

    }

    private void MenangLevelTiga()
    {
        if (skor == 142)
        {
            winmisi3.SetActive(true);
            life = life + 1;
            PlayerPrefs.SetInt("playerlifes", life);
            if (life < 4)
            {
                star1.SetActive(true);
                startiga = 1;
            }
            else if (life < 6)
            {
                star2.SetActive(true);
                startiga = 2;
            }
            else
            {
                star3.SetActive(true);
                startiga = 3;
            }
            PlayerPrefs.SetInt("levelReached", 3);
            PlayerPrefs.SetInt("leveltiga", life);
            PlayerPrefs.SetInt("startiga", startiga);
        }
        else
            menang3.SetActive(true);

    }
}
