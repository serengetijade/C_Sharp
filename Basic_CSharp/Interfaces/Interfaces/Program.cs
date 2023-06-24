using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using static Interfaces.Program;

namespace Interfaces
{
    /// <summary>
    /// Right click on IComparable > Quick Actions and Refactoring > Implement interface
    /// </summary>
    class Program : IComparable, INotifyPropertyChanged, IComparer<string>, IEquatable<Program>, IEqualityComparer<objToCompare>
    {
        public static void Main(string[] args)
        {

        }
        //--------------------------------------------------------
        Program ex1 = new Program() { exapmleLength = 2 };
        public int exapmleLength;
        /// <summary>
        /// IComparable Interface: Compare two objects and return an int
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>int</returns>
        public int CompareTo(object? obj)
        {
            Program ex2 = (Program)obj;     //Caste the object passed into the function to a 'Program' object named ex2. if
            if (ex1.exapmleLength == ex2.exapmleLength)
            {
                return 0;
            }
            else if (ex1.exapmleLength > ex2.exapmleLength)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        //--------------------------------------------------------
        public event PropertyChangedEventHandler? PropertyChanged;        
        /// <summary>
        /// Notifies when a property value has changed. 
        /// </summary>
        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(Name));  
            }
        }

        //--------------------------------------------------------
        /// <summary>
        /// IComparer Interface
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        /// Required:
        //public event PropertyChangedEventHandler? PropertyChanged;
        class Employee
        {
            public int Id { get; set; }
        }
        public int Compare(string? x, string? y)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee(); 
            return emp1.Id.CompareTo(emp2.Id);
            //Results: 
            //0 means Ids are equal
            //-number means emp2 two is less than emp1
            //positive numb emp2 is greater than emp1
        }

        //--------------------------------------------------------
        public string baseData;
        ///<summary>
        /// IEquitable - determine if two instances are equal to each other.
        /// Compare some 'other' data to give 'baseData'. 
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Equals(Program? other)
        {
            if(other == null)
            {
                return false;
            }
            return baseData.GetHashCode().Equals(other.baseData); 
            //GetHashCode generates a number/code to represent that particular data and provides a way to compare. 
        }

        //--------------------------------------------------------
        /// <summary>
        /// IEqualityComparer: compare two objects
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public class objToCompare
        {
            Guid id;
            public Guid Id
            {
                get { return id; }
                set { id = value; }
            }
        }
        /// <summary>
        /// Takes in two objects(of the specified type) and returns a bool value 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Equals(objToCompare? x, [AllowNull]objToCompare? y)         //? and [
        {
            return x.Id == y.Id;
        }

        /// <summary>
        /// Takes in one parameter to get a hash code 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public int GetHashCode([DisallowNull] objToCompare obj)
        {
            return obj.Id.GetHashCode();
        }
    }

    //--------------------------------------------------------
    public class Wallet : IEnumerable
    {
        //Properties: 
        Money[] bills = null;
        int openIndex = 0;      //This represents the next index in the array.

        //Constructor: 
        public Wallet()
        {
            bills = new Money[100]; //he array can contain 100 items. 
        }

        //Methods: 
        public void Add(Money bill)
        {
            bills[openIndex] = bill;    //Set bill objects passed to this method at the (next free) index position.
            openIndex++;                //Increment the openIndex counter. 
        }

        //An enumerator is an object that helps iterate over a collection. It returns an object of type Inumerator.
        public IEnumerator GetEnumerator()
        {
            foreach(Money bill in bills) {
                if (bill == null)   //If a bill is null, pass over it
                {
                    break;
                }

                yield return bill;  //If a bill is not null, return the bill object. 
            }
        }
    }

    public class Money
    {
        public int amount;
    }
    //--------------------------------------------------------
    class Program2 : IEnumerator
    {
        List<object> items = new List<object>();
        int current;    //This is to return the current object from the items list that is being interated through.

        public object Current => throw new NotImplementedException();

        /// <summary>
        /// Determine if there is another element in the collection that must be iterated through. 
        /// </summary>
        /// <returns>True value means there are more objects. False value means it is the end of the collection.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool MoveNext()
        {
            if(items.Count == 0 || items.Count < current)
            {
                return false;
            }
            return true;
        }

        /// <summary>
        /// Reset the current index.
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Reset()
        {
            current = 0;
        }
    }

    //--------------------------------------------------------
    class Program3 : ICollection
    {
        //Gets the number of elements in the collection. 
        public int Count => throw new NotImplementedException();

        //Returns true if access to the collection is thread safe. 
        public bool IsSynchronized => throw new NotImplementedException();

        //Can be used to get an object that will synchronize access to the collection. 
        public object SyncRoot => throw new NotImplementedException();

        // Copy the elements of the of the collection into an array. 
        //"index" specifies the index of where to start.</param>
        public void CopyTo(Array array, int index)
        {
            throw new NotImplementedException();
        }

        // Returns an enumerator that iterates over a collection.
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
    //--------------------------------------------------------
}