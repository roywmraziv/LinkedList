namespace LinkedList;

public class CustomLinkedList
{
    private Node head; // the first node in the list

    public void Append(int value)
    {
        Node newNode = new Node(value); 

        if(head == null) // if the list is empty
        {
            head = newNode; // the new node becomes the head
            return;
        }
        
        Node current = head;

        while (current.Next != null) // iterate through the list
        {
            current = current.Next;
        }
        current.Next = newNode; // link/connect the new node
    }

    public void Prepend(int value)
    {
        Node newNode = new Node(value);
        newNode.Next = head; // point the new node to the current head
        head = newNode; // make the new node the new head
    }

    public void Remove(int value)
    {
        if (head == null) return; // if the list is empty, do nothing

        if (head.Value == value) // if the head is the value to be removed
        {
            head = head.Next; // move head to the next node
            return;
        }
        
        Node current = head;

        while (current.Next != null && current.Next.Value != value)
        {
            current = current.Next; // iterate through the list until target is found
        }

        if (current.Next != null)
        {
            current.Next = current.Next.Next; // skip over the node to remove
        }
    }

    public bool Contains(int value)
    {
        if (head == null) return false;
        
        Node current = head;
        while (current != null)
        {
            if (current.Value == value) return true;
            current = current.Next;
        }
        return false;
    }

    public void PrintList()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Value + " -> ");
            current = current.Next;
        }
        Console.Write("null");
    }
}