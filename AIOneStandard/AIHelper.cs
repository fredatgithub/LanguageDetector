using System.Collections.Generic;
using System.Linq;

namespace AIOneStandard
{
  public static class AiHelper
  {
    public static IEnumerable<KeyValuePair<string, int>> SortDicoByValue(Dictionary<string, int> sampleDico)
    {
      return sampleDico.OrderByDescending(sortingBy => sortingBy.Value);
    }
  }
}