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
            bookletId = _bookletId;
            name = _name;
            pane = _pane;
            description = _description;
            CreateBookletDAL();
            
        }

        public Booklet(int _bookletId)
        {
            bookletId = _bookletId;
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
        public void SetId(int _id)
        {
            bookletId = _id;
        }
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

        //Dal functies
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
