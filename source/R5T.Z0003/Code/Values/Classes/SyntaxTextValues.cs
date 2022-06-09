using System;


namespace R5T.Z0003
{
	public class SyntaxTextValues : ISyntaxTextValues
	{
		#region Infrastructure

	    public static SyntaxTextValues Instance { get; } = new();

	    private SyntaxTextValues()
	    {
	    }

	    #endregion
	}
}