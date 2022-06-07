using Serenity.ComponentModel;
using System.ComponentModel;

namespace Serenity.Cinema
{
    [EnumKey("Cinema.Gender")]
    public enum Gender
    {
        [Description("Male")]
        Male = 1,
        [Description("Female")]
        Female = 2
    }
}