namespace HelloWorld
{
  class Program
  {
    static void Main(string[] args)
    {
      Tree tree = new Tree();
      Node root = tree.Insert("Organigrama");
      string seguir = "s";

      do
      {
        Console.Clear();
        Console.Write("Ingrese el departamento a registrar: ");
        string departamento = Console.ReadLine() ?? "No asignado";

        Console.Write("\nIngrese el departamento al que reportara: ");
        string departamentoAReportar = Console.ReadLine() ?? root.Value;

        Node? departamentoPadre = tree.Search(departamentoAReportar, root);
        tree.Insert(departamento, departamentoPadre);
        tree.PrintTree(root);

        Console.Write("¿Desea continuar? [s/n] ");
        seguir = Console.ReadLine() ?? "s";
      } while (seguir == "s");
    }
  }
}