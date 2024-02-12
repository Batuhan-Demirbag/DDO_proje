using System;
using System.Collections;
public class ArrayListGenerator
{
    public ArrayList CreateArrayList()
    {
        ArrayList list = new ArrayList();

        list.Add(1);
        list.Add("iki");
        list.Add(3.14);
        list.Add(true);

        return list;
    }
}
