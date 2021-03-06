using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckingnameInfoExampleofStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Name name0;
            Name name1;
            Name name2;
            // read names and create name objects
            Console.Write("Enter Name 1 (firstname mi. lastname): ");
            name0 = new Name(Console.ReadLine());
            Console.Write("Enter Name 2 (firstname mi. lastname): ");
            name1 = new Name(Console.ReadLine());
            Console.Write("Enter Name 3 (firstname mi. lastname): ");
            name2 = new Name(Console.ReadLine());
            Console.WriteLine();
            // display name info
            Console.WriteLine("{0}, {1} {2}.", name0.LastName,
            name0.FirstName, name0.MiddleInitial);
            Console.WriteLine("{0}, {1} {2}.", name1.LastName,
            name1.FirstName, name1.MiddleInitial);
            Console.WriteLine("{0}, {1} {2}.", name2.LastName,
            name2.FirstName, name2.MiddleInitial);
            // display hyphenated info
            Console.WriteLine("{0}, Hyphenated: {1}", name0.LastName,
            name0.Hyphenated);
            Console.WriteLine("{0}, Hyphenated: {1}", name1.LastName,
            name1.Hyphenated);
            Console.WriteLine("{0}, Hyphenated: {1}", name2.LastName,
            name2.Hyphenated);
            
Console.WriteLine();
            Console.ReadLine();
        }
    }

    public class Name
    {
        #region Fields
        string firstName;
        char middleInitial;
        string lastName;
        #endregion
        #region Constructors
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="fullName">full name</param>
        public Name(string fullName)
        {
            // extract parts from full name
            int firstSpaceLocation = fullName.IndexOf(' ');
            firstName = fullName.Substring(0, firstSpaceLocation);
            middleInitial = fullName[firstSpaceLocation + 1];
            lastName = fullName.Substring(fullName.LastIndexOf(' ') + 1);
        }
        #endregion
        #region Properties
        /// <summary>
        /// Gets the first name
        /// </summary>
        public string FirstName
        {
            get { return firstName; }
        }
        /// <summary>
        /// Gets the middle initial
        /// </summary>
        public char MiddleInitial
        {
            get { return middleInitial; }
        }
        /// <summary>
        /// Gets the last name
        /// </summary>
        public string LastName
        {
            get { return lastName; }
        }
        /// <summary>
        /// Gets whether or not the last name is hyphenated
        /// </summary>
        public bool Hyphenated
        {
            get { return lastName.IndexOf('-') != -1; }
        }
        #endregion
    }
}
