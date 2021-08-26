using System;
using Xunit;
using CodeChallenge33;


namespace CodeChallenge33Tests
{
    public class CodeChallenge33Tests
    {
    [Fact]
    public void CanJoinLeftTest()
    {
      books1.Set("Harry Potter", "and the Sorcerer's Stone");
      books1.Set("Ready Player", "One");
      books1.Set("LOTR", "The Fellowship");
      books1.Set("A Song of", "Ice and");

      DataStructures.Hashtable books2 = new HashMap(48);

      books2.Set("Harry Potter", "and the Chamer of Secrets");
      books2.Set("Ready Player", "Two");
      books2.Set("LOTR", "the Two Tower");
      books2.Set("A Song of", "Fire");

      List<string[]> sample = HashMap.LeftJoin(books1, books2);

      Assert.Equal("Harry Potter", sample[0][0]);
      Assert.Equal("LOTR", sample[1][0]);
      Assert.Equal("A Song of", sample[2][0]);
      Assert.Equal("Ready Player", sample[3][0]);

      Assert.Equal("and the Sorcerer's Stone", sample[0][1]);
      Assert.Equal("The Fellowship", sample[1][1]);
      Assert.Equal("Ice and", sample[2][1]);
      Assert.Equal("One", sample[3][1]);

      Assert.Equal("and the Chamer of Secrets", sample[0][2]);
      Assert.Equal("the Two Tower", sample[1][2]);
      Assert.Equal("Fire", sample[2][2]);
      Assert.Equal("Two", sample[3][2]);
    }
  }
}
