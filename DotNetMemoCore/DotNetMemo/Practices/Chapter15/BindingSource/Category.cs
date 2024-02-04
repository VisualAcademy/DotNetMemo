namespace DotNetMemo
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public Category(int id, string name)
        {
            this.CategoryID = id;
            this.CategoryName = name;
        }
    }
}
