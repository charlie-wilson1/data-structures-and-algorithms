using System;
using Xunit;
using nodes;

namespace XUnitNode
{
	public class UnitTest1
	{
		[Fact]
		public void CanPrint()
		{
      Program.LinkedList.Print();
      Assert.Equals("( 7 ) -> ( 6 ) -> ( 5 ) -> NULL", LinkedList.Print());
		}

    [Fact]
    public void CanFind()
    {
      Program.LinkedList.Includes(6);
      Assert.Equals(true, 6);
    }
	}
}
