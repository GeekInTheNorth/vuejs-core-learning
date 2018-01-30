using System.Collections.Generic;

namespace WebApp.Models
{
    public class CollectionModel
    {
        public string CollectionName { get; set; }

        public List<CollectionModelItem> Items { get; set; }
    }

    public class CollectionModelItem
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}