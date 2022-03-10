namespace System
{
    static class StringExtensions
    {
        //Primeiro parametro
        // está se referenciado ao objeto string
        // o count é o valor para cortar a string
        public static string Cut(this string thisObj, int count)
        {

            if(thisObj.Length <= count)
            {
                return thisObj;
            }
            else
            {
                return thisObj.Substring(0, count) + "....";
            }

        }



    }
}
