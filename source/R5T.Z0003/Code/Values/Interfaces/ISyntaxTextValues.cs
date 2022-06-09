using System;

using R5T.T0131;


namespace R5T.Z0003
{
	[ValuesMarker]
	public interface ISyntaxTextValues : IValuesMarker
	{
		public string UsingSystemNamespace => "using System;";
	}
}