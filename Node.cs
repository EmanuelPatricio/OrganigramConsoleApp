namespace HelloWorld
{
  class Node
  {
    public string Value { get; set; }
    public Node? Child { get; set; }
    public Node? Sibling { get; set; }

    public Node()
    {
      Value = "";
      Child = null;
      Sibling = null;
    }
  }
}