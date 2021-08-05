using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeChallenge18.Classes
{
  public class KaryTree<T>
  {
    public Node<T> Root { get; set; }

    public KaryTree(T root)
    {
      root = Root.Value;
    }
  }
}
