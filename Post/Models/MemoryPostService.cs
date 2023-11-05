namespace Post.Models
{
    public class MemoryPostService : IPostService
    {
        private Dictionary<int, PostClass> _items = new Dictionary<int, PostClass>();
        public int Add(PostClass item)
        {
            int id = _items.Keys.Count != 0 ? _items.Keys.Max() : 0;
            item.Id = id + 1;
            _items.Add(item.Id, item);
            return item.Id;
        }

        public void Delete(int id)
        {
            _items.Remove(id);
        }

        public List<PostClass> FindAll()
        {
            return _items.Values.ToList();
        }

        public PostClass? FindById(int id)
        {
            return _items[id];
        }

        public void Update(PostClass item)
        {
            _items[item.Id] = item;
        }
    }
}
