namespace HelloWorld
{
  class Tree
  {
    private Node root;
    private Node? work;
    private int i = 0;

    public Tree()
    {
      root = new Node();
    }

    public Node Insert(string value, Node? node = null)
    {
      // Si el nodo no existe, inserta el nuevo nodo en la raiz del arbol
      if (node == null)
      {
        root.Value = value;
        root.Child = null;
        root.Sibling = null;
        return root;
      }

      if (node.Child == null)
      {
        Node temp = new Node();
        temp.Value = value;
        node.Child = temp;
        return temp;
      }
      else
      {
        work = node.Child;

        // Me posiciono como el ultimo hermano del nodo
        while (work.Sibling != null)
        {
          work = work.Sibling;
        }

        Node temp = new Node();
        temp.Value = value;
        work.Sibling = temp;
        return temp;
      }
    }

    public void PrintTree(Node node)
    {
      if (node == null)
        return;

      for (int n = 0; n < i; n++)
        Console.Write("  ");

      Console.WriteLine(node.Value);

      if (node.Child != null)
      {
        i++;
        PrintTree(node.Child);
        i--;
      }

      if (node.Sibling != null)
        PrintTree(node.Sibling);
    }

    public Node Search(string value, Node node)
    {
      Node? searchingNode = null;

      if (node == null)
        throw new Exception("Node in Search method from Tree class cannot be null.");

      if (node.Value.CompareTo(value) == 0)
      {
        searchingNode = node;
        return searchingNode;
      }

      if (node.Child != null)
      {
        searchingNode = Search(value, node.Child);

        if (searchingNode != null)
          return searchingNode;
      }

      if (node.Sibling != null)
      {
        searchingNode = Search(value, node.Sibling);

        if (searchingNode != null)
          return searchingNode;
      }

      return searchingNode ?? throw new Exception("Node do not exists or it's value is incorrect.");
    }
  }
}