//namespace Graphs_AdjacencyLists
//{
//    public class Example
//    {
//        public static void Main(string[] args) {
//        //Build the graph: 
//        Node one = new Node(1); 
//        Node two = new Node(2); 
//        Node three = new Node(3); 
//        Node four = new Node(4); 
//        Node five = new Node(5); 
//        Node six = new Node(6);

//        //Initialize the graph using the constructor (defined below):
//        Graph graph = new Graph(6); 

//        //Add edges to the graph: 
//        graph.AddEdge(six,four);
//        graph.AddEdge(four,five);
//        graph.AddEdge(four,three);
//        graph.AddEdge(three,two);
//        graph.AddEdge(five,two);
//        graph.AddEdge(two,one);
//        graph.AddEdge(five,one);
//        }
//    }

//    class Node
//    {
//        //PROPERTIES
//        public List<object> Neighbors { get; set; }
//        public int Data;

//        //CONSTRUCTOR
//        public Node(int data) 
//        {
//            Data = data;
//        }
//    }

//    class Graph
//    {
//        //Recall Vertices is another name for Nodes.
//        //PROPERTIES
//        public int NumberOfVertices { get; set; }
//        public List<Node> Vertices { get; set; }

//        //CONSTRUCTOR
//        public Graph(int size)
//        {
//            NumberOfVertices = size;
//            Vertices = new List<Node>();

//            for(int i = 0; i < NumberOfVertices; i++)
//            {
//                Vertices[i] = new Node(NumberOfVertices);
//            }
//        }

//        //CLASS METHODS
//        public void AddEdge(Node source, Node destination)
//        {
//            source.Neighbors.Add(destination);
//            destination.Neighbors.Add(source);
//        }
//        public void RemoveEdge(Node source, Node destination)
//        {
//            source.Neighbors.Remove(destination);
//            destination.Neighbors.Remove(source);
//        }
//        public bool IsAdjacent(Node node1, Node node2)
//        {   
//            //Return true if node1 contains node2 within its "Neighbors" list property.
//            return node1.Neighbors.Contains(node2);
//        }
//    }
//}

namespace Graphs_Matrix
{
    public class Example
    {
        public static void Main(string[] args)
        {

        }
    }

    class Graph
    {
        bool[,] adjacencyMatrix;
        int NumberOfVertices { get; set; }

        //CONSTRUCTOR
        public Graph(int size)
        {
            NumberOfVertices = size;
            adjacencyMatrix = new bool[size, size];
        }

        //CLASS METHODS
        public void AddEdge(int i, int j)
        {
            adjacencyMatrix[i, j] = true;
            adjacencyMatrix[j, i] = true;
        }
        public void RemoveEdge(int i, int j)
        {
            adjacencyMatrix[i, j] = false;
            adjacencyMatrix[j, i] = false;
        }
        public bool IsAdjacent(int i, int j)
        {
            return adjacencyMatrix[i, j];
        }
    }
}