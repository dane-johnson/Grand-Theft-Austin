using UnityEngine;
using System.Collections;

public class ManageGibs : MonoBehaviour {

	public int maxBloodDrops;

	private Node first, last;
	private int dropCount = 0;

	void Update () {
		while(dropCount > maxBloodDrops){
			//Pop it off
			PopBloodStack();
			dropCount--;
			//Go look again
		}
	}

	private void PopBloodStack(){
		Node temp = first;

		//Move the head
		first = first.next;
		//Get rid of the GameObject
		Destroy(temp.obj);
	}

	public void AddToBloodStack(GameObject drop){
		Node temp = new Node();
		temp.obj = drop;

		//Add it to the queue
		if(first != null){
			last.next = temp;
			last = temp;
		} else {
			first = temp;
			last = temp;
		}
		dropCount++;
	}
}


class Node{
	public Node next;
	public GameObject obj;
}
