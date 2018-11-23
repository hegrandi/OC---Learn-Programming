using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4C6
{
    class Program
    {
        static void Main(string[] args)
        {
            // create subsets of branches
            var branchSet1 = new List<Branch>();
            branchSet1.Add(new Branch(new List<Branch>()));
            branchSet1.Add(new Branch(new List<Branch>()));
            branchSet1.Add(new Branch(new List<Branch>()));

            var branchSet2 = new List<Branch>();
            branchSet2.Add(new Branch(new List<Branch>()));
            branchSet2.Add(new Branch(new List<Branch>()));
            branchSet2.Add(new Branch(new List<Branch>()));
            branchSet2.Add(new Branch(new List<Branch>()));

            var branchSet3 = new List<Branch>();
            branchSet3.Add(new Branch(new List<Branch>()));
            branchSet3.Add(new Branch(new List<Branch>()));
            branchSet3.Add(new Branch(new List<Branch>()));

            // add subbranches to the root branches
            var branches = new List<Branch>();
            branches.Add(new Branch(branchSet1));
            branches.Add(new Branch(branchSet2));
            branches.Add(new Branch(branchSet3));

            var tree = new Tree(branches: branches);

            paint(branchs: tree.branches);

            void paint(List<Branch> branchs)
            {
                branchs = tree.branches;
                if (branchs.Count > 0)
                {
                    for (int i = 0; i < branchs.Count; i++)
                    {
                        Console.WriteLine("Painting a branch!");

                        // paint subbranches RECURSIVELY!
                        paint(branchs: branchs[i].branches);
                    }
                }
            }
        }
    }

    class Branch
    {
        public List<Branch> branches = new List<Branch>();

        public Branch(List<Branch> branches)
        {
            this.branches = branches;
        }
    }

    class Tree
    {
        public List<Branch> branches = new List<Branch>();

        public Tree(List<Branch> branches)
        {
            this.branches = branches;
        }
    }
}
