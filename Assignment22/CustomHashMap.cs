using System;
class CustomHashMap{
    private class Node{
        //Node variables
        public int Key;
        public int Value;
        public Node Next;
        //Constructor
        public Node(int key, int value){
            Key = key;
            Value = value;
            Next = null;
        }
    }
    private const int SIZE = 1000; 
    private Node[] buckets;
    //Constructor
    public CustomHashMap(){
        buckets = new Node[SIZE];
    }
    //method to get index
    private int GetIndex(int key)
    {
        return Math.Abs(key) % SIZE; 
    }
    //method to put
    public void Put(int key, int value){
        int index = GetIndex(key);
        Node head = buckets[index];
        //if key exists then update it
        Node current = head;
        while (current != null){
            if (current.Key == key){
                current.Value = value;
                return;
            }
            current = current.Next;
        }
        //insert at the beginning of the linked list
        Node newNode = new Node(key, value);
        newNode.Next = head;
        buckets[index] = newNode;
    }
    //method to get key value
    public int Get(int key){
        int index = GetIndex(key);
        Node current = buckets[index];
        while (current != null){
            if (current.Key == key)
                return current.Value;
            current = current.Next;
        }

        return -1;
    }
    //method to remove the key value
    public void Remove(int key){
        int index = GetIndex(key);
        Node current = buckets[index];
        Node prev = null;
        while (current != null){
            if (current.Key == key){
                if (prev == null)
                    buckets[index] = current.Next; 
                else
                    prev.Next = current.Next; 

                return;
            }
            prev = current;
            current = current.Next;
        }
    }
    //Main method
    public static void Main(){
        CustomHashMap hashMap = new CustomHashMap();
        hashMap.Put(1, 10);
        hashMap.Put(2, 20);
        hashMap.Put(1, 15); 
        Console.WriteLine("Key 1: " + hashMap.Get(1)); 
        Console.WriteLine("Key 2: " + hashMap.Get(2)); 
        Console.WriteLine("Key 3: " + hashMap.Get(3)); 
        hashMap.Remove(2);
        Console.WriteLine("Key 2 after deletion: " + hashMap.Get(2)); 
    }
}
