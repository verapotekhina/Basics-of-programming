namespace Pluralize
{
	public static class PluralizeTask
	{
		public static string PluralizeRubles(int count)
		{
            if (((count % 10 > 10) && (count % 10 < 20)) || (count % 10 == 0)|| ((count % 10 > 4) && (count % 10 < 10)))
                return "рублей";
            else if ((count % 10 == 1) && ((count % 100 != 1) || (count % 100 != 0)))
                return "рубль";
            else //((count % 10 > 1) && (count % 10 < 5))
                return "рубля"; 
		}
	}
}