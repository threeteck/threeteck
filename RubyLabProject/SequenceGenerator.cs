using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RubyLabProject
{
	public class SequenceGenerator
	{
		private IEnumerator<IEnumerable<int>> sequenceEnumerator;
		private StringBuilder stringBuilder;
		public int CurrentIndex { get; private set; }

		public SequenceGenerator()
		{
			sequenceEnumerator = Next_sequence().GetEnumerator();
			stringBuilder = new StringBuilder();
			CurrentIndex = -1;
		}

		private IEnumerable<IEnumerable<int>> Next_sequence()
		{
			List<int> seq = new List<int> { 1 };
			yield return seq;
			List<int> buffer = new List<int>();
			while (true)
			{
				buffer.Clear();
				int current_digit = seq[0];
				int current_count = 1;
				for (int i = 1; i < seq.Count; i++)
				{
					if (current_digit != seq[i])
					{
						buffer.Add(current_count);
						buffer.Add(current_digit);
						current_digit = seq[i];
						current_count = 1;
					}
					else
						current_count++;
				}
				buffer.Add(current_count);
				buffer.Add(current_digit);
				seq = new List<int>(buffer);
				yield return seq;
			}
		}

		public string GetNext()
		{
			CurrentIndex++;
			stringBuilder.Clear();
			sequenceEnumerator.MoveNext();
			foreach (int val in sequenceEnumerator.Current)
				stringBuilder.Append(val);
			return stringBuilder.ToString();
		}

		public IEnumerable<string> Generate(int count = -1)
		{
			while (count != 0)
			{
				if (count > 0) count--;
				yield return GetNext();
			}
		}

		public void Reset()
		{
			sequenceEnumerator = Next_sequence().GetEnumerator();
			CurrentIndex = -1;
		}
	}
}
