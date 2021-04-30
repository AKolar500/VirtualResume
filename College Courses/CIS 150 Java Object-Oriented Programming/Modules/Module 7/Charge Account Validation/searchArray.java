

public class searchArray
{

	public static int sequentialSearch(int[] array, int account)
	{
		int index, //loop control variable
			value,
			element; //element the value (account) is found at
		boolean found = false; //flag indicating search results. this will be returned.
		//chargeAccountDemo account;

		//element 0 is the starting point of the search.
		index = 0;

		value = account;

		//set the default values. these will be returned if the search comes up empty.
		element = -1;
		//found = false;

		//search the array.
		while (!found && index < array.length)
		{
			if (array[index] == value)
			{
				found = true;
				element = index;
			}

			index++;
		}

		return found;
	}
}