using System;

namespace dummy_project
{
	public class InsertionSort
	{
		public InsertionSort ()
		{}

		public int[] Sort(int[] list)
		{
			for( int iii = 1; iii < list.Length; ++iii )
			{
				int temp = list[iii];
				int jjj = iii;

				while( jjj > 0 && list[jjj-1] > temp )
				{
					list [jjj] = list [jjj - 1];
					jjj--;
				}

				list[jjj] = temp;
			}

			return list;
		}
	}
}

