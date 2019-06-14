using Library.Domain;
using Library.Domain.Abstractions;
using Library.Domain.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Library.DataAccess.EF_CodeFirst.Repositories
{
    public class BranchRepository : IBranchRepository
    {
        LibraryDBContext context;

        public List<Branch> GetAll()
        {
            List<Branch> branches;
            using (context = new LibraryDBContext())
            {
                branches = new List<Branch>(context.Branches);
            }
            return branches;
        }

        public Branch GetById(int id)
        {
            Branch branch;
            using (context = new LibraryDBContext())
            {
                branch = context.Branches.AsQueryable().FirstOrDefault(x => x.Id == id).Clone();
            }
            return branch;
        }

        public void Add(Branch branch)
        {
            using (context = new LibraryDBContext())
            {
                if (branch.Id == 0)
                {
                    context.Branches.Add(branch);
                    context.SaveChanges();
                }
                else
                {
                    Branch newBranch = context.Branches.FirstOrDefault(x => x.Id == branch.Id);
                    newBranch.Name = branch.Name;
                    newBranch.Address = branch.Address;
                    newBranch.Note = branch.Note;
                    context.SaveChanges();
                }
            }
        }

        public void Remove(Branch branch)
        {
            using (context = new LibraryDBContext())
            {
                Branch newBranch = context.Branches.FirstOrDefault(x => x.Id == branch.Id);
                context.Branches.Remove(newBranch);
                context.SaveChanges();
            }
        }
    }
}
