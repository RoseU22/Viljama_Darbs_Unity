using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Imporē, lai varētu darboties ar pointer interfeisu
using UnityEngine.EventSystems;

public class ObjektuParvietošana : MonoBehaviour,
IPointerDownHandler, IBeginDragHandler, 
IDragHandler, IEndDragHandler{
	public Canvas kanva;
	private RectTransform transformacijasLogs;

	// Use this for initialization
	void Start () {
		transformacijasLogs = GetComponent<RectTransform>();
	}

	public void OnPointerDown(PointerEventData notikums)
	{
		Debug.Log(
			"Izdarīts kreisais klikšķis uz velkama objekta!");
	}


	public void OnBeginDrag(PointerEventData notikums)
	{
		Debug.Log("Uzsākta objekta vikšana!");
	}

	public void OnDrag(PointerEventData notikums)
	{
		Debug.Log("Notiek objekta vilkšana!");
		Vector2 mousePosition = new Vector2 (Input.mousePosition.x, Input.mousePosition.y);
		mousePosition.x = Mathf.Clamp (mousePosition.x, 0 + transformacijasLogs.rect.width /2, Screen.width - transformacijasLogs.rect.width /2);
		mousePosition.y = Mathf.Clamp (mousePosition.y, 0 + transformacijasLogs.rect.height /2, Screen.height - transformacijasLogs.rect.height /2);
		transform.position = mousePosition;

		//transformacijasLogs.anchoredPosition +=
		//	notikums.delta / kanva.scaleFactor; 
	}

	public void OnEndDrag(PointerEventData notikums)
	{
		Debug.Log("Beigta objekta vilkšana!");
	}

}