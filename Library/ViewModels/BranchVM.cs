using Commands.BranchCommands;
using Library.Domain.Entities;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Controls;

namespace Library.ViewModels
{
    public class BranchVM : BaseVM
    {
        public BranchVM()
        {
            //AddBranch = new AddBranchCMD(this);
            //EditBranch = new EditBranchCMD(this);
            //RejectBranch = new RejectBranchCMD(this);
            //DeleteBranch = new DeleteBranchCMD(this);

            CurrentBranch = new Branch();
        }
        
        public int NoBranch = 1;
        public Button btnAddBranch { get; set; }
        public AddBranchCMD AddBranch { get; set; }
        public EditBranchCMD EditBranch { get; set; }
        public RejectBranchCMD RejectBranch { get; set; }
        public DeleteBranchCMD DeleteBranch { get; set; }

        int stateBranch;
        public int StateBranch
        {
            get { return stateBranch; }
            set { stateBranch = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(StateBranch))); }
        }

        ObservableCollection<Branch> branches;
        public ObservableCollection<Branch> Branches
        {
            get { return branches; }
            set { branches = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(Branches))); }
        }

        ObservableCollection<Branch> myFilteredBranches;
        public ObservableCollection<Branch> MyFilteredBranches
        {
            get
            {
                if (SearchText == null) return branches;
                return new ObservableCollection<Branch>(branches.Where(x => x.Name.ToLower().Contains(SearchText.ToLower()) || x.Address.ToLower().Contains(SearchText.ToLower())).ToList());
            }
            set { myFilteredBranches = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(MyFilteredBranches))); }
        }

        private Branch selectedBranch;

        public Branch SelectedBranch
        {
            get { return selectedBranch; }
            set { selectedBranch = value; if (value != null) CurrentBranch = value.Clone(); }
        }

        private Branch currentBranch;

        public Branch CurrentBranch
        {
            get { return currentBranch; }
            set { currentBranch = value; OnPropertyChanged(new PropertyChangedEventArgs(nameof(CurrentBranch))); }
        }

        private string searchText;
        public string SearchText
        {
            get { return searchText; }
            set
            {
                searchText = value;
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(SearchText)));
                OnPropertyChanged(new PropertyChangedEventArgs(nameof(MyFilteredBranches)));
            }
        }
    }
}
