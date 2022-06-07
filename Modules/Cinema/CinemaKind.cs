using Serenity.ComponentModel;
using System.ComponentModel;

namespace Serenity.Cinema
{
  [EnumKey("Cinema.CinemaKind")]
  public enum CinemaKind
  {
    [Description("Film")]
    Film = 1,
    [Description("TV Series")]
    TvSeries = 2,
    [Description("Mini Series")]
    MiniSeries = 3,
  }
}