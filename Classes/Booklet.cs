namespace MBPC_VeilingApp.Classes
{
    public class Booklet
    {
        private int bookletId;
        private string name;
        private string pane;
        private string description;

        public Booklet(int _bookletId, string _name, string _pane, string _description)
        {
            // Controlle om de kijken of de opgegeven argumenten voldoen aan de database regels
            if (_name.Length > 10) { throw new ArgumentException("Name should be at most 10 characters long."); }
            if (_pane.Length > 10) { throw new ArgumentException("Pane should be at most 10 characters long."); }
            if (_description.Length > 50) { throw new ArgumentException("Description should be at most 50 characters long."); }

            bookletId = _bookletId;
            name = _name;
            pane = _pane;
            description = _description;
            //CreateBookletDAL();
        }

        //Getters
        public int GetId()
        {
            return bookletId;
        }
        public string GetDescription()
        {
            return description;
        }
        public string GetName()
        {
            return name;
        }
        public string GetPane()
        {
            return pane;
        }

        //Setters
        public void SetDescription(string _description)
        {
            description = _description;
        }
        public void SetName(string _name)
        {
            name = _name;
        }
        public void SetPane(string _pane)
        {
            pane = _pane;
        }

        //DAL functies
        public void CreateBookletDAL()
        {
            DAL.CreateBooklet(this);
        }
        public void UpdateBookletDAL(string _name, string _pane, string _description)
        {
            DAL.UpdateBooklet(new Booklet(bookletId, _name, _pane, _description));
        }
        public void DeleteBookletDAL()
        {
            DAL.DeleteBooklet(this);
        }
    }
}
