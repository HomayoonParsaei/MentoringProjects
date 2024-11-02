
namespace RegularPolygon.Enums.EnumsFrindlyText
{
    public static class PolygonNameFriendlyText
    {
        private static Dictionary<PolygonName, string> FriendlyText = new()
        {
            { PolygonName.Triangle,"Triangle (III)" },
            { PolygonName.Quadrilateral,"Quadrilateral (IV)" },
            { PolygonName.Pentagon,"Pentagon (V)" },
            { PolygonName.Hexagon,"Hexagon (VI)" },
            { PolygonName.Heptagon,"Heptagon (VII)" }, 
            { PolygonName.Octagon,"Octagon (VIII)" },
            { PolygonName.Nonagon,"Nonagon (IX)" } ,
            { PolygonName.Decagon,"Decagon (X)" },
            { PolygonName.Hendecagon,"Hendecagon (XI)" },   
            { PolygonName.Dodecagon,"Dodecagon (XII)" }
         };
        public static List<string> GetFriendlyTextList()
        {
            return FriendlyText.Values.ToList();
        }

    }
}
