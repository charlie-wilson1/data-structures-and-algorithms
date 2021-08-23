using System;
using Xunit;
using hash_table;

namespace HashTableTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanAddToHashTable()
        {
      string key = "U-District";
      string val = "98105 ";

      HashTable hash = new HashTable(16);

      hash.Set(key, val);

      Assert.True(hash.Contains(key));
    }

    [Fact]
    public void CanRetrieve()
    {
      string key = "U-District";
      string val = "98105";

      HashTable hash = new HashTable(16);

      hash.Set(key, val);

      Assert.Equal("98105",hash.Get(key));
    }
    [Fact]
    public void ReturnsNull()
    {
      string key = "U-District";
      string val = "98105";

      HashTable hash = new HashTable(16);

      Assert.Null(hash.Get(key));
    }

    [Fact]
    public void CanHashKeyToInRangeVal()
    {
      string key = "U-District";
      string val = "98105";

      HashTable hash = new HashTable(16);

      hash.Set(key, val);

      Assert.Equal("98105", hash.Get(key));
    }

    [Fact]
    public void CanRetrieveFromCollision()
    {
      string key = "U-District";
      string val = "98105";

      string key2 = "District-U";
      string val2 = "98105";

      HashTable hash = new HashTable(16);
      hash.Set(key, val);
      hash.Set(key2, val2);

      Assert.Equal(val, hash.Get(key));
    }
  }
}
