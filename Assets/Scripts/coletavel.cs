using Unity.VisualScripting;
using UnityEngine;

public class Coletável : MonoBehaviour
{

    public string nomeDoItem = "Coletável";

    public float velocidadeGiro = 90f;


    void Update()

    {

        transform.Rotate(0, velocidadeGiro * Time.deltaTime, 0);

    }

    private void OnTriggerEnter(Collider outro)

    {

        Inventário inventario = outro.GetComponent<Inventário>();

        if (inventario != null)

        {

            inventario.AdicionarItem(nomeDoItem);

            Destroy(gameObject);

        }

    }

}