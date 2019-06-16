namespace Library.Domain.Abstractions
{
    public abstract class BaseHuman
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Note { get; set; }

        protected BaseHuman()
        {
        }

        protected BaseHuman(int id, int no, string name, string surname, string note)
        {
            Id = id;
            No = no;
            Name = name;
            Surname = surname;
            Note = note;
        }
    }
}
