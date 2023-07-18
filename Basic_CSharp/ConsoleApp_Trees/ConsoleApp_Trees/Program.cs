//Type "T" is the generic type to represent and object who's type will be defined later in the program.
namespace Trees
{
    class Example
    {
        public static void Main(string[] args) {
            TreeNode<string> a = new TreeNode<string>("a");
            TreeNode<string> b = new TreeNode<string>("b");
            TreeNode<string> c = new TreeNode<string>("c");
            TreeNode<string> d = new TreeNode<string>("d");
            TreeNode<string> e = new TreeNode<string>("e");
            TreeNode<string> f = new TreeNode<string>("f");
            TreeNode<string> g = new TreeNode<string>("g");

            a.SetLeft(b);
            a.SetRight(c);
            b.SetLeft(d);
            b.SetRight(e);                      
            c.SetLeft(f);
            c.SetRight(g);

            //Call a method from another class and define the type that method will use: 
            Console.WriteLine(Program<string>.GetHeight(a));

            Console.WriteLine("PreOrder: ");
            PreOrder(a);    //Result: a b d e c f g
            
            Console.WriteLine("\nInOrder: ");
            InOrder(a);    //Result: d b e a f c g  

            Console.WriteLine("\nPostOrder: ");
            InOrder(a);    //Result: d b e a f c g
        }

        //TRAVERSAL METHODS
        static void PreOrder(TreeNode<string> root)
        {
            if(root != null)
            {
                Console.Write(root.GetValue().ToString() + " ");
                PreOrder(root.GetLeft());
                PreOrder(root.GetRight());
            }
        }
        static void InOrder(TreeNode<string> root)
        {
            if (root != null)
            {
                InOrder(root.GetLeft());
                Console.Write(root.GetValue().ToString() + " ");
                InOrder(root.GetRight());
            }
        }
        static void PostOrder(TreeNode<string> root)
        {   
            if (root != null)
            {
                PostOrder(root.GetLeft());
                PostOrder(root.GetRight());
                Console.Write(root.GetValue().ToString() + " ");
            }
        }

        //Determine if a tree is balanced:
        static bool IsBalanced(TreeNode<string> root)
        {
            int diff = 0;
            if((root.GetLeft() != null && root.GetRight() == null) ||
                (root.GetLeft() == null && root.GetRight() != null))
            {
                diff += 1;
            }
            else
            {
                diff = 0;
            }

            return IsBalanced(root.GetLeft()) && IsBalanced(root.GetRight());
        }
    } 

    public class Program<T>        //In order to use the generic type parameter, it must be added to program class. 
    {
        public static int GetHeight(TreeNode<T> root)
        {
            if(root == null) return 0;  
            return Math.Max(GetHeight(root.GetLeft()),GetHeight(root.GetRight()) + 1);      //Add one to account for the root node. 
        }                       
    }

    //Define a tree:
    public class TreeNode<T>
    {
        T value;
        TreeNode<T> left = null;
        TreeNode<T> right = null;

        //Constructor: 
        public TreeNode(T value)
        {
            this.value = value;
        }

        public TreeNode<T> GetLeft()
        {
            return left;
        }
        public TreeNode<T> GetRight()
        {
            return right;
        }
        public T GetValue()
        {
            return value;
        }
        public void SetValue(T value)
        {
            this.value = value;
        }
        public void SetRight(TreeNode<T> node)
        {
            right = node;
        }
        public void SetLeft(TreeNode<T> node)
        {
            left = node;
        }
    }
}