using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class KorbManager : MonoBehaviour
{
    public List<string> farben = new List<string>();
    public List<Color> _targetFarben = new List<Color>();
    List<string> targetFarben = new List<string>();
    public List<GameObject> eier = new List<GameObject>();

    public Text infotext;
    public Ausgang ausgang;
    public GameObject resetter; 
    public Collider sceneChangeTrigger;
    public GameObject eierPrefab;
    public GameObject eierPrefabInstance;
    public Transform eierPrefabParent;
    public Text text;
    public bool soundHasPlayed;

    private void Start()
    {
        // Es können keine Farben vergleichen werden, sondern lediglich der String vom Farbcode 

        _targetFarben.ForEach((i)=> { targetFarben.Add(i.ToString()); });

        // Spwan Eier

        eierPrefabInstance = Instantiate(eierPrefab, eierPrefabParent);
    }

    void Update()
    {
        // Temporär für Debugging

        text.text = "";
        farben.ForEach((i) => { text.text += (", " + i); });
    }

    private void OnTriggerStay(Collider other)
    {
        // Tag Comparison um Collision mit der Hand des Spielers auszuschließen

        if (other.CompareTag("Ei") && !eier.Contains(other.gameObject))
        {
            // Eierfarbe zur Liste hinzufügen

            farben.Add(other.GetComponent<Renderer>().material.color.ToString());

            // Ei soll nicht mehr bewegt werden können, sobald es im Korb liegt

            other.GetComponent<XRGrabInteractable>().enabled = false;
            other.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotation;

            // Ei zur Liste aller Eier im Korb hinzufügen

            eier.Add(other.gameObject);
        }

        // Sobald 3 Eier im Korb liegen, wird überprüft, ob es die richtigen sind

        if (farben.Count == 3)
        {
            // Die Listen sortieren, damit sie verglichen werden können

            farben.Sort();
            targetFarben.Sort();

            // Listen vergleichen

            if (CompareLists(farben, targetFarben))
            {
                // Wenn die Farben stimmen, soll ein entsprechender Text angezeigt werden, soll sich der Ausgang öffnen und ein Sound abgespielt werden

                infotext.text = "Gut gemacht! Jetzt musst du nur noch den Ausgang finden, dann bist du frei!";

                ausgang.OpenAusgang();
                sceneChangeTrigger.enabled = true;

                // Sound soll nur in einen Frame abspielen

                if (soundHasPlayed) return;
                AudioManager.instance.PlaySound(AudioManager.instance.correctSound);
                soundHasPlayed = true;
            }
            else
            {
               // Wenn die Farben nicht stimmen, soll ein entsprechender Text angezeigt werden, sollen die Eier respawnen und ein Sound abgespielt werden

                foreach (GameObject i in eier)
                {
                    Destroy(i);
                }

                Destroy(eierPrefabInstance);
                eierPrefabInstance = Instantiate(eierPrefab, eierPrefabParent);

                infotext.text = "Das waren die falschen Eier. Geh zurück und probiere es nochmal!";
                resetter.SetActive(true);

                // Listen für einen neuen Versuch leeren

                eier.Clear();
                farben.Clear();

                // Sound soll nur in einen Frame abspielen

                if (soundHasPlayed) return;
                AudioManager.instance.PlaySound(AudioManager.instance.wrongSound);
                soundHasPlayed = true;
            }
        }
    }

    bool CompareLists(List<string> l1, List<string> l2)
    {
        // Wenn die Listen nicht gleich lange sind, können sie nicht ident sein

        if (l1.Count != l2.Count)
        {
            return false;
        }

        // Alle Elemente werden überprüft, sobald eines nicht gleich ist returned die Funktion false

        for (int i = 0; i < l1.Count; i++)
        {
            if (l1[i] != l2[i])
            {
                return false;
            }
        }

        return true;
    }
}
