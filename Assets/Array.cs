using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        int[] arrayInt = new int[] { 2, 4, 6, 8, 10 };
List<int> listInt = new List<int>();
        List<int> emptyListInt = new List<int>();

    

        listInt.Add(1);
        listInt.Add(2);
        listInt.Add(3);
        listInt.Add(5);
        listInt.Add(7);
        listInt.Add(9)


        emptyListInt.Add(array(arrayInt[0] * listInt[0]);
        emptyListInt.Add(array(arrayInt[1] * listInt[1]);
        emptyListInt.Add(array(arrayInt[2] * listInt[2]);
        emptyListInt.Add(array(arrayInt[3] * listInt[3]);
        emptyListInt.Add(array(arrayInt[4] * listInt[4]);

        Debug.Log(emptyListInt[0]);
        Debug.Log(emptyListInt[1]);
        Debug.Log(emptyListInt[2]);
        Debug.Log(emptyListInt[3]);
        Debug.Log(emptyListInt[4]);