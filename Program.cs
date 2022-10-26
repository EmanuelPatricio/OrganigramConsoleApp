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
        string departament = Console.ReadLine() ?? "No asignado";

        Console.Write("\nIngrese el departamento al que reportara: ");
        string departamentToReport = Console.ReadLine() ?? root.Value;

        Node? parentDepartament = tree.Search(departamentToReport, root);
        tree.Insert(departament, parentDepartament);
        tree.PrintTree(root);

        Console.Write("¿Desea continuar? [s/n] ");
        seguir = Console.ReadLine() ?? "s";
      } while (seguir == "s");
    }
  }
}